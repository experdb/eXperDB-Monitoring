package experdb.mnt.task;

import java.math.BigDecimal;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.apache.commons.dbcp.PoolingDriver;
import org.apache.ibatis.exceptions.PersistenceException;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.postgresql.util.PSQLException;
import org.postgresql.util.PSQLState;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.ResourceInfo;
import experdb.mnt.db.dbcp.DBCPPoolManager;
import experdb.mnt.db.mybatis.SqlSessionManager;
import experdb.mnt.util.MD5Gen;

public class ActvCollect extends TaskApplication {

	private static final String RESOURCE_KEY_CURRENT_LOCK = "CURRENT_LOCK";
	private static final String RESOURCE_KEY_BACKEND_RSC = "BACKEND_RSC";
	private static final String RESOURCE_KEY_ACCESS = "ACCESS";
	
	private static final String RESOURCE_KEY_CPU_CLOCKS = "CPU_CLOCKS";	
	
	private String is_collect_ok = "Y";
	private String failed_collect_type = "";	
	
	private String instance_db_version = "";
	
	public ActvCollect(String instanceId, String taskId) {
		super(instanceId, taskId);
	}

	@Override
	public void run() {
		try {
			instance_db_version = (String) MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("pg_version_min");
			
			long collectPeriod = (Integer)MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("collect_period_sec");
			
			long sleepTime;
			long startTime;
			long endTime;
			int checkAlive = 0;
			
			while (!MonitoringInfoManager.getInstance().isReLoad())
			{
				//log.debug(System.currentTimeMillis());
				
				try {
					is_collect_ok = "Y";
					failed_collect_type = "";
					
					startTime =  System.currentTimeMillis();
					
					execute(); //수집 실행
	
					//check whether the thread is running or not.
					if (checkAlive++ % 100 == 0){
						log.info("[ActvCollect ==>> " + instanceId + "]");
						checkAlive = 1;
					}
					
					endTime =  System.currentTimeMillis();
					
					if((endTime - startTime) > (collectPeriod * 1000) )
					{
						//처리 시간이 수집주기보다 크면 바로처리
						continue;
					} else {
						sleepTime = (collectPeriod * 1000) - (endTime - startTime);
					}
				
					Thread.sleep(sleepTime);
	
				} catch (Exception e) {
					//log.error("", e);
					log.error("[ActvCollect:instanceId ==>> " + instanceId + "]" + " execute fail]", e);
				}
			}		
		} catch (Exception e) {
			//log.error("", e);
			log.error("[ActvCollect:instanceId ==>> " + instanceId + "]" + " escaped loop]", e);
		}		
	}	
	
	private void execute() {
		SqlSessionFactory sqlSessionFactory = null;
		Connection connection = null;
		SqlSession sessionCollect = null;
		SqlSession sessionAgent  = null;
		
		try {
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			log.debug("[instanceId ==>> " + instanceId + "]" + " Collect]");
			try {
				connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + instanceId);
				sessionCollect = sqlSessionFactory.openSession(connection);
			} catch (Exception e) {
				failed_collect_type = "0";
				is_collect_ok = "N";
				//log.error("", e);	
				log.error("[instanceId ==>> " + instanceId + "]" + " Connection failed]");		
			}
				
			sessionAgent = sqlSessionFactory.openSession();
			sessionAgent.update("app.TB_SET_LOCK_TIMEOUT_U001");
				
			List<HashMap<String, Object>> currentLockSel = new ArrayList<HashMap<String,Object>>(); // CURRENT_LOCK 정보 수집
			List<HashMap<String, Object>> backendRscSel = new ArrayList<HashMap<String,Object>>(); // BACKEND_RSC 정보 수집
			List<HashMap<String, Object>> accessSel = new ArrayList<HashMap<String,Object>>(); //Access 수집
			List<HashMap<String, Object>> sessionStats = new ArrayList<HashMap<String,Object>>(); //Session Stats 수집
			
			if(is_collect_ok.equals("Y"))
			{			
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////
				// CPU_CLOCKS 구하기			
				if(ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_CPU_CLOCKS) == null)
				{
					HashMap<String, Object> tempCpuClocks = new HashMap<String, Object>();
					
					tempCpuClocks = sessionCollect.selectOne("app.BT_GET_CPU_CLOCKS_001");
					
					ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_CPU_CLOCKS, tempCpuClocks.get("get_cpu_clocks"));
				}
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////
							
////////////////////////////////////////////////////////////////////////////////////////////////////////////
				int extensions = (Integer)MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("extensions");
				extensions &= 0x04;
				
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////
				// 이전값 확인
				List<HashMap<String, Object>> preList = new ArrayList<HashMap<String,Object>>();
				
	
				///////////////////////////////////////////////////////////////////////////////
				// BACKEND_RSC 이전값 확인
				if(ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_BACKEND_RSC) == null)
				{
					HashMap<String, Object> dbVerMap = new HashMap<String, Object>();
					if (instance_db_version.isEmpty())
						instance_db_version = "9.5";
					dbVerMap.put("instance_db_version", instance_db_version);					
					
					preList.clear();
					if (extensions > 0 )
						preList = sessionCollect.selectList("app.BT_BACKEND_RSC_002", dbVerMap);
					else
						preList = sessionCollect.selectList("app.BT_BACKEND_RSC_001", dbVerMap);
					
					HashMap<String, Object> tempCpu = new HashMap<String, Object>();
					for (HashMap<String, Object> map : preList) {
						tempCpu.put(String.valueOf(map.get("process_id")), map);
					}				
					
					ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_BACKEND_RSC, tempCpu);
				}
				///////////////////////////////////////////////////////////////////////////////			
				
				
				
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////			
				//서버를 모니터링한다.
				
				try {
					// CURRENT_LOCK 정보 수집
					try {
						HashMap<String, Object> dbVerMap = new HashMap<String, Object>();
						dbVerMap.put("instance_db_version", instance_db_version);

						currentLockSel = sessionCollect.selectList("app.BT_CURR_LOCK_001", dbVerMap);
					} catch (Exception e) {
						failed_collect_type = "1";
						throw e;
					}			
					
					// BACKEND_RSC 정보 수집
					try {
						HashMap<String, Object> dbVerMap = new HashMap<String, Object>();
						dbVerMap.put("instance_db_version", instance_db_version);						
						
						if (extensions > 0 )
							backendRscSel = sessionCollect.selectList("app.BT_BACKEND_RSC_002", dbVerMap);
						else
							backendRscSel = sessionCollect.selectList("app.BT_BACKEND_RSC_001", dbVerMap);	 	
//					} catch (Exception e) {
//						failed_collect_type = "2";
//						throw e;
//					}						
					} catch (Exception e) {
						if(e instanceof PersistenceException){
							PersistenceException pe = (PersistenceException)e;
							if( pe.getCause() instanceof PSQLException) {
								PSQLException psqle = (PSQLException)pe.getCause();
								//if (!PSQLState.SYNTAX_ERROR.getState().equals(psqle.getSQLState())){
								if (!PSQLState.DATA_ERROR.getState().equals(psqle.getSQLState())){
									failed_collect_type = "2";
									throw e;									
								}
							} else {
								failed_collect_type = "2";
								throw e;									
							}
						} else {
							failed_collect_type = "2";
							throw e;									
						}
					}	
					
//					// SESSION_STATS 정보 수집
//					try {
//						HashMap<String, Object> dbVerMap = new HashMap<String, Object>();
//						dbVerMap.put("instance_db_version", instance_db_version);						
//						
//						sessionStats = sessionCollect.selectList("app.BT_SESSION_STATS_001", dbVerMap);
//					} catch (Exception e) {
//						failed_collect_type = "3";
//						throw e;
//					}
				} catch (Exception e1) {
					is_collect_ok = "N";
					failed_collect_type = "2";
					//log.error("", e1);
					log.error("[instanceId ==>> " + instanceId + "]", e1);
				}
			}
				
			if(is_collect_ok.equals("Y"))
			{			
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////
				// DB connection 정보
				List<HashMap<String, Object>> dbConnList = new ArrayList<HashMap<String,Object>>();
				dbConnList = sessionCollect.selectList("app.PG_STAT_DATABASE_INFO_001");
	
				// pool 네임정보를 가져온다.
				PoolingDriver driver = (PoolingDriver) DriverManager.getDriver("jdbc:apache:commons:dbcp:");
				String[] poolNames = driver.getPoolNames();
				
				for (HashMap<String, Object> mapDB : dbConnList) {
					String poolName = instanceId + "." + taskId + "." + mapDB.get("db_name");
					
					//풀 생성여부를 확인하여 없으면 생성한다.
					boolean isPool = false;
					for (int i = 0; i < poolNames.length; i++){
						if(poolNames[i].equals(poolName)){
							isPool = true;
							break;
						}
					}				
					
					if(!isPool)
					{
						//pool이 없는경우 폴을 생성한다.
						HashMap instanceMap = MonitoringInfoManager.getInstanceMap(instanceId);
						
						DBCPPoolManager.setupDriver(
								"org.postgresql.Driver",
								"jdbc:postgresql://"+ instanceMap.get("server_ip") +":"+ instanceMap.get("service_port") +"/"+ mapDB.get("db_name"),
								(String)instanceMap.get("conn_user_id"),
								(String)instanceMap.get("conn_user_pwd"),
								poolName,
								20
						);					
					}
					/////////////////////////////////////////////////////////
					
					
					Connection connDB = null;
					SqlSession sessDB = null;
					
					try {
						//DB 컨넥션을 가져온다.
						connDB = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + poolName);
						sessDB = sqlSessionFactory.openSession(connDB);
	
						///////////////////////////////////////////////////////////////////////////////
						// ACCESS 이전값 확인
						if(ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_ACCESS + "_" + mapDB.get("db_name")) == null)
						{
							HashMap<String, Object> inputParam = new HashMap<String, Object>();
							inputParam.put("db_name", 					mapDB.get("db_name"));
							inputParam.put("datid", 					mapDB.get("datid"));
	
							
							HashMap<String, Object> selectMap = sessDB.selectOne("app.BT_ACCESS_INFO_001", inputParam);
	
							ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_ACCESS + "_" + mapDB.get("db_name"), selectMap);
							
	//						log.fatal("최초 이전값 : " + selectMap);
						}
						///////////////////////////////////////////////////////////////////////////////				
						
						///////////////////////////////////////////////////////////////////////////////
						// ACCESS 정보수집
						HashMap<String, Object> inputAccessParam = new HashMap<String, Object>();
						inputAccessParam = (HashMap<String, Object>) ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_ACCESS + "_" + mapDB.get("db_name"));
						
						Map<String, Object> accessTempSel = new HashMap<String, Object>();
						try {
							inputAccessParam.put("datid", 					mapDB.get("datid"));
							
							accessTempSel = sessDB.selectOne("app.BT_ACCESS_INFO_001", inputAccessParam);
						} catch (Exception e) {
							failed_collect_type = "3";
							throw e;
						}						
						accessSel.add((HashMap<String, Object>) accessTempSel);
						
	//					log.fatal("이전값 : " + inputAccessParam);
	//					log.fatal("조회값 : " + accessTempSel);
						
						ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_ACCESS + "_" + mapDB.get("db_name"), accessTempSel);
						/////////////////////////////////////////////////////////////////////////////
				
					} catch (Exception e1) {
						is_collect_ok = "N";
						failed_collect_type = "2";
						//log.error("", e1);
						log.error("[instanceId ==>> " + instanceId + "]", e1);
						break;
					} finally {
						sessDB.close();
					}
				}
			}			
			
			
			
			try {
				Map<String, Object> parameAgent = new HashMap<String, Object>();

				Map<String, Object> preValue = new HashMap<String, Object>();
				
				///////////////////////////////////////////////////////////////////////////////
				// TB_ACTV_COLLECT_INFO 정보 등록
				log.debug("[instanceId ==>> " + instanceId + "]" + " Debug Insert ACTV]");
				
				//금일자 최초 거래인지 확인
				HashMap<String, Object> regDateMap = sessionAgent.selectOne("app.TB_ACTV_COLLECT_INFO_S001");
				
				if(regDateMap.get("max_reg_date") == null)	regDateMap.put("max_reg_date", "");
				
				if(!regDateMap.get("max_reg_date").equals(regDateMap.get("reg_date")))
				{
					//금일자에 등록된 거래가 없는경우 시퀀스 초기화
					sessionAgent.selectList("app.SEQ_SETVAL_ACTV");
				}				
				
				Map<String, Object> parameActv = new HashMap<String, Object>();
				parameActv.put("instance_id", Integer.valueOf(instanceId));
				parameActv.put("is_collect_ok", is_collect_ok);				
				parameActv.put("failed_collect_type", failed_collect_type);
				
				sessionAgent.insert("app.TB_ACTV_COLLECT_INFO_I001", parameActv);
				
				if(is_collect_ok.equals("N"))
				{
					log.debug("[instanceId ==>> " + instanceId + "]" + " Debug Insert ACTV only commit]");
					sessionAgent.commit();
					return;
				}
				///////////////////////////////////////////////////////////////////////////////
				
				///////////////////////////////////////////////////////////////////////////////
				// CURRENT_LOCK 정보 등록
				for (HashMap<String, Object> map : currentLockSel) {
					HashMap<String, Object> inputParam = new HashMap<String, Object>();
					String blocking_query = map.get("blocking_query") != null ? map.get("blocking_query").toString() : null;
					String blocked_query = map.get("blocked_query") != null ? map.get("blocked_query").toString() : null;
					String blocking_queryid = map.get("blocking_query") != null ? map.get("blocking_queryid").toString() : null;
					String blocked_queryid = map.get("blocked_query") != null ? map.get("blocked_queryid").toString() : null;
					map.put("blocking_query", 					blocking_queryid);
					map.put("blocked_query", 					blocked_queryid);
					sessionAgent.insert("app.TB_CURRENT_LOCK_I001", map);

					inputParam.put("queryid", 					blocking_queryid);
					inputParam.put("instance_id", 				Integer.parseInt(instanceId));
					inputParam.put("query", 					blocking_query);
					inputParam.put("dbid", 						map.get("blocking_datid"));
					inputParam.put("userid", 					map.get("blocking_usesysid"));
					HashMap<String, Object> queryIdMap = sessionAgent.selectOne("app.TB_QUERY_INFO_S001", inputParam);						
					if (queryIdMap == null){
						sessionAgent.insert("app.TB_QUERY_INFO_I001", inputParam);
					}
				}
//				if(currentLockSel.size() > 0){
//					HashMap<String, Object> parameter = new HashMap<String, Object>();
//										parameter.put("list", currentLockSel);
//					sessionAgent.insert("app.TB_CURRENT_LOCK_I002", currentLockSel);
//				}
				///////////////////////////////////////////////////////////////////////////////				
				
				///////////////////////////////////////////////////////////////////////////////
				// BACKEND_RSC 정보 등록
				preValue.clear();
				preValue = (Map<String, Object>) ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_BACKEND_RSC);
				
				Map<String, Object> preSaveBackendRsc = new HashMap<String, Object>();
				for (HashMap<String, Object> map : backendRscSel) {
					HashMap<String, Object> tempMap = new HashMap<String, Object>();
					tempMap = (HashMap<String, Object>) preValue.get(String.valueOf(map.get("process_id")));

					//이전값이 없는경우(새로생성된 프로세스)
//					if(tempMap == null) {
//						preSaveBackendRsc.put(String.valueOf(map.get("process_id")), map);
//						
//						continue;
//					}
					
					if(tempMap == null) {
						preSaveBackendRsc.put(String.valueOf(map.get("process_id")), map);
					
						map.put("current_proc_utime", 0);
						map.put("current_proc_stime", 0);
						map.put("current_proc_read_kb", 0);
						map.put("current_proc_write_kb", 0);
						
						map.put("proc_cpu_util", 0);
					} else {				
					
						double current_proc_utime = Double.valueOf(map.get("agg_proc_utime").toString()) - Double.valueOf(tempMap.get("agg_proc_utime").toString());
						double current_proc_stime = Double.valueOf(map.get("agg_proc_stime").toString()) - Double.valueOf(tempMap.get("agg_proc_stime").toString());
						double current_proc_read_kb = Double.valueOf(map.get("agg_proc_read_kb").toString()) - Double.valueOf(tempMap.get("agg_proc_read_kb").toString());
						double current_proc_write_kb = Double.valueOf(map.get("agg_proc_write_kb").toString()) - Double.valueOf(tempMap.get("agg_proc_write_kb").toString());
						
						double current_sec_from_epoch = Double.valueOf(map.get("sec_from_epoch").toString()) - Double.valueOf(tempMap.get("sec_from_epoch").toString());
						
						double proc_cpu_util = 0;
						
						double cpu_clock = Double.valueOf(ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_CPU_CLOCKS).toString());
	
				
						if(cpu_clock != 0)
						{
							proc_cpu_util = Math.round((((current_proc_utime + current_proc_stime) / (cpu_clock * current_sec_from_epoch)) * 100 ) * Math.pow(10, 2)) / Math.pow(10, 2);
							if(proc_cpu_util > 100)
								proc_cpu_util = 100.0;
							else if(proc_cpu_util < 0)
								proc_cpu_util = 0.0;							
						}
	
						map.put("current_proc_utime", current_proc_utime);
						map.put("current_proc_stime", current_proc_stime);
						map.put("current_proc_read_kb", current_proc_read_kb);
						map.put("current_proc_write_kb", current_proc_write_kb);
						
						map.put("proc_cpu_util", proc_cpu_util);
					}
					
					double dbl_instance_db_version = Double.parseDouble(instance_db_version);
					
					int extensions = (Integer)MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("extensions");
					
					extensions &= 0x04;

					if (dbl_instance_db_version >= 9.5)
					{
						HashMap<String, Object> inputParam = new HashMap<String, Object>();
						inputParam.put("instance_id", 				Integer.parseInt(instanceId));
						inputParam.put("queryid", 					map.get("queryid"));
						inputParam.put("query", 					map.get("sql"));
						inputParam.put("dbid", 						map.get("datid"));
						inputParam.put("userid", 					map.get("usesysid"));
												
//						sessionAgent.insert("app.TB_BACKEND_RSC_I003", map);
//						if (map.get("db_name") != null)
//							sessionAgent.insert("app.TB_QUERY_INFO_I001", inputParam);
						
						if(extensions > 0)
							sessionAgent.insert("app.TB_BACKEND_RSC_I002", map);
						else{
							sessionAgent.insert("app.TB_BACKEND_RSC_I003", map);
							HashMap<String, Object> queryIdMap = sessionAgent.selectOne("app.TB_QUERY_INFO_S001", inputParam);						
							if (queryIdMap == null){
								if(inputParam.get("queryid") != null)
									sessionAgent.insert("app.TB_QUERY_INFO_I001", inputParam);
							}
						}

//						HashMap<String, Object> queryIdMap = sessionAgent.selectOne("app.TB_QUERY_INFO_S001", inputParam);						
//						if (queryIdMap != null){
//							map.put("queryid", queryIdMap.get("queryid"));
//							sessionAgent.insert("app.TB_BACKEND_RSC_I002", map);
//						}else{
//							sessionAgent.insert("app.TB_BACKEND_RSC_I003", map);
//							if (extensions > 0 )
//								inputParam.put("stmt_queryid", 				map.get("stmt_queryid"));
//							if (map.get("db_name") != null)
//								sessionAgent.insert("app.TB_QUERY_INFO_I001", inputParam);
//						}
					}else{
						sessionAgent.insert("app.TB_BACKEND_RSC_I001", map);
					}
					preSaveBackendRsc.put(String.valueOf(map.get("process_id")), map);
				}
				
				ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_BACKEND_RSC, preSaveBackendRsc);
				///////////////////////////////////////////////////////////////////////////////				
				
				///////////////////////////////////////////////////////////////////////////////
				// ACCESS 정보 등록
				for (HashMap<String, Object> map : accessSel) {
					sessionAgent.insert("app.TB_ACCESS_INFO_I001", map);
				}
				///////////////////////////////////////////////////////////////////////////////			
				
				log.debug("[instanceId ==>> " + instanceId + "]" + " Debug Insert ACTV commit]");
				//Commit
				sessionAgent.commit();
			} catch (Exception e) {
				sessionAgent.rollback();
				//log.error("", e);
				log.error("[instanceId ==>> " + instanceId + "]", e);
			}
			
		} catch (Exception e) {
			//log.error("", e);
			log.error("[instanceId ==>> " + instanceId + "]", e);
		} finally {
			if(sessionAgent != null)	sessionAgent.close();
			if(sessionCollect != null)	sessionCollect.close();
		}
	}

}

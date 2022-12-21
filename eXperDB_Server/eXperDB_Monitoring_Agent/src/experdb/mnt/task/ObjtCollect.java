package experdb.mnt.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Enumeration;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.apache.commons.dbcp.PoolingDriver;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.ResourceInfo;
import experdb.mnt.db.dbcp.DBCPPoolManager;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class ObjtCollect extends TaskApplication {

	private static final String RESOURCE_KEY_ACCESS = "ACCESS";
	private static final String RESOURCE_KEY_TABLESPACE = "TABLESPACE";
	private static final String RESOURCE_KEY_TABLE = "TABLE";
	private static final String RESOURCE_KEY_INDEX = "INDEX";

	private String is_collect_ok = "Y";
	private String failed_collect_type = "";	
	
	public ObjtCollect(String instanceId, String taskId) {
		super(instanceId, taskId);
	}

	@Override
	public void run() {
		
		long collectPeriod = (Integer) MonitoringInfoManager.getInstance().getConfig("hchk_period_sec");
		long collectObjectPeriod = (Integer) MonitoringInfoManager.getInstance().getConfig("objt_period_sec");
		
		long sleepTime;
		long startTime;
		long startExecuteTime = 0;
		long startDeleteTime = 0;
		long endTime;
		int DelteTurn = 5;
		
		while (!MonitoringInfoManager.getInstance().isReLoad())
		{
			log.debug(System.currentTimeMillis());
			Date now = new Date();
			
			try {
				is_collect_ok = "Y";
				failed_collect_type = "";
				
				startTime =  System.currentTimeMillis();				
				
				//HA info
				Enumeration		en = MonitoringInfoManager.getInstance().getInstanceId();
				while (en.hasMoreElements()) {
					updateHAstatus((String) en.nextElement());
				}	
				
				en = MonitoringInfoManager.getInstance().getInstanceId();
				long Test_startTime = System.nanoTime();
				//OBJT 정보수집
				now = new Date();
				System.out.println(now.toString());
				while (en.hasMoreElements()) {
					String instance_id = (String)en.nextElement();
					execute(instance_id);
					now = new Date();
					System.out.println("instance_id =" + instance_id + " " + now.toString());
				}					
				
				//OBJT 이전정보삭제
				en = MonitoringInfoManager.getInstance().getInstanceId();
				while (en.hasMoreElements()) {
					DeleteObject((String) en.nextElement());
				}
				startDeleteTime = System.currentTimeMillis() + collectObjectPeriod * 1000 * DelteTurn ;
				long Test_estimatedTime = System.nanoTime() - Test_startTime;

				endTime =  System.currentTimeMillis();
				
				sleepTime = (collectObjectPeriod * 1000) - (endTime - startTime);
				now = new Date();
//				System.out.println(now.toString() + "걸린 시간 : " + Test_estimatedTime/1000000000.0 + " milli seconds");
				System.out.println("id =" + instanceId + " " + now.toString() + "걸린 시간 : " + Test_estimatedTime/1000000000.0 + " milli seconds" + " col:" + collectObjectPeriod + " es:" + (endTime - startTime) + " sl:" + sleepTime);
				Thread.sleep(sleepTime < 0 ? 0 : sleepTime);
				
//				if((endTime - startTime) > (collectPeriod * 1000) )
//				{
//					//처리 시간이 수집주기보다 크면 바로처리
//					continue;
//				} else {
//					sleepTime = (collectPeriod * 1000) - (endTime - startTime);
//				}
			
//				Thread.sleep(sleepTime);
				
			} catch (Exception e) {
				//log.error("", e);
				log.error("[instanceId ==>> " + instanceId + "]", e);
			}
		}
		
	}	
	
	private void execute(String reqInstanceId) {
		SqlSessionFactory sqlSessionFactory = null;
		Connection connection = null;
		SqlSession sessionCollect = null;
		SqlSession sessionAgent  = null;
		String instance_db_version = "";
		
		is_collect_ok = "Y";
		failed_collect_type = "";	
		
		try {
			//수집 DB의 버젼을 가져온다
			instance_db_version = (String) MonitoringInfoManager.getInstance().getInstanceMap(reqInstanceId).get("pg_version_min");

			
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			
			try {			
				connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + reqInstanceId);
				sessionCollect = sqlSessionFactory.openSession(connection);
			} catch (Exception e) {
				failed_collect_type = "0";
				is_collect_ok = "N";
				//log.error("", e);
				log.error("[instanceId ==>> " + instanceId + "]", e);
			}
			
			sessionAgent = sqlSessionFactory.openSession();
			
//			// 인스턴스정보를 가져와 UPDATE 한다.
//			if(is_collect_ok.equals("Y"))
//			{	
//				try {
//					HashMap<String, Object> select = new HashMap<String, Object>();
//					/*add to update ha_info by robin 201712 */
//					select.put("instance_db_version", instance_db_version);	
//					select = sessionCollect.selectOne("app.EXPERDBMA_BT_UPTIME_MAXCONN_002", select);
//					
//					select.put("instance_id", Integer.valueOf(reqInstanceId));
//					select.put("max_conn_cnt", Integer.valueOf((String) select.get("max_conn_cnt")));
//					select.put("ha_role", select.get("ha_role"));
//					select.put("ha_host", select.get("ha_host"));
//					select.put("ha_port", select.get("ha_port"));
//					
//					sessionAgent.update("app.TB_INSTANCE_INFO_U002", select);
//					/*add to update ha_info by robin 201712 end*/
//					
//					sessionAgent.commit();
//				} catch (Exception e) {
//					sessionAgent.rollback();
//					log.error("", e);
//				}			
//			}
			
			//List<HashMap<String, Object>> accessSel = new ArrayList<HashMap<String,Object>>(); //Access 수집
			List<HashMap<String, Object>> tableSel = new ArrayList<HashMap<String,Object>>(); //Table 수집
			List<HashMap<String, Object>> tableExtSel = new ArrayList<HashMap<String,Object>>(); //Table Ext 수집
			List<HashMap<String, Object>> indexSel = new ArrayList<HashMap<String,Object>>(); //Index 수집
			List<HashMap<String, Object>> tablespaceSel = new ArrayList<HashMap<String,Object>>(); //TableSpace 수집			
			
			if(is_collect_ok.equals("Y"))
			{			
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////
				// DB connection 정보
				List<HashMap<String, Object>> dbConnList = new ArrayList<HashMap<String,Object>>();
				dbConnList = sessionCollect.selectList("app.PG_STAT_DATABASE_INFO_001");
	
				// pool 네임정보를 가져온다.
				PoolingDriver driver = (PoolingDriver) DriverManager.getDriver("jdbc:apache:commons:dbcp:");
				String[] poolNames = driver.getPoolNames();
				
				log.debug("이전 pool ==>> " + Arrays.toString(poolNames));
				
		
				for (HashMap<String, Object> mapDB : dbConnList) {
					String poolName = reqInstanceId + "." + taskId + "." + mapDB.get("db_name");
					
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
						HashMap instanceMap = MonitoringInfoManager.getInstanceMap(reqInstanceId);
						
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
	
						////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
						///////////////////////////////////////////////////////////////////////////////
//						// ACCESS 이전값 확인
//						if(ResourceInfo.getInstance().get(reqInstanceId, taskId, RESOURCE_KEY_ACCESS + "_" + mapDB.get("db_name")) == null)
//						{
//							HashMap<String, Object> inputParam = new HashMap<String, Object>();
//							inputParam.put("db_name", 					mapDB.get("db_name"));
//							inputParam.put("datid", 					mapDB.get("datid"));
//	
//							
//							HashMap<String, Object> selectMap = sessDB.selectOne("app.BT_ACCESS_INFO_001", inputParam);
//	
//							ResourceInfo.getInstance().put(reqInstanceId, taskId, RESOURCE_KEY_ACCESS + "_" + mapDB.get("db_name"), selectMap);
//							
//	//						log.fatal("최초 이전값 : " + selectMap);
//						}
//						///////////////////////////////////////////////////////////////////////////////				
//						
//						///////////////////////////////////////////////////////////////////////////////
//						// ACCESS 정보수집
//						HashMap<String, Object> inputAccessParam = new HashMap<String, Object>();
//						inputAccessParam = (HashMap<String, Object>) ResourceInfo.getInstance().get(reqInstanceId, taskId, RESOURCE_KEY_ACCESS + "_" + mapDB.get("db_name"));
//						
//						Map<String, Object> accessTempSel = new HashMap<String, Object>();
//						try {
//							inputAccessParam.put("datid", 					mapDB.get("datid"));
//							
//							accessTempSel = sessDB.selectOne("app.BT_ACCESS_INFO_001", inputAccessParam);
//						} catch (Exception e) {
//							failed_collect_type = "1";
//							throw e;
//						}						
//						accessSel.add((HashMap<String, Object>) accessTempSel);
//						
//	//					log.fatal("이전값 : " + inputAccessParam);
//	//					log.fatal("조회값 : " + accessTempSel);
//						
//						ResourceInfo.getInstance().put(reqInstanceId, taskId, RESOURCE_KEY_ACCESS + "_" + mapDB.get("db_name"), accessTempSel);
//						/////////////////////////////////////////////////////////////////////////////
						
						
						///////////////////////////////////////////////////////////////////////////////
						// TABLE 이전값 확인
						if(ResourceInfo.getInstance().get(reqInstanceId, taskId, RESOURCE_KEY_TABLE + "_" + mapDB.get("db_name")) == null)
						{
							List<HashMap<String, Object>> selectList = new ArrayList<HashMap<String,Object>>();
							selectList = sessDB.selectList("app.BT_TABLE_INFO_001");
							
							for (HashMap<String, Object> map : selectList) {
								HashMap<String, Object> temp = new HashMap<String, Object>();
								temp.put("agg_seq_scan_cnt", 	map.get("agg_seq_scan_cnt"));
								temp.put("agg_seq_tuples", 		map.get("agg_seq_tuples"));
								temp.put("agg_index_scan_cnt", 	map.get("agg_index_scan_cnt"));
								temp.put("agg_index_tuples", 	map.get("agg_index_tuples"));
								
								ResourceInfo.getInstance().put(reqInstanceId, taskId, RESOURCE_KEY_TABLE + "_" + mapDB.get("db_name") 
										                                                              + "_" + map.get("schema_name")
										                                                              + "_" + map.get("table_name")
										                                                              , temp);
							}
							
							ResourceInfo.getInstance().put(reqInstanceId, taskId, RESOURCE_KEY_TABLE + "_" + mapDB.get("db_name"), mapDB.get("db_name")); 
						}
						///////////////////////////////////////////////////////////////////////////////
						
						///////////////////////////////////////////////////////////////////////////////
						// TABLE 정보수집
						List<HashMap<String, Object>> tableTempSel = new ArrayList<HashMap<String,Object>>();
						try {					
							tableTempSel = sessDB.selectList("app.BT_TABLE_INFO_001");
						} catch (Exception e) {
							failed_collect_type = "3";
							throw e;
						}					
							
						for (HashMap<String, Object> map : tableTempSel) {
							HashMap<String, Object> tempMap = new HashMap<String, Object>(); //이전값
							tempMap =  (HashMap<String, Object>) ResourceInfo.getInstance().get(reqInstanceId, taskId, RESOURCE_KEY_TABLE 
																										+ "_" + mapDB.get("db_name") 
																										+ "_" + map.get("schema_name") 
																										+ "_" + map.get("table_name"));
							
							//이전값이 없는경우
							if(tempMap == null) {
								tempMap = new HashMap<String, Object>();
								
								tempMap.put("agg_seq_scan_cnt", 	map.get("agg_seq_scan_cnt"));
								tempMap.put("agg_seq_tuples", 		map.get("agg_seq_tuples"));
								tempMap.put("agg_index_scan_cnt", 	map.get("agg_index_scan_cnt"));
								tempMap.put("agg_index_tuples", 	map.get("agg_index_tuples"));
								
								ResourceInfo.getInstance().put(reqInstanceId, taskId, RESOURCE_KEY_TABLE + "_" + mapDB.get("db_name") 
		                                + "_" + map.get("schema_name")
		                                + "_" + map.get("table_name")
		                                , tempMap);
								
								continue;
							}						
							
							long current_seq_scan_cnt 		= Long.valueOf(map.get("agg_seq_scan_cnt").toString()) - Long.valueOf(tempMap.get("agg_seq_scan_cnt").toString());
							long current_seq_tuples 		= Long.valueOf(map.get("agg_seq_tuples").toString()) - Long.valueOf(tempMap.get("agg_seq_tuples").toString());
							long current_index_scan_cnt 	= Long.valueOf(map.get("agg_index_scan_cnt").toString()) - Long.valueOf(tempMap.get("agg_index_scan_cnt").toString());
							long current_index_tuples 		= Long.valueOf(map.get("agg_index_tuples").toString()) - Long.valueOf(tempMap.get("agg_index_tuples").toString());
							
							map.put("current_seq_scan_cnt", 	current_seq_scan_cnt);
							map.put("current_seq_tuples", 		current_seq_tuples);
							map.put("current_index_scan_cnt", 	current_index_scan_cnt);
							map.put("current_index_tuples", 	current_index_tuples);
							
							map.put("db_name",	mapDB.get("db_name"));
														
							tableSel.add(map);
							
							HashMap<String, Object> tableExtMap = new HashMap<String, Object>(); //이전값
														
							tableExtMap.put("collect_dt", map.get("collect_dt"));
							tableExtMap.put("relid", map.get("relid"));
							tableExtMap.put("instance_id", Integer.valueOf(reqInstanceId));
							tableExtMap.put("autovacuum_count", map.get("autovacuum_count"));
							tableExtMap.put("autoanalyze_count", map.get("autoanalyze_count"));
							tableExtMap.put("maxage", map.get("maxage"));
							
							tableExtSel.add(tableExtMap);
							
							tempMap.put("agg_seq_scan_cnt", 	map.get("agg_seq_scan_cnt"));
							tempMap.put("agg_seq_tuples", 		map.get("agg_seq_tuples"));
							tempMap.put("agg_index_scan_cnt", 	map.get("agg_index_scan_cnt"));
							tempMap.put("agg_index_tuples", 	map.get("agg_index_tuples"));
							
							ResourceInfo.getInstance().put(reqInstanceId, taskId, RESOURCE_KEY_TABLE + "_" + mapDB.get("db_name") 
	                                + "_" + map.get("schema_name")
	                                + "_" + map.get("table_name")
	                                , tempMap);
						}
						///////////////////////////////////////////////////////////////////////////////
						
						///////////////////////////////////////////////////////////////////////////////
						// INDEX 정보수집
						HashMap<String, Object> inputIndexParam = new HashMap<String, Object>();
						inputIndexParam.put("db_name", mapDB.get("db_name"));
						
						List<HashMap<String, Object>> indexTempSel = new ArrayList<HashMap<String,Object>>();
						try {					
							indexTempSel = sessDB.selectList("app.BT_INDEX_INFO_001", inputIndexParam);
						} catch (Exception e) {
							failed_collect_type = "4";
							throw e;
						}						
						
						for (HashMap<String, Object> map : indexTempSel) {
							indexSel.add(map);
						}
						///////////////////////////////////////////////////////////////////////////////
						////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////				
					} catch (Exception e1) {
						is_collect_ok = "N";
						//log.error("", e1);
						log.error("[instanceId ==>> " + instanceId + "]", e1);
						break;
					} finally {
						sessDB.close();
					}
				}
	
				
				
				///////////////////////////////////////////////////////////////////////////////
				// TABLESPACE 정보 수집
				if(is_collect_ok.equals("Y")) {
					try {
						HashMap<String, Object> dbVerMap = new HashMap<String, Object>();
						dbVerMap.put("instance_db_version", instance_db_version);						

						tablespaceSel = sessionCollect.selectList("app.BT_TABLESPACE_INFO_001", dbVerMap);
					} catch (Exception e) {
						failed_collect_type = "2";
						is_collect_ok = "N";
						//log.error("", e);
						log.error("[instanceId ==>> " + instanceId + "]", e);
					}					
				}
				///////////////////////////////////////////////////////////////////////////////			
			}
			
			
			try {
				
				///////////////////////////////////////////////////////////////////////////////
				// TB_RSC_COLLECT_INFO 정보 등록
				
				//금일자 최초 거래인지 확인
				HashMap<String, Object> regDateMap = sessionAgent.selectOne("app.TB_OBJT_COLLECT_INFO_S001");
				
				if(regDateMap.get("max_reg_date") == null)	regDateMap.put("max_reg_date", "");
				
				if(!regDateMap.get("max_reg_date").equals(regDateMap.get("reg_date")))
				{
					//금일자에 등록된 거래가 없는경우 시퀀스 초기화
					sessionAgent.selectList("app.SEQ_SETVAL_OBJT");
				}	
				
				Map<String, Object> parameObjt = new HashMap<String, Object>();
				parameObjt.put("instance_id", Integer.valueOf(reqInstanceId));				
				parameObjt.put("is_collect_ok", is_collect_ok);				
				parameObjt.put("failed_collect_type", failed_collect_type);
				
				sessionAgent.insert("app.TB_OBJT_COLLECT_INFO_I001", parameObjt);
				
				if(is_collect_ok.equals("N"))
				{
					sessionAgent.commit();
					return;
				}				
				///////////////////////////////////////////////////////////////////////////////			
			
				
//				///////////////////////////////////////////////////////////////////////////////
//				// ACCESS 정보 등록
//				for (HashMap<String, Object> map : accessSel) {
//					sessionAgent.insert("app.TB_ACCESS_INFO_I001", map);
//				}
//				///////////////////////////////////////////////////////////////////////////////			
			
				///////////////////////////////////////////////////////////////////////////////
				// TABLESPACE 정보 등록
				for (HashMap<String, Object> map : tablespaceSel) {
					sessionAgent.insert("app.TB_TABLESPACE_INFO_I001", map);					
				}
				
				///////////////////////////////////////////////////////////////////////////////			
			
				///////////////////////////////////////////////////////////////////////////////
				// TABLE 정보 등록
				for (HashMap<String, Object> map : tableSel) {
					sessionAgent.insert("app.TB_TABLE_INFO_I001", map);
				}
				
				// TABLE 정보 등록
				for (HashMap<String, Object> map : tableExtSel) {
					sessionAgent.insert("app.TB_TABLE_EXT_INFO_I001", map);
				}
				
				///////////////////////////////////////////////////////////////////////////////				
				
				///////////////////////////////////////////////////////////////////////////////
				// INDEX 정보 등록
				for (HashMap<String, Object> map : indexSel) {
					sessionAgent.insert("app.TB_INDEX_INFO_I001", map);					
				}
				///////////////////////////////////////////////////////////////////////////////				
				
			
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
	
	private void DeleteObject(String reqInstanceId) {
		SqlSessionFactory sqlSessionFactory = null;
		Connection connection = null;
		SqlSession sessionCollect = null;
		SqlSession sessionAgent  = null;
		String instance_db_version = "";
		
		try {
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();

			sessionAgent = sqlSessionFactory.openSession();
					
			try {
				///////////////////////////////////////////////////////////////////////////////
				// TABLESPACE 정보 삭제
				sessionAgent.delete("app.TB_TABLESPACE_INFO_D001");
				///////////////////////////////////////////////////////////////////////////////			
			
				///////////////////////////////////////////////////////////////////////////////
				// TABLE 정보 삭제
				sessionAgent.delete("app.TB_TABLE_INFO_D001");
				///////////////////////////////////////////////////////////////////////////////				
				
				///////////////////////////////////////////////////////////////////////////////
				// INDEX 정보 삭제
				sessionAgent.delete("app.TB_INDEX_INFO_D001");
				///////////////////////////////////////////////////////////////////////////////				
							
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
	
	private void updateHAstatus(String reqInstanceId) {
		SqlSessionFactory sqlSessionFactory = null;
		Connection connection = null;
		SqlSession sessionCollect = null;
		SqlSession sessionAgent  = null;
		String instance_db_version = "";
		is_collect_ok = "Y";
		failed_collect_type = "";	
		
		try {
			//수집 DB의 버젼을 가져온다
			instance_db_version = (String) MonitoringInfoManager.getInstance().getInstanceMap(reqInstanceId).get("pg_version_min");

			
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			
			try {			
				connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + reqInstanceId);
				sessionCollect = sqlSessionFactory.openSession(connection);
			} catch (Exception e) {
				failed_collect_type = "0";
				is_collect_ok = "N";
				//log.error("", e);
				log.error("[instanceId ==>> " + instanceId + "]", e);
			}
			
			sessionAgent = sqlSessionFactory.openSession();
			
			// 인스턴스정보를 가져와 UPDATE 한다.
			if(is_collect_ok.equals("Y"))
			{	
				try {
					HashMap<String, Object> select = new HashMap<String, Object>();
					/*add to update ha_info by robin 201712 */
					select.put("instance_db_version", instance_db_version);	
					select = sessionCollect.selectOne("app.EXPERDBMA_BT_UPTIME_MAXCONN_001", select);
					select.put("instance_id", Integer.valueOf(reqInstanceId));
					select.put("max_conn_cnt", Integer.valueOf((String) select.get("max_conn_cnt")));
					//select.put("ha_role", select.get("ha_role"));
					//select.put("ha_host", select.get("ha_host"));
					//select.put("ha_port", select.get("ha_port"));
					sessionAgent.update("app.TB_INSTANCE_INFO_U001", select);	
					/*add to update ha_info by robin 201712 end*/
					
					sessionAgent.commit();
				} catch (Exception e) {
					sessionAgent.rollback();
					//log.error("", e);
					log.error("[instanceId ==>> " + instanceId + "]", e);
				}			
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

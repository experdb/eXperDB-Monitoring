package experdb.mnt.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Date;
import java.util.Enumeration;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

import org.apache.commons.dbcp.PoolingDriver;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;

import experdb.mnt.LicenseInfoManager;
import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.ResourceInfo;
import experdb.mnt.db.dbcp.DBCPPoolManager;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class HchkCollect extends TaskApplication {

	public HchkCollect(String instanceId, String taskId) {
		super(instanceId, taskId);
	}

	@Override
	public void run() {

//		//OBJT 정보수집
//		Enumeration		en = MonitoringInfoManager.getInstance().getInstanceId();
//		while (en.hasMoreElements()) {
//			objtCollect((String) en.nextElement());
//		}
		
		
		SqlSessionFactory sqlSessionFactory = null;
		Connection connection = null;
		SqlSession sessionAgent  = null;
		
		try {
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			sessionAgent = sqlSessionFactory.openSession();		

			List<String> queryList = new ArrayList<String>();
			List<HashMap<String, Object>> selectList = new ArrayList<HashMap<String,Object>>();
			List<HashMap<String, Object>> insertList = new ArrayList<HashMap<String,Object>>();
			// Alert 수집 robin 201802
			List<HashMap<String, Object>> insertAlertList = new ArrayList<HashMap<String,Object>>();
			List<HashMap<String, Object>> updateList = new ArrayList<HashMap<String,Object>>();
			
			// Threshold 정보수집 robin 201802
			List<HashMap<String, Object>> selectTholdList = new ArrayList<HashMap<String,Object>>();
			try {					
				selectTholdList = sessionAgent.selectList("app.TB_HCHK_THOLD_INFO_001");
			} catch (Exception e) {
				log.error("", e);
				throw e;
			}			
			
			try {
				//select 쿼리
				queryList.add("EXPERDBMA_BT_HCHK_BUFFERHITRATIO_001");
				queryList.add("EXPERDBMA_BT_HCHK_LOCKCNT_001");
				queryList.add("EXPERDBMA_BT_HCHK_CONNECTION_001");
				queryList.add("EXPERDBMA_BT_HCHK_CONNECTIONFAIL_001");
				queryList.add("EXPERDBMA_BT_HCHK_UNUSEDINDEX_001");
				queryList.add("EXPERDBMA_BT_HCHK_LASTANALYZE_001");
				queryList.add("EXPERDBMA_BT_HCHK_DISKUSAGE_001");
				queryList.add("EXPERDBMA_BT_HCHK_CPUUTIL_001");
				queryList.add("EXPERDBMA_BT_HCHK_CPUWAIT_001");
				queryList.add("EXPERDBMA_BT_HCHK_MEMUSAGE_001");
				queryList.add("EXPERDBMA_BT_HCHK_SWAPUSAGE_001");
				queryList.add("EXPERDBMA_BT_HCHK_HA_STATUS_CHANGED_001");
				queryList.add("EXPERDBMA_BT_HCHK_REPLICATIONDELAY_001");
				queryList.add("EXPERDBMA_BT_HCHK_REPLICATIONSLOT_001");	
				queryList.add("EXPERDBMA_BT_HCHK_VIRTUALIP_001");				
				queryList.add("EXPERDBMA_BT_HCHK_WALCNT_001");
				queryList.add("EXPERDBMA_BT_HCHK_HGCPUUTIL_001");
				queryList.add("EXPERDBMA_BT_HCHK_HGCPUWAIT_001");
				queryList.add("EXPERDBMA_BT_HCHK_HAMEMUSAGE_001");
				queryList.add("EXPERDBMA_BT_HCHK_HGSWAPUSAGE_001");
				queryList.add("EXPERDBMA_BT_HCHK_HGCONNECTION_001");
				queryList.add("EXPERDBMA_BT_HCHK_SO_STATUS_CHANGED_001");				
				queryList.add("EXPERDBMA_BT_HCHK_UNUSEDINDEX_001");
				
				for (String s : queryList) {
					selectList.clear();
					selectList = sessionAgent.selectList("app." + s);

					for (HashMap<String, Object> map : selectList) {
						
						for(String key : map.keySet()){
				            if(	!key.equals("instance_id") 		&& 
				            	!key.equals("hchk_name") 		&&
				            	!key.equals("value") 			&&
				            	!key.equals("collect_group") 	&&
				            	!key.equals("collect_reg_date")	&&
				            	!key.equals("collect_reg_seq") 	&&
				            	!key.equals("reg_time")
				              )
				            {
				            	HashMap<String, Object> tempMap = new HashMap<String, Object>();

				            	tempMap.put("instance_id", 		map.get("instance_id"));
				            	tempMap.put("hchk_name", 		key.toUpperCase());
				            	tempMap.put("value", 			map.get(key));
				            	tempMap.put("collect_group", 	map.get("collect_group"));
				            	tempMap.put("collect_reg_date",	map.get("collect_reg_date"));
				            	tempMap.put("collect_reg_seq", 	map.get("collect_reg_seq"));
				            	tempMap.put("reg_time", 		map.get("reg_time"));
				            	int nState = 0;
				            	//add alert list into TB_HCHK_ALERT_INFO robin 201802
								for (HashMap<String, Object> tholdMap : selectTholdList) {									
						            if(tholdMap.get("instance_id").equals(tempMap.get("instance_id")) && 
						            	tholdMap.get("hchk_name").equals(tempMap.get("hchk_name")))
						            {
						            	HashMap<String, Object> alertMap = new HashMap<String, Object>();

						            	int nThreshold = Integer.parseInt(tholdMap.get("fixed_threshold").toString());
						            	int nIsHigher = Integer.parseInt(tholdMap.get("is_higher").toString());
						            	int nPause = Integer.parseInt(tholdMap.get("pause").toString());
						            	double dWarnThold = Double.parseDouble(tholdMap.get("warning_threshold").toString());
						            	double dCritThold = Double.parseDouble(tholdMap.get("critical_threshold").toString());
						            	double dValue = Double.parseDouble(tempMap.get("value").toString());
						            	
						            	tempMap.put("critical_start_time", 		tholdMap.get("critical_start_time"));
						            	if(nPause == 1) break;
						            	if(nThreshold == 0) {
							            	if(nIsHigher == 0) {
							            		if(dValue < dWarnThold)
							            			break;
							            		alertMap.put("state", (dValue >= dCritThold) ? 300 : 200);							            		
							            	} else {
							            		if(dValue > dWarnThold)
							            			break;
							            		alertMap.put("state", (dValue <= dCritThold) ? 300 : 200);
							            	}
						            	} else if(nThreshold == 1) {
							            	if(nIsHigher == 0) {
							            		if(dValue < dWarnThold)
							            			break;
							            	} else {
							            		if(dValue > dWarnThold)
							            			break;
							            	}
						            		alertMap.put("state", 200);							            		
								        } else if(nThreshold == 2) {
							            	if(nIsHigher == 0) {
							            		if(dValue < dCritThold)
							            			break;
							            	} else {
							            		if(dValue > dCritThold)
							            			break;
							            	}
						            		alertMap.put("state", 300);	
										} else	break;
			            	
						            	nState =  Integer.parseInt(alertMap.get("state").toString());
						            	
						            	if (alertMap.get("state").toString().equals("300")){
						            		/* check whether retention_time set or not */
							            	if (tholdMap.get("retention_time") == null) {
								            	alertMap.put("instance_id",tempMap.get("instance_id"));
								            	alertMap.put("hchk_name",  tempMap.get("hchk_name"));								            	
								            	insertAlertList.add(alertMap);
							            	} else if (Integer.parseInt(tholdMap.get("retention_time").toString()) == 0) {
									            alertMap.put("instance_id",tempMap.get("instance_id"));
									            alertMap.put("hchk_name",  tempMap.get("hchk_name"));
									            insertAlertList.add(alertMap);
							            	} else {							            		
							            		/* check that the alert state is retained for the duration of the alert. */
							            		if (tempMap.get("critical_start_time") != null){
								            		long retention_time = Integer.parseInt(tholdMap.get("retention_time").toString()) * 1000;
								            		SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
								            		SimpleDateFormat sdf2 = new SimpleDateFormat("yyyyMMdd HH:mm:ss");
									            	Date criticalTime = sdf.parse(tempMap.get("critical_start_time").toString());
									            	Date regTime = sdf2.parse(tempMap.get("collect_reg_date") + " "+ tempMap.get("reg_time"));

									            	long timediff = regTime.getTime() - (criticalTime.getTime() + retention_time) ;
									        		
									            	if (timediff >= 0){
										            	alertMap.put("instance_id",tempMap.get("instance_id"));
										            	alertMap.put("hchk_name",  tempMap.get("hchk_name"));
										            	insertAlertList.add(alertMap);
									            	}							            			
							            		}
							            	}						            	
						            	} else {
							            	alertMap.put("instance_id",tempMap.get("instance_id"));
							            	alertMap.put("hchk_name",  tempMap.get("hchk_name"));
							            	insertAlertList.add(alertMap);
						            	}
						            	break;						            	
						            }
								}
								
								HashMap<String, Object> updateMap = new HashMap<String, Object>();
								if (tempMap.get("critical_start_time") == null ){
									if (nState >= 300){
										updateMap.put("instance_id", tempMap.get("instance_id"));
										updateMap.put("hchk_name", tempMap.get("hchk_name"));
										SimpleDateFormat sdf = new SimpleDateFormat("yyyyMMdd HH:mm:ss");
						            	Date criticalTime = sdf.parse(tempMap.get("collect_reg_date") + " "+ tempMap.get("reg_time"));
						            	updateMap.put("critical_start_time", criticalTime);
										updateList.add(updateMap);
									} 								
								} else {
									if (nState < 300){
										updateMap.put("instance_id", tempMap.get("instance_id"));
										updateMap.put("hchk_name", tempMap.get("hchk_name"));
										updateMap.put("critical_start_time", null);
										updateList.add(updateMap);
									} 								
								}
									
				            	insertList.add(tempMap);
				            }
				        }				        
					}
				}
				
				//금일자 최초 거래인지 확인
				HashMap<String, Object> regDateMap = sessionAgent.selectOne("app.TB_HCHK_COLLECT_INFO_S001");
				
				if(regDateMap.get("max_reg_date") == null)	regDateMap.put("max_reg_date", "");
				
				if(!regDateMap.get("max_reg_date").equals(regDateMap.get("reg_date")))
				{
					//금일자에 등록된 거래가 없는경우 시퀀스 초기화
					sessionAgent.selectList("app.SEQ_SETVAL_HCHK");
				}				
				
				//HCHK_REG_SEQ 증가
				sessionAgent.selectOne("app.HCHK_REG_SEQ_001");
				
				//update
				for (HashMap<String, Object> map : updateList) {
					sessionAgent.update("app.TB_HCHK_THRD_LIST_U001", map);
				}
				//insert
				for (HashMap<String, Object> map : insertList) {
					sessionAgent.insert("app.TB_HCHK_COLLECT_INFO_I001", map);
				}
				//insert Alert robin 201802			
				for (HashMap<String, Object> map : insertAlertList) {
					sessionAgent.insert("app.TB_HCHK_ALERT_INFO_I001", map);
				}
				
				//Commit
				sessionAgent.commit();
			} catch (Exception e) {
				sessionAgent.rollback();
				log.error("", e);
			}			
			
		} catch (Exception e) {
			log.error("", e);
		} finally {
			sessionAgent.close();
		}
		
		exportAlert();
	}
	
	private void exportAlert() {
/////////////////////////////////////////////////////////////////////////////////////////////
	SqlSessionFactory sqlSessionFactory = null;
	Connection connection = null;
	Connection connExternalDB = null;
	SqlSession sessionAgent  = null;
	PreparedStatement pstmt = null;
	
	List<HashMap<String, Object>> exportAlertSel = new ArrayList<HashMap<String,Object>>(); // Collect Alert info 
	
	int[] argIndex = {0,0,0};
	
	try {			
			sqlSessionFactory = SqlSessionManager.getInstance();
			sessionAgent = sqlSessionFactory.openSession();	
			boolean isSuccess = false;
			String errorMessages = "";
			
			// Get export info
			HashMap<String, Object> selectExportInfo = new HashMap<String,Object>();
			try {					
				selectExportInfo = sessionAgent.selectOne("app.TB_EXPORT_INFO_001");
			} catch (Exception e) {
				log.error("", e);
				throw e;
			}
			
			try {
				exportAlertSel = sessionAgent.selectList("app.TB_EXPORT_ALERT_001");
			} catch (Exception e) {
				log.error("", e);
				throw e;
			}

			HashMap<String, Object> configMapForKey = new HashMap<String, Object>();
			String cryptokey = "";
			try {
				configMapForKey = sessionAgent.selectOne("system.TB_CONFIG_R002");
				cryptokey = (String)configMapForKey.get("serial_key");
				cryptokey = cryptokey.substring(0, 24);			
			} catch (Exception e) {
				log.error("", e);
				throw e;
			}
						
			if (exportAlertSel.size() > 0){
				try {
					connExternalDB = prepareConnection(selectExportInfo, cryptokey);
					if (connExternalDB != null){
						pstmt = prepareCommand(connExternalDB, selectExportInfo, argIndex);
						if (pstmt != null){
							int updateInstanceId = 0;
							for (HashMap<String, Object> exportMap : exportAlertSel) {
								if((exportMap.get("sender") == null) || (exportMap.get("sender").toString().length() > 0)){
									pstmt.setString(argIndex[0], exportMap.get("sender").toString());
									pstmt.setString(argIndex[1], exportMap.get("reciever").toString());
									pstmt.setString(argIndex[2], exportMap.get("messages").toString());
								} else {
									pstmt.setString(argIndex[0], exportMap.get("reciever").toString());
									pstmt.setString(argIndex[1], exportMap.get("messages").toString());
								}
								pstmt.executeUpdate();
							}
						}
						connExternalDB.commit();
						if(connExternalDB != null) connExternalDB.close();
						if(pstmt != null) pstmt.close();
						isSuccess = true;
					} else{
						isSuccess = false;
						errorMessages = "Connection failed.";
					}
				} catch (Exception e) {
					isSuccess = false;
					errorMessages = e.getMessage();
					log.error("", e);
					if(pstmt != null) 
						pstmt.close();
				}	
			}

			//insert export history robin 201802			
			for (HashMap<String, Object> map : exportAlertSel) {
				map.put("issuccess", isSuccess);
				map.put("error", errorMessages);
				sessionAgent.insert("app.TB_EXPORT_ALERT_I001", map);
				//update last sent time
				sessionAgent.update("app.TB_EXPORT_ALERT_U001", map);
			}			

			sessionAgent.commit();
		} catch (Exception e) {
			log.error("", e);			
			sessionAgent.rollback();
		} finally {
			if(sessionAgent != null)	sessionAgent.close();
		}
//////////////////////////////////////////////////////////////////////////////////////////////
	}
	private Connection prepareConnection(HashMap<String,Object> selectExportInfo, String cryptokey)
	{		
		// Make JDBC Url
		String driver = "";
		String connectUrl = "";
		Connection connExternalDB = null;
		try {
			switch (Integer.parseInt(selectExportInfo.get("link_type").toString())) {
				case 0 :
					driver =  "com.microsoft.sqlserver.jdbc.SQLServerDriver" ;
					connectUrl = "jdbc:sqlserver://"+selectExportInfo.get("link_ip").toString()+":"+selectExportInfo.get("link_port").toString()+";databaseName="+selectExportInfo.get("link_database").toString();
					break;
				case 1 :
					driver =  "oracle.jdbc.driver.OracleDriver" ;
					connectUrl =  "jdbc:oracle:thin:@"+selectExportInfo.get("link_ip").toString()+":"+selectExportInfo.get("link_port").toString()+"/"+selectExportInfo.get("link_database").toString();
					break;
			}
			
			Class.forName(driver);
			DriverManager.setLoginTimeout(3);
			String dbPass = selectExportInfo.get("link_password").toString();
			dbPass = LicenseInfoManager.decryptTDES(cryptokey, dbPass);
			
			connExternalDB = DriverManager.getConnection(connectUrl, selectExportInfo.get("link_id").toString(), dbPass);
			connExternalDB.setAutoCommit(false);

		} catch (Exception e) {
			log.error("", e);
		} 
		return connExternalDB;
	}
	
	private PreparedStatement prepareCommand(Connection connExternalDB, HashMap<String,Object> selectExportInfo, int[] argIndex)
	{		
		// Make prepareStatements
		String driver = "";
		String connectUrl = "";
		PreparedStatement pstmt = null;
		String sqlcommand = "";			
		try {
			sqlcommand = selectExportInfo.get("link_statements").toString();
						
			argIndex[0] = sqlcommand.indexOf("$src");
			argIndex[1] = sqlcommand.indexOf("$dst");
			argIndex[2] = sqlcommand.indexOf("$msg");
			
	        int big = (argIndex[0]>argIndex[1])&&(argIndex[0]>argIndex[2])?argIndex[0]:(argIndex[2]>argIndex[1]?argIndex[2]:argIndex[1]);
	        int small = (argIndex[1]>argIndex[0])&&(argIndex[2]>argIndex[0])?argIndex[0]:(argIndex[1]>argIndex[2]?argIndex[2]:argIndex[1]);
	        int middle = (argIndex[0]+argIndex[1]+argIndex[2])-big-small;
	        
	        for(int i = 0 ; i < 3; i++){
	        	if (argIndex[i] == big) argIndex[i] = 3;
	        	else if (argIndex[i] == middle) argIndex[i] = 2;
	        	else  argIndex[i] = 1;
	        }				
			
	        sqlcommand = sqlcommand.replace("$src", "?");
	        sqlcommand = sqlcommand.replace("$dst", "?");
	        sqlcommand = sqlcommand.replace("$msg", "?");	        
			pstmt = connExternalDB.prepareStatement(sqlcommand);
		} catch (Exception e) {
			log.error("", e);
		}
		return pstmt;
	}

	private static final String RESOURCE_KEY_TABLESPACE = "TABLESPACE";
	private static final String RESOURCE_KEY_TABLE = "TABLE";
	private static final String RESOURCE_KEY_INDEX = "INDEX";

	private String is_collect_ok = "Y";
	private String failed_collect_type = "";	
	
	private void objtCollect(String reqInstanceId) {
		
		is_collect_ok = "Y";
		failed_collect_type = "";
		
		String instance_db_version = "";
		
		SqlSessionFactory sqlSessionFactory = null;
		Connection connection = null;
		SqlSession sessionCollect = null;
		SqlSession sessionAgent  = null;
		
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
				log.error("[instanceId ==>> " + instanceId + "]" + " Connection failed]");		

			}
			
			sessionAgent = sqlSessionFactory.openSession();
			

			// 인스턴스정보를 가져와 UPDATE 한다.
			if(is_collect_ok.equals("Y"))
			{	
				try {
					HashMap<String, Object> select = new HashMap<String, Object>();
					/*add to update ha_info by robin 201712 */
					select.put("instance_db_version", instance_db_version);	
					select = sessionCollect.selectOne("app.EXPERDBMA_BT_UPTIME_MAXCONN_002", select);
					
					select.put("instance_id", Integer.valueOf(reqInstanceId));
					select.put("max_conn_cnt", Integer.valueOf((String) select.get("max_conn_cnt")));
					
					sessionAgent.update("app.TB_INSTANCE_INFO_U001", select);
					/*add to update ha_info by robin 201712 end*/
					
					sessionAgent.commit();
				} catch (Exception e) {
					sessionAgent.rollback();
					log.error("", e);
				}			
			}
			
			List<HashMap<String, Object>> tablespaceSel = new ArrayList<HashMap<String,Object>>(); //TableSpace 수집			
			List<HashMap<String, Object>> tableSel = new ArrayList<HashMap<String,Object>>(); //Table 수집
			List<HashMap<String, Object>> indexSel = new ArrayList<HashMap<String,Object>>(); //Index 수집
			
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
								15
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
							failed_collect_type = "2";
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
							failed_collect_type = "3";
							throw e;
						}						
						
						for (HashMap<String, Object> map : indexTempSel) {
							indexSel.add(map);
						}
						///////////////////////////////////////////////////////////////////////////////
						////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////				
					} catch (Exception e1) {
						is_collect_ok = "N";
						log.error("", e1);
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
						failed_collect_type = "1";
						is_collect_ok = "N";
						log.error("", e);
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
			
				
				///////////////////////////////////////////////////////////////////////////////
				// TABLESPACE 정보 등록
				for (HashMap<String, Object> map : tablespaceSel) {
					sessionAgent.insert("app.TB_TABLESPACE_INFO_I001", map);
				}
				///////////////////////////////////////////////////////////////////////////////			
			
				///////////////////////////////////////////////////////////////////////////////
				// TABLE 정보 등록
//				for (HashMap<String, Object> map : tableSel) {
//					sessionAgent.delete("app.TB_TABLE_INFO_D001", map);
//				}
				if (tableSel.size() > 0)
					sessionAgent.delete("app.TB_TABLE_INFO_D001", tableSel.get(0)); //Run only once by Database(Sequence)
				
				for (HashMap<String, Object> map : tableSel) {
					sessionAgent.insert("app.TB_TABLE_INFO_I001", map);
				}
				///////////////////////////////////////////////////////////////////////////////				
				
				///////////////////////////////////////////////////////////////////////////////
				// INDEX 정보 등록
//				for (HashMap<String, Object> map : indexSel) {
//					sessionAgent.delete("app.TB_INDEX_INFO_D001", map);
//				}
				if (indexSel.size() > 0)
					sessionAgent.delete("app.TB_INDEX_INFO_D001", indexSel.get(0)); //Run only once by Database(Sequence)
				
				for (HashMap<String, Object> map : indexSel) {
					sessionAgent.insert("app.TB_INDEX_INFO_I001", map);
				}
				///////////////////////////////////////////////////////////////////////////////				
				
			
				//Commit
				sessionAgent.commit();
			} catch (Exception e) {
				sessionAgent.rollback();
				log.error("", e);
			}			
			
		} catch (Exception e) {
			log.error("", e);
		} finally {
			if(sessionAgent != null)	sessionAgent.close();
			if(sessionCollect != null)	sessionCollect.close();
		}
	}	
	
}

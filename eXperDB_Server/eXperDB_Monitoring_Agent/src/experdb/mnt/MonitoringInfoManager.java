package experdb.mnt;

import java.sql.Connection;
import java.sql.DriverManager;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Date;
import java.util.Enumeration;
import java.util.HashMap;
import java.util.Hashtable;
import java.util.List;

import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.log4j.Logger;

import experdb.mnt.db.mybatis.SqlSessionManager;

public class MonitoringInfoManager {
	private static Logger log = Logger.getLogger(MonitoringInfoManager.class);
	
	private static MonitoringInfoManager thisObj = null;
	private static Hashtable	monitoringInfoHash = new Hashtable();
	private static Hashtable	configHash = new Hashtable();

	private static String lastModDt	= "";
	private static boolean isReLoad	= false;

	public static synchronized void initInstance() throws Exception {
		if (thisObj != null) {
			log.info("MonitoringInfoManager가 이미 초기화되었습니다.");
			return;
		}

		log.info("************************************************************");
		log.info("MonitoringInfoManager를 초기화합니다.");		
		
		thisObj = new MonitoringInfoManager();
		thisObj.loadInfo();
		thisObj.changeInfo();
		isReLoad = false;
		
		log.info("MonitoringInfoManager를 초기화하였습니다.");
		log.info("************************************************************");		
	}	
	
	public static synchronized MonitoringInfoManager getInstance() {
		if(thisObj == null)
		{
			try {
				initInstance();
			} catch (Exception e) {
				log.error("", e);
			}
		}
		
		return thisObj;
	}	
	
	public void loadInfo() throws Exception {
		SqlSessionFactory sqlSessionFactory = SqlSessionManager.getInstance();
		SqlSession session = sqlSessionFactory.openSession();
		
		try {
			List<HashMap<String, Object>> tempS = session.selectList("system.TB_INSTANCE_INFO_R001");

//			====================== 제거
			
			/* *********************************<Crypto>******************************* */
			HashMap<String, Object> configMapForKey = new HashMap<String, Object>();
			
			configMapForKey = session.selectOne("system.TB_CONFIG_R002");
			String cryptokey = (String)configMapForKey.get("serial_key");
			cryptokey = cryptokey.substring(0, 24);			
			//get key
//			System.out.println(LicenseInfoManager.encryptTDES(cryptokey, "Hello World"));
//			System.out.println(LicenseInfoManager.decryptTDES(cryptokey, LicenseInfoManager.encryptTDES(cryptokey, "Hello World")));
			/* *******************************<Crypto>********************************** */
			
			// create extension pg_profile
			session.update("app.TB_CREATE_PROFILE_001");
			session.commit();
			
			SqlSession sessionCollect = null;
			Connection connection = null;
			String instance_db_version = "";
			
			for (HashMap<String, Object> map : tempS) {
				
				try {
					sessionCollect = null;
					connection = null;
					
					connection = DriverManager.getConnection(
							"jdbc:postgresql://" + map.get("server_ip") + ":" + map.get("service_port") + "/" + map.get("conn_db_name"), 
							(String) map.get("conn_user_id"),
							LicenseInfoManager.decryptTDES(cryptokey, (String)map.get("conn_user_pwd")));
					
					sessionCollect = sqlSessionFactory.openSession(connection);

					HashMap<String, Object> select_prev = new HashMap<String, Object>();
					select_prev = sessionCollect.selectOne("app.EXPERDBMA_BT_GET_PGVERSION_001");
					instance_db_version = (String)select_prev.get("pg_version");
					HashMap<String, Object> select = new HashMap<String, Object>();
					HashMap<String, Object> selectext = new HashMap<String, Object>();
					
					/* add to update ha info by robin 201712*/
					//select = sessionCollect.selectOne("app.EXPERDBMA_BT_UPTIME_MAXCONN_001");		
					try {
						select.put("instance_db_version", instance_db_version);	
						select = sessionCollect.selectOne("app.EXPERDBMA_BT_UPTIME_MAXCONN_001", select);
						selectext = sessionCollect.selectOne("app.PG_CHECK_EXTENSION_003");
						if (selectext != null) select.put("extensions", selectext.get("extensions"));
						select.put("instance_id", map.get("instance_id"));
					} catch (Exception e) {
						log.error(e);
						continue;
					}
					
					/* update ha group 서버 다시띄우면 변경됨 */
					HashMap<String, Object> select_group = new HashMap<String, Object>();
					select_group = session.selectOne("app.EXPERDBMA_BT_SELECT_HA_GROUP_001", select);					
					
					/* update  */
					select.put("max_conn_cnt", Integer.valueOf((String) select.get("max_conn_cnt")));
					if (select_group != null)
						select.put("ha_group",      select_group.get("ha_group"));
					else
						select.put("ha_group",      select.get("instance_id"));
					
					session.update("app.TB_INSTANCE_INFO_U002", select);
				    /* add to update ha info by robin 201712 end*/
					
					/*add to create function to make FBI by robin 201902 start*/
					session.update("app.PG_CREATE_FUNCTION_FOR_INDEX_001");
					/*add to create function to make FBI by robin 201902 end*/
					
					/*add to create fdw and temp table by robin 201902 start*/
					map.put("conn_user_pwd", LicenseInfoManager.decryptTDES(cryptokey, (String)map.get("conn_user_pwd")));
					session.update("app.TB_RTSTATEMENTS_INFO_C001", map);
					//session.selectList("app.SEQ_SETVAL_STMT");
					/*add to create fdw and temp table by robin 201902 end*/
					/*add to create snapshot by robin 202007 start*/
					session.update("app.TB_SNAPSHOT_INFO_C001", map);
					/*add to create snapshot by robin 202007 end*/
					
					
					session.commit();
				} catch (Exception e) {
					log.error(e);
					/* 
					 * 2016.04.27 최초 agent 로드 시에 타겟 DB가 shutdown 시 exception으로 agent가 종료되어 주석처리 
					throw new Exception(e);
					*/					
				} finally {
					if(sessionCollect != null)	sessionCollect.close();
				}
				
			}
			
//			====================== 제거			
			
			
			
			List<HashMap<String, Object>> list = session.selectList("system.TB_INSTANCE_INFO_R001");

			monitoringInfoHash = new Hashtable();
			
			if(list.size() == 0)
			{
				log.info("대상수집서버 정보가 없습니다.");
			}
			else {
				
				for (HashMap<String, Object> map : list) {
					
					//DB 버젼정보를 가져온다.
					for(String key : map.keySet()){
						if(key.equals("pg_version")) {
							if(map.get(key) == null || map.get(key).equals(""))		break;
							
							String version = ((String) map.get(key)).split("\\s")[1];
							String[] temp = version.split("[.]");
							
							String majorVersion = temp[0] + "." + temp[1]; 
							
							map.put(key, majorVersion);
							break;
						}
						if(key.equals("conn_user_pwd")) {
							if(map.get(key) == null || map.get(key).equals(""))		break;
							
							String conn_user_pwd = (String) map.get(key);
							map.put(key, LicenseInfoManager.decryptTDES(cryptokey, (String)map.get("conn_user_pwd")));
							break;
						}
					}					
					
					monitoringInfoHash.put(map.get("instance_id").toString(), map);
				}
			}

			//TB_CONFIG 정보를 가져온다.
			HashMap<String, Object> configMap = new HashMap<String, Object>();
			
			configMap = session.selectOne("system.TB_CONFIG_R001");
			for(String key : configMap.keySet()){
				configHash.put(key, configMap.get(key));
			}
			
			
		} catch (Exception e){
			log.error("MonitoringInfoManager 읽는중 오류가 발생하였습니다.");
			log.error(e);
			throw new Exception(e);
		} finally {
			session.close();
		}
	}
	
	public void changeInfo(){
		log.debug("<<===================== instance changeInfo =====================>>");		
		
		SqlSessionFactory sqlSessionFactory = SqlSessionManager.getInstance();
		SqlSession session = sqlSessionFactory.openSession();
		
		try {
			HashMap<String, Object> selectMap = new HashMap<String, Object>();  
			selectMap = session.selectOne("system.TB_INSTANCE_INFO_R002");

			String currLastModDt = "";
			if(selectMap != null && !selectMap.isEmpty() ) {
				currLastModDt = selectMap.get("last_mod_dt").toString(); 
			}
			
			log.debug("가져온값==>>" + currLastModDt);
			log.debug("저장된값==>>" + lastModDt);				
			
			if(!lastModDt.equals(currLastModDt)) {
//				isReLoad = true;  // 재기동을 전문으로 처리하여 주석처리						
				lastModDt = currLastModDt;
			}			
			
			//TB_CONFIG 정보를 가져온다.
			HashMap<String, Object> configMap = new HashMap<String, Object>();
			
			configMap = session.selectOne("system.TB_CONFIG_R001");
			for(String key : configMap.keySet()){
				configHash.put(key, configMap.get(key));
			}			
			
			//삭제 배치 기동여부를 확인한다.
			SimpleDateFormat sdf = new SimpleDateFormat("H:mm:ss");
			
			Date batchTime = sdf.parse(configHash.get("daily_batch_start_time").toString());
			Date nowTime = sdf.parse(configHash.get("now_time").toString());
			
            if(nowTime.after(batchTime)) {
            	// 배치기동
            	List<HashMap<String, Object>> logList = new ArrayList<HashMap<String,Object>>();
            	
            	logList = session.selectList("system.TB_SYS_LOG_R001");
            	
            	if(logList.isEmpty())
            	{
//            		isReLoad = true; // 재기동을 전문으로 처리하여 주석처리
            		configHash.put("batch_start","Y");
            	} else{
            		configHash.put("batch_start","N");
            	}
            	
            } else{
            	configHash.put("batch_start","N");
            }
            	
			
            log.debug("batch_start ===============================>>>> " + configHash.get("batch_start"));
			
		} catch (Exception e){
			log.error("MonitoringInfoManager 변경사항 확인중 오류가 발생하였습니다.");
			log.error(e);
		} finally {
			session.close();
		}		
		
	}
	
	public static Enumeration getInstanceId() {
		return monitoringInfoHash.keys();
	}
	
	public static HashMap getInstanceMap(String instanceId) {
		return (HashMap) monitoringInfoHash.get(instanceId);
	}
	
	public static boolean isReLoad() {
		return isReLoad;
	}

	public static void setReLoad(boolean isReLoad) {
		MonitoringInfoManager.isReLoad = isReLoad;
	}	
	
	public static Object getConfig(String key) {
		return configHash.get(key);
	}
}



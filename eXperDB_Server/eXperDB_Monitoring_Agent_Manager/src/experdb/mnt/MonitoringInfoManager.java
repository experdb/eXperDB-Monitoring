package experdb.mnt;

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
			List<HashMap<String, Object>> list = session.selectList("system.TB_INSTANCE_INFO_R001");

			monitoringInfoHash = new Hashtable();
			
			if(list.size() == 0)
			{
				log.info("대상수집서버 정보가 없습니다.");
			}
			else {
				
				for (HashMap<String, Object> map : list) {
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
				isReLoad = true;						
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
            		isReLoad = true;
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



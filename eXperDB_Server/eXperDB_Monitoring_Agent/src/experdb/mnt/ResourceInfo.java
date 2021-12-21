package experdb.mnt;

import java.util.Enumeration;
import java.util.HashMap;
import java.util.Hashtable;
import java.util.Iterator;
import java.util.List;
import java.util.Set;

import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.logging.log4j.Logger;
import org.apache.logging.log4j.LogManager;

import experdb.mnt.db.mybatis.SqlSessionManager;

public class ResourceInfo {
	private static Logger log = LogManager.getLogger(ResourceInfo.class);
	
	private static ResourceInfo thisObj = null;
	private static Hashtable	resourceInfoHash = new Hashtable<String, Object>();

	public static synchronized void initInstance() throws Exception {
		if (thisObj != null) {
			return;
		}
		
		thisObj = new ResourceInfo();
	}	
	
	public static synchronized ResourceInfo getInstance() {
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

	public Object get(String instanceId, String taskId, String key) {
		if(!resourceInfoHash.containsKey(instanceId + "_" + taskId + "_" + key))	return null;
		return resourceInfoHash.get(instanceId + "_" + taskId + "_" + key);
	}
	
	public void put(String instanceId, String taskId, String key, Object value) {
		resourceInfoHash.put(instanceId + "_" + taskId + "_" + key, value);
	}	
	
	

	public Hashtable getResourceMap() {
		return resourceInfoHash;
	}
	
	public void putResourceMap(String key, Object value) {
		resourceInfoHash.put(key, value);
	}	

	public void reSet(){
		resourceInfoHash = null;
		resourceInfoHash = new Hashtable<String, Object>();
	}
	
	
	/*
	public static HashMap<String, Object> getResource(String instanceId, String taskId, String key) {
		HashMap<String, Object> temp1 = new HashMap<String, Object>();
		HashMap<String, Object> temp2 = new HashMap<String, Object>();
		
		if(!resourceInfoHash.containsKey(instanceId))	return null;
		temp1 = (HashMap<String, Object>) resourceInfoHash.get(instanceId);
		
		if(!temp1.containsKey(taskId))	return null;
		temp2 = (HashMap<String, Object>) temp1.get(taskId);
		
		if (!temp2.containsKey(key))	return null;
		
		return (HashMap<String, Object>) temp2.get(key);
	}	

	public static void putResource(String instanceId, String taskId, String key, Object value) {
		HashMap<String, Object> temp1 = new HashMap<String, Object>();
		HashMap<String, Object> temp2 = new HashMap<String, Object>();
		
		//temp2에 이전값을 넣는다.
		if(resourceInfoHash.containsKey(instanceId))
		{
			HashMap<String, Object> prevalue = new HashMap<String, Object>();
			prevalue = (HashMap<String, Object>) resourceInfoHash.get(instanceId);
			
			log.debug("prevalue==>" + prevalue);
			
			for( String k : prevalue.keySet() ){
				temp2.put(k, prevalue.get(k));
				log.debug("temp2==>" + temp2);
			}
			
		}
		
		temp1.put(key, value);		
		temp2.put(taskId, temp1);
		
		resourceInfoHash.put(instanceId, temp2);
	}
	*/
}



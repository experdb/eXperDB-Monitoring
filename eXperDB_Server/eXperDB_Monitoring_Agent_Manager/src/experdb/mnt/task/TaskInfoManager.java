package experdb.mnt.task;

import java.util.ArrayList;
import java.util.HashMap;
import java.util.Hashtable;
import java.util.Enumeration;
import java.util.LinkedList;
import java.util.Map;
import java.util.StringTokenizer;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;

import org.apache.logging.log4j.Logger;
import org.apache.logging.log4j.LogManager;

import experdb.mnt.eXperDBMAConfig;

public class TaskInfoManager {
	private static Logger log = LogManager.getLogger(TaskInfoManager.class);	
	
	private static TaskInfoManager	thisObj = null;
	private static Hashtable taskInfoHash = null;
	
	public static synchronized void initInstance() throws Exception {
		if (thisObj != null) {
			log.info("TaskInfoManager가 이미 초기화되었습니다.");
			return;
		}

		log.info("************************************************************");
		log.info("TaskInfoManager를 초기화합니다.");		
		
		thisObj = new TaskInfoManager();
		thisObj.loadInfo();
		
		log.info("TaskInfoManager를 초기화하였습니다.");
		log.info("************************************************************");
	}

	public static synchronized TaskInfoManager getInstance() {
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
	
	private void loadInfo() throws Exception {
		String configFilename = System.getProperty("eXperDBMA_HOME") + 
								System.getProperty("CONFIG_DIR") + "/" + 
								eXperDBMAConfig.getInstance().getProperty("Task.infofile");
		BufferedReader	in = null;
		
		try {
			File	f = new File(configFilename);

			in		= new BufferedReader(new FileReader(f));

	   		String	temp = null;
	   		int		readPoint = 0;
	   		
	   		String		bKey = "";
	   		Hashtable	bHash = new Hashtable();
	   		Hashtable	sHash = null;
	   		
	   		while ((temp = in.readLine()) != null) {
				readPoint	= 0;
				
	   			if(!temp.startsWith("#")) {
	   				if(temp.startsWith("[")) {
	   					if(sHash != null) { 
	   						bHash.put(bKey, sHash);
	   					}
	   					
	   					bKey	= temp.substring(1, temp.length() - 1);
	   					sHash	= new Hashtable();
	   				} else if (temp.indexOf('=') != -1) {
	   					String	key = "";
	   					String	value = "";
	   					
						readPoint	= temp.indexOf('=');
						
						key		= temp.substring(0, readPoint).trim();
						value	= temp.substring(readPoint + 1).trim();
						
						if (value.indexOf(",") > 0) {
							ArrayList list = new ArrayList();
							StringTokenizer st = new StringTokenizer(value, ",");
							
							while (st.hasMoreTokens()) {
								String	val = st.nextToken().trim();
								
								list.add(val);
							}
							
							sHash.put(key, list);							
						} else{
							sHash.put(key, value);							
						}
	  	 			}
	   			}
	   		}
	   		
	   		try {
	   			bHash.put(bKey, sHash);
	   		} catch (NullPointerException ne) {
	   			log.info("등록된 Task가 없습니다.");
	   		}
	   		
			taskInfoHash	= bHash;
		} catch(Exception e) {
			log.error("Task 정보를 읽는중 오류가 발생하였습니다.",e);
			
			throw new Exception(e);
		} finally {
			try { in.close(); } catch(IOException e) {}
		}
	}
	
	public static Enumeration getTaskId() {
		return taskInfoHash.keys();
	}	
	
	public static Hashtable getTaskMap(String taskId) {
		return (Hashtable) taskInfoHash.get(taskId);
	}
	
	public static String getAtt(String taskId, String key) {
		Map<String, Object> temp = new HashMap<String, Object>();
		temp = (Map<String, Object>) taskInfoHash.get(taskId);
		
		String keyValue = "";
		
		if(temp.containsKey(key))		keyValue=(String) temp.get(key);
		
		return keyValue;
	}
}

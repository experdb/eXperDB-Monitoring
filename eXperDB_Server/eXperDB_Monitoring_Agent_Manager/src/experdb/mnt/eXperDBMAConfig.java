package experdb.mnt;

import java.io.IOException;
import java.io.ObjectInput;
import java.io.ObjectOutput;
import java.io.Serializable;
import java.io.Externalizable;
import java.io.File;
import java.io.BufferedReader;
import java.io.FileReader;
import java.util.Map;
import java.util.Vector;
import java.util.HashMap;
import java.util.StringTokenizer;
import java.util.LinkedList;
import java.util.List;

import org.apache.log4j.Logger;

public class eXperDBMAConfig implements Serializable {
	private static Logger log = Logger.getLogger(eXperDBMAConfig.class);
	
	private Map listProperties;
	private Map mapProperties;
	private Map stringProperties;

	private Vector changeListeners = null;
	
	private static eXperDBMAConfig	thisObj = null;
	
	public static synchronized void initInstance() throws Exception {
		if (thisObj != null) {
			log.info("eXperDBMAConfig가 이미 초기화되었습니다.");
			return;
		}
		
		log.info("************************************************************");
		log.info("eXperDBMAConfig을 초기화합니다.");
		
		String		configFileName = System.getProperty("eXperDBMA.config");

		if (configFileName == null) {
			log.info("설정파일이 지정되지 않았습니다. -DeXperDBMA.config에 설정파일을 지정해주십시오.");
			throw new Exception("설정파일이 지정되지 않았습니다. -DeXperDBMA.config에 설정파일을 지정해주십시오.");
		}
		
		thisObj		= new eXperDBMAConfig();
		
		thisObj.readFromConfigFile(geteXperDBMAHome() + getConfigDir() + "/" + configFileName);
		
		log.info("eXperDBMAConfig을 초기화하였습니다.");
		log.info("************************************************************");
	}
	
	public static synchronized void FreeInstance() {
		if (thisObj != null)
			return;
	}
	
	public static synchronized eXperDBMAConfig getInstance() throws Exception {
		if (thisObj == null) {
			log.info("eXperDBMAConfig가 초기화되지 않았습니다.");
			throw new Exception("eXperDBMAConfig가 초기화되지 않았습니다.");
		}
		
		return thisObj;
	}
	
	private void readFromConfigFile(String fileName) throws Exception {
		File	file = new File(fileName);
		
		log.info("설정파일[" + fileName + "]을 읽고 있습니다.");
		
		try {
			Vector	lines = readLines(file, "#");	// #은 주석, \은 다음 Line이 있음을 의미
			
			parseConfigFile(lines);
		} catch(Exception e) {
			log.info("설정파일을 읽는 도중 에러가 발생하였습니다.");
			throw new Exception(e);
		}
	}
	
	protected Vector readLines(File file, String trim_str) throws IOException {
		Vector			ret_val = null;
		BufferedReader	in = null;
		
		try {
			in		= new BufferedReader(new FileReader(file));
	   		ret_val	= new Vector();
	   		
	   		String	temp = null;
	   		boolean addNextLine = false;
	   		
	   		while ((temp = in.readLine()) != null) {
	   			temp	= temp.trim();
	   			
	   			if ((temp.length() <= 0) || temp.startsWith(trim_str))
	   				continue;
	   			
	   			if (addNextLine) {
	   				String		before = (String)ret_val.lastElement();
	   				
	   				if (temp.startsWith("\\")) before += temp.substring(1);
	   				else before += temp;
	   				
	   				ret_val.setElementAt(before, ret_val.size() - 1);
	   				
	   				addNextLine		= false;
	   			} else if (temp.startsWith("\\")) {
	   				String		before = (String)ret_val.lastElement();
	   				
	   				before	+= temp.substring(1);
	   				
	   				ret_val.setElementAt(before, ret_val.size() - 1);
	   			} else if (temp.endsWith("\\")) {
	   				addNextLine		= true;
	   				
	   				ret_val.addElement(temp.substring(0, temp.length() - 1));
	   			} else {
	   				ret_val.addElement(temp.trim());
	   			}
	   		}
	   		
	   		in.close();
	   	} catch(IOException e) {
			
			if (in != null) try { in.close(); } catch(Exception e1) {}
			
			throw e;
		}
		
		return ret_val;
	}
	
	protected void parseConfigFile(Vector lines) throws Exception {
		this.listProperties   = new HashMap();
		this.mapProperties    = new HashMap();
		this.stringProperties = new HashMap();
		
		try {
			for (int i = 0; i < lines.size(); i++) {
				String	line = (String)lines.elementAt(i);
				
				int		deliIndex = line.indexOf("=");
				
				String	key = line.substring(0, deliIndex);
				String	value = line.substring(deliIndex + 1);
				
				// Step 1. Map인 경우의 처리
				if ((value.indexOf("{") >= 0) && (value.indexOf("}") > 2)) {	// 이때는 {}가 있는 것임.
					Map				element = new HashMap();
					StringTokenizer st = new StringTokenizer(value, ",", false);
					
					while (st.hasMoreTokens()) {
						String 	elementKey = st.nextToken().trim();
						
						elementKey	= elementKey.substring(1);
						
						String	elementVal = st.nextToken(",").trim();
						
						elementVal	= elementVal.substring(0, elementVal.length() - 1).trim();
						
						element.put(elementKey, elementVal);
					}
					
					this.mapProperties.put(key, element);
					
					java.util.Iterator	iter = element.keySet().iterator();
					
					while (iter.hasNext()) {
						String	t1 = (String)iter.next();
						String	t2 = (String)element.get(t1);
					}
					
					continue;
				} else if (value.trim().startsWith("\"")) {
					String	temp = value.substring(value.indexOf("\"") + 1, value.lastIndexOf("\"")).trim();
					
					this.stringProperties.put(key, temp);
				// Step 2. List인 경우의 처리
				} else if (value.indexOf(",") > 0) {	// 이때는 ,가 있는 것임.
					LinkedList		list = new LinkedList();
					StringTokenizer st = new StringTokenizer(value, ",");
					
					while (st.hasMoreTokens()) {
						String	val = st.nextToken().trim();
						
						list.add(val);
					}
					
					this.listProperties.put(key, list);
					
					continue;
				// Step 3. 일반 String인 경우의 처리
				} else {
					this.stringProperties.put(key, value.trim());
					continue;
				}
			}
		} catch(Exception e) {
			log.info("설정파일을 분석할 수 없습니다.");
			throw new Exception(e);
		}
	}
	
	/*
	public static String getLogHome() {
		return geteXperDBMAHome() + File.separator + "logs";
	}
	*/
	
	public static String geteXperDBMAHome() {
		return System.getProperty("eXperDBMA_HOME");
	}
	
	public static String getConfigDir() {
		return System.getProperty("CONFIG_DIR");
	}
	
	/*
	private String containerId = null;
	
	public String getContainerId() {
		if (containerId == null) {
			containerId		= getString("webcash.itms.system.id");
		}
		return containerId;
	}
	*/
	
	/*
	public void reload() {
		for (int i = 0; (changeListeners != null) && (i < changeListeners.size()); i++) {
			(changeListeners.elementAt(i)).acceptSystemConfigChangeEvent();
		}
	}
	
	public synchronized void addChangeListener(SystemConfigChangeListener changeListener) {
		if (this.changeListeners == null) {
			this.changeListeners = new Vector();
		}
		
		this.changeListeners.addElement(changeListener);
	}	
	*/
	
	public List getList(String propertyName) {
		if (listProperties == null) return null;
		
		return (List)listProperties.get(propertyName);
	}
	
	public Map getMap(String propertyName) {
		if (mapProperties == null) return null;
		
		return (Map)mapProperties.get(propertyName);
	}
	
	public boolean getBoolean(String propertyName) throws Exception {
		String	temp = getString(propertyName);
		
		if (temp == null)
			throw new Exception("A Property[" + propertyName + "] was not found, because string properties is null.");
		
		if (temp.trim().equals("true"))
			return true;
		else if (temp.trim().equals("false"))
			return false;
		else
			throw new Exception("A value of Boolean Property[" + propertyName + "] is [" + temp + "].");
	}
	
	public long getLong(String propertyName) throws Exception {
		String	temp = getString(propertyName);
		
		if (temp == null)
			throw new Exception("A Property[" + propertyName + "] was not found, because string properties is null.");
		
		long	retVal = 0L;
		
		try {
			retVal = Long.parseLong(temp.trim());
		} catch(Exception e) {
			throw new Exception("A value of Integer Property[" + propertyName + "] is [" + temp + "].");
		}
		
		return retVal;
	}
	
	public int getInt(String propertyName) throws Exception {
		String	temp = getString(propertyName);
		
		if (temp == null)
			throw new Exception("A Property[" + propertyName + "] was not found, because string properties is null.");
		
		int retVal = -1;
		
		try {
			retVal = Integer.parseInt(temp.trim());
		} catch(Exception e) {
			throw new Exception("A value of Integer Property[" + propertyName + "] is [" + temp + "].");
		}
		
		return retVal;
	}
	
	public String getProperty(String propertyName) {
		return getString(propertyName);
	}
	
	public String getString(String propertyName) {
		if (stringProperties == null) return null;
		
		return (String)stringProperties.get(propertyName);
	}
}

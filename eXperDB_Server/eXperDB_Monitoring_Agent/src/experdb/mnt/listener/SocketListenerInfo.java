package experdb.mnt.listener;

import java.util.Hashtable;
import java.util.Vector;
import java.util.StringTokenizer;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;

import org.apache.logging.log4j.Logger;
import org.apache.logging.log4j.LogManager;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.eXperDBMAConfig;

public class SocketListenerInfo {
	private static Logger log = LogManager.getLogger(SocketListenerInfo.class);	
	
	private static final String	_SOCKETLISTENER_CONFIG = "SocketListenerInfo.config";
	
	private static final String	_LISTENPORT = "listenPort";
	private static final String _TIMEOUT = "timeout";
	private static final String _BACKLOG = "backlog";
	
	private static final String _ACCEPTMODE = "acceptMode";
	private static final String	_OPPOSITEIPS = "oppositeIPs";
	
	private static SocketListenerInfo	_thisObj = null;
	
	private static Hashtable		_listenerInfoHash = null;
	
	private Hashtable		_listenerInfo = null;
	private String			_listenerName = "";
		
	public static final int		_DEFAULT_LISTENPORT = -1;
	public static final int		_DEFAULT_TIMEOUT = -1;
	public static final int		_DEFAULT_BACKLOG = -1;
	
	public static synchronized void initInstance() throws Exception {
		if (_thisObj == null) {
			log.info("**************************************************");
			log.info("SocketListenerInfo를 초기화합니다.");
			
			_thisObj		= new SocketListenerInfo();
			
			_thisObj.loadInfo();
			
			log.info("SocketListenerInfo가 초기화되었습니다.");
			log.info("**************************************************");
		}
	}

	public static synchronized SocketListenerInfo getInstance(String listenerName) throws Exception {
		getInstance().setListenerName(listenerName);
		
		return _thisObj;
	}
	
	private static synchronized SocketListenerInfo getInstance() throws Exception {
		if (_thisObj == null) {
			initInstance();
		}
		
		return _thisObj;
	}	
	
	private void setListenerName(String listenerName) throws Exception {
		_listenerInfo	= (Hashtable)_listenerInfoHash.get(listenerName);
		
		if(_listenerInfo == null) {
			throw new Exception(" 요청된 SocketListener를 찾을 수 없습니다. [" + listenerName + "]");
		}
		
		_listenerName	= listenerName;
	}
	
	public String getListenerName() {
		return _listenerName;
	}	
	
	private void loadInfo() throws Exception {
		String configFilename = System.getProperty("eXperDBMA_HOME") + 
				System.getProperty("CONFIG_DIR") + "/" + 
				eXperDBMAConfig.getInstance().getProperty("Socket.infofile");
		
		BufferedReader	in = null;
		
		log.info("소켓리스너 정보를 읽어오고 있습니다. [" + configFilename + "]");
		
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
	   						
	   						log.debug("----------------------------------------");
	   					}
	   					
	   					bKey	= temp.substring(1, temp.length() - 1);
	   					sHash	= new Hashtable();
	   					
	   					log.debug("----------------------------------------");
	   					log.debug("SocketListenerName : " + bKey);
	   				} else if (temp.indexOf('=') != -1) {
	   					String	key = "";
	   					String	value = "";
	   					
						readPoint	= temp.indexOf('=');
						
						key		= temp.substring(0, readPoint).trim();
						value	= temp.substring(readPoint + 1).trim();
						
						if (key.compareTo(_OPPOSITEIPS) == 0) {
							Vector				t = new Vector();
							StringTokenizer		st = new StringTokenizer(value, "|");
							
							while (st.hasMoreTokens()) {
								t.addElement(st.nextToken());
							}
							
							sHash.put(key, t);
						} else
							sHash.put(key, value);
						
						log.debug(key + " : " + value);
	  	 			}
	   			}
	   		}
	   		
	   		bHash.put(bKey, sHash);
	   		
	   		log.debug("----------------------------------------");
	   		
			_listenerInfoHash	= bHash;
		} catch(Exception e) {
			log.error("소켓리스너 정보를 읽어오는 중 오류가 발생하였습니다. [" + e + "]");
			
			throw new Exception(e);
		} finally {
			try { in.close(); } catch(IOException e) {}
		}
	}

	public int getListenPort() {
		int		listenPort = -1;
		
		try {
			listenPort	= Integer.parseInt((String)_listenerInfo.get(SocketListenerInfo._LISTENPORT));
		} catch (Exception e) {
			listenPort	= SocketListenerInfo._DEFAULT_LISTENPORT;
		}
		
		return listenPort;		
	}

	public int getTimeout() {
		int		timeout = -1;
		
		try {
			timeout		= Integer.parseInt((String)_listenerInfo.get(SocketListenerInfo._TIMEOUT));
		} catch (Exception e) {
			timeout		= SocketListenerInfo._DEFAULT_TIMEOUT;
		}
		
		return timeout;
	}
	
	public int getBacklog() {
		int		backlog = -1;

		try {
			backlog		= Integer.parseInt((String)_listenerInfo.get(SocketListenerInfo._BACKLOG));
		} catch (Exception e) {
			backlog		= SocketListenerInfo._DEFAULT_BACKLOG;
		}
		
		return backlog;
	}
	
	public boolean getAcceptMode() {
		boolean	acceptMode = true;
		
		try {
			if (((String)_listenerInfo.get(SocketListenerInfo._ACCEPTMODE)).compareTo("negative") == 0)
				acceptMode	= false;
		} catch (Exception e) {
		}
		
		return acceptMode;
	}
	
	public Vector getOppositeIPs() {
		Vector		v = null;
		
		try {
			v	= (Vector)_listenerInfo.get(SocketListenerInfo._OPPOSITEIPS);
		} catch (Exception e) {
		}
		
		if (v == null)
			v	= new Vector();
		
		return v;
	}
}

package experdb.mnt.listener;

import java.net.ServerSocket;
import java.net.Socket;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Hashtable;
import java.util.Vector;
import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.io.InterruptedIOException;

import org.apache.log4j.Logger;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.util.Queue;

public class SocketListener implements Runnable {
	private static Logger log = Logger.getLogger(SocketListener.class);

	private String			listenerName = "";
	private int				listenPort = -1;
	private int				timeout = -1;
	private int				backlog = -1;
	private boolean			acceptMode = true;
	private	Vector			oppositeIPs = new Vector();
	
	private Queue			clientSocketQueue = null;
	private ServerSocket	serverSocket = null;	
	private boolean 		toBeShutdown = false;

	public SocketListener(String listenerName, Queue clientSocketQueue) throws Exception {
		super();
		
		this.listenerName		= listenerName;
		this.listenPort			= SocketListenerInfo.getInstance(listenerName).getListenPort();
		this.timeout			= SocketListenerInfo.getInstance(listenerName).getTimeout();
		this.backlog			= SocketListenerInfo.getInstance(listenerName).getBacklog();
		this.acceptMode			= SocketListenerInfo.getInstance(listenerName).getAcceptMode();
		this.oppositeIPs		= SocketListenerInfo.getInstance(listenerName).getOppositeIPs();
		
		this.clientSocketQueue	= clientSocketQueue;
	}
	
	private void createServerSocket() throws Exception {
		try {
			this.serverSocket	= new ServerSocket(listenPort, backlog);
			this.serverSocket.setSoTimeout(1000);
		} catch(Exception e) {
			log.error("서버소켓을 생성하지 못했습니다. [" + e + "]");
			
			throw new Exception("서버소켓을 생성하지 못했습니다. [" + e + "]");
		}
	}
	
	public void startup() throws Exception {
		log.info("");
		log.info("**************************************************");
		log.info("SocketListener[" + listenerName + "]를 기동합니다.");
		log.info("ListenerPort : [" + listenPort + "]");
		log.info("Timeout : [" + timeout + "]");
		log.info("Backlog : [" + backlog + "]");
		
		createServerSocket();
		
		Thread		mainThread = new Thread(this);
		
		mainThread.start();
		
		log.info("SocketListener[" + listenerName + "]가 거래수신을 대기하고 있습니다.");
		log.info("**************************************************");
		log.info("");
	}
	
	public void shutdown() throws Exception {
		log.info("");
		
		this.toBeShutdown = true;
		
		try {
			this.serverSocket.close();
		} catch(Exception e) {
			e.printStackTrace();
			throw new Exception("A listener could not be shutdown. Exception [" + e + "]");
		}
		
		log.info("SocketListener가 종료되었습니다.");		
	}	
	
	public void run() {
		while ( !toBeShutdown ) {
			try {
				Socket	client = null;
				
				try {
					client = serverSocket.accept();

					// 접속 가능한 아이피인지 체크
					// 우선 _SYSTEM 일때만 체크한다.
					boolean		accept = true;
					String		clientIP = client.getInetAddress().getHostAddress();
					
					if (acceptMode) {
						accept	= true;
						
						for (int i = 0; i < oppositeIPs.size(); i++) {
							String		oppositeIP = (String)oppositeIPs.get(i);
							
							if (oppositeIP.compareTo(clientIP) == 0) {
								accept	= false;
								break;
							}
						}
					} else {
						accept	= false;
						
						for (int i = 0; i < oppositeIPs.size(); i++) {
							String		oppositeIP = (String)oppositeIPs.get(i);
							
							if (oppositeIP.compareTo(clientIP) == 0) {
								accept	= true;
								break;
							}
						}
					}
					
					if (!accept) {
						log.info("접속이 허용되지 않은 IP에서의 접속시도입니다. [" + clientIP + "]");
						
						client.close();
						
						continue;
					}
					// 접속 가능한 아이피인지 체크					
				} catch (InterruptedIOException iioe) {
					continue;
				}
				
				if ( toBeShutdown ) break;
				
				if (client != null)
					clientSocketQueue.put(client);
			} catch(Exception e) {
				log.error("Fail to processing client request. Exception [" + e + "]");
				log.error("", e);
			}
		}
	
		log.info("Please wait for Shutdown a listener...");
	
		log.info("Closing ServerSocket.");
	}
}

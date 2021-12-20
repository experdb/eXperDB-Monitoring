package experdb.mnt.listener;

import java.net.Socket;
import java.text.SimpleDateFormat;
import java.util.Date;

import org.apache.logging.log4j.Logger;
import org.apache.logging.log4j.LogManager;

import experdb.mnt.task.TaskInfoManager;
import experdb.mnt.util.Queue;

public class TaskManagerForeXperDBMAManager implements Runnable {
	private static Logger log = LogManager.getLogger(TaskManagerForeXperDBMAManager.class);
	
	private Queue		clientSocketQueue = null;
	private boolean 	toBeShutdown = false;		
	
	public TaskManagerForeXperDBMAManager(Queue clientSocketQueue) throws Exception {
		super();
		
		this.clientSocketQueue	= clientSocketQueue;
	}
		
	public void startup() throws Exception {
		log.info("Task Manager For eXperDBMAMANAGER  START..............");
		
		// 메인 쓰레드 생성 및 실행
		Thread		mainThread = new Thread(this);
		
		mainThread.start();		
	}
	
	public void shutdown() throws Exception {
		System.out.println("TaskManagerForeXperDBMAMANAGER::shutdown() TaskManager Shutdown이 요청되었습니다.");
		
		this.toBeShutdown = true;		
	}	
	
	public void run() {
		while ( !toBeShutdown ) {
			try {
				Socket	s = (Socket)clientSocketQueue.pull();
				
				if (s == null)
					continue;
				
				SocketExecutorForeXperDBMAManager		executor = new SocketExecutorForeXperDBMAManager(s);
				
				(new Thread(executor)).start();
				
				if ( toBeShutdown ) break;
			} catch(Exception e) {
				log.error("Fail to processing client request. Exception [" + e + "]");
				log.error("",e);
			}
		}
	
		log.info("Please wait for Shutdown a listener...");
	
		log.info("Closing ServerSocket.");
	}
}

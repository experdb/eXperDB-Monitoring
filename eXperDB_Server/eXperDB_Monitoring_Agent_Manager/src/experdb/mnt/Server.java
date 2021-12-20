package experdb.mnt;

import java.io.File;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.HashMap;
import java.util.Map;

import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.logging.log4j.Logger;
import org.apache.logging.log4j.LogManager;
import org.apache.logging.log4j.core.LoggerContext;

import experdb.mnt.db.dbcp.DBCPPoolManager;
import experdb.mnt.db.mybatis.SqlSessionManager;
import experdb.mnt.listener.SocketListener;
import experdb.mnt.listener.SocketListenerInfo;
import experdb.mnt.listener.TaskManagerForeXperDBMAManager;
import experdb.mnt.task.TaskInfoManager;
import experdb.mnt.task.TaskManager;
import experdb.mnt.util.Queue;

public class Server {
	private static Logger log = LogManager.getLogger(Server.class);
	
	public static void main(String[] args) {

		//LOG4J 설정 파일 지정
		//PropertyConfigurator.configure(System.getProperty("eXperDBMA_HOME") + System.getProperty("CONFIG_DIR") + "/" + "log4j.properties");
		
		LoggerContext context = (LoggerContext) LogManager.getContext(false);
		File log4jXmlFile = new File(System.getProperty("eXperDBMA_HOME") + System.getProperty("CONFIG_DIR") + "/" + "log4j.properties");
		context.setConfigLocation(log4jXmlFile.toURI());
		
		
		// 환경설정파일 로드
		try {
			eXperDBMAConfig.initInstance();
		} catch (Exception e) {
			log.error("", e);
			return;
		}
		
		// SqlSessionManager 초기화
		try {
			SqlSessionManager.initInstance();
		} catch (Exception e) {
			log.error("", e);
			return;
		}		
		
		//Driver 로딩 
		try {
			Class.forName("org.apache.commons.dbcp.PoolingDriver");
		} catch (Exception e) {
			log.error("", e);
			return;			
		}
		

		//MonitoringInfoManager 초기화
//		try {
//			MonitoringInfoManager.initInstance();
//		} catch (Exception e) {
//			log.error("", e);
//			return;
//		}		

		//TaskInfoManager 초기화
		try {
			TaskInfoManager.initInstance();
		} catch (Exception e) {
			log.error("", e);
			return;
		}		
		
		
		//Socket 초기화 및 기동
		try {
			Queue	eXperDBMAManagerSocketQueue = new Queue("eXperDBMAManagerSocketQueue");
			
			SocketListenerInfo.initInstance();
			
			SocketListener			eXperDBMAManagerListener = new SocketListener("eXperDBMAMANAGER", eXperDBMAManagerSocketQueue);
			TaskManagerForeXperDBMAManager		eXperDBMATaskManager = new TaskManagerForeXperDBMAManager(eXperDBMAManagerSocketQueue);
			
			eXperDBMAManagerListener.startup();
			eXperDBMATaskManager.startup();
		} catch (Exception e) {
			log.error("", e);
			return;
		}		
		
		
		
		//모니터링 기동
		new TaskManager().startUp();		
		
	}

}
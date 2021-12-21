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
import org.apache.logging.log4j.core.LoggerContext;
import org.apache.logging.log4j.LogManager;

import experdb.mnt.db.dbcp.DBCPPoolManager;
import experdb.mnt.db.mybatis.SqlSessionManager;
import experdb.mnt.listener.SocketListener;
import experdb.mnt.listener.SocketListenerInfo;
import experdb.mnt.listener.TaskManagerForeXperDBMA;
import experdb.mnt.task.TaskInfoManager;
import experdb.mnt.task.TaskManager;
import experdb.mnt.util.Queue;

public class Server {
	private static Logger log = LogManager.getLogger(Server.class);
	
	public static void main(String[] args) {

		//LOG4J 설정 파일 지정
		//PropertyConfigurator.configure(System.getProperty("eXperDBMA_HOME") + System.getProperty("CONFIG_DIR") + "/" + "log4j.properties");			
		/**
		PropertyConfigurator.configure("C:\\Users\\Chobits\\Dropbox\\DxWork\\DX_Monitoring_Agent\\config\\" + "log4j.properties");		
		System.setProperty("CONFIG_DIR", "config");
		System.setProperty("eXperDBMA_HOME", "C:\\Users\\Chobits\\Dropbox\\DxWork\\DX_Monitoring_Agent\\");
		System.setProperty("eXperDBMA.config", "eXperDBMA.config");
		**/
		
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
		try {
			MonitoringInfoManager.initInstance();
		} catch (Exception e) {
			log.error("", e);
			return;
		}		

		//TaskInfoManager 초기화
		try {
			TaskInfoManager.initInstance();
		} catch (Exception e) {
			log.error("", e);
			return;
		}		

		// LicenseInfoManager
		try {
			LicenseInfoManager.licenseVerification();
		} catch (Exception e) {
			log.error("", e);
			return;
		}		
		
		//Socket 초기화 및 기동
		try {
			Queue	eXperDBMASocketQueue = new Queue("eXperDBMASocketQueue");
			
			SocketListenerInfo.initInstance();
			
			SocketListener			eXperDBMAListener = new SocketListener("eXperDBMA", eXperDBMASocketQueue);
			TaskManagerForeXperDBMA		eXperDBMATaskManager = new TaskManagerForeXperDBMA(eXperDBMASocketQueue);
			
			eXperDBMAListener.startup();
			eXperDBMATaskManager.startup();
		} catch (Exception e) {
			log.error("", e);
			return;
		}		
		
		
		
		//모니터링 기동
		new TaskManager().startUp();		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
//		try {
//			SqlSessionFactory sqlSessionFactory = SqlSessionManager.getInstance();
//			SqlSession session = sqlSessionFactory.openSession();
//			
//			try {
//				
//				Map<String, Object> parameters = new HashMap<String, Object>();
//				parameters.put("instance_id", 311);			
//				
//				session.selectList("app.getOne", parameters);
//
//			} catch (Exception e){
//				e.printStackTrace();
//			} finally {
//				session.close();
//			}
//		} catch (Exception e) {
//			// TODO Auto-generated catch block
//			e.printStackTrace();
//		}		
		
		
		
		
		
		
		
		
		
//		// 수집서버 DB connection Pool 생성
//		try {
//			eXperDBMAConfig dc = eXperDBMAConfig.getInstance();
//			DBCPPoolManager.setupDriver(
//					dc.getProperty("DB.driver"), 
//					dc.getProperty("DB.url"), 
//					dc.getProperty("DB.user"), 
//					dc.getProperty("DB.password"), 
//					dc.getProperty("DB.poolName"), 
//					dc.getInt("DB.maxActive"));
//		} catch (Exception e) {
//			log.error("", e);
//			return;
//		}		
//		
//		Connection connection = null;
//		
//		try {
//			connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:SYSTEM");
//		} catch (SQLException e1) {
//			// TODO Auto-generated catch block
//			e1.printStackTrace();
//		}
//		
//		
//		SqlSessionFactory sqlMapper = SqlSessionManager.getInstance();
//		
//		SqlSession session = sqlMapper.openSession(connection);
//		try {
//			
//			Map<String, Object> parameters = new HashMap<String, Object>();
//			parameters.put("instance_id", 311);			
//			
//			session.selectList("Test.getOne", parameters);
//
//		} catch (Exception e){
//			e.printStackTrace();
//		} finally {
//			session.close();
//		}		
		
		
		
		
		
		
//		// 수집서버 DB connection Pool 생성
//		try {
//			eXperDBMAConfig dc = eXperDBMAConfig.getInstance();
//			DBCPPoolManager.setupDriver(
//					dc.getProperty("DB.driver"), 
//					dc.getProperty("DB.url"), 
//					dc.getProperty("DB.user"), 
//					dc.getProperty("DB.password"), 
//					dc.getProperty("DB.poolName"), 
//					dc.getInt("DB.maxActive"));
//		} catch (Exception e) {
//			log.error("", e);
//			return;
//		}
//		
//		
//		//수집TASK를 기동한다.
//		new TaskManager().startUp();
		
		
		
		
		
		
		
		
		
		
		
		
//		try {
//			DBCPPoolManager.printDriverStats("SYSTEM");
//			DBCPPoolManager.shutdownDriver("SYSTEM");
//			DBCPPoolManager.printDriverStats("SYSTEM");
//		} catch (Exception e) {
//			// TODO Auto-generated catch block
//			e.printStackTrace();
//		}
		
		
		
		
		
		
		
		
		
		
		
		
//		System.out.println(eXperDBMAConfig.getInstance().getProperty("aa"));
		
		
		
		//new TaskManager().startUp();
		
//		log.debug("END.......................................");
		
		
//		System.out.println("99999999999999");
	}

}
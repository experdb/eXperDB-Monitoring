package experdb.mnt.task;

import java.lang.Thread.UncaughtExceptionHandler;
import java.sql.DriverManager;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.Enumeration;
import java.util.GregorianCalendar;
import java.util.HashMap;
import java.util.Map;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;

import org.apache.commons.dbcp.PoolingDriver;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.log4j.Logger;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.ResourceInfo;
import experdb.mnt.Server;
import experdb.mnt.eXperDBMAConfig;
import experdb.mnt.db.mybatis.SqlSessionManager;


public class TaskManager{
	private static Logger log = Logger.getLogger(TaskManager.class);
	
	public void startUp() {
		log.info("************************************************************");
		log.info("수집 TASK를 기동합니다.");
		log.info("************************************************************");
		
		String currentThreadName = Thread.currentThread().getName();
		
		Thread mainThread = new Thread(new ExceptionLeakingTask(), "TaskManager");
		mainThread.setUncaughtExceptionHandler(new ThreadExceptionHandler("TaskManager"));
		mainThread.start();
	}
}

class ExceptionLeakingTask implements Runnable {

	private static Logger log = Logger.getLogger(TaskManager.class);
	@Override
	public void run() {
		try {
			
			while(true)
			{
				ExecutorService executorService = Executors.newCachedThreadPool();
				
				log.info("모니터링 START!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");

				boolean isstandAloneStart = false;
				
				//모니터링서버 정보를 가져와 모니터링한다.
				Enumeration		e = MonitoringInfoManager.getInstance().getInstanceId();
				while (e.hasMoreElements()) {
					executorService.execute(new TaskExecutor((String) e.nextElement(), false));

					isstandAloneStart = true;
					
					Thread.sleep(1* 1000);
				}
				
				//Update Driver of instances status
				updateDriverStatus();
				
				//전체 작업 Task를 가져온다
				if(isstandAloneStart)
				{
					Enumeration		taskE = TaskInfoManager.getInstance().getTaskId();
					while (taskE.hasMoreElements()) {
						String taskId = (String) taskE.nextElement();
						String standAlone = TaskInfoManager.getInstance().getAtt(taskId, "standAlone"); 
						
						if(standAlone.equals("true"))
						{
							executorService.execute(new TaskExecutor(taskId, true));
						
							Thread.sleep(1* 1000);
						}
					}
				}

				boolean isStart = true;
				//Instance 정보 변경 여부를 확인한다.
				while(true) {
					Thread.sleep(5* 1000);
					
					MonitoringInfoManager.getInstance().changeInfo();

					//Hourly batch------------- Start
					SimpleDateFormat transFormat = new SimpleDateFormat("mm:ss");
					Date now = new Date();
					String strCurrentTime = transFormat.format(now);
					Date batchStartHourlyTime = transFormat.parse(MonitoringInfoManager.getInstance().getConfig("daily_batch_start_time").toString().substring(3));
					Date batchEndHourlyTime = new Date(batchStartHourlyTime.getTime() + 1000 * 10);
					String strBatchTimeStart = transFormat.format(batchStartHourlyTime);
					String strBatchTimeEnd = transFormat.format(batchEndHourlyTime);

					if (isStart == true){
						log.info("Start batch hourly (init)");
						Class.forName("experdb.mnt.task."+ "HourlyBatchTask").getConstructor().newInstance();
						isStart = false;
					}
					
					if(strCurrentTime.compareTo(strBatchTimeStart) > 0 && strCurrentTime.compareTo(strBatchTimeEnd) < 0){
						log.info("Start batch hourly");
						Class.forName("experdb.mnt.task."+ "HourlyBatchTask").getConstructor().newInstance();
					}
					//Hourly batch------------- End

					if(MonitoringInfoManager.getInstance().getConfig("batch_start").equals("Y"))
					{
						Class.forName("experdb.mnt.task."+ "DailyBatchTask").getConstructor().newInstance();
					}
					

// 재기동을 전문으로 처리하여 주석처리					
//					if(MonitoringInfoManager.getInstance().isReLoad())
//					{
//						log.info("************************************************************");
//						log.info("현재 수집을 종료하고 재기동한다.");
//						log.info("************************************************************");
//						
//						//서버정보가 변경된 경우 쓰레드를 종료하고 재기동한다
//						
//						// 쓰레드 종료
//						executorService.shutdown();
//						executorService.awaitTermination(Long.MAX_VALUE, TimeUnit.SECONDS);
//						
//						// DB 컨넥션풀을 종료한다.
//						PoolingDriver driver = (PoolingDriver) DriverManager.getDriver("jdbc:apache:commons:dbcp:");
//						String[] poolNames = driver.getPoolNames();
//						
//						for (int i = 0; i < poolNames.length; i++){
//							driver.closePool(poolNames[i]);
//						}
//						
//						//ResourceInfo를 초기화 한다.
//						ResourceInfo.getInstance().reSet();
//						
//						//모니터링 정보를 다시 불러온다.
//						MonitoringInfoManager.getInstance().loadInfo();
//						
//						MonitoringInfoManager.getInstance().setReLoad(false);
//						
//						if(MonitoringInfoManager.getInstance().getConfig("batch_start").equals("Y"))
//						{
//							Class.forName("experdb.mnt.task."+ "DailyBatchTask").getConstructor().newInstance();
//						}
//						
//						break;
//					}
					
					
				}

			}
			
		} catch (Exception e) {
			log.error("", e);
		}
		throw new RuntimeException();
	}
	public static void updateDriverStatus(){
		log.info("Update driver status");
		SqlSessionFactory sqlSessionFactory = SqlSessionManager.getInstance();
		SqlSession sessionAgent = sqlSessionFactory.openSession();
		
		try {
			HashMap<String, Object> updateMap = new HashMap<String, Object>();
			updateMap.put("driver_status", "H");			
			sessionAgent.update("app.TB_SYS_LOG_U002", updateMap);			
			sessionAgent.commit();
		} catch (Exception e){
			sessionAgent.rollback();
			log.error("driver_status를 update하는중 오류가 발생하였습니다.");
			log.error(e);
		}
	}
}

class ThreadExceptionHandler implements UncaughtExceptionHandler{
	private String handlerName;
	private static Logger log = Logger.getLogger(TaskManager.class);
	
	public ThreadExceptionHandler(String handlerName) {
		this.handlerName = handlerName;
	}

	@Override
	public void uncaughtException(Thread thread, Throwable e) {
		log.error(handlerName + " caught Exception in Thread" + thread.getName(), e); 
	}

}

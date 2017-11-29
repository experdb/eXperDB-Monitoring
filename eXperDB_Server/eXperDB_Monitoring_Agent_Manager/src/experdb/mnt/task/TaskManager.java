package experdb.mnt.task;

import java.sql.DriverManager;
import java.util.Enumeration;
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


public class TaskManager implements Runnable{
	private static Logger log = Logger.getLogger(TaskManager.class);
	
	public void startUp() {
		log.info("************************************************************");
		log.info("수집 TASK를 기동합니다.");
		log.info("************************************************************");
		
		Thread mainThread = new Thread(this);
		mainThread.start();
	}
	
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
					
				//Instance 정보 변경 여부를 확인한다.
				while(true) {
					Thread.sleep(5* 1000);
					
					MonitoringInfoManager.getInstance().changeInfo();
					
					if(MonitoringInfoManager.getInstance().isReLoad())
					{
						log.info("************************************************************");
						log.info("현재 수집을 종료하고 재기동한다.");
						log.info("************************************************************");
						
						//서버정보가 변경된 경우 쓰레드를 종료하고 재기동한다
						
						// 쓰레드 종료
						executorService.shutdown();
						executorService.awaitTermination(Long.MAX_VALUE, TimeUnit.SECONDS);
						
						// DB 컨넥션풀을 종료한다.
						PoolingDriver driver = (PoolingDriver) DriverManager.getDriver("jdbc:apache:commons:dbcp:");
						String[] poolNames = driver.getPoolNames();
						
						for (int i = 0; i < poolNames.length; i++){
							driver.closePool(poolNames[i]);
						}
						
						//ResourceInfo를 초기화 한다.
						ResourceInfo.getInstance().reSet();
						
						//모니터링 정보를 다시 불러온다.
						MonitoringInfoManager.getInstance().loadInfo();
						
						MonitoringInfoManager.getInstance().setReLoad(false);
						
						if(MonitoringInfoManager.getInstance().getConfig("batch_start").equals("Y"))
						{
							Class.forName("experdb.mnt.task."+ "DailyBatchTask").getConstructor().newInstance();
						}
						
						break;
					}
				}

			}
			
		} catch (Exception e) {
			log.error("", e);
		}
		
	}

}

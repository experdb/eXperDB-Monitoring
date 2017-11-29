package experdb.mnt.task;

import java.lang.reflect.Constructor;
import java.util.Enumeration;
import java.util.HashMap;
import java.util.concurrent.ExecutorService;
import java.util.concurrent.Executors;
import java.util.concurrent.TimeUnit;

import org.apache.log4j.Logger;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.eXperDBMAConfig;
import experdb.mnt.db.dbcp.DBCPPoolManager;


public class TaskExecutor implements Runnable{
	private static Logger log = Logger.getLogger(TaskExecutor.class);	
	private String instanceId = "";
	private Boolean isStandAlone = false;
	private HashMap instanceMap = null;
	
	public TaskExecutor(String str, boolean is) {
		instanceId = str;
		isStandAlone = is;
	}
	
	@Override
	public void run() {
		log.debug("instanceId ===>>> " + instanceId);

		try {
			if(!isStandAlone)
			{
				//instanceId 정보를 가져온다
				instanceMap = MonitoringInfoManager.getInstanceMap(instanceId);
				
				//DBpool을 생성한다.
				DBCPPoolManager.setupDriver(
						"org.postgresql.Driver",
						"jdbc:postgresql://"+ instanceMap.get("server_ip") +":"+ instanceMap.get("service_port") +"/"+ instanceMap.get("conn_db_name"),
						(String)instanceMap.get("conn_user_id"),
						(String)instanceMap.get("conn_user_pwd"),
						instanceId,
						10
				);
			}
			
			//쓰레드폴을 생성한다.
			ExecutorService executorService = Executors.newFixedThreadPool(eXperDBMAConfig.getInstance().getInt("ThreadPool.maxActive"));
			
			boolean  isFirst = true;
			
			while (!MonitoringInfoManager.getInstance().isReLoad())
			{
				//전체 작업 Task를 가져온다
				Enumeration		e = TaskInfoManager.getInstance().getTaskId();
				
				while (e.hasMoreElements()) {
					String taskId = (String) e.nextElement();
					String className = TaskInfoManager.getInstance().getAtt(taskId, "className");
					String standAlone = TaskInfoManager.getInstance().getAtt(taskId, "standAlone");
					String onceTheFirst = TaskInfoManager.getInstance().getAtt(taskId, "onceTheFirst");
					
					if(isStandAlone)
					{
						//단독 기동일경우
						if(!taskId.equals(instanceId)) continue;	
					} else{
						if(standAlone.equals("true"))	continue;
					}
					
					//최초한번만 기동일경우
					if(onceTheFirst.equals("true"))
					{
						if(!isFirst) continue;
					}
					
					log.debug("TASK 기동 instanceId : ["+ instanceId +"], taskId : ["+ taskId +"]");
					
					Constructor cons = Class.forName("experdb.mnt.task."+ className).getConstructor(String.class, String.class);
					executorService.execute((Runnable) cons.newInstance(instanceId, taskId));
				}
				
				//수집 주기별 기동한다.
				if(isStandAlone)
				{
					int collectPeriod = 0;
					
					if(instanceId.equals("HCHK_COLLECT")){
						collectPeriod =(Integer) MonitoringInfoManager.getInstance().getConfig("hchk_period_sec");
					} else{
						collectPeriod =Integer.valueOf(TaskInfoManager.getInstance().getAtt(instanceId, "collectPeriod"));
					}
					
					Thread.sleep(collectPeriod * 1000);
				} else{
					Thread.sleep((Integer)instanceMap.get("collect_period_sec") * 1000);					
				}

				isFirst = false;
			}
			
			executorService.shutdown();
			
			try {
				if (!executorService.awaitTermination(60, TimeUnit.SECONDS)) {
					if (!executorService.awaitTermination(60, TimeUnit.SECONDS)) {
						executorService.shutdownNow();
					}
				}
			} catch (InterruptedException e) {
				executorService.shutdownNow();
				log.debug(e);
			}
			
		} catch (Exception e) {
			log.error("", e);
		}
	}

}

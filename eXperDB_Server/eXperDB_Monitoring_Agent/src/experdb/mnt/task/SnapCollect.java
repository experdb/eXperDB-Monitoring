package experdb.mnt.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Enumeration;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.apache.commons.dbcp.PoolingDriver;
import org.apache.ibatis.exceptions.PersistenceException;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.postgresql.util.PSQLException;
import org.postgresql.util.PSQLState;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.ResourceInfo;
import experdb.mnt.db.dbcp.DBCPPoolManager;
import experdb.mnt.db.mybatis.SqlSessionManager;
import experdb.mnt.util.MD5Gen;

public class SnapCollect extends TaskApplication {

	private static final String RESOURCE_KEY_ACCESS = "ACCESS";
	private static final String RESOURCE_KEY_TABLESPACE = "TABLESPACE";
	private static final String RESOURCE_KEY_TABLE = "TABLE";
	private static final String RESOURCE_KEY_INDEX = "INDEX";

	private String is_collect_ok = "Y";
	private String failed_collect_type = "";	
	boolean isFirst = true;
	
	public SnapCollect(String instanceId, String taskId) {
		super(instanceId, taskId);
	}

	@Override
	public void run() {
		try {
			long collectPeriod = 0;
			long sleepTime;
			long startTime;
			long endTime;
			int checkAlive = 0;
			if (MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("snap_period_min") == null)
				collectPeriod = 0;
			else
				collectPeriod = 60 * (Integer)MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("snap_period_min");
			
			while (!MonitoringInfoManager.getInstance().isReLoad())
			{
				//log.debug(System.currentTimeMillis());
				
				try {
					is_collect_ok = "Y";
					failed_collect_type = "";
					
					if(collectPeriod <= 0){
						Thread.sleep(10 * 1000);
						continue;
					}

					startTime =  System.currentTimeMillis();
					
					execute(); //수집 실행
	
					//check whether the thread is running or not.
					if (checkAlive++ % 100 == 0){
						log.info("[RscCollect ==>> " + instanceId + "]");
						checkAlive = 1;
					}
					
					endTime =  System.currentTimeMillis();
					
					if((endTime - startTime) > (collectPeriod * 1000) )
					{
						//처리 시간이 수집주기보다 크면 바로처리
						continue;
					} else {
						sleepTime = (collectPeriod * 1000) - (endTime - startTime);
					}
				
					Thread.sleep(sleepTime);
	
				} catch (Exception e) {
					log.error("[QueryCollect:instanceId ==>> " + instanceId + "]" + " execute fail]", e);
				}
			}
		} catch (Exception e) {
			//log.error("", e);
			log.error("[QueryCollect:instanceId ==>> " + instanceId + "]" + " escaped loop]", e);
		}		
	}
	
	private void execute() {
		SqlSessionFactory sqlSessionFactory = null;
		SqlSession sessionAgent  = null;
		
		try {
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			log.debug("[instanceId ==>> " + instanceId + "]" + " " + this.getClass().getName());

			sessionAgent = sqlSessionFactory.openSession();
			/* Check Snapshot state*/
			HashMap<String, Object> inputParam = new HashMap<String, Object>();
			inputParam.put("instance_id", 				Integer.parseInt(instanceId));
			HashMap<String, Object> checkSnapStateMap = sessionAgent.selectOne("TB_SNAPSHOT_INFO_S001", inputParam);
			if(checkSnapStateMap == null || checkSnapStateMap.get("enabled").toString().equals("false")){
				log.info("[instanceId ==>> " + instanceId + "]" + " Snapshot is disabled]"+ " " + this.getClass().getName());
				return;
			}
			
			/* Create Snapshot */
			sessionAgent.update("TB_SNAPSHOT_INFO_U001", inputParam); 
			//Commit
			sessionAgent.commit();
		} catch (Exception e) {
			log.error("", e);
		} finally {
			if(sessionAgent != null)	sessionAgent.close();
		}
	}

}

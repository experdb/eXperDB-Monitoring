package experdb.mnt.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.Date;
import java.util.Enumeration;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

import org.apache.commons.dbcp.PoolingDriver;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.ResourceInfo;
import experdb.mnt.db.dbcp.DBCPPoolManager;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class ReplCollect extends TaskApplication {

	private static final String RESOURCE_KEY_CHECKPOINT = "CHECKPOINT";
	private static final String RESOURCE_KEY_REPLICATIONDELAY = "REPLICATIONDELAY";

	private String is_collect_ok = "Y";
	private String failed_collect_type = "";
	private String instance_db_version = "";
	private long collectPeriod = 0;
	private long collectPeriodCheckpoint = 0;
	private long gatherCheckpointTime = 0;
	private boolean bInsertCheckpoint = false;
	
	public ReplCollect(String instanceId, String taskId) {
		super(instanceId, taskId);
	}

	@Override
	public void run() {

//		long collectPeriod = (Integer) MonitoringInfoManager.getInstance().getConfig("hchk_period_sec");
//		
//		
//		long sleepTime;
//		long startTime;
//		long endTime;
//		
//
//		log.debug(System.currentTimeMillis());
//		
//		try {
//			is_collect_ok = "Y";
//			failed_collect_type = "";
//			int a = 1 +1 ;
//			a = 1-1;
//			//HA info
//			Enumeration		en = MonitoringInfoManager.getInstance().getInstanceId();
//			while (en.hasMoreElements()) {
//				execute((String) en.nextElement()); //수집 실행
//			}	
//		} catch (Exception e) {
//			log.error("", e);
//		}
		
		instance_db_version = (String) MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("pg_version_min");
		
		collectPeriod = (Integer)MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("collect_period_sec");
		collectPeriodCheckpoint = collectPeriod * 5;
		
		long sleepTime;
		long startTime;
		long endTime;		
		
		while (!MonitoringInfoManager.getInstance().isReLoad())
		{
			log.debug(System.currentTimeMillis());
			
			try {
				is_collect_ok = "Y";
				failed_collect_type = "";
				
				startTime =  System.currentTimeMillis();
				
				execute(); //수집 실행

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
				log.error("", e);
			}
		}

	}
	
	private void execute() {
		SqlSessionFactory sqlSessionFactory = null;
		Connection connection = null;
		SqlSession sessionCollect = null;
		SqlSession sessionAgent  = null;
		
		Date from = null;
		SimpleDateFormat transFormat = new SimpleDateFormat("yyyy-MM-dd HH:mm:ss");
		String startDelay = "";
						
		try {
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			
			try {			
				connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + instanceId);
				sessionCollect = sqlSessionFactory.openSession(connection);
			} catch (Exception e) {
				failed_collect_type = "0";
				is_collect_ok = "N";
				//log.error("", e);	
				log.error("[reqInstanceId ==>> " + instanceId + "]" + " Connection failed]");
			}
			
			sessionAgent = sqlSessionFactory.openSession();
			
			HashMap<String, Object> replSel = new HashMap<String,Object>();// Replicaiton 정보 수집
		
			//////////////////////////////////////////////////////////////////////////////////
			// Replication 정보 수집
			if(is_collect_ok.equals("Y")) {
				try {
					HashMap<String, Object> preList = new HashMap<String,Object>();			
					if(ResourceInfo.getInstance().get(instanceId, taskId+"REPL", RESOURCE_KEY_REPLICATIONDELAY) == null)
					{
						from = new Date();
						startDelay = transFormat.format(from);
						preList.put("start_delay", startDelay);
						ResourceInfo.getInstance().put(instanceId, taskId+"REPL", RESOURCE_KEY_REPLICATIONDELAY, preList);
					}

					HashMap<String, Object> dbVerMap = new HashMap<String, Object>();
					dbVerMap.put("instance_db_version", instance_db_version);
					
					Map<String, Object> preValue = new HashMap<String, Object>();
					preValue = (Map<String, Object>) ResourceInfo.getInstance().get(instanceId, taskId+"REPL", RESOURCE_KEY_REPLICATIONDELAY);
					
					startDelay = preValue.get("start_delay").toString();
					dbVerMap.put("start_delay", startDelay);
					
					replSel = sessionCollect.selectOne("app.EXPERDBMA_BT_UPTIME_MAXCONN_002", dbVerMap);
				} catch (Exception e) {
					failed_collect_type = "1";
					is_collect_ok = "N";
					log.error("", e);
				}					
			}
			///////////////////////////////////////////////////////////////////////////////////		
			// checkpoint 정보 수집
			HashMap<String, Object> checkpointSel = new HashMap<String,Object>();// Replicaiton 정보 수집
			//////////////////////////////////////////////////////////////////////////////////////////////////////////////	
			
			long checktime = System.currentTimeMillis();
			if (gatherCheckpointTime < checktime) {
				///////////////////////////////////////////////////////////////////////////////
				
				if(is_collect_ok.equals("Y")) {
					
					// checkpoint 이전값 확인				
					HashMap<String, Object> preList = new HashMap<String,Object>();				
					try {
						if(ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_CHECKPOINT) == null)
						{
							preList = sessionCollect.selectOne("app.EXPERDBMA_BT_CHECKPOINT_001");
							
							HashMap<String, Object> tempCheckpoint = new HashMap<String, Object>();						
							ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_CHECKPOINT, preList);
						}
						///////////////////////////////////////////////////////////////////////////////
						HashMap<String, Object> dbVerMap = new HashMap<String, Object>();
						dbVerMap.put("instance_db_version", instance_db_version);
						checkpointSel = sessionCollect.selectOne("app.EXPERDBMA_BT_CHECKPOINT_001", dbVerMap);
					} catch (Exception e) {
						failed_collect_type = "1";
						is_collect_ok = "N";
						log.error("", e);
					}					
				}
				gatherCheckpointTime = collectPeriodCheckpoint * 1000  + checktime ;
				bInsertCheckpoint = true;
			}			
			///////////////////////////////////////////////////////////////////////////////////
		
			try {
								
				///////////////////////////////////////////////////////////////////////////////
				// TB_REPL_COLLECT_INFO 정보 등록
				
				//금일자 최초 거래인지 확인
				HashMap<String, Object> regDateMap = sessionAgent.selectOne("app.TB_REPL_COLLECT_INFO_S001");
				
				if(regDateMap.get("max_reg_date") == null)	regDateMap.put("max_reg_date", "");
				
				if(!regDateMap.get("max_reg_date").equals(regDateMap.get("reg_date")))
				{
					//금일자에 등록된 거래가 없는경우 시퀀스 초기화
					sessionAgent.selectList("app.SEQ_SETVAL_REPL");
				}
				
				
				if(replSel.size() > 0 && Double.parseDouble(replSel.get("replay_lag").toString()) == 0){
					from = new Date();
					startDelay = transFormat.format(from);
					
					HashMap<String, Object> preList = new HashMap<String,Object>();		
					preList.put("start_delay", startDelay);
					ResourceInfo.getInstance().put(instanceId, taskId+"REPL", RESOURCE_KEY_REPLICATIONDELAY, preList);
				}
				
				Map<String, Object> parameObjt = new HashMap<String, Object>();
				parameObjt.put("instance_id", Integer.valueOf(instanceId));
				parameObjt.put("is_collect_ok", is_collect_ok);				
				parameObjt.put("failed_collect_type", failed_collect_type);				
				parameObjt.put("ha_role", replSel.get("ha_role"));
				parameObjt.put("ha_host", replSel.get("ha_host"));
				parameObjt.put("ha_port", replSel.get("ha_port"));
				parameObjt.put("replay_lag", replSel.get("replay_lag"));
				
				sessionAgent.insert("app.TB_REPL_COLLECT_INFO_I001", parameObjt);
				
				if(is_collect_ok.equals("N"))
				{
					sessionAgent.commit();
					return;
				}
				///////////////////////////////////////////////////////////////////////////////
				
				///////////////////////////////////////////////////////////////////////////////
				if (bInsertCheckpoint) {
				// TB_CHECKPOINT_COLLECT_INFO 정보 등록
					Map<String, Object> preValue = new HashMap<String, Object>();
					preValue = (Map<String, Object>) ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_CHECKPOINT);
					
					long checkpoints_timed_delta = 0;
					long checkpoints_req_delta = 0;
					double timediff = 0;
					if(checkpointSel.size() > 0) {
						checkpoints_timed_delta = Long.parseLong(checkpointSel.get("checkpoints_timed").toString()) - Long.parseLong(preValue.get("checkpoints_timed").toString());
						checkpoints_req_delta = Long.parseLong(checkpointSel.get("checkpoints_req").toString()) - Long.parseLong(preValue.get("checkpoints_req").toString());
						timediff = Double.parseDouble(checkpointSel.get("checkpoint_time").toString()) - Double.parseDouble(preValue.get("checkpoint_time").toString());
					} 
							
					double checkpoints_timed_time_delta = 0;
					double checkpoints_req_time_delta = 0;
					if ((checkpoints_timed_delta + checkpoints_req_delta) > 0) {
						checkpoints_timed_time_delta = checkpoints_timed_delta / (checkpoints_timed_delta + checkpoints_req_delta) * timediff;
						checkpoints_req_time_delta = checkpoints_req_delta / (checkpoints_timed_delta + checkpoints_req_delta) * timediff;
					}
					
					//금일자 최초 거래인지 확인
					parameObjt.clear();				
					parameObjt.put("instance_id", Integer.valueOf(instanceId));		
					parameObjt.put("checkpoints_timed", checkpointSel.get("checkpoints_timed"));
					parameObjt.put("checkpoints_req", checkpointSel.get("checkpoints_req"));
					parameObjt.put("checkpoint_time", checkpointSel.get("checkpoint_time"));
					parameObjt.put("checkpoints_timed_delta", checkpoints_timed_delta);
					parameObjt.put("checkpoints_req_delta", checkpoints_req_delta);
					parameObjt.put("checkpoints_timed_time_delta", checkpoints_timed_time_delta);
					parameObjt.put("checkpoints_req_time_delta", checkpoints_req_time_delta);
					
					sessionAgent.insert("app.TB_CHECKPOINT_INFO_I001", parameObjt);				
					if(checkpointSel.size() > 0) 
						ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_CHECKPOINT, checkpointSel);
					bInsertCheckpoint = false;
				///////////////////////////////////////////////////////////////////////////////	
				}
				//Commit
				sessionAgent.commit();
			} catch (Exception e) {
				sessionAgent.rollback();
				log.error("", e);
			}			
			
		} catch (Exception e) {
			log.error("", e);
		} finally {
			if(sessionAgent != null)	sessionAgent.close();
			if(sessionCollect != null)	sessionCollect.close();
		}
	}	
	
	
//	private void execute(String reqInstanceId) {
//			
//		String instance_db_version = "";
//		SqlSessionFactory sqlSessionFactory = null;
//		Connection connection = null;
//		SqlSession sessionCollect = null;
//		SqlSession sessionAgent  = null;
//		
//		is_collect_ok = "Y";
//		failed_collect_type = "";
//		
//		instance_db_version = (String) MonitoringInfoManager.getInstance().getInstanceMap(reqInstanceId).get("pg_version_min");
//		
//		try {
//			// DB Connection을 가져온다
//			sqlSessionFactory = SqlSessionManager.getInstance();
//			
//			try {			
//				connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + reqInstanceId);
//				sessionCollect = sqlSessionFactory.openSession(connection);
//			} catch (Exception e) {
//				failed_collect_type = "0";
//				is_collect_ok = "N";
//				//log.error("", e);	
//				log.error("[reqInstanceId ==>> " + reqInstanceId + "]" + " Connection failed]");		
//
//			}
//			
//			sessionAgent = sqlSessionFactory.openSession();
//			
//			HashMap<String, Object> replSel = new HashMap<String,Object>();// Replicaiton 정보 수집
//		
//			//////////////////////////////////////////////////////////////////////////////////
//			// Replication 정보 수집
//			if(is_collect_ok.equals("Y")) {
//				try {
//					HashMap<String, Object> dbVerMap = new HashMap<String, Object>();
//					dbVerMap.put("instance_db_version", instance_db_version);							
//					replSel = sessionCollect.selectOne("app.EXPERDBMA_BT_UPTIME_MAXCONN_002", dbVerMap);
//				} catch (Exception e) {
//					failed_collect_type = "1";
//					is_collect_ok = "N";
//					log.error("", e);
//				}					
//			}
//			///////////////////////////////////////////////////////////////////////////////////			
//		
//			try {
//				
//				///////////////////////////////////////////////////////////////////////////////
//				// TB_REPL_COLLECT_INFO 정보 등록
//				
//				//금일자 최초 거래인지 확인
//				HashMap<String, Object> regDateMap = sessionAgent.selectOne("app.TB_REPL_COLLECT_INFO_S001");
//				
//				if(regDateMap.get("max_reg_date") == null)	regDateMap.put("max_reg_date", "");
//				
//				if(!regDateMap.get("max_reg_date").equals(regDateMap.get("reg_date")))
//				{
//					//금일자에 등록된 거래가 없는경우 시퀀스 초기화
//					sessionAgent.selectList("app.SEQ_SETVAL_REPL");
//				}				
//				
//				Map<String, Object> parameObjt = new HashMap<String, Object>();
//				parameObjt.put("instance_id", Integer.valueOf(reqInstanceId));
//				parameObjt.put("is_collect_ok", is_collect_ok);				
//				parameObjt.put("failed_collect_type", failed_collect_type);
//				parameObjt.put("ha_role", replSel.get("ha_role"));
//				parameObjt.put("ha_host", replSel.get("ha_host"));
//				parameObjt.put("ha_port", replSel.get("ha_port"));
//				
//				sessionAgent.insert("app.TB_REPL_COLLECT_INFO_I001", parameObjt);
//				
//				if(is_collect_ok.equals("N"))
//				{
//					sessionAgent.commit();
//					return;
//				}				
//				///////////////////////////////////////////////////////////////////////////////
//						
//				//Commit
//				sessionAgent.commit();
//			} catch (Exception e) {
//				sessionAgent.rollback();
//				log.error("", e);
//			}			
//			
//		} catch (Exception e) {
//			log.error("", e);
//		} finally {
//			if(sessionAgent != null)	sessionAgent.close();
//			if(sessionCollect != null)	sessionCollect.close();
//		}
//	}	
	
}

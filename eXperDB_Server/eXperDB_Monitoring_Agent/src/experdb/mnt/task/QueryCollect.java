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

public class QueryCollect extends TaskApplication {

	private static final String RESOURCE_KEY_ACCESS = "ACCESS";
	private static final String RESOURCE_KEY_TABLESPACE = "TABLESPACE";
	private static final String RESOURCE_KEY_TABLE = "TABLE";
	private static final String RESOURCE_KEY_INDEX = "INDEX";

	private String is_collect_ok = "Y";
	private String failed_collect_type = "";	
	boolean isFirst = true;
	
	public QueryCollect(String instanceId, String taskId) {
		super(instanceId, taskId);
	}

	@Override
	public void run() {
		try {
			long collectPeriod = (Integer)MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("rtstmt_period_sec");
			long rescan = 0;
			
			long sleepTime;
			long startTime;
			long endTime;
			int checkAlive = 0;
			
			if (MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("hchk_period_sec") != null)
				if ((Integer)MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("hchk_period_sec") > 0){
					resetReScanStmt(); //reset rescan flag
				}
			
			while (!MonitoringInfoManager.getInstance().isReLoad())
			{
				//log.debug(System.currentTimeMillis());
				
				try {
					is_collect_ok = "Y";
					failed_collect_type = "";
					
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
		Connection connection = null;
		SqlSession sessionCollect = null;
		SqlSession sessionAgent  = null;
		
		try {
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			log.debug("[instanceId ==>> " + instanceId + "]" + " Collect]");
			try {			
				connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + instanceId);
				sessionCollect = sqlSessionFactory.openSession(connection);
			} catch (Exception e) {
				failed_collect_type = "0";
				is_collect_ok = "N";
				log.error("[instanceId ==>> " + instanceId + "]" + " Connection failed]");
			}

			sessionAgent = sqlSessionFactory.openSession();
			HashMap<String, Object> checkReadOnlyMap = sessionCollect.selectOne("EXPERDBMA_BT_CHECK_READONLY_001");
			if(checkReadOnlyMap.get("isrecovery").toString().equals("false")){ // check the target cluster's role is slave 
				if(isFirst == true){
					sessionCollect.update("EXPERDBMA_BT_CREATE_PLPERL_001");
					sessionCollect.update("EXPERDBMA_BT_PGSS_QUERY_CREATE_001");
					isFirst = false;
				}
			}
			
			List<HashMap<String, Object>> pgssSel = new ArrayList<HashMap<String,Object>>(); //Access 수집
			
			try {
				// PGSS QUERY TEXT 정보 수집
				try {
					HashMap<String, Object> paramMap = new HashMap<String, Object>();
					paramMap.put("delimeter", "!#");
					pgssSel = sessionCollect.selectList("app.BT_PGSS_QUERY_001", paramMap);
				} catch (Exception e) {
					failed_collect_type = "2";
					throw e;
				}
				
				if((pgssSel == null) || (pgssSel.size() == 0))
					return ;
				
			} catch (Exception e1) {
				is_collect_ok = "N";
				log.error("[instanceId ==>> " + instanceId + "]", e1);
			}			
			
			try {
				// PGSS_QUERY 정보 등록
				for (HashMap<String, Object> map : pgssSel) {
					map.put("instance_id", Integer.valueOf(instanceId));
					sessionAgent.insert("app.TB_PGSS_QUERY_INFO_I001", map);
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
	
	private void resetReScanStmt() {
		SqlSessionFactory sqlSessionFactory = null;
		Connection connection = null;
		SqlSession sessionAgent  = null;
		SqlSession sessionCollect = null;
		
		try {
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			log.debug("[instanceId ==>> " + instanceId + "]" + " Collect]");
			try {			
				connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + instanceId);
				sessionCollect = sqlSessionFactory.openSession(connection);
			} catch (Exception e) {
				failed_collect_type = "0";
				is_collect_ok = "N";
				log.error("[instanceId ==>> " + instanceId + "]" + " Connection failed]");
			}
						
			sessionAgent = sqlSessionFactory.openSession();
			HashMap<String, Object> checkReadOnlyMap = sessionCollect.selectOne("EXPERDBMA_BT_CHECK_READONLY_001");
			if(checkReadOnlyMap.get("isrecovery").toString().equals("false")){ // check the target cluster's role is slave 
				if(isFirst == true){
					sessionCollect.update("EXPERDBMA_BT_CREATE_PLPERL_001");
					sessionCollect.update("EXPERDBMA_BT_PGSS_QUERY_RESET_001");
					isFirst = false;
				}
			}
			
			try {
				// collect all queries after resetting
				try {
					sessionCollect.update("app.BT_PGSS_QUERY_002"); 
					sessionCollect.commit();
				} catch (Exception e) {
					failed_collect_type = "2";
					throw e;
				}
				
			} catch (Exception e1) {
				is_collect_ok = "N";
				log.error("[instanceId ==>> " + instanceId + "]", e1);
			}	

			sessionAgent = sqlSessionFactory.openSession();
			HashMap<String, Object> rescanMap = new HashMap<String,Object>(); //Access 수집
			rescanMap.put("instance_id", Integer.parseInt(instanceId));
			rescanMap.put("hchk_period_sec", null);
			sessionAgent.update("app.TB_INSTANCE_INFO_U007", rescanMap);
			sessionAgent.commit();
		} catch (Exception e) {
			log.error("", e);
		} finally {
			if(sessionAgent != null)	sessionAgent.close();			
		}
	}
}

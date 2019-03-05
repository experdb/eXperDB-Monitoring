package experdb.mnt.task;

import java.math.BigDecimal;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.util.Arrays;
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

public class RTStmtCollect extends TaskApplication {

	private static final String RESOURCE_KEY_BACKEND_RSC = "BACKEND_RSC";
	
	private String is_collect_ok = "Y";
	private String failed_collect_type = "";	
	
	private String instance_db_version = "";
	
	public RTStmtCollect(String instanceId, String taskId) {
		super(instanceId, taskId);
	}

	@Override
	public void run() {
		
		instance_db_version = (String) MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("pg_version_min");
		long collectPeriod = (Integer)MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("rtstmt_period_sec");
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
				
				execute(collectPeriod); //수집 실행
				
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
	
	private void execute(long collectPeriod) {
		SqlSessionFactory sqlSessionFactory = null;
		Connection connection = null;
		SqlSession sessionCollect = null;
		SqlSession sessionAgent  = null;
		
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
				log.error("[instanceId ==>> " + instanceId + "]" + " Connection failed]");		
			}
				
			sessionAgent = sqlSessionFactory.openSession();
			List<HashMap<String, Object>> rtStmtSel = new ArrayList<HashMap<String,Object>>(); // STMT 정보 수집
			
			if(is_collect_ok.equals("Y"))
			{			
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////			
				//				
				try {
					// statements 정보 수집
					List<HashMap<String, Object>> RTStmtSel = new ArrayList<HashMap<String,Object>>();
					HashMap<String, Object> inputParam = new HashMap<String, Object>();
					inputParam.put("instance_id", Integer.parseInt(instanceId));

					RTStmtSel = sessionAgent.selectList("app.BT_RTSTMT_INFO_001", inputParam);

					for (HashMap<String, Object> map : RTStmtSel) {
						map.put("instance_id", 				Integer.parseInt(instanceId));
						sessionAgent.insert("app.BT_RTSTMT_INFO_I001", map);
						HashMap<String, Object> queryIdMap = sessionAgent.selectOne("app.TB_QUERY_INFO_S001", map);						
						if (queryIdMap == null){
							inputParam.put("queryid", 					map.get("query"));
							inputParam.put("query", 					map.get("query"));
							inputParam.put("stmt_queryid", 				map.get("queryid"));
							sessionAgent.insert("app.TB_QUERY_INFO_I001", inputParam);
						}
					}
					
					//Sequence
					HashMap<String, Object> SeqMap = sessionAgent.selectOne("app.SEQ_GET_NEXT_STMT");
					int sequence = Integer.parseInt(SeqMap.get("nextval").toString());
					
					HashMap<String, Object> paramMap = new HashMap<String, Object>();
					paramMap.put("instance_id", Integer.parseInt(instanceId));
					paramMap.put("table_order", sequence % 2);
					sessionAgent.delete("app.BT_RTSTMT_CALL_INFO_T001", paramMap);
					sessionAgent.insert("app.BT_RTSTMT_CALL_INFO_I001", paramMap);	
					sessionAgent.commit();
				} catch (Exception e) {					
					is_collect_ok = "N";
					log.error("", e);
				}
			}
		} catch (Exception e) {
			log.error("", e);
		} finally {
			if(sessionAgent != null)	sessionAgent.close();
			if(sessionCollect != null)	sessionCollect.close();
		}
	}

}

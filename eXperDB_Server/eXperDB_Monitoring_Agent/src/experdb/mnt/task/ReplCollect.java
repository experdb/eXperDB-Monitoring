package experdb.mnt.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.util.Arrays;
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

	private static final String RESOURCE_KEY_TABLESPACE = "TABLESPACE";
	private static final String RESOURCE_KEY_TABLE = "TABLE";
	private static final String RESOURCE_KEY_INDEX = "INDEX";

	private String is_collect_ok = "Y";
	private String failed_collect_type = "";
	private String instance_db_version = "";
	
	public ReplCollect(String instanceId, String taskId) {
		super(instanceId, taskId);
	}

	@Override
	public void run() {

		long collectPeriod = (Integer) MonitoringInfoManager.getInstance().getConfig("hchk_period_sec");
		
		
		long sleepTime;
		long startTime;
		long endTime;
		

		log.debug(System.currentTimeMillis());
		
		try {
			is_collect_ok = "Y";
			failed_collect_type = "";
			int a = 1 +1 ;
			a = 1-1;
			//HA info
			Enumeration		en = MonitoringInfoManager.getInstance().getInstanceId();
			while (en.hasMoreElements()) {
				execute((String) en.nextElement()); //수집 실행
			}	
		} catch (Exception e) {
			log.error("", e);
		}

	}
	
	private void execute(String reqInstanceId) {
			
		String instance_db_version = "";
		SqlSessionFactory sqlSessionFactory = null;
		Connection connection = null;
		SqlSession sessionCollect = null;
		SqlSession sessionAgent  = null;
		
		is_collect_ok = "Y";
		failed_collect_type = "";
		
		instance_db_version = (String) MonitoringInfoManager.getInstance().getInstanceMap(reqInstanceId).get("pg_version_min");
		
		try {
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			
			try {			
				connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + reqInstanceId);
				sessionCollect = sqlSessionFactory.openSession(connection);
			} catch (Exception e) {
				failed_collect_type = "0";
				is_collect_ok = "N";
				//log.error("", e);	
				log.error("[reqInstanceId ==>> " + reqInstanceId + "]" + " Connection failed]");		

			}
			
			sessionAgent = sqlSessionFactory.openSession();
			
			HashMap<String, Object> replSel = new HashMap<String,Object>();// Replicaiton 정보 수집
		
			//////////////////////////////////////////////////////////////////////////////////
			// Replication 정보 수집
			if(is_collect_ok.equals("Y")) {
				try {
					HashMap<String, Object> dbVerMap = new HashMap<String, Object>();
					dbVerMap.put("instance_db_version", instance_db_version);							
					replSel = sessionCollect.selectOne("app.EXPERDBMA_BT_UPTIME_MAXCONN_002", dbVerMap);
				} catch (Exception e) {
					failed_collect_type = "1";
					is_collect_ok = "N";
					log.error("", e);
				}					
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
				
				Map<String, Object> parameObjt = new HashMap<String, Object>();
				parameObjt.put("instance_id", Integer.valueOf(reqInstanceId));
				parameObjt.put("is_collect_ok", is_collect_ok);				
				parameObjt.put("failed_collect_type", failed_collect_type);
				parameObjt.put("ha_role", replSel.get("ha_role"));
				parameObjt.put("ha_host", replSel.get("ha_host"));
				parameObjt.put("ha_port", replSel.get("ha_port"));
				
				sessionAgent.insert("app.TB_REPL_COLLECT_INFO_I001", parameObjt);
				
				if(is_collect_ok.equals("N"))
				{
					sessionAgent.commit();
					return;
				}				
				///////////////////////////////////////////////////////////////////////////////
						
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
	
}

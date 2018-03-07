package experdb.mnt.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.HashMap;

import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class StartCollect extends TaskApplication {

	public StartCollect(String instanceId, String taskId) {
		super(instanceId, taskId);
	}

	@Override
	public void run() {
		SqlSessionFactory sqlSessionFactory = null;
		Connection connection = null;
		SqlSession sessionCollect = null;
		SqlSession sessionAgent  = null;
		String instance_db_version = "";
		
		try {
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			
			connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + instanceId);
			instance_db_version = (String) MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("pg_version_min");
			sessionCollect = sqlSessionFactory.openSession(connection);
			
			sessionAgent = sqlSessionFactory.openSession();			
			
			
			
			HashMap<String, Object> select = new HashMap<String, Object>();
			/*add to update ha_info by robin 201712 */
			select.put("instance_db_version", instance_db_version);	
			select = sessionCollect.selectOne("app.EXPERDBMA_BT_UPTIME_MAXCONN_002", select);
			
			select.put("instance_id", Integer.valueOf(instanceId));
			select.put("max_conn_cnt", Integer.valueOf((String) select.get("max_conn_cnt")));
			select.put("ha_role", select.get("ha_role"));
			select.put("ha_host", select.get("ha_host"));
			select.put("ha_port", select.get("ha_port"));
			
			log.debug("=====>>>" + select);
			
			sessionAgent.update("app.TB_INSTANCE_INFO_U002", select);
			/*add to update ha_info by robin 201712 end*/
			
			
			sessionAgent.commit();
		} catch (Exception e) {
			log.error("", e);			
			if(sessionAgent != null) sessionAgent.rollback();
		} finally {
			if(sessionAgent != null) sessionAgent.close();
			if(sessionCollect != null) sessionCollect.close();
		}
	}

}

package experdb.mnt.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.HashMap;

import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;

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
		
		try {
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			
			connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + instanceId);
			sessionCollect = sqlSessionFactory.openSession(connection);
			
			sessionAgent = sqlSessionFactory.openSession();			
			
			
			
			HashMap<String, Object> select = new HashMap<String, Object>();
			
			select = sessionCollect.selectOne("app.EXPERDBMA_BT_UPTIME_MAXCONN_001");
			
			select.put("instance_id", Integer.valueOf(instanceId));
			select.put("max_conn_cnt", Integer.valueOf((String) select.get("max_conn_cnt")));
			
			log.debug("=====>>>" + select);
			
			sessionAgent.update("app.TB_INSTANCE_INFO_U001", select);
			
			
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

package experdb.mnt.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

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
			HashMap<String, Object> selectext = new HashMap<String, Object>();
			/*add to update ha_info by robin 201712 */
			select.put("instance_db_version", instance_db_version);	
			select = sessionCollect.selectOne("app.EXPERDBMA_BT_UPTIME_MAXCONN_001", select);
			selectext = sessionCollect.selectOne("app.PG_CHECK_EXTENSION_003");
			if (selectext != null) select.put("extensions", selectext.get("extensions"));
			select.put("instance_id", Integer.valueOf(instanceId));
			select.put("max_conn_cnt", Integer.valueOf((String) select.get("max_conn_cnt")));
			
			log.debug("=====>>>" + select);
			
			List<HashMap<String, Object>> selectuser = new ArrayList<HashMap<String,Object>>(); //User 수집		
			selectuser = sessionCollect.selectList("app.EXPERDBMA_BT_GET_PGUSER_001");
			
			/* update ha group 서버 다시띄우면 변경됨 */
			HashMap<String, Object> select_group = new HashMap<String, Object>();
			select_group = sessionAgent.selectOne("app.EXPERDBMA_BT_SELECT_HA_GROUP_001", select);					
			
			/* update  */
			if (select_group != null)
				select.put("ha_group",      select_group.get("ha_group"));
			else
				select.put("ha_group",      select.get("instance_id"));
			
			sessionAgent.update("app.TB_INSTANCE_INFO_U002", select);

			for (HashMap<String, Object> map : selectuser) {
				map.put("instance_id", Integer.valueOf(instanceId));
				sessionAgent.insert("app.TB_PGUSER_I001", map);					
			}
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

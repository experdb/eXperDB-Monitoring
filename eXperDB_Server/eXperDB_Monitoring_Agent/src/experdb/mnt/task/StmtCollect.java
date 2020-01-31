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
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.ResourceInfo;
import experdb.mnt.db.dbcp.DBCPPoolManager;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class StmtCollect extends TaskApplication {

	private static final String RESOURCE_KEY_ACCESS = "ACCESS";
	private static final String RESOURCE_KEY_TABLESPACE = "TABLESPACE";
	private static final String RESOURCE_KEY_TABLE = "TABLE";
	private static final String RESOURCE_KEY_INDEX = "INDEX";

	private String is_collect_ok = "Y";
	private String failed_collect_type = "";	
	
	public StmtCollect(String instanceId, String taskId) {
		super(instanceId, taskId);
	}

	@Override
	public void run() {
		long collectStmtPeriod = (Integer) MonitoringInfoManager.getInstance().getConfig("stmt_period_sec");
		long sleepTime;
		long startTime;
		long nextExecuteTime = 0;
		long startDeleteTime = 0;
		long endTime;
		
		while (!MonitoringInfoManager.getInstance().isReLoad())
		{
			log.debug(System.currentTimeMillis());
			
			try {
				startTime =  System.currentTimeMillis();				
				
				Enumeration		en = MonitoringInfoManager.getInstance().getInstanceId();
				
				if ( nextExecuteTime  <= startTime) {
					//OBJT 정보수집					
					while (en.hasMoreElements()) {
						execute((String) en.nextElement());
					}
					nextExecuteTime = System.currentTimeMillis() + collectStmtPeriod * 1000;
				}
				
				endTime =  System.currentTimeMillis();
				
				sleepTime = nextExecuteTime - (endTime);
				Thread.sleep(sleepTime < 0 ? 0 : sleepTime);
								
			} catch (Exception e) {
				//log.error("", e);
				log.error("[instanceId ==>> " + instanceId + "]" + " execute fail]", e);
			}
		}
	}	
	
	private void execute(String reqInstanceId) {
		SqlSessionFactory sqlSessionFactory = null;
		Connection connection = null;
		SqlSession sessionCollect = null;
		SqlSession sessionAgent  = null;
		String instance_db_version = "";
		
		is_collect_ok = "Y";
		failed_collect_type = "";	
		
		try {
			//수집 DB의 버젼을 가져온다
			instance_db_version = (String) MonitoringInfoManager.getInstance().getInstanceMap(reqInstanceId).get("pg_version_min");
			
			//수집 DB의 버젼 및 extension 설치 확인
			double dbl_instance_db_version = Double.parseDouble(instance_db_version);
			int extensions = (Integer)MonitoringInfoManager.getInstance().getInstanceMap(reqInstanceId).get("extensions");
			extensions &= 0x02; //check pg_stat_statment installed or not.
			if ((dbl_instance_db_version < 9.5) || (extensions <= 0 ) )
				return;

			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			
			try {
				connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + reqInstanceId);
				sessionCollect = sqlSessionFactory.openSession(connection);
			} catch (Exception e) {
				failed_collect_type = "0";
				is_collect_ok = "N";
				//log.error("", e);
				log.error("[instanceId ==>> " + instanceId + "]" + " Connection fail]", e);
			}
			
			sessionAgent = sqlSessionFactory.openSession();
			List<HashMap<String, Object>> pgssSel = new ArrayList<HashMap<String,Object>>();
			HashMap<String, Object> pgssCollect = new HashMap<String,Object>();

			if(is_collect_ok.equals("Y"))
			{						
				///////////////////////////////////////////////////////////////////////////////
				// STATEMENT 정보수집						
				try {					
					pgssSel = sessionCollect.selectList("app.TB_PGSS_INFO_S001");
				} catch (Exception e) {
					failed_collect_type = "3";
					log.error("instanceid=[" + reqInstanceId + "]", e);
					throw e;
				}					
				///////////////////////////////////////////////////////////////////////////////
			}
						
			try {
				
				///////////////////////////////////////////////////////////////////////////////
				// TB_QUERY_INFO 정보 등록
				Map<String, Object> parameObjt = new HashMap<String, Object>();
				parameObjt.put("instance_id", Integer.valueOf(reqInstanceId));
				
				JSONArray stmtArray = new JSONArray();
				for (HashMap<String, Object> map : pgssSel) {
					HashMap<String, Object> inputParam = new HashMap<String, Object>();
					inputParam.put("instance_id", 				Integer.parseInt(reqInstanceId));
					//inputParam.put("db_name", 					map.get("db_name"));
					//inputParam.put("queryid", 					map.get("query"));
					//inputParam.put("query", 						map.get("query"));									
					inputParam.put("dbid", 			map.get("dbid"));
					inputParam.put("userid", 		map.get("userid"));
					inputParam.put("query", 		map.get("queryid"));			
					HashMap<String, Object> queryIdMap = sessionAgent.selectOne("app.TB_QUERY_INFO_S002", inputParam);
					if (queryIdMap == null){
//						inputParam.put("stmt_queryid", 				map.get("queryid"));
//						sessionAgent.insert("app.TB_QUERY_INFO_I001", inputParam);
						try{							
							HashMap<String, Object> fullQueryMap = null;
							inputParam.put("queryid", 	map.get("queryid"));
							fullQueryMap = sessionCollect.selectOne("app.BT_RTSTMT_INFO_QUERY_001", inputParam);
							if (fullQueryMap != null){
								inputParam.put("stmt_queryid", 			map.get("queryid"));
								inputParam.put("query", 			    fullQueryMap.get("query"));
								inputParam.put("queryid", 			    fullQueryMap.get("query"));
								sessionAgent.insert("app.TB_QUERY_INFO_I001", inputParam);
							}
						} catch (Exception e) {
							//log.error("", e);
							log.error("[instanceId ==>> " + instanceId + "]", e);
						} 
						
					}
					
					inputParam.put("stmt_queryid", 				map.get("queryid"));
					sessionAgent.insert("app.TB_QUERY_INFO_I002", inputParam);
					
					JSONObject stmtObj = new JSONObject();
					//stmtObj.put("userid"			 ,map.get("userid"));
					//stmtObj.put("dbid"               ,map.get("dbid"));
					stmtObj.put("userid"			 ,map.get("username"));
					stmtObj.put("dbid"               ,map.get("db_name"));
					stmtObj.put("queryid"		     ,map.get("queryid"));
					stmtObj.put("calls"		         ,map.get("calls"));
					stmtObj.put("total_time"         ,map.get("total_time"));
					stmtObj.put("min_time"           ,map.get("min_time"));
					stmtObj.put("max_time"           ,map.get("max_time"));
					stmtObj.put("mean_time"          ,map.get("mean_time"));
					stmtObj.put("stddev_time"        ,map.get("stddev_time"));
					stmtObj.put("rows"               ,map.get("rows"));
					stmtObj.put("shared_blks_hit"    ,map.get("shared_blks_hit"));
					stmtObj.put("shared_blks_read"   ,map.get("shared_blks_read"));
					stmtObj.put("shared_blks_dirtied",map.get("shared_blks_dirtied"));
					stmtObj.put("shared_blks_written",map.get("shared_blks_written"));
					stmtObj.put("local_blks_hit"     ,map.get("local_blks_hit"));
					stmtObj.put("local_blks_read"    ,map.get("local_blks_read"));
					stmtObj.put("local_blks_dirtied" ,map.get("local_blks_dirtied"));
					stmtObj.put("local_blks_written" ,map.get("local_blks_written"));
					stmtObj.put("temp_blks_read"     ,map.get("temp_blks_read"));
					stmtObj.put("temp_blks_written"  ,map.get("temp_blks_written"));
					stmtObj.put("blk_read_time"      ,map.get("blk_read_time"));
					stmtObj.put("blk_write_time"	 ,map.get("blk_write_time"));
					stmtArray.add(stmtObj);
				}		
			
				///////////////////////////////////////////////////////////////////////////////
				// TB_PGSS_INFO 정보 등록
				pgssCollect.put("instance_id", 				Integer.parseInt(reqInstanceId));
				pgssCollect.put("pgss", 				stmtArray.toString());
				sessionAgent.insert("app.TB_PGSS_INFO_I001", pgssCollect);					
				///////////////////////////////////////////////////////////////////////////////				

				//Commit
				sessionAgent.commit();
			} catch (Exception e) {
				sessionAgent.rollback();
				//log.error("", e);
				log.error("[instanceId ==>> " + instanceId + "]", e);
			}			
			
		} catch (Exception e) {
			//log.error("", e);
			log.error("[instanceId ==>> " + instanceId + "]", e);
		} finally {
			if(sessionAgent != null)	sessionAgent.close();
			if(sessionCollect != null)	sessionCollect.close();
		}
	}
}

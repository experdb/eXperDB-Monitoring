package experdb.mnt.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.logging.log4j.Logger;
import org.apache.logging.log4j.LogManager;

import experdb.mnt.LicenseInfoManager;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class VIPCollect{
	protected static Logger log = LogManager.getLogger(VIPCollect.class);	
	
	public VIPCollect() {
		//log.error("Check Primary VIP");
		execute(1);
		try{
			Thread.sleep(1000);
		} catch (Exception e) {
		}
		//log.("Check Secodary VIP");
		//execute(2);
		//log.info("Check VIP");
		
		checkSolution();
	}


	private void execute(int index) {
		SqlSessionFactory sqlSessionFactory = null;
		SqlSession sessionAgent  = null;
						
		try {
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			sessionAgent = sqlSessionFactory.openSession();
			List<HashMap<String, Object>> virtualSel = new ArrayList<HashMap<String,Object>>();
			///////////////////////////////////////////////////////////////////////////////////
			Connection conn = null;
			SqlSession session = null;	
			HashMap<String, Object> virtualStatusSel = null;
			// get cryptokey
			HashMap<String, Object> configMapForKey = new HashMap<String, Object>();
			configMapForKey = sessionAgent.selectOne("system.TB_CONFIG_R002");
			String cryptokey = (String)configMapForKey.get("serial_key");
			cryptokey = cryptokey.substring(0, 24);			
			// Service ip 정보 수집
			Map<String, Object> parameObjt = new HashMap<String, Object>();
			try {
				virtualSel = sessionAgent.selectList(index == 1 ? "app.TB_INSTANCE_INFO_R004" : "app.TB_INSTANCE_INFO_R005", parameObjt);
				if(virtualSel != null){
					for (HashMap<String, Object> groupMap : virtualSel) {
						try {
							Class.forName("org.postgresql.Driver");
							DriverManager.setLoginTimeout(3);
							String dbPass = groupMap.get("conn_user_pwd").toString();
							dbPass = LicenseInfoManager.decryptTDES(cryptokey, dbPass);
							conn = DriverManager.getConnection(
									"jdbc:postgresql://" + (index == 1 ? groupMap.get("virtual_ip").toString() : groupMap.get("virtual_ip2").toString()) + ":" + groupMap.get("service_port").toString() 
														 + "/" + groupMap.get("conn_db_name").toString() + "?socketTimeout=5", groupMap.get("conn_user_id").toString(),
														 dbPass);
							session = sqlSessionFactory.openSession(conn);
							virtualStatusSel = session.selectOne("app.EXPERDBMA_BT_CHECK_VIP_001");
							if(virtualStatusSel != null && !groupMap.get("host_name").equals(virtualStatusSel.get("host_name"))){
								groupMap.put("host_name", virtualStatusSel.get("host_name"));
							}
							groupMap.put("virtual_ip_stat", 1);
							if(conn != null) conn.close();
							if(session != null)	session.close();
						} catch (Exception e) {
							groupMap.put("virtual_ip_stat", 0);
							if(conn != null) conn.close();
							if(session != null)	session.close();
							log.error("[Connection timeout! : vip1:" + groupMap.get("virtual_ip") + ", vip2:"+  groupMap.get("virtual_ip2"));		
						}
										
			
						try {				
							if(groupMap != null){
								if(index == 1)
									sessionAgent.update("app.TB_INSTANCE_INFO_U003", groupMap);
								else
									sessionAgent.update("app.TB_INSTANCE_INFO_U004", groupMap);
								sessionAgent.commit();
							}				
						} catch (Exception e) {
							sessionAgent.rollback();
							log.error("", e);		
						}
					}
				}			
			} catch (Exception e) {
				log.error("", e);
			}
			
		} catch (Exception e) {
			log.error("", e);		
		} finally {
			if(sessionAgent != null)	sessionAgent.close();
		}
	}
	
	
	private void checkSolution() {
		SqlSession sessionCollect = null;
		SqlSession sessionAgent  = null;
		try {
			Connection connection = null;
			SqlSessionFactory sqlSessionFactory = SqlSessionManager.getInstance();
			List<HashMap<String, Object>> selectWithSol = new ArrayList<HashMap<String,Object>>();
			HashMap<String, Object> selectStatSol = new HashMap<String,Object>();
			HashMap<String, Object> solMap;
			sessionAgent = sqlSessionFactory.openSession();
			int withSol = 0, statSol = 0, statSolCollect = 0;
			//check solution all clusters
			selectWithSol = sessionAgent.selectList("app.TB_INSTANCE_INFO_S002");
			if(selectWithSol != null){
				for (HashMap<String, Object> map : selectWithSol) {
					int instanceId =  Integer.valueOf(map.get("instance_id").toString());
					//check the solution is installed or not.
					
					if (map.get("withsolutions") == null)
						continue;

					withSol = Integer.valueOf(map.get("withsolutions").toString());
					if (withSol <= 0)
						continue;
					
					//get the previous status of solution.
					if (map.get("statsolutions") == null)
						statSol = 0;
					else
						statSol = Integer.valueOf(map.get("statsolutions").toString());
					try{
						//get the current status of solution.
						connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + instanceId);
						sessionCollect = sqlSessionFactory.openSession(connection);
						sessionCollect.update("EXPERDBMA_BT_CREATE_FUNCTION_001");
						selectStatSol = sessionCollect.selectOne("app.EXPERDBMA_BT_CHECK_SOLUTION_001");
						statSolCollect = Integer.valueOf(selectStatSol.get("statsolutions").toString());
					} catch (Exception e) {
						sessionCollect.rollback();
					}
					
					if(sessionCollect != null)	sessionCollect.close();

					//compare the status of solution with previous.
					if (statSol == statSolCollect)
						continue;

					solMap = new HashMap<String,Object>();
					solMap.put("instance_id", instanceId);
					solMap.put("statsolutions", statSolCollect);
					
					//update the status of solution.
					sessionAgent.update("app.TB_INSTANCE_INFO_U005", solMap);
					//Commit
					sessionAgent.commit();
				}
			}
				
		} catch (Exception e) {
			sessionAgent.rollback();
			log.error("", e);				
		} finally {
			if(sessionAgent != null)	sessionAgent.close();
		}
	}
}

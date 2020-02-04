package experdb.mnt.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.log4j.Logger;

import experdb.mnt.LicenseInfoManager;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class VIPCollect{
	protected static Logger log = Logger.getLogger(VIPCollect.class);	
	
	public VIPCollect() {
		//log.error("Check Primary VIP");
		execute(1);
		try{
			Thread.sleep(1000);
		} catch (Exception e) {
		}
		//log.("Check Secodary VIP");
		execute(2);
		//log.info("Check VIP");
	}


	private void execute(int index) {
		SqlSessionFactory sqlSessionFactory = null;
		SqlSession sessionCollect = null;
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
							if(conn != null) conn.close();
							if(session != null)	session.close();
						} catch (Exception e) {
							groupMap.put("host_name", null);
							if(conn != null) conn.close();
							if(session != null)	session.close();
							log.error("[Connection timeout! :" + groupMap.get("virtual_ip") + groupMap.get("virtual_ip2"));		
						}
										
						try {				
							if(groupMap != null){
								if(groupMap.get("host_name") != null){
									if(index == 1)
										sessionAgent.update("app.TB_INSTANCE_INFO_U003", groupMap);
									else
										sessionAgent.update("app.TB_INSTANCE_INFO_U004", groupMap);
									sessionAgent.commit();
								}			
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
			if(sessionCollect != null)	sessionCollect.close();
		}
	}
}

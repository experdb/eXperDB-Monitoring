package experdb.mnt.listener.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

import org.apache.commons.codec.binary.Base64;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.ResourceInfo;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class DX005 implements SocketApplication{

	@Override
	public JSONArray perform(String tran_cd, String req_data) throws Exception {

		JSONParser parser=new JSONParser();
		Object reqDataObj=parser.parse(req_data);		
		JSONObject jReqDataObj = (JSONObject) reqDataObj;
		JSONArray resDataArray = new JSONArray();
		JSONObject resDataObj = new JSONObject();
		
		SqlSessionFactory sqlSessionFactory = null;
		SqlSession sessionAgent  = null;
		Connection connection = null;
		
		PreparedStatement ps1		= null;
		ResultSet rs1 				= null;		
		
		try {
			
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			sessionAgent = sqlSessionFactory.openSession();

			String instance_id = (String)jReqDataObj.get("instance_id");
			HashMap instanceMap = MonitoringInfoManager.getInstanceMap(instance_id);
			
			try {			
				String dbPass = "";
				
				if (jReqDataObj.get("password").equals("useDefaultAccount")){
					connection = DriverManager.getConnection(
							"jdbc:postgresql://" + instanceMap.get("server_ip") + ":" + instanceMap.get("service_port") + "/" + jReqDataObj.get("database"), 
							(String)instanceMap.get("conn_user_id"),
							(String)instanceMap.get("conn_user_pwd"));
				} else {
					connection = DriverManager.getConnection(
							"jdbc:postgresql://" + instanceMap.get("server_ip") + ":" + instanceMap.get("service_port") + "/" + jReqDataObj.get("database"), 
							(String) jReqDataObj.get("username"), 
							(String) jReqDataObj.get("password"));
				}			
			} catch (Exception e) {
				resDataObj.put("_error_cd", "DX005_E01");
				resDataObj.put("_error_msg", "DB에 접속할 수 없습니다.");
				resDataArray.add(resDataObj);
				log.error("", e);
				return resDataArray;
			}

			ps1 = connection.prepareStatement((String) jReqDataObj.get("sql"));
			
			
			try {
				rs1 = ps1.executeQuery();
			} catch (Exception e) {
				resDataObj.put("_error_cd", "DX005_E02");
				resDataObj.put("_error_msg", e.getMessage());
				resDataArray.add(resDataObj);
				log.error("", e);
				return resDataArray;
			}
			
			
			JSONArray queryListArray = new JSONArray();
			
			while(rs1.next()){
				JSONObject queryListObj = new JSONObject();
				queryListObj.put("queryplan",rs1.getString("QUERY PLAN"));
			
				queryListArray.add(queryListObj);
			}
			
			
			resDataObj.put("queryplan_list", queryListArray);
			resDataArray.add(resDataObj);
			
		} catch (Exception e) {
			log.error("", e);
			throw e;
		} finally {
			if(sessionAgent != null)	sessionAgent.close();
			
			if (ps1  != null) { try { ps1.close();  } catch (Exception e) {} }
			if (rs1  != null) { try { rs1.close();  } catch (Exception e) {} }
			if (connection  != null) { try { connection.close();  } catch (Exception e) {} }
		}
		
		resDataArray.add(resDataObj);
		return resDataArray;
	}

}

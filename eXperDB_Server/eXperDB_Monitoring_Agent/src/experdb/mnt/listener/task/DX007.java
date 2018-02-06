package experdb.mnt.listener.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.StringTokenizer;

import org.apache.commons.codec.binary.Base64;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

import experdb.mnt.LicenseInfoManager;
import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class DX007 implements SocketApplication{

	@Override
	public JSONArray perform(String tran_cd, String req_data) throws Exception {

		JSONParser parser=new JSONParser();
		Object reqDataObj=parser.parse(req_data);		
		JSONObject jReqDataObj = (JSONObject) reqDataObj;
		JSONArray resDataArray = new JSONArray();
		JSONObject resDataObj = new JSONObject();
		SqlSession sessionAgent  = null;
		
		
		SqlSessionFactory sqlSessionFactory = SqlSessionManager.getInstance();
		Connection connection = null;
		SqlSession sessionCollect = null;
		
		String instance_id = jReqDataObj.get("_InstanceId").toString();
		String Sequence = jReqDataObj.get("_Sequence").toString();
		String PID = jReqDataObj.get("_PID").toString();
		String ControlType = jReqDataObj.get("_ControlType").toString();
		String AccessType = jReqDataObj.get("_AccessType").toString();
		String RegDate = jReqDataObj.get("_RegDate").toString();
		
		HashMap instanceMap = MonitoringInfoManager.getInstanceMap(instance_id);
				
		try {
			Class.forName("org.postgresql.Driver");
			
			try {					
				connection = DriverManager.getConnection(
						"jdbc:postgresql://" + instanceMap.get("server_ip") + ":" + instanceMap.get("service_port") + "/" + instanceMap.get("conn_db_name"), 
						(String) instanceMap.get("conn_user_id"),
						(String)instanceMap.get("conn_user_pwd"));
				
				sessionCollect = sqlSessionFactory.openSession(connection);
			} catch (Exception e) {
				resDataObj.put("_error_cd", "DX007_E01");
				resDataObj.put("_error_msg", "Could not connect to the database.");
				log.error("", e);
				resDataArray.add(resDataObj);
				return resDataArray;	
			}	
							

			//if(regDateMap.get("max_reg_date") == null)	regDateMap.put("max_reg_date", "");
			
			HashMap<String, Object> ResultMap = null;
			
			HashMap<String, Object> inputParam = new HashMap<String, Object>();
		
			inputParam.put("pid", Integer.valueOf(PID));
			
			if (AccessType.equalsIgnoreCase("0")) {
				ResultMap = sessionCollect.selectOne("app.PG_CANCEL_QUERY_001", inputParam);
			}else if (AccessType.equalsIgnoreCase("1")){
				ResultMap = sessionCollect.selectOne("app.PG_TERMINATE_QUERY_001", inputParam);			
			}
			
			if (ResultMap.get("result").toString().equals("false")){
				resDataObj.put("_error_cd", "DX007_E02");
				resDataObj.put("_error_msg", "Failed to cancel/terminate the query.");				
				resDataArray.add(resDataObj);
				return resDataArray;
			}
			inputParam.clear();
			inputParam.put("reg_date", RegDate);
			inputParam.put("actv_reg_seq", Integer.valueOf(Sequence));
			inputParam.put("instance_id", Integer.valueOf(instance_id));
			inputParam.put("process_id", Integer.valueOf(PID));
			inputParam.put("control_type", ControlType);
			inputParam.put("access_type", AccessType);
			
			sessionAgent = sqlSessionFactory.openSession();
			sessionAgent.insert("app.TB_CONTROL_PROCESS_HIST_I001", inputParam);
			sessionAgent.commit();
		} catch (Exception e) {
			log.error("", e);
			resDataObj.put("_error_cd", "DX007_E03");
			resDataObj.put("_error_msg", "Failed to run control query.");				
			resDataArray.add(resDataObj);
			return resDataArray;
		} finally {
			if(connection != null) connection.close();
		}
		resDataArray.add(resDataObj);
		return resDataArray;	
	}
}
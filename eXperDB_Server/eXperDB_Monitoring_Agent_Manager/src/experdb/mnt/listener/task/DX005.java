package experdb.mnt.listener.task;

import java.sql.Connection;
import java.sql.DriverManager;
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

import experdb.mnt.ResourceInfo;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class DX005 implements SocketApplication{

	@Override
	public JSONObject perform(String tran_cd, String req_data) throws Exception {

		JSONParser parser=new JSONParser();
		Object reqDataObj=parser.parse(req_data);		
		JSONObject jReqDataObj = (JSONObject) reqDataObj;
		
		JSONObject resDataObj = new JSONObject();
		
		SqlSessionFactory sqlSessionFactory = null;
		SqlSession sessionAgent  = null;
		Connection connection = null;
		SqlSession sessionCollect = null;		
		
		try {
			
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			sessionAgent = sqlSessionFactory.openSession();

			String instance_id = (String)jReqDataObj.get("instance_id");
			
			List<Integer> inputParam = new ArrayList<Integer>();
			inputParam.add(Integer.valueOf(instance_id));
			
			HashMap<String, Object> selectMap = sessionAgent.selectOne("app.DX001_001", inputParam);			
			

			try {
				String dbPass = "";
				dbPass = (String) jReqDataObj.get("password");
				byte[] decoded = Base64.decodeBase64(dbPass.getBytes());
				dbPass =  new String(decoded);
				
				connection = DriverManager.getConnection(
						"jdbc:postgresql://" + selectMap.get("server_ip") + ":" + selectMap.get("service_port") + "/" + jReqDataObj.get("database"), 
						(String) jReqDataObj.get("username"),
						dbPass);
				
				sessionCollect = sqlSessionFactory.openSession(connection);
			} catch (Exception e) {
				resDataObj.put("_error_cd", "DX005_E01");
				resDataObj.put("_error_msg", "DB에 접속할 수 없습니다.");
				
				log.error("", e);
				return resDataObj;
			}
			
			HashMap<String, Object> queryParam = new HashMap<String, Object>();
			queryParam.put("query", (String) jReqDataObj.get("sql"));			
			
			List<HashMap<String, Object>> queryPlanList = new ArrayList<HashMap<String,Object>>();
			queryPlanList = sessionCollect.selectList("app.DX005_001", queryParam);
			
			JSONArray queryListArray = new JSONArray();
			
			for (HashMap<String, Object> map : queryPlanList) {
				JSONObject queryListObj = new JSONObject();
				queryListObj.put("queryplan", map.get("QUERY PLAN"));
			
				queryListArray.add(queryListObj);
			}
			
			
			resDataObj.put("queryplan_list", queryListArray);
			
		} catch (Exception e) {
			log.error("", e);
			throw e;
		} finally {
			if(sessionCollect != null)	sessionCollect.close();
			if(sessionAgent != null)	sessionAgent.close();
		}
		
		return resDataObj;
	}

}

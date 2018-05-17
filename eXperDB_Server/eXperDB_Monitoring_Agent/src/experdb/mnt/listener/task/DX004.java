package experdb.mnt.listener.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.List;

import org.apache.commons.codec.binary.Base64;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

import experdb.mnt.LicenseInfoManager;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class DX004 implements SocketApplication{

	@Override
	public JSONArray perform(String tran_cd, String req_data) throws Exception {

		JSONParser parser=new JSONParser();
		Object reqDataObj=parser.parse(req_data);		
		JSONObject jReqDataObj = (JSONObject) reqDataObj;
		JSONArray resDataArray = new JSONArray();
		JSONObject resDataObj = new JSONObject();
		
		SqlSessionFactory sqlSessionFactory = SqlSessionManager.getInstance();
		SqlSession session = sqlSessionFactory.openSession();		
		
		Connection connection = null;
		SqlSession sessionCollect = null;
		
		try {

			String dbPass = "";
			
			try {
				Class.forName("org.postgresql.Driver");
				
				dbPass = (String) jReqDataObj.get("password");
				HashMap<String, Object> configMapForKey = new HashMap<String, Object>();
				configMapForKey = session.selectOne("system.TB_CONFIG_R002");
				String cryptokey = (String)configMapForKey.get("serial_key");
				cryptokey = cryptokey.substring(0, 24);			
				dbPass = LicenseInfoManager.decryptTDES(cryptokey, dbPass);
				
				connection = DriverManager.getConnection(
						"jdbc:postgresql://" + jReqDataObj.get("targetip") + ":" + jReqDataObj.get("targetport") + "/" + jReqDataObj.get("database"), 
						(String) jReqDataObj.get("username"),
						dbPass);
				
				//sqlSessionFactory = SqlSessionManager.getInstance();
				sessionCollect = sqlSessionFactory.openSession(connection);
			} catch (Exception e) {
				resDataObj.put("_error_cd", "DX003_E01");
				resDataObj.put("_error_msg", "DB에 접속할 수 없습니다.");
				resDataArray.add(resDataObj);
				log.error("", e);
				return resDataArray;
			}
			
			List<HashMap<String, Object>> dbList = new ArrayList<HashMap<String,Object>>();
			dbList = sessionCollect.selectList("app.DX004_001");
			
			JSONArray dbListArray = new JSONArray();
			
			for (HashMap<String, Object> mapDB : dbList) {
				Connection connDB = null;
				SqlSession sessDB = null;
				
				try {
					connDB = DriverManager.getConnection(
							"jdbc:postgresql://" + jReqDataObj.get("targetip") + ":" + jReqDataObj.get("targetport") + "/" + mapDB.get("datname"), 
							(String) jReqDataObj.get("username"),
							dbPass);
					sessDB = sqlSessionFactory.openSession(connDB);
					
					List<HashMap<String, Object>> schemaList = new ArrayList<HashMap<String,Object>>();
					schemaList = sessionCollect.selectList("app.DX004_002");
					
					String schema = "";
					
					for (HashMap<String, Object> map : schemaList) {
						if(!schema.equals("")) schema = schema + "|";
						schema = schema + map.get("nspname");
					}
					
					JSONObject schemaListObj = new JSONObject();
					schemaListObj.put("dbname", mapDB.get("datname"));
					schemaListObj.put("schema", schema);
					
					dbListArray.add(schemaListObj);
				} catch (Exception e) {
					resDataObj.put("_error_cd", "DX003_E02");
					resDataObj.put("_error_msg", "DB에 접속할 수 없습니다.");
					resDataArray.add(resDataObj);
					log.error("", e);
					return resDataArray;					
				} finally {
					if(sessDB != null)	sessDB.close();
				}
				
			}
			
			resDataObj.put("db_list", dbListArray);
			resDataArray.add(resDataObj);
			
		} catch (Exception e) {
			log.error("", e);
			throw e;
		} finally {
			if(sessionCollect != null)	sessionCollect.close();
			if(session != null) session.close();
			if(connection != null) connection.close();
		}
		
		resDataArray.add(resDataObj);
		return resDataArray;
	}

}

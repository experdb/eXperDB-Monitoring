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

public class DX008 implements SocketApplication{

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
		HashMap<String, Object> ResultMap = null;
		
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
				resDataObj.put("_error_cd", "DX008_E01");
				resDataObj.put("_error_msg", "DB에 접속할 수 없습니다.");
				resDataArray.add(resDataObj);
				log.error("", e);
				return resDataArray;
			}
			
			HashMap<String, Object> inputParam = new HashMap<String, Object>();
			
			inputParam.put("query", (String) jReqDataObj.get("query"));
							
			ResultMap = sessionCollect.selectOne("app.DX005_001", inputParam);
			
			if (ResultMap.get("host") == null || ResultMap.get("port") == null){
				resDataObj.put("_error_cd", "DX008_E02");
				resDataObj.put("_error_msg", "Failed to execute the query.");				
				resDataArray.add(resDataObj);
				return resDataArray;
			}
			
			resDataObj.put("ha_host", ResultMap.get("host").toString());
			resDataObj.put("ha_port", ResultMap.get("port").toString());
		} catch (Exception e) {
			log.error("", e);
			resDataObj.put("_error_cd", "DX008_E03");
			resDataObj.put("_error_msg", "Failed to execute query.");				
			resDataArray.add(resDataObj);
			return resDataArray;
		} finally {
			if(connection != null) connection.close();
		}		
		resDataArray.add(resDataObj);
		return resDataArray;	
	}
}
package experdb.mnt.listener.task;

import java.sql.Connection;
import java.sql.DriverManager;

import org.apache.commons.codec.binary.Base64;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

public class DX003 implements SocketApplication{

	@Override
	public JSONObject perform(String tran_cd, String req_data) throws Exception {

		JSONParser parser=new JSONParser();
		Object reqDataObj=parser.parse(req_data);		
		JSONObject jReqDataObj = (JSONObject) reqDataObj;
		
		JSONObject resDataObj = new JSONObject();
		
		Connection connection = null;
		
		try {
			Class.forName("org.postgresql.Driver");
			
			String dbPass = (String) jReqDataObj.get("password");
			byte[] decoded = Base64.decodeBase64(dbPass.getBytes());
			dbPass =  new String(decoded);
			
			connection = DriverManager.getConnection(
					"jdbc:postgresql://" + jReqDataObj.get("targetip") + ":" + jReqDataObj.get("targetport") + "/" + jReqDataObj.get("database"), 
					(String) jReqDataObj.get("username"),
					dbPass);
			
		} catch (Exception e) {
			resDataObj.put("_error_cd", "DX003_E01");
			resDataObj.put("_error_msg", "DB에 접속할 수 없습니다.");
			
			log.error("", e);
		} finally {
			if(connection != null) connection.close();
		}

		return resDataObj;
	}

}

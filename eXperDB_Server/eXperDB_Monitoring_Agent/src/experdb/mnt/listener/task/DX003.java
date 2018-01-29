package experdb.mnt.listener.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.HashMap;

import org.apache.commons.codec.binary.Base64;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

import experdb.mnt.LicenseInfoManager;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class DX003 implements SocketApplication{

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
		
		try {
			//라이선스에 따른 instance 갯수를 확인한다.
			
			//시리얼키를 가져온다.
			////////////////////////////////////////////////////////////////////////////////////////
			HashMap<String, Object> serialKeyMap = session.selectOne("system.TB_CONFIG_R002");
			
			if(serialKeyMap == null || serialKeyMap.get("serial_key").equals("")){
				resDataObj.put("_error_cd", "DX003_E01");
				resDataObj.put("_error_msg", "등록된 License가 없습니다.");
				resDataArray.add(resDataObj);
				return resDataArray;
			}			
			
			String serialKey = LicenseInfoManager.decrypt((String) serialKeyMap.get("serial_key"));
			
			String INSTANCE     = serialKey.substring(57, 62);; //INSTANCE 개수(00000)
			
			if(!INSTANCE.equals("00000")){
				if(Integer.valueOf(INSTANCE) < Integer.valueOf((String) jReqDataObj.get("instance_cnt"))){
					resDataObj.put("_error_cd", "DX003_E02");
					resDataObj.put("_error_msg", "등록된 라이센스보다 인스턴스 갯수가 초과되었습니다.");
					resDataArray.add(resDataObj);
					return resDataArray;				
				}
			}
			
			
			//DB 접속 확인
			try {
				Class.forName("org.postgresql.Driver");
				
				String dbPass = (String) jReqDataObj.get("password");
				HashMap<String, Object> configMapForKey = new HashMap<String, Object>();
				configMapForKey = session.selectOne("system.TB_CONFIG_R002");
				String cryptokey = (String)configMapForKey.get("serial_key");
				cryptokey = cryptokey.substring(0, 24);			
				dbPass = LicenseInfoManager.decryptTDES(cryptokey, dbPass);
//				byte[] decoded = Base64.decodeBase64(dbPass.getBytes());
//				dbPass =  new String(decoded);
				
				connection = DriverManager.getConnection(
						"jdbc:postgresql://" + jReqDataObj.get("targetip") + ":" + jReqDataObj.get("targetport") + "/" + jReqDataObj.get("database"), 
						(String) jReqDataObj.get("username"),
						dbPass);
				
			} catch (Exception e) {
				resDataObj.put("_error_cd", "DX003_E03");
				resDataObj.put("_error_msg", "DB에 접속할 수 없습니다.");
				
				log.error("", e);
				resDataArray.add(resDataObj);
				return resDataArray;			
			}			
			
		} catch (Exception e) {
			log.error("", e);
			throw e;
		} finally {
			if(connection != null) connection.close();
			if(session != null)	session.close();
		}
		
		resDataArray.add(resDataObj);
		return resDataArray;

	}

}

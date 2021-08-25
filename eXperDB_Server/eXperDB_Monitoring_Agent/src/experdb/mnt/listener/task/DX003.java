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

	public class DB_TYPE
	{
	    public static final int MSS = -1;
	    public static final int ORA = -2;
	    public static final int MYSQL = -3;
	    public static final int POG = -4;
	}
	
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
			int intInstanceCount = Integer.valueOf((String)jReqDataObj.get("instance_cnt")); 
			if ( intInstanceCount > 0){
			
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
					if(Integer.valueOf(INSTANCE) < intInstanceCount){
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
			}else{
				//External DB 접속 확인
				try {
					String driver = "";
					String connectURL = "";
					switch (intInstanceCount) {
					case DB_TYPE.MSS :
						driver = "com.microsoft.sqlserver.jdbc.SQLServerDriver";
						connectURL = "jdbc:sqlserver://" + jReqDataObj.get("targetip")+":" + jReqDataObj.get("targetport") +";databaseName=" + jReqDataObj.get("database");
						break;
					case DB_TYPE.ORA :
						driver =  "oracle.jdbc.driver.OracleDriver" ;
						connectURL =  "jdbc:oracle:thin:@"+jReqDataObj.get("targetip")+":"+jReqDataObj.get("targetport")+"/"+jReqDataObj.get("database");
						break;
					case DB_TYPE.MYSQL :
						driver = "com.mysql.cj.jdbc.Driver";
						connectURL = "jdbc:mysql://"+ jReqDataObj.get("targetip") + ":" + jReqDataObj.get("targetport") + "/" + jReqDataObj.get("database");
						break;
					case DB_TYPE.POG :
						driver = "org.postgresql.Driver";
						connectURL = "jdbc:postgresql://" + jReqDataObj.get("targetip") + ":" + jReqDataObj.get("targetport") + "/" + jReqDataObj.get("database");
						break;
					}
					Class.forName(driver);

					String dbPass = (String) jReqDataObj.get("password");
					HashMap<String, Object> configMapForKey = new HashMap<String, Object>();
					configMapForKey = session.selectOne("system.TB_CONFIG_R002");
					String cryptokey = (String)configMapForKey.get("serial_key");
					cryptokey = cryptokey.substring(0, 24);			
					dbPass = LicenseInfoManager.decryptTDES(cryptokey, dbPass);
					
					DriverManager.setLoginTimeout(3);
					connection = DriverManager.getConnection(connectURL, (String) jReqDataObj.get("username"), dbPass);
					
				} catch (Exception e) {
					resDataObj.put("_error_cd", "DX003_E03");
					resDataObj.put("_error_msg", "DB에 접속할 수 없습니다.");
					
					log.error("", e);
					resDataArray.add(resDataObj);
					return resDataArray;			
				}
			}
			
		} catch (Exception e) {
			log.error("", e);
			throw e;
		} finally {
			if(session != null)	session.close();
			if(connection != null) connection.close();
		}
		
		resDataArray.add(resDataObj);
		return resDataArray;

	}

}

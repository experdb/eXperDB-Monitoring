package experdb.mnt.listener.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;
import java.util.StringTokenizer;

import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.ResourceInfo;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class DX006 implements SocketApplication{

	@Override
	public JSONArray perform(String tran_cd, String req_data) throws Exception {

		JSONParser parser=new JSONParser();
		
//		req_data = "{\"instance_list\":[{\"instance_id\":\"3\"}], \"_tran_sub_cd\": \"5\", \"datetime\": \"2017-05-17 19:04:59\"}";
//		req_data = "{\"instance_list\":[{\"instance_id\":\"3\"}], \"_tran_sub_cd\": \"6\", \"datetime\": \"2017-05-17 19:04:59\"}";
//		req_data = "{\"instance_list\":[{\"instance_id\":\"3\"}], \"_tran_sub_cd\": \"7\", \"filename\": \"pg_log/postgresql-2017-05-11_174130.log\", \"offset\": \"0\", \"len\": \"1000\"}";
		
		Object reqDataObj=parser.parse(req_data);		
		JSONObject jReqDataObj = (JSONObject) reqDataObj;
		JSONArray resDataArray = new JSONArray();
		JSONObject resDataObj = new JSONObject();
		
		SqlSessionFactory sqlSessionFactory = null;
		SqlSession sessionAgent  = null;
		
		try {
			// DB Connection을 가져온다NN
			sqlSessionFactory = SqlSessionManager.getInstance();
			sessionAgent = sqlSessionFactory.openSession();

			JSONArray instanceListArray = (JSONArray) jReqDataObj.get("instance_list");
			Iterator iterator = instanceListArray.iterator();
			
			String subCommand = jReqDataObj.get("_tran_sub_cd").toString();
			
			List<Integer> inputParam = new ArrayList<Integer>();
			
			while (iterator.hasNext()) {
			      JSONObject instanceIdObj = (JSONObject) iterator.next();
			      String instance_id = (String)instanceIdObj.get("instance_id");
			      inputParam.add(Integer.valueOf(instance_id));
			}
			
			List<HashMap<String, Object>> instanceList = new ArrayList<HashMap<String,Object>>(); //수집 인스턴스정보
			instanceList = sessionAgent.selectList("app.DX001_001", inputParam);			

			for (HashMap<String, Object> instanceMap : instanceList) {
				Connection connection = null;
				SqlSession sessionCollect = null;
				
				String is_collect_ok = "Y";
				String failed_collect_type = "";				
				
				String instance_db_version = "";
				String logDestination = "";
				
				try {
					Class.forName("org.postgresql.Driver");
					
					try {					
						connection = DriverManager.getConnection(
								"jdbc:postgresql://" + instanceMap.get("server_ip") + ":" + instanceMap.get("service_port") + "/" + instanceMap.get("conn_db_name"), 
								(String) instanceMap.get("conn_user_id"),
								(String) instanceMap.get("conn_user_pwd"));
						
						sessionCollect = sqlSessionFactory.openSession(connection);
					} catch (Exception e) {
						failed_collect_type = "0";
						is_collect_ok = "N";
						log.error("", e);
					}
					
					instance_db_version = (String) MonitoringInfoManager.getInstance().getInstanceMap(String.valueOf(instanceMap.get("instance_id"))).get("pg_version");
					List<HashMap<String, Object>> ResultList = new ArrayList<HashMap<String,Object>>();

					if(subCommand.equals("2")){

					}					
					/////////////////////////////////////////////////////
					// Check log_line_prefix
					else if(subCommand.equals("3")){
					
						return resDataArray;
					/////////////////////////////////////////////////////
					// Check log_directory
				   } else if(subCommand.equals("4")){

						return resDataArray;
					/////////////////////////////////////////////////////
					// Get log files
				   } else if(subCommand.equals("5")){
						ResultList = sessionCollect.selectList("app.PG_CHECK_EXTENSION_001");
						if (ResultList.isEmpty()){
							resDataObj.put("_error_cd", "DX006_E01");
							resDataObj.put("_error_msg", "Admin pack이 설치되지 않았습니다..");
							resDataArray.add(resDataObj);
							return resDataArray;
						}
						
						ResultList = sessionCollect.selectList("app.PG_CHECK_EXTENSION_002");
						if (ResultList.isEmpty()){
							sessionCollect.update("app.PG_CREATE_EXTENSION_001");
						}	
						
/*						ResultList = sessionCollect.selectList("app.PG_SHOW_LOGLINE_001");
						if (ResultList.isEmpty()){
							resDataObj.put("_error_cd", "DX006_E03");
							resDataObj.put("_error_msg", "log_line_prefix 조회에 실패했습니다..");
							resDataArray.add(resDataObj);
							return resDataArray;
						}
												
						ResultList = sessionCollect.selectList("app.PG_SHOW_DIRECTORY_001");
						if (ResultList.isEmpty()){
							resDataObj.put("_error_cd", "DX006_E04");
							resDataObj.put("_error_msg", "log_directory 조회에 실패했습니다..");
							resDataArray.add(resDataObj);
							return resDataArray;
						}*/
						
						logDestination = sessionCollect.selectOne("app.PG_LOG_DESTINATION_001");
						if (logDestination.isEmpty()){
							resDataObj.put("_error_cd", "DX006_E04");
							resDataObj.put("_error_msg", "log_destination 조회에 실패했습니다..");
							resDataArray.add(resDataObj);
							return resDataArray;
						}

						if( logDestination.equals("csvlog"))
							ResultList = sessionCollect.selectList("app.PG_GET_LOGFILES_003");
						else						
							ResultList = sessionCollect.selectList("app.PG_GET_LOGFILES_001");
						if (ResultList.isEmpty()){
							resDataObj.put("_error_cd", "DX006_E05");
							resDataObj.put("_error_msg", "log_directory 조회에 실패했습니다..");
							resDataArray.add(resDataObj);
							return resDataArray;
						}
						resDataObj.put("_tran_sub_cd", "5");
						resDataArray.add(resDataObj);
						resDataArray.addAll(ResultList);
						return resDataArray;
					/////////////////////////////////////////////////////
					// Read log file
				   } else if(subCommand.equals("6")){
						HashMap<String, Object> logfileParam = new HashMap<String, Object>();
						String logBuff = "", lineBuff = "";
						List<String> lineArray = new ArrayList<String>();
						String fileName = jReqDataObj.get("filename").toString();
						long reqOffSet = Long.parseLong(jReqDataObj.get("offset").toString());
						long reqReadLength = Long.parseLong(jReqDataObj.get("len").toString());
						long resOffSet = 0, lineLength = 0;
						long fileLength = 0;
						
						logfileParam.put("filename", fileName);
						logfileParam.put("logoffset", reqOffSet);
						logfileParam.put("length", reqReadLength);
						
						logDestination = sessionCollect.selectOne("app.PG_LOG_DESTINATION_001");
						if (logDestination.isEmpty()){
							resDataObj.put("_error_cd", "DX006_E04");
							resDataObj.put("_error_msg", "log_destination 조회에 실패했습니다..");
							resDataArray.add(resDataObj);
							return resDataArray;
						}

						if( logDestination.equals("csvlog"))
							logBuff = sessionCollect.selectOne("app.PG_GET_LOGFILES_004", logfileParam);
						else
							logBuff = sessionCollect.selectOne("app.PG_GET_LOGFILES_002", logfileParam);
						if (logBuff.length() <= 0){
							resDataObj.put("_error_cd", "DX006_E05");
							resDataObj.put("_error_msg", "log info 조회에 실패했습니다..");
							resDataArray.add(resDataObj);
							return resDataArray;
						}
						
						fileLength = Long.parseLong(logBuff);
						
						if(reqOffSet >= fileLength){
							resDataObj.put("_error_cd", "DX006_E06");
							resDataObj.put("_error_msg", "End of file.");
							resDataArray.add(resDataObj);
							return resDataArray;
						}
						
						logBuff = sessionCollect.selectOne("app.PG_READ_LOGFILE_001", logfileParam);
						if (logBuff.length() <= 0){
							resDataObj.put("_error_cd", "DX006_E07");
							resDataObj.put("_error_msg", "log_directory 조회에 실패했습니다..");
							resDataArray.add(resDataObj);
							return resDataArray;
						}							
						
						//logBuff = ResultList.get(0).get(key).;
						StringTokenizer st = new StringTokenizer(logBuff); 

						while(st.hasMoreTokens()) {
							lineBuff = st.nextToken("\n");
							byte[] temp = lineBuff.getBytes();
							lineLength = temp.length;
							if((!st.hasMoreTokens())){
								if(fileLength > (lineLength + reqOffSet + resOffSet + 1))
									break;
							}
							lineArray.add(lineBuff);
							resOffSet += (lineLength+1);						
						}						

						resDataObj.put("_tran_sub_cd", "6");
						resDataObj.put("offset", resOffSet);
						resDataArray.add(resDataObj);
						resDataArray.addAll(lineArray);
						return resDataArray;
					}
				} catch (Exception e) {
					resDataObj.put("_error_cd", "DX001_E01");
					resDataObj.put("_error_msg", "오브젝트 정보 조회중 오류가 발생하였습니다.");
					resDataArray.add(resDataObj);
					log.error("", e);
					
					return resDataArray;
				} finally {
					if(sessionCollect != null)	sessionCollect.close();
				}
				
			}
			
		} catch (Exception e) {
			log.error("", e);
			throw e;
		} finally {
			if(sessionAgent != null)	sessionAgent.close();
		}
		
		resDataArray.add(resDataObj);
		return resDataArray;
	}
}

package experdb.mnt.listener.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.Map;

import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.ResourceInfo;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class DX001 implements SocketApplication{

	@Override
	public JSONArray perform(String tran_cd, String req_data) throws Exception {

		JSONParser parser=new JSONParser();
		Object reqDataObj=parser.parse(req_data);		
		JSONObject jReqDataObj = (JSONObject) reqDataObj;
		JSONArray resDataArray = new JSONArray();
		JSONObject resDataObj = new JSONObject();
		
		SqlSessionFactory sqlSessionFactory = null;
		SqlSession sessionAgent  = null;
		
		try {
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			sessionAgent = sqlSessionFactory.openSession();

			JSONArray instanceListArray = (JSONArray) jReqDataObj.get("instance_list");
			Iterator iterator = instanceListArray.iterator();
			
			List<Integer> inputParam = new ArrayList<Integer>();
			
			while (iterator.hasNext()) {
			      JSONObject instanceIdObj = (JSONObject) iterator.next();
			      String instance_id = (String)instanceIdObj.get("instance_id");
			      inputParam.add(Integer.valueOf(instance_id));
			}
			
			List<HashMap<String, Object>> instanceList = new ArrayList<HashMap<String,Object>>(); //수집 인스턴스정보
			instanceList = sessionAgent.selectList("app.DX001_001", inputParam);			
			

			HashMap instanceMap = null;
			
			for(Integer instanceId: inputParam) {		
			//for (HashMap<String, Object> instanceMap : instanceList) {
				Connection connection = null;
				SqlSession sessionCollect = null;
				
				String is_collect_ok = "Y";
				String failed_collect_type = "";				
				
				String instance_db_version = "";
				
				instanceMap = MonitoringInfoManager.getInstanceMap(Integer.toString(instanceId));
				
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
					
					instance_db_version = (String) MonitoringInfoManager.getInstance().getInstanceMap(String.valueOf(instanceMap.get("instance_id"))).get("pg_version_min");
					
					List<HashMap<String, Object>> tablespaceSel = new ArrayList<HashMap<String,Object>>(); //TableSpace 수집
					List<HashMap<String, Object>> tableSel = new ArrayList<HashMap<String,Object>>(); //Table 수집
					List<HashMap<String, Object>> indexSel = new ArrayList<HashMap<String,Object>>(); //Index 수집
					
					if(is_collect_ok.equals("Y"))
					{
						//////////////////////////////////////////////////////////////////////////////////////////////////////////////
						// DB connection 정보
						List<HashMap<String, Object>> dbConnList = new ArrayList<HashMap<String,Object>>();
						dbConnList = sessionCollect.selectList("app.PG_STAT_DATABASE_INFO_001");
						
						for (HashMap<String, Object> mapDB : dbConnList) {
							Connection connDB = null;
							SqlSession sessDB = null;
							
							try {
								//DB 컨넥션을 가져온다.
								connDB = DriverManager.getConnection(
										"jdbc:postgresql://" + instanceMap.get("server_ip") + ":" + instanceMap.get("service_port") + "/" + mapDB.get("db_name"), 
										(String) instanceMap.get("conn_user_id"),
										(String) instanceMap.get("conn_user_pwd"));
								
								sessDB = sqlSessionFactory.openSession(connDB);
								
								///////////////////////////////////////////////////////////////////////////////
								// TABLE 정보수집
								List<HashMap<String, Object>> tableTempSel = new ArrayList<HashMap<String,Object>>();
								try {					
									tableTempSel = sessDB.selectList("app.BT_TABLE_INFO_001");
								} catch (Exception e) {
									failed_collect_type = "1";
									throw e;
								}					
									
								for (HashMap<String, Object> map : tableTempSel) {
									map.put("db_name",	mapDB.get("db_name"));
									
									map.put("current_seq_scan_cnt", 	0);
									map.put("current_seq_tuples", 		0);
									map.put("current_index_scan_cnt", 	0);
									map.put("current_index_tuples", 	0);									
									
									tableSel.add(map);
								}
								///////////////////////////////////////////////////////////////////////////////								

								///////////////////////////////////////////////////////////////////////////////
								// INDEX 정보수집
								HashMap<String, Object> inputIndexParam = new HashMap<String, Object>();
								inputIndexParam.put("db_name", mapDB.get("db_name"));
								
								List<HashMap<String, Object>> indexTempSel = new ArrayList<HashMap<String,Object>>();
								try {					
									indexTempSel = sessDB.selectList("app.BT_INDEX_INFO_001", inputIndexParam);
								} catch (Exception e) {
									failed_collect_type = "2";
									throw e;
								}						
								
								for (HashMap<String, Object> map : indexTempSel) {
									indexSel.add(map);
								}
								///////////////////////////////////////////////////////////////////////////////								
							} catch (Exception e1) {
								is_collect_ok = "N";
								log.error("", e1);
								break;
							} finally {
								sessDB.close();
							}								
						} //for END
						
						///////////////////////////////////////////////////////////////////////////////
						// TABLESPACE 정보 수집
						if(is_collect_ok.equals("Y")) {
							try {
								HashMap<String, Object> dbVerMap = new HashMap<String, Object>();
								dbVerMap.put("instance_db_version", instance_db_version);								
								
								tablespaceSel = sessionCollect.selectList("app.BT_TABLESPACE_INFO_001", dbVerMap);
							} catch (Exception e) {
								failed_collect_type = "2";
								is_collect_ok = "N";
								log.error("", e);
							}					
						}
						///////////////////////////////////////////////////////////////////////////////						
					} //if END

					
					try {
						
						///////////////////////////////////////////////////////////////////////////////
						// TB_RSC_COLLECT_INFO 정보 등록
						
						//금일자 최초 거래인지 확인
						HashMap<String, Object> regDateMap = sessionAgent.selectOne("app.TB_OBJT_COLLECT_INFO_S001");
						
						if(regDateMap.get("max_reg_date") == null)	regDateMap.put("max_reg_date", "");
						
						if(!regDateMap.get("max_reg_date").equals(regDateMap.get("reg_date")))
						{
							//금일자에 등록된 거래가 없는경우 시퀀스 초기화
							sessionAgent.selectList("app.SEQ_SETVAL_OBJT");
						}						
						
						Map<String, Object> parameObjt = new HashMap<String, Object>();
						parameObjt.put("instance_id", instanceMap.get("instance_id"));				
						parameObjt.put("is_collect_ok", is_collect_ok);				
						parameObjt.put("failed_collect_type", failed_collect_type);
						
						sessionAgent.insert("app.TB_OBJT_COLLECT_INFO_I001", parameObjt);
						
						if(is_collect_ok.equals("N"))
						{
							sessionAgent.commit();
							
							resDataObj.put("_error_cd", "DX001_E02");
							resDataObj.put("_error_msg", "오브젝트 정보 조회중 오류가 발생하였습니다.");
							resDataArray.add(resDataObj);
							return resDataArray;
						}				
						///////////////////////////////////////////////////////////////////////////////			
					
						
						///////////////////////////////////////////////////////////////////////////////
						// TABLESPACE 정보 등록
						for (HashMap<String, Object> map : tablespaceSel) {
							sessionAgent.insert("app.TB_TABLESPACE_INFO_I001", map);
						}
						///////////////////////////////////////////////////////////////////////////////			
					
						///////////////////////////////////////////////////////////////////////////////
						// TABLE 정보 등록
						for (HashMap<String, Object> map : tableSel) {
							sessionAgent.insert("app.TB_TABLE_INFO_I001", map);
						}
						///////////////////////////////////////////////////////////////////////////////				
						
						///////////////////////////////////////////////////////////////////////////////
						// INDEX 정보 등록
						for (HashMap<String, Object> map : indexSel) {
							sessionAgent.insert("app.TB_INDEX_INFO_I001", map);
						}
						///////////////////////////////////////////////////////////////////////////////				
						
					
						//Commit
						sessionAgent.commit();
					} catch (Exception e) {
						sessionAgent.rollback();
						log.error("", e);
						throw e;
					}					
					
				} catch (Exception e) {
					resDataObj.put("_error_cd", "DX001_E01");
					resDataObj.put("_error_msg", "오브젝트 정보 조회중 오류가 발생하였습니다.");
					
					log.error("", e);
					resDataArray.add(resDataObj);
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

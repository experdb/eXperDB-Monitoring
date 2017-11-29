package experdb.mnt.listener.task;

import java.io.BufferedReader;
import java.io.InputStream;
import java.io.InputStreamReader;
import java.io.OutputStream;

import org.apache.commons.codec.binary.Base64;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

public class MDX001 implements SocketApplication{

	@Override
	public JSONObject perform(String tran_cd, String req_data) throws Exception {

		JSONParser parser=new JSONParser();
		Object reqDataObj=parser.parse(req_data);		
		JSONObject jReqDataObj = (JSONObject) reqDataObj;
		
		JSONObject resDataObj = new JSONObject();
		

		try {

			String command = "";
			String cmd1 = System.getProperty("AGENT_HOME") + "bin/experdbma.sh ";
			String cmd2 = "";
			
			if(jReqDataObj.get("service").equals("1")) {
				// START
				cmd2 = "start";
			} else if(jReqDataObj.get("service").equals("2")) {
				// Stop
				cmd2 = "stop";
			} else if(jReqDataObj.get("service").equals("3")) {
				// Restart
				cmd2 = "restart";
			} else{
				resDataObj.put("_error_cd", "MDX003_E02");
				resDataObj.put("_error_msg", "등록된 서비스가 없습니다.");
				
				return resDataObj;
			}
			
			command = cmd1 + cmd2;
			
			InputStream is = null;
			BufferedReader br = null;
			
			try    
			{    
				
			    Runtime runtime= Runtime.getRuntime();    
			    Process process= runtime.exec(command); // 여기에서 외부 프로그램 실행
			    
//			    process.waitFor();
			    
			    is= process.getInputStream();    
			    br=new java.io.BufferedReader(new java.io.InputStreamReader(is));
			    
			    String tmp;    
			    while ((tmp=br.readLine()) != null )    
			    {    
			    	log.info(tmp);
			    	
			    	if(tmp.indexOf("Booting SUCCESS!!!") > 0)	break;
			    }    

			}    
			catch(Exception e)    
			{    
				log.error("", e);
				
				resDataObj.put("_error_cd", "MDX003_E03");
				resDataObj.put("_error_msg", "서비스 실행중 오류가 발생하였습니다.");
				
				return resDataObj;    
			} finally {
			    is.close();				
			    br.close();    
			}

	
		} catch (Exception e) {
			resDataObj.put("_error_cd", "MDX003_E01");
			resDataObj.put("_error_msg", "오류가 발생하였습니다. 관리자에게 문의 하시기 바랍니다.");
			
			log.error("", e);
		} finally {
			
		}

		return resDataObj;
	}

}

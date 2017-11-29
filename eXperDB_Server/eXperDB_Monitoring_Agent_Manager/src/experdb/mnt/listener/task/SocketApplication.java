package experdb.mnt.listener.task;

import org.apache.log4j.Logger;
import org.json.simple.JSONObject;

import experdb.mnt.task.TaskApplication;

public interface SocketApplication {
	public static Logger log = Logger.getLogger(SocketApplication.class);
	
	public JSONObject perform(String tran_cd, String req_data) throws Exception;
}

package experdb.mnt.listener.task;

import org.apache.logging.log4j.Logger;
import org.apache.logging.log4j.LogManager;
import org.json.simple.JSONObject;

import experdb.mnt.task.TaskApplication;

public interface SocketApplication {
	public static Logger log = LogManager.getLogger(SocketApplication.class);
	
	public JSONObject perform(String tran_cd, String req_data) throws Exception;
}

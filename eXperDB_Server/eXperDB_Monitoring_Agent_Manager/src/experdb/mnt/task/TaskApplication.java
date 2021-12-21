package experdb.mnt.task;

import org.apache.logging.log4j.Logger;
import org.apache.logging.log4j.LogManager;

public abstract class TaskApplication implements Runnable{
	protected static Logger log = LogManager.getLogger(TaskApplication.class);	
	
	protected String instanceId = "";
	protected String taskId = "";
	
	public TaskApplication(String instanceId, String taskId) {
		this.instanceId = instanceId;
		this.taskId = taskId;
	}
}

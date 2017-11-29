package experdb.mnt.task;

import org.apache.log4j.Logger;

public abstract class TaskApplication implements Runnable{
	protected static Logger log = Logger.getLogger(TaskApplication.class);	
	
	protected String instanceId = "";
	protected String taskId = "";
	
	public TaskApplication(String instanceId, String taskId) {
		this.instanceId = instanceId;
		this.taskId = taskId;
	}
}

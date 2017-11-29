package experdb.mnt.task;

import java.sql.Connection;
import java.sql.DriverManager;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Hashtable;
import java.util.List;
import java.util.Map;

import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.ResourceInfo;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class RscCollect extends TaskApplication {

	private static final String RESOURCE_KEY_MEMORY = "MEMORY";
	private static final String RESOURCE_KEY_CPU = "CPU";
	private static final String RESOURCE_KEY_DISK_IO = "DISK_IO";
	private static final String RESOURCE_KEY_DISK_USAGE = "DISK_USAGE";

	private String is_collect_ok = "Y";
	private String failed_collect_type = "";
	
	public RscCollect(String instanceId, String taskId) {
		super(instanceId, taskId);
	}

	@Override
	public void run() {
		
		long collectPeriod = (Integer)MonitoringInfoManager.getInstance().getInstanceMap(instanceId).get("collect_period_sec");
		
		long sleepTime;
		long startTime;
		long endTime;
		
		while (!MonitoringInfoManager.getInstance().isReLoad())
		{
			log.debug(System.currentTimeMillis());
			
			try {
				is_collect_ok = "Y";
				failed_collect_type = "";
				
				startTime =  System.currentTimeMillis();
				
				execute(); //수집 실행

				endTime =  System.currentTimeMillis();
				
				if((endTime - startTime) > (collectPeriod * 1000) )
				{
					//처리 시간이 수집주기보다 크면 바로처리
					continue;
				} else {
					sleepTime = (collectPeriod * 1000) - (endTime - startTime);
				}
			
				Thread.sleep(sleepTime);

			} catch (Exception e) {
				log.error("", e);
			}
		}
		
	}

	private void execute() {
		SqlSessionFactory sqlSessionFactory = null;
		Connection connection = null;
		SqlSession sessionCollect = null;
		SqlSession sessionAgent  = null;
		
		try {
			// DB Connection을 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			
			try {
				connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + instanceId);
				sessionCollect = sqlSessionFactory.openSession(connection);
			} catch (Exception e) {
				failed_collect_type = "0";
				is_collect_ok = "N";
				log.error("", e);
			}
			
			sessionAgent = sqlSessionFactory.openSession();
			
			
			
			List<HashMap<String, Object>> memorySel = new ArrayList<HashMap<String,Object>>();// 메모리 정보 수집
			List<HashMap<String, Object>> cpuSel = new ArrayList<HashMap<String,Object>>(); // CPU 정보 수집			
			List<HashMap<String, Object>> diskIoSel = new ArrayList<HashMap<String,Object>>(); //DISK_IO 정보 수집
			List<HashMap<String, Object>> diskUsageSel = new ArrayList<HashMap<String,Object>>();// DISK_USAGE 정보 수집			
			
			if(is_collect_ok.equals("Y"))
			{
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////
				// 이전값 확인
				List<HashMap<String, Object>> preList = new ArrayList<HashMap<String,Object>>();
				
				///////////////////////////////////////////////////////////////////////////////
				// CPU 이전값 확인
				if(ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_CPU) == null)
				{
					preList.clear();
					preList = sessionCollect.selectList("app.BT_CPU_STAT_001");
					
					HashMap<String, Object> tempCpu = new HashMap<String, Object>();
					for (HashMap<String, Object> map : preList) {
						//이전값 컬럼 : agg_user_util, agg_nice_util, agg_sys_util, agg_idle_util, agg_wait_util
						tempCpu.put(String.valueOf(map.get("cpu_logical_id")), map);
					}				
					
					ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_CPU, tempCpu);
					
					log.debug("cpu 최초 이전값  ==>>" + ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_CPU));
				}
				///////////////////////////////////////////////////////////////////////////////
	
				///////////////////////////////////////////////////////////////////////////////
				// DISK_IO 이전값 확인
				if(ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_DISK_IO) == null)
				{
					preList.clear();
					preList = sessionCollect.selectList("app.BT_DISK_IO_001");
	
					HashMap<String, Object> tempDiskIo = new HashMap<String, Object>();
					for (HashMap<String, Object> map : preList) {
						//이전값 컬럼 : agg_user_util, agg_nice_util, agg_sys_util, agg_idle_util, agg_wait_util
						tempDiskIo.put(String.valueOf(map.get("disk_name")), map);
					}				
					
					ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_DISK_IO, tempDiskIo);
				}
				///////////////////////////////////////////////////////////////////////////////
				
				
				
				//////////////////////////////////////////////////////////////////////////////////////////////////////////////			
				//서버를 모니터링한다.
				
				try {
					// 메모리 정보 수집
					try {
						memorySel = sessionCollect.selectList("app.BT_MEMORY_STAT_001");
					} catch (Exception e) {
						failed_collect_type = "1";
						throw e;
					}
					
					// cpu 정보 수집
					try {			
						cpuSel = sessionCollect.selectList("app.BT_CPU_STAT_001");
					} catch (Exception e) {
						failed_collect_type = "2";
						throw e;
					}
					
					// DISK_IO 정보 수집
					try {
						//이전값 가져오기
	//					Map<String, Object> preDiskIoTemp = new HashMap<String, Object>();
	//					preDiskIoTemp = (Map<String, Object>) ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_DISK_IO);
	//					
	//					HashMap<String, Object> diskIoSelInput = new HashMap<String, Object>();
	//					diskIoSelInput.put("collect_dt", preDiskIoTemp.get("collect_dt"));
						
						diskIoSel = sessionCollect.selectList("app.BT_DISK_IO_001");
					} catch (Exception e) {
						failed_collect_type = "3";
						throw e;
					}
					
					// DISK_USAGE 정보 수집
					try {			
						diskUsageSel= sessionCollect.selectList("app.BT_DISK_USAGE_001");
					} catch (Exception e) {
						failed_collect_type = "4";
						throw e;
					}
	
					
				} catch (Exception e1) {
					is_collect_ok = "N";
					log.error("", e1);
				}						 	
			}
			 
			
			try {
				Map<String, Object> parameAgent = new HashMap<String, Object>();

				Map<String, Object> preValue = new HashMap<String, Object>();
				
				///////////////////////////////////////////////////////////////////////////////
				// TB_RSC_COLLECT_INFO 정보 등록
				Map<String, Object> parameRsc = new HashMap<String, Object>();
				parameRsc.put("instance_id", Integer.valueOf(instanceId));
				parameRsc.put("is_collect_ok", is_collect_ok);				
				parameRsc.put("failed_collect_type", failed_collect_type);

				sessionAgent.insert("app.TB_RSC_COLLECT_INFO_I001", parameRsc);
				
				if(is_collect_ok.equals("N"))
				{
					sessionAgent.commit();
					return;
				}
				///////////////////////////////////////////////////////////////////////////////
				
				///////////////////////////////////////////////////////////////////////////////
				// 메모리 정보 등록
				for (HashMap<String, Object> map : memorySel) {
					sessionAgent.insert("app.TB_MEMORY_STAT_I001", map);
				}
				///////////////////////////////////////////////////////////////////////////////
				
				///////////////////////////////////////////////////////////////////////////////
				// CPU 정보 등록
				preValue.clear();
				preValue = (Map<String, Object>) ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_CPU);
				
				Map<String, Object> preSaveCpu = new HashMap<String, Object>();
				for (HashMap<String, Object> map : cpuSel) {
					HashMap<String, Object> tempMap = new HashMap<String, Object>();
					tempMap = (HashMap<String, Object>) preValue.get(String.valueOf(map.get("cpu_logical_id")));
					
					//이전값이 없는경우
					if(tempMap == null) {
						preSaveCpu.put(String.valueOf(map.get("cpu_logical_id")), map);
						
						continue;
					}
					
					double current_user_util = Double.valueOf(map.get("agg_user_util").toString()) - Double.valueOf(tempMap.get("agg_user_util").toString());
					double current_nice_util = Double.valueOf(map.get("agg_nice_util").toString()) - Double.valueOf(tempMap.get("agg_nice_util").toString());
					double current_sys_util = Double.valueOf(map.get("agg_sys_util").toString()) - Double.valueOf(tempMap.get("agg_sys_util").toString());
					double current_idle_util = Double.valueOf(map.get("agg_idle_util").toString()) - Double.valueOf(tempMap.get("agg_idle_util").toString());
					double current_wait_util = Double.valueOf(map.get("agg_wait_util").toString()) - Double.valueOf(tempMap.get("agg_wait_util").toString());
					
					double sum_current_util = current_user_util + current_nice_util + current_sys_util + current_idle_util + current_wait_util;
					
					
					double user_util_rate = 0;
					double nice_util_rate = 0;
					double sys_util_rate = 0;
					double idle_util_rate = 0;
					double wait_util_rate = 0;
					
					
					if(sum_current_util != 0)
					{
						user_util_rate = Math.round((current_user_util / sum_current_util * 100) * Math.pow(10, 2)) / Math.pow(10, 2);
						nice_util_rate = Math.round((current_nice_util / sum_current_util * 100) * Math.pow(10, 2)) / Math.pow(10, 2);
						sys_util_rate = Math.round((current_sys_util / sum_current_util * 100) * Math.pow(10, 2)) / Math.pow(10, 2);
						idle_util_rate = Math.round((current_idle_util / sum_current_util * 100) * Math.pow(10, 2)) / Math.pow(10, 2);
						wait_util_rate = Math.round((current_wait_util / sum_current_util * 100) * Math.pow(10, 2)) / Math.pow(10, 2);
					}
					
					map.put("current_user_util", current_user_util);
					map.put("current_nice_util", current_nice_util);
					map.put("current_sys_util", current_sys_util);
					map.put("current_idle_util", current_idle_util);
					map.put("current_wait_util", current_wait_util);
					
					map.put("user_util_rate", user_util_rate);
					map.put("nice_util_rate", nice_util_rate);
					map.put("sys_util_rate", sys_util_rate);
					map.put("idle_util_rate", idle_util_rate);
					map.put("wait_util_rate", wait_util_rate);
					
					
					if(String.valueOf(map.get("cpu_logical_id")).equals("1")){
						sessionAgent.insert("app.TB_CPU_STAT_MASTER_I001", map);
					} else
					{
						sessionAgent.insert("app.TB_CPU_STAT_DETAIL_I001", map);
					}
					
					preSaveCpu.put(String.valueOf(map.get("cpu_logical_id")), map);
					
					log.debug("cpu 이전값 map   ==>>" + tempMap);
					log.debug("cpu 정보등록 map ==>>" + map);
				}
				
				ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_CPU, preSaveCpu);
				///////////////////////////////////////////////////////////////////////////////				

				///////////////////////////////////////////////////////////////////////////////
				// DISK_IO 정보 등록
				preValue.clear();
				preValue = (Map<String, Object>) ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_DISK_IO);				
				
				Map<String, Object> preSaveDiskIo = new HashMap<String, Object>();
				for (HashMap<String, Object> map : diskIoSel) {
					HashMap<String, Object> tempMap = new HashMap<String, Object>();
					tempMap = (HashMap<String, Object>) preValue.get(String.valueOf(map.get("disk_name")));
					
					//이전값이 없는경우
					if(tempMap == null) {
						preSaveDiskIo.put(String.valueOf(map.get("disk_name")), map);
						preSaveDiskIo.put("collect_dt", map.get("collect_dt"));
						
						continue;
					}					
					
					double current_read_kb = Double.valueOf(map.get("agg_read_kb").toString()) - Double.valueOf(tempMap.get("agg_read_kb").toString());
					double current_write_kb = Double.valueOf(map.get("agg_write_kb").toString()) - Double.valueOf(tempMap.get("agg_write_kb").toString());
					double current_io_msec = Double.valueOf(map.get("agg_io_msec").toString()) - Double.valueOf(tempMap.get("agg_io_msec").toString());
					
					double sec_diff = Double.valueOf(map.get("sec_from_epoch").toString()) - Double.valueOf(tempMap.get("sec_from_epoch").toString());
					
					double read_busy_rate = 0;
					double write_busy_rate = 0;

					if(sec_diff != 0)
					{
						double rate = (current_io_msec / 1000) / sec_diff;
						if (rate > 1) 	rate = 1.0;
						
						read_busy_rate = Math.round((current_read_kb / (current_write_kb+current_read_kb ) * (rate) * 100) * Math.pow(10, 2)) / Math.pow(10, 2);
						write_busy_rate = Math.round((current_write_kb / (current_write_kb+current_read_kb ) * (rate) * 100) * Math.pow(10, 2)) / Math.pow(10, 2);						
					}
					
					map.put("current_read_kb", current_read_kb);
					map.put("current_write_kb", current_write_kb);
					map.put("current_io_msec", current_io_msec);
					
					map.put("read_busy_rate", read_busy_rate);
					map.put("write_busy_rate", write_busy_rate);
					
					map.put("delta_time", sec_diff);
					
					sessionAgent.insert("app.TB_DISK_IO_I001", map);
					
					log.debug("DISK_IO__ 이전값 map ==>>" + tempMap);
					log.debug("DISK_IO__ 등록값 map ==>>" + map);					
					
					preSaveDiskIo.put(String.valueOf(map.get("disk_name")), map);
					preSaveDiskIo.put("collect_dt", map.get("collect_dt"));
				}
				
				ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_DISK_IO, preSaveDiskIo);
				///////////////////////////////////////////////////////////////////////////////				
				
				///////////////////////////////////////////////////////////////////////////////
				// DISK_USAGE 정보 등록
				for (HashMap<String, Object> map : diskUsageSel) {
					sessionAgent.insert("app.TB_DISK_USAGE_I001", map);
				}
				///////////////////////////////////////////////////////////////////////////////				
				
				log.debug(ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_CPU));
				log.debug(ResourceInfo.getInstance().get(instanceId, taskId, RESOURCE_KEY_DISK_IO));
				
				//Commit
				sessionAgent.commit();
			} catch (Exception e) {
				sessionAgent.rollback();
				log.error("", e);
			}

		} catch (Exception e) {
			log.error("", e);
		} finally {
			if(sessionAgent != null)	sessionAgent.close();
			if(sessionCollect != null)	sessionCollect.close();
		}
	}
}

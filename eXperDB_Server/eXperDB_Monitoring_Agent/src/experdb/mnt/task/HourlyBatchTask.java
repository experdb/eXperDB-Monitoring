package experdb.mnt.task;

import java.sql.Connection;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.HashMap;
import java.util.List;

import org.apache.ibatis.session.ExecutorType;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.log4j.Logger;

import experdb.mnt.LicenseInfoManager;
import experdb.mnt.db.mybatis.SqlSessionManager;

import java.util.Enumeration;
import experdb.mnt.MonitoringInfoManager;
import java.sql.DriverManager;
public class HourlyBatchTask {

	protected static Logger log = Logger.getLogger(HourlyBatchTask.class);	
	
	private String status = "2"; // 1:진행중 / 2:정상종료 / 3:오류
	private String comments = ""; // 오류세부 정보 : 0:데몬기동 / 1:접속종료 / 2:데이터삭제 / 3: VACUUM&ANALYZE /  4: 시퀀스초기화/ 5:인스턴스정보 UPDATE / 6: 접속수립 / 9:데몬종료
	private String reg_date = ""; // 오늘날짜
	
	public HourlyBatchTask() {
		execute();
		check_partiton();
	}
	
	private void execute() {
		SqlSession sessionAgent  = null;
		
		//Manage real time statements 
		try {
			//Check whether collect real time statements.
			Enumeration		en = MonitoringInfoManager.getInstance().getInstanceId();
			int period = 0;
			while (en.hasMoreElements()) {
				period = (Integer)MonitoringInfoManager.getInstance().getInstanceMap((String)en.nextElement()).get("rtstmt_period_sec");
				if (period > 0)
					break;
			}
			
			if (period == 0)
				return ;
			
			Date currentHour = new Date();
			Date nextHour = new Date(currentHour.getTime() + (1000 * 60 * 60));
			Date oldHour = new Date(currentHour.getTime() - (1000 * 60 * 60 * 8));
			SimpleDateFormat transFormat = new SimpleDateFormat("yyyyMMddHH");
			String new_date = transFormat.format(nextHour);
			String now_date = transFormat.format(currentHour);
			String old_date = transFormat.format(oldHour);
			HashMap<String, Object> partitionTableMap = new HashMap<String, Object>();
			partitionTableMap.put("new_date", new_date);
			partitionTableMap.put("now_date", now_date);
			partitionTableMap.put("old_date", old_date);
			partitionTableMap.put("tablename", "tb_realtime_statements");
			
			// DB Connection을 가져온다
			sessionAgent = SqlSessionManager.getInstance().openSession();		
			try {
				// Create new partition tables and Truncate old partition
				sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);
				sessionAgent.commit();
			} catch (Exception e) {
				sessionAgent.rollback();
				log.error("", e);
			}
			sessionAgent.close();
			
			sessionAgent = SqlSessionManager.getInstance().openSession(ExecutorType.SIMPLE, true);
			try {
				// Create index of partition tables
				sessionAgent.update("app.PG_INDEX_TB_REALTIME_STATEMENTS_PARTITIONS_001", partitionTableMap);//CREATE INDEX idx01_realtime_statements ON tb_realtime_statements USING btree (collect_dt DESC);
				sessionAgent.commit();
			} catch (Exception e) {
				sessionAgent.rollback();
				log.error("", e);
				
				status = "3";
				comments = "2";
			}
			
			sessionAgent.close();
			sessionAgent = SqlSessionManager.getInstance().openSession(ExecutorType.SIMPLE, true);

		} catch (Exception e) {
			log.error("", e);
		} finally {
			if(sessionAgent != null) sessionAgent.close();
		}
	}
	
	private void check_partiton() {
		SqlSession sessionAgent  = null;
		
		boolean isExists = false;
		try {
			sessionAgent = SqlSessionManager.getInstance().openSession();		
			
			HashMap<String, Object> checkMap = new HashMap<String, Object>();
			HashMap<String, Object> checkReturnMap = new HashMap<String, Object>();
			Date today = new Date();
			SimpleDateFormat transFormat = new SimpleDateFormat("yyyyMMdd");
			String now_date = transFormat.format(today);
			HashMap<String, Object> partitionTableMap = new HashMap<String, Object>();
			checkMap.put("regdate", now_date);			
			checkMap.put("tablename", "tb_access_info");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_actv_collect_info");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_backend_rsc");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_checkpoint_info");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_cpu_stat_detail");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_cpu_stat_master");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_current_lock");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_disk_io");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_disk_usage");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_hchk_alert_info");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_hchk_collect_info");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_memory_stat");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_objt_collect_info");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_pg_stat_statements");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_replication_info");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_replication_lag_info");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_rsc_collect_info");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			checkMap.put("tablename", "tb_table_ext_info");
			checkReturnMap = sessionAgent.selectOne("app.TB_CHECK_PARTITION_R001", checkMap);
			isExists = true;
		} catch (Exception e) {
			log.error("", e);			
		} finally {
			if(sessionAgent != null) sessionAgent.close();
		}
		try {
			if (isExists == false){
				// DB Connection을 가져온다
				sessionAgent = SqlSessionManager.getInstance().openSession();		
	
				Date currentHour = new Date();
				Date oldHour = new Date(currentHour.getTime() - (1000 * 60 * 60 * 8));
				SimpleDateFormat transFormat = new SimpleDateFormat("yyyyMMdd");
				String now_date = transFormat.format(currentHour);
				String old_date = transFormat.format(oldHour);
				HashMap<String, Object> partitionTableMap = new HashMap<String, Object>();
				partitionTableMap.put("new_date", now_date);
				partitionTableMap.put("now_date", now_date);
		
				sessionAgent.close();
				sessionAgent = SqlSessionManager.getInstance().openSession(ExecutorType.SIMPLE, true);
				
				try {
					// Create partition tables
					partitionTableMap.put("tablename", "tb_actv_collect_info");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);
					partitionTableMap.put("tablename", "tb_checkpoint_info");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);
					partitionTableMap.put("tablename", "tb_current_lock");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);
					partitionTableMap.put("tablename", "tb_backend_rsc");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);
					partitionTableMap.put("tablename", "tb_objt_collect_info");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);
					partitionTableMap.put("tablename", "tb_access_info");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);
					partitionTableMap.put("tablename", "tb_rsc_collect_info");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);
					partitionTableMap.put("tablename", "tb_memory_stat");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);				
					partitionTableMap.put("tablename", "tb_cpu_stat_master");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);				
					partitionTableMap.put("tablename", "tb_cpu_stat_detail");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);				
					partitionTableMap.put("tablename", "tb_disk_io");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);				
					partitionTableMap.put("tablename", "tb_disk_usage");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);				
					partitionTableMap.put("tablename", "tb_hchk_collect_info");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);				
					partitionTableMap.put("tablename", "tb_hchk_alert_info");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);				
					partitionTableMap.put("tablename", "tb_replication_info");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);				
					partitionTableMap.put("tablename", "tb_replication_lag_info");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);				
					partitionTableMap.put("tablename", "tb_pg_stat_statements");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);				
					partitionTableMap.put("tablename", "tb_table_ext_info");
					sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_002", partitionTableMap);	
					
					sessionAgent.commit();
				} catch (Exception e) {
					sessionAgent.rollback();
					log.error("", e);
				}
				sessionAgent.close();
				sessionAgent = SqlSessionManager.getInstance().openSession(ExecutorType.SIMPLE, true);
				
				try {
					
					// Add constraint of partition tables
					partitionTableMap.put("regdate", "_" + now_date);
					sessionAgent.update("app.PG_CONSTRAINT_TB_ACTV_COLLECT_INFO_001" , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_ACCESS_INFO_001"       , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_BACKEND_RSC_001"       , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_CPU_STAT_DETAIL_001"   , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_CPU_STAT_MASTER_001"   , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_DISK_IO_001"           , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_DISK_USAGE_001"        , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_HCHK_COLLECT_INFO_001" , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_REPLICATION_INFO_001"  , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_REPLICATION_LAG_INFO_001"  , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_CHECKPOINT_INFO_001"   , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_MEMORY_STAT_001"       , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_OBJT_COLLECT_INFO_001" , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_RSC_COLLECT_INFO_001"  , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_TABLE_EXT_INFO_001"    , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_HCHK_ALERT_INFO_001"   , partitionTableMap);
					sessionAgent.update("app.PG_CONSTRAINT_TB_PG_STAT_STATEMENTS_001", partitionTableMap);
					// Create index of partition tables
					
					sessionAgent.update("app.PG_CREATE_FUNCTION_FOR_INDEX_001"  , partitionTableMap);
					sessionAgent.update("app.PG_INDEX_TB_CURRENT_LOCK_001"      , partitionTableMap);
					sessionAgent.update("app.PG_INDEX_TB_CURRENT_LOCK_002"      , partitionTableMap);
					sessionAgent.update("app.PG_INDEX_TB_BACKEND_RSC_001"       , partitionTableMap);
					sessionAgent.update("app.PG_INDEX_TB_ACCESS_INFO_001"       , partitionTableMap);
					sessionAgent.update("app.PG_INDEX_TB_MEMORY_STAT_001"       , partitionTableMap);
					sessionAgent.update("app.PG_INDEX_TB_CPU_STAT_MASTER_001"   , partitionTableMap);
					sessionAgent.update("app.PG_INDEX_TB_DISK_IO_001"           , partitionTableMap);
					sessionAgent.update("app.PG_INDEX_TB_DISK_USAGE_001"        , partitionTableMap);
					sessionAgent.update("app.PG_INDEX_TB_TABLE_EXT_INFO_001"    , partitionTableMap);
					sessionAgent.update("app.PG_INDEX_TB_ACTV_COLLECT_INFO_001"    , partitionTableMap);
					sessionAgent.update("app.PG_INDEX_TB_RSC_COLLECT_INFO_001"    , partitionTableMap);
					//Commit
					sessionAgent.commit();
				} catch (Exception e) {
					sessionAgent.rollback();
					log.error("", e);
				}
			}
			sessionAgent.close();			
		} catch (Exception e) {
			log.error("", e);
		} finally {
			if(sessionAgent != null) sessionAgent.close();
		}
	}
}

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
import org.apache.logging.log4j.Logger;
import org.apache.logging.log4j.LogManager;

import experdb.mnt.db.mybatis.SqlSessionManager;

public class DailyBatchTask {

	protected static Logger log = LogManager.getLogger(DailyBatchTask.class);	
	
	public DailyBatchTask() {
		execute();
	}
	
	private void execute() {
		try {
			create_partitions();
			create_partitions_indexs();
			delete_trend_logs();
		} catch (Exception e) {
			log.error("", e);
		}
	}
	
	private void create_partitions()
	{
		SqlSession sessionAgent  = null;
		sessionAgent = SqlSessionManager.getInstance().openSession(ExecutorType.SIMPLE, true);
		
		try {
			log.info("Start to Create partitions");
			sessionAgent.selectList("app.TB_TERMINATE_OTHER_SESSIONS_001");
			log.info("Blocked other sessions to make partition tables");
			// Create partition tables
			HashMap<String, Object> partitionTableMap = new HashMap<String, Object>();
			partitionTableMap.put("tablename", "tb_actv_collect_info");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);
			partitionTableMap.put("tablename", "tb_checkpoint_info");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);
			partitionTableMap.put("tablename", "tb_current_lock");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);
			partitionTableMap.put("tablename", "tb_backend_rsc");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);
			partitionTableMap.put("tablename", "tb_objt_collect_info");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);
			partitionTableMap.put("tablename", "tb_access_info");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);
			partitionTableMap.put("tablename", "tb_rsc_collect_info");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);
			partitionTableMap.put("tablename", "tb_memory_stat");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);				
			partitionTableMap.put("tablename", "tb_cpu_stat_master");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);				
			partitionTableMap.put("tablename", "tb_cpu_stat_detail");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);				
			partitionTableMap.put("tablename", "tb_disk_io");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);				
			partitionTableMap.put("tablename", "tb_disk_usage");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);				
			partitionTableMap.put("tablename", "tb_hchk_collect_info");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);				
			partitionTableMap.put("tablename", "tb_hchk_alert_info");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);				
			partitionTableMap.put("tablename", "tb_replication_info");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);				
			partitionTableMap.put("tablename", "tb_replication_lag_info");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);				
			partitionTableMap.put("tablename", "tb_pg_stat_statements");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);				
			partitionTableMap.put("tablename", "tb_table_ext_info");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);	
			partitionTableMap.put("tablename", "tb_wal_info");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);
			partitionTableMap.put("tablename", "tb_query_info");
			sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);
			sessionAgent.commit();
			log.info("Created daily partition tables");
			//real time partition table
			partitionTableMap.put("tablename", "tb_realtime_statements");
			sessionAgent.update("app.PG_ATTACH_PARTITIONS_002", partitionTableMap);	
			sessionAgent.update("app.PG_DETACH_PARTITIONS_002", partitionTableMap);
			sessionAgent.commit();
			log.info("End to Create partitions");
		} catch (Exception e) {
			sessionAgent.rollback();
			log.error("", e);			
		} finally {
			sessionAgent.close();
		}
	}
	
	private void create_partitions_indexs()
	{
		SqlSession sessionAgent  = null;
		sessionAgent = SqlSessionManager.getInstance().openSession(ExecutorType.SIMPLE, true);
		try {
			log.info("Start to make constraints and indexes");
			// Add constraint of partition tables
			Date today = new Date();
			Date tomorrow = new Date(today.getTime() + (1000 * 60 * 60 * 24));
			SimpleDateFormat transFormat = new SimpleDateFormat("yyyyMMdd");
			String new_date = transFormat.format(tomorrow);
			HashMap<String, Object> partitionTableMap = new HashMap<String, Object>();
			partitionTableMap.put("regdate", "_" + new_date);
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
			sessionAgent.update("app.PG_CONSTRAINT_TB_WAL_INFO_001"			 , partitionTableMap);
			sessionAgent.update("app.PG_CONSTRAINT_TB_QUERY_INFO_001"		 , partitionTableMap);

			// Create index of partition tables
			sessionAgent.update("app.PG_CREATE_FUNCTION_FOR_INDEX_001"  , partitionTableMap);
			sessionAgent.update("app.PG_INDEX_TB_ACTV_COLLECT_INFO_001"    , partitionTableMap);
			sessionAgent.update("app.PG_INDEX_TB_RSC_COLLECT_INFO_001"    , partitionTableMap);
			sessionAgent.update("app.PG_INDEX_TB_CURRENT_LOCK_001"      , partitionTableMap);
			sessionAgent.update("app.PG_INDEX_TB_CURRENT_LOCK_002"      , partitionTableMap);
			sessionAgent.update("app.PG_INDEX_TB_BACKEND_RSC_001"       , partitionTableMap);
			sessionAgent.update("app.PG_INDEX_TB_ACCESS_INFO_001"       , partitionTableMap);
			sessionAgent.update("app.PG_INDEX_TB_MEMORY_STAT_001"       , partitionTableMap);
			sessionAgent.update("app.PG_INDEX_TB_CPU_STAT_MASTER_001"   , partitionTableMap);
			sessionAgent.update("app.PG_INDEX_TB_DISK_IO_001"           , partitionTableMap);
			sessionAgent.update("app.PG_INDEX_TB_DISK_USAGE_001"        , partitionTableMap);
			sessionAgent.update("app.PG_INDEX_TB_TABLE_EXT_INFO_001"    , partitionTableMap);
			sessionAgent.update("app.PG_INDEX_TB_REPLICATION_INFO_001"       , partitionTableMap);
			//Commit
			sessionAgent.commit();
			//real time partition table
			sessionAgent.update("app.PG_INDEX_TB_REALTIME_STATEMENTS_PARTITIONS_001", partitionTableMap);			
			sessionAgent.commit();
			log.info("End to make constraints and indexes");
		} catch (Exception e) {
			sessionAgent.rollback();
			log.error("", e);
		} finally {
			sessionAgent.close();
		}
	}	
	
	private void delete_trend_logs()
	{
		SqlSession sessionAgent  = null;
		sessionAgent = SqlSessionManager.getInstance().openSession(ExecutorType.SIMPLE, true);
		
		try {
			log.info("Start to delete trend logs");
			sessionAgent.selectList("app.TB_TERMINATE_OTHER_SESSIONS_001");
			log.info("Blocked other sessions to delete trend logs");
			// delete trend logs
			sessionAgent.delete("app.PG_MAINTAIN_TRENDLOG_D001");
			sessionAgent.delete("app.PG_MAINTAIN_TRENDLOG_D002");
			sessionAgent.update("app.VACUUM_ANALYZE_TRENDLOG_U001");
			sessionAgent.update("app.VACUUM_ANALYZE_TRENDLOG_U002");
			sessionAgent.commit();
			log.info("End to delete trend logs");
		} catch (Exception e) {
			sessionAgent.rollback();
			log.error("", e);			
		} finally {
			sessionAgent.close();
		}
	}
}

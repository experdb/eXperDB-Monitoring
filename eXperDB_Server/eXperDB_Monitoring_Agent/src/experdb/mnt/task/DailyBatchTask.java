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
public class DailyBatchTask {

	protected static Logger log = Logger.getLogger(DailyBatchTask.class);	
	
	private String status = "2"; // 1:진행중 / 2:정상종료 / 3:오류
	private String comments = ""; // 오류세부 정보 : 0:데몬기동 / 1:접속종료 / 2:데이터삭제 / 3: VACUUM&ANALYZE /  4: 시퀀스초기화/ 5:인스턴스정보 UPDATE / 6: 접속수립 / 9:데몬종료
	private String reg_date = ""; // 오늘날짜
	
	public DailyBatchTask() {
		execute();
	}
	
	private void execute() {
		SqlSession sessionAgent  = null;
		
		try {
			// 라이센스 검증
			try {
				LicenseInfoManager.licenseVerification();
			} catch (Exception e) {
				log.error("", e);
			}			
			
			// DB Connection을 가져온다
			sessionAgent = SqlSessionManager.getInstance().openSession();		

			Calendar cal = Calendar.getInstance();
			cal.setTime( new Date(System.currentTimeMillis()) );
			reg_date = new SimpleDateFormat("yyyyMMdd").format( cal.getTime());

			
			try {
				//TB_SYS_LOG 시작 insert
				HashMap<String, Object> insertMap = new HashMap<String, Object>();
				insertMap.put("reg_date", reg_date);
				
				sessionAgent.insert("app.TB_SYS_LOG_I001", insertMap);
				
				//Commit
				sessionAgent.commit();
			} catch (Exception e) {
				sessionAgent.rollback();
				log.error("", e);
				throw e;
			}			
						
			try {
				Enumeration		en = MonitoringInfoManager.getInstance().getInstanceId();
				Connection connection = null;
				SqlSession sessionCollect = null;
				SqlSessionFactory sqlSessionFactory = SqlSessionManager.getInstance();
				List<HashMap<String, Object>> selectUser = new ArrayList<HashMap<String,Object>>();

				while (en.hasMoreElements()) {
					String instanceId =  (String) en.nextElement();
					connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + instanceId);
					sessionCollect = sqlSessionFactory.openSession(connection);
					selectUser = sessionCollect.selectList("app.EXPERDBMA_BT_GET_PGUSER_001");
					log.debug("=====>>>" + selectUser);
									
					for (HashMap<String, Object> map : selectUser) {
						map.put("instance_id", Integer.parseInt(instanceId));
						sessionAgent.insert("app.TB_PGUSER_I001", map);					
					}					
				}				
				//Commit
				sessionAgent.commit();
			} catch (Exception e) {
				sessionAgent.rollback();
				log.error("", e);
				throw e;
			}	
			
			
			try {
				//Table Delete
				//sessionAgent.delete("app.PGMONBT_BATCH_ACTV_COLLECT_INFO_001");
				//sessionAgent.delete("app.PGMONBT_BATCH_CURRENT_LOCK_001");
				//sessionAgent.delete("app.PGMONBT_BATCH_BACKEND_RSC_001");
				//sessionAgent.delete("app.PGMONBT_BATCH_ACCESS_INFO_001");
				
				//sessionAgent.delete("app.PGMONBT_BATCH_OBJT_COLLECT_INFO_001");
				sessionAgent.delete("app.PGMONBT_BATCH_TABLESPACE_INFO_001");
				sessionAgent.delete("app.PGMONBT_BATCH_TABLE_INFO_001");
				sessionAgent.delete("app.PGMONBT_BATCH_INDEX_INFO_001");
				
				//sessionAgent.delete("app.PGMONBT_BATCH_RSC_COLLECT_INFO_001");
				//sessionAgent.delete("app.PGMONBT_BATCH_MEMORY_STAT_001");
				//sessionAgent.delete("app.PGMONBT_BATCH_CPU_STAT_MASTER_001");
				//sessionAgent.delete("app.PGMONBT_BATCH_CPU_STAT_DETAIL_001");
				//sessionAgent.delete("app.PGMONBT_BATCH_DISK_IO_001");
				//sessionAgent.delete("app.PGMONBT_BATCH_DISK_USAGE_001");
				
				//sessionAgent.delete("app.PGMONBT_BATCH_HCHK_COLLECT_INFO_001");
				sessionAgent.delete("app.PGMONTB_BATCH_CONTROL_PROCESS_HIST_001");//robin 0207 delete Lock history
				//sessionAgent.delete("app.PGMONTB_BATCH_HCHK_ALERT_INFO_001");//robin 0208 delete Alert history
				//sessionAgent.delete("app.PGMONTB_BATCH_REPLICATION_INFO_001");//robin 0418 delete replication
				//sessionAgent.delete("app.PGMONTB_BATCH_CHECKPOINT_INFO_001");//robin 0418 delete checkpoint
				sessionAgent.delete("app.PGMONTB_BATCH_QEURY_INFO_001");//robin 1031 delete checkpoint
				//sessionAgent.delete("app.PGMONTB_BATCH_PG_STAT_STATEMENT_001");//robin 1031 delete checkpoint
				//sessionAgent.delete("app.PGMONBT_BATCH_TABLE_EXT_INFO_001");//robin 1031 delete table ext
				sessionAgent.delete("app.PGMONBT_BATCH_TB_USER_INFO_001");//robin 190122 delete user info
				//Commit
				sessionAgent.commit();
			} catch (Exception e) {
				sessionAgent.rollback();
				log.error("", e);
				
				status = "3";
				comments = "2";
			}
			
			sessionAgent.close();
			sessionAgent = SqlSessionManager.getInstance().openSession(ExecutorType.SIMPLE, true);
			
			try {
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
				partitionTableMap.put("tablename", "tb_pg_stat_statements");
				sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);				
				partitionTableMap.put("tablename", "tb_table_ext_info");
				sessionAgent.update("app.PG_MAINTAIN_PARTITIONS_001", partitionTableMap);	
				
				sessionAgent.commit();
			} catch (Exception e) {
				sessionAgent.rollback();
				log.error("", e);
				
				status = "3";
				comments = "2";
			}
			sessionAgent.close();
			sessionAgent = SqlSessionManager.getInstance().openSession(ExecutorType.SIMPLE, true);
			
			try {
				
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
				sessionAgent.update("app.PG_CONSTRAINT_TB_CHECKPOINT_INFO_001"   , partitionTableMap);
				sessionAgent.update("app.PG_CONSTRAINT_TB_MEMORY_STAT_001"       , partitionTableMap);
				sessionAgent.update("app.PG_CONSTRAINT_TB_OBJT_COLLECT_INFO_001" , partitionTableMap);
				sessionAgent.update("app.PG_CONSTRAINT_TB_RSC_COLLECT_INFO_001"  , partitionTableMap);
				sessionAgent.update("app.PG_CONSTRAINT_TB_TABLE_EXT_INFO_001"    , partitionTableMap);
				sessionAgent.update("app.PG_CONSTRAINT_TB_HCHK_ALERT_INFO_001"   , partitionTableMap);
				sessionAgent.update("app.PG_CONSTRAINT_TB_PG_STAT_STATEMENTS_001", partitionTableMap);
				// Create index of partition tables
				sessionAgent.update("app.PG_INDEX_TB_CURRENT_LOCK_001"      , partitionTableMap);
				sessionAgent.update("app.PG_INDEX_TB_CURRENT_LOCK_002"      , partitionTableMap);
				sessionAgent.update("app.PG_INDEX_TB_BACKEND_RSC_001"       , partitionTableMap);
				sessionAgent.update("app.PG_INDEX_TB_ACCESS_INFO_001"       , partitionTableMap);
				sessionAgent.update("app.PG_INDEX_TB_MEMORY_STAT_001"       , partitionTableMap);
				sessionAgent.update("app.PG_INDEX_TB_CPU_STAT_MASTER_001"   , partitionTableMap);
				sessionAgent.update("app.PG_INDEX_TB_DISK_IO_001"           , partitionTableMap);
				sessionAgent.update("app.PG_INDEX_TB_DISK_USAGE_001"        , partitionTableMap);
				sessionAgent.update("app.PG_INDEX_TB_TABLE_EXT_INFO_001"    , partitionTableMap);
				//Commit
				sessionAgent.commit();
			} catch (Exception e) {
				sessionAgent.rollback();
				log.error("", e);
				
				status = "3";
				comments = "2";
			}
			
			sessionAgent.close();
			sessionAgent = SqlSessionManager.getInstance().openSession(ExecutorType.SIMPLE, true);
			
			try {
				//vacuum analyze
				sessionAgent.update("app.VACUUM_ANALYZE_U001");
				sessionAgent.update("app.VACUUM_ANALYZE_U002");
				sessionAgent.update("app.VACUUM_ANALYZE_U003");
				sessionAgent.update("app.VACUUM_ANALYZE_U006");
				sessionAgent.update("app.VACUUM_ANALYZE_U007");
				sessionAgent.update("app.VACUUM_ANALYZE_U008");
				sessionAgent.update("app.VACUUM_ANALYZE_U009");
				sessionAgent.update("app.VACUUM_ANALYZE_U010");
				sessionAgent.update("app.VACUUM_ANALYZE_U011");
				sessionAgent.update("app.VACUUM_ANALYZE_U012");
				sessionAgent.update("app.VACUUM_ANALYZE_U013");
				sessionAgent.update("app.VACUUM_ANALYZE_U014");
				sessionAgent.update("app.VACUUM_ANALYZE_U015");
				sessionAgent.update("app.VACUUM_ANALYZE_U016");
				sessionAgent.update("app.VACUUM_ANALYZE_U017");
				sessionAgent.update("app.VACUUM_ANALYZE_U018");
				sessionAgent.update("app.VACUUM_ANALYZE_U019");
				sessionAgent.update("app.VACUUM_ANALYZE_U020");
				sessionAgent.update("app.VACUUM_ANALYZE_U021");
				sessionAgent.update("app.VACUUM_ANALYZE_U022");
				sessionAgent.update("app.VACUUM_ANALYZE_U023");
				sessionAgent.update("app.VACUUM_ANALYZE_U024");
				sessionAgent.update("app.VACUUM_ANALYZE_U025");
				sessionAgent.update("app.VACUUM_ANALYZE_U026");
				sessionAgent.update("app.VACUUM_ANALYZE_U027");
				sessionAgent.update("app.VACUUM_ANALYZE_U028");
				sessionAgent.update("app.VACUUM_ANALYZE_U029");
				sessionAgent.update("app.VACUUM_ANALYZE_U030");
			} catch (Exception e) {
				log.error("", e);
				
				status = "3";
				
				if(comments.equals("")) {
					comments = "3";
				} else{
					comments = comments + "|3";
				}
			}			

			
			//TB_SYS_LOG 정보 UPDATE
			HashMap<String, Object> updateMap = new HashMap<String, Object>();
			updateMap.put("status", status);
			updateMap.put("comments", comments);
			updateMap.put("reg_date", reg_date);
				
			sessionAgent.update("app.TB_SYS_LOG_U001", updateMap);
				
		} catch (Exception e) {
			log.error("", e);
		} finally {
			if(sessionAgent != null) sessionAgent.close();
		}
	}
}

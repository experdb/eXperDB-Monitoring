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
}

package experdb.mnt.task;
import experdb.mnt.eXperDBMAConfig;

import java.sql.Connection;
import java.text.SimpleDateFormat;
import java.util.ArrayList;
import java.util.Calendar;
import java.util.Date;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

import org.apache.ibatis.session.ExecutorType;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.log4j.Logger;

import experdb.mnt.db.mybatis.SqlSessionManager;

import java.util.Enumeration;
import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.eXperDBMAConfig;

import java.sql.DriverManager;


import org.quartz.Job;
import org.quartz.JobExecutionContext;
import org.quartz.JobExecutionException;

public class ReportJob implements Job {

	protected static Logger log = Logger.getLogger(ReportJob.class);	
	
	private String status = "2"; // 1:진행중 / 2:정상종료 / 3:오류
	private String comments = ""; // 오류세부 정보 : 0:데몬기동 / 1:접속종료 / 2:데이터삭제 / 3: VACUUM&ANALYZE /  4: 시퀀스초기화/ 5:인스턴스정보 UPDATE / 6: 접속수립 / 9:데몬종료
	private String reg_date = ""; // 오늘날짜
	
	public ReportJob() {
		log.info("collect the reporting data started");		
	}
	
	public void execute(JobExecutionContext context) throws JobExecutionException {
		SqlSession sessionAgent  = null;
		log.info("ReportJob started(hourly)");
		int ret = 0;
	    String schedFormat = null;
	    int timeperiod = 0;
	    String timeunit = null;
		try {
			schedFormat = eXperDBMAConfig.getInstance().getProperty("Time.report_period");
		} catch (Exception e1) {
			// TODO Auto-generated catch block
			e1.printStackTrace();
		}
		
		if (schedFormat.equalsIgnoreCase("m")){
			timeperiod = 1;
			timeunit = "m";
		} else if (schedFormat.equalsIgnoreCase("2m")){
			timeperiod = 2;
			timeunit = "m";
		} else if (schedFormat.equalsIgnoreCase("h")){
			timeperiod = 1;
			timeunit = "h";
		} else if (schedFormat.equalsIgnoreCase("2h")){
			timeperiod = 2;
			timeunit = "h";
		} else{
			timeperiod = 1;
			timeunit = "h";
		}
		
		//Manage real time statements 
		try {
			Map<String, Object> parameObjt = new HashMap<String, Object>();
			parameObjt.put("timeperiod", timeperiod);
			parameObjt.put("timeunit", timeunit);	
		
			sessionAgent = SqlSessionManager.getInstance().openSession();
			//301~304 Collect Resource
			sessionAgent.insert("app.TB_COLLECT_REPORT_DATA_I001", parameObjt);
			//318 Collect Statements
			sessionAgent.insert("app.TB_COLLECT_REPORT_DATA_I002", parameObjt);
			//320 Lock sessions
			sessionAgent.insert("app.TB_COLLECT_REPORT_DATA_I003", parameObjt);
			sessionAgent.commit();
		} catch (Exception e) {
			log.error("", e);
			ret = -1;
		} finally {
			if(sessionAgent != null) sessionAgent.close();
		}
	}
}

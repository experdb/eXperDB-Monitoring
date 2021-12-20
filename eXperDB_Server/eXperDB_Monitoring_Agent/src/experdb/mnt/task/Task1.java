package experdb.mnt.task;

import java.io.BufferedReader;
import java.io.FileReader;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;
import java.util.HashMap;
import java.util.Hashtable;
import java.util.List;
import java.util.Map;
import java.util.StringTokenizer;

import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.logging.log4j.Logger;
import org.apache.logging.log4j.LogManager;

import experdb.mnt.MonitoringInfoManager;
import experdb.mnt.ResourceInfo;
import experdb.mnt.Server;
import experdb.mnt.db.mybatis.SqlSessionManager;

public class Task1 extends TaskApplication{


	public Task1(String instanceId, String taskId) {
		super(instanceId, taskId);
		execute();
	}	

	private void execute() {
		log.debug("11111111111111111111111111111111111111111111111111111111111111111111111111111");
	}
	
	
	@Override
	public void run() {
		log.debug("[instanceId ==>> " + instanceId + "]" + "[taskId ==>> " + taskId + "]");		
		
		try {
			
			log.debug("11111111111111111111111111111111111111111111111111111111111111111111111111111");
			
			//task 정보를 가져온다.
//			Hashtable taskMap = TaskInfoManager.getTaskMap(taskId);
//			
//			SqlSessionFactory sqlSessionFactory = SqlSessionManager.getInstance();
//			Connection connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:" + instanceId);
//			SqlSession session1 = sqlSessionFactory.openSession(connection);
//			SqlSession session2 = sqlSessionFactory.openSession(true);
			
			try {
//				Map<String, Object> parameters = new HashMap<String, Object>();
//				Hashtable resource = ResourceInfo.getResourceMap();
//				
//				ArrayList arry = (ArrayList) taskMap.get("paramColumn");
//				
//				for(int i = 0; i < arry.size(); i++) {
//					int preVaslue = 0;
//					
////					if(resource.containsKey(instanceId)){
////						HashMap h = 
////					}
//					
//					parameters.put((String) arry.get(i), preVaslue);
//				}
//				
//				List<HashMap<String, Object>> list = session1.selectList("app.BT_CPU_STAT_MASTER_001", parameters);
//				
//				
//
//				if(list.size() != 0)
//				{
//					for (HashMap<String, Object> map : list) {
//						session2.insert("app.BT_CPU_STAT_MASTER_001_I", map);
//						
//						
//						HashMap<String, Object> map1 = null;
//						map1.put(taskId, map);
//						
//						log.debug(map1);
//						
//						resource.put(instanceId, map1);
//						
//						log.debug(resource);
//					}
//				}
				
				
				
			} catch (Exception e) {
				log.error("", e);
			} finally {
//				session1.close();
//				session2.close();
			}
			
			
			
			
			
			
//			Map<String, Object> tempCpu = new HashMap<String, Object>();
//			tempCpu.put("11", "111");
//			
//			Map<String, Object> tempDiskIo = new HashMap<String, Object>();
//			tempDiskIo.put("22", "111");
//			
//			
//			ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_CPU, tempCpu);
//			ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_DISK_IO, tempDiskIo);
//			
//			log.debug(ResourceInfo.getInstance().getResourceMap());
//			
//			
//			
//			
//			
//
//			Map<String, Object> tempDiskIo1 = new HashMap<String, Object>();
//
//			tempDiskIo1.put("11", "999");
//			
//			ResourceInfo.getInstance().put(instanceId, taskId, RESOURCE_KEY_CPU, tempDiskIo1);
//			
//			log.debug(ResourceInfo.getInstance().getResourceMap());			
			
			
			
			
			
			
		} catch (Exception e) {
			log.error("", e);
		}
		
		
		
	}
	
	
	
	
	
	
	
	
	
	
	
//	@Override
//	public void perform(String str) {
//	
//		Connection 			connection = null;
//		PreparedStatement 	ps = null;
//		ResultSet 			rs = null;
//		
//		try {
//			
//			long s = System.currentTimeMillis();
//			
//			connection = DriverManager.getConnection("jdbc:apache:commons:dbcp:SYSTEM");
//			connection.setAutoCommit(false);
//			
//			String query = "select aa, bb from public.test where aa = ?";
//			ps = connection.prepareStatement(query);
//			
//			ps.setString(1, "22");
//			
//			rs = ps.executeQuery();
//			
//			while(rs.next()){
//				log.debug("[" + rs.getString("aa") + "]" + "[" + rs.getString("bb") + "]");
//			}
//			
//			connection.commit();
//			
//			//System.out.println("수행시간 [" + (System.currentTimeMillis() - s) / 1000 + "] [" + (System.currentTimeMillis() - s) + "]");
//			
//		} catch (Exception e) {
//			try { connection.rollback();} catch(Exception e1) {e1.printStackTrace();}
//			e.printStackTrace();
//		} finally {
//			if (rs  != null) { try { rs.close();  } catch (Exception e) {} }
//			try { ps.close(); } catch(Exception e) {e.printStackTrace();}
//			try { connection.setAutoCommit(true); connection.close(); } catch(Exception e) {e.printStackTrace();}
//		}		
//		
//		
//	}

}

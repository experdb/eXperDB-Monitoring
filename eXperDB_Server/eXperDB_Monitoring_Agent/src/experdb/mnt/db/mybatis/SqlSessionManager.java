package experdb.mnt.db.mybatis;

import java.io.Reader;

import org.apache.ibatis.io.Resources;
import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.ibatis.session.SqlSessionFactoryBuilder;
import org.apache.log4j.Logger;

import experdb.mnt.eXperDBMAConfig;

public class SqlSessionManager {
	private static Logger log = Logger.getLogger(SqlSessionManager.class);
	
	private static SqlSessionFactory sqlSession = null;
	
	public static void initInstance() throws Exception {
		if (sqlSession != null) {
			log.info("SqlSessionManager가 이미 초기화되었습니다.");
			return;
		}
		
		log.info("************************************************************");
		log.info("SqlSessionManager를 초기화합니다.");
		
		Reader reader = new java.io.FileReader(	System.getProperty("eXperDBMA_HOME") + 
												System.getProperty("CONFIG_DIR") + "/" + 
												eXperDBMAConfig.getInstance().getProperty("MyBatis.configfile"));
		sqlSession = new SqlSessionFactoryBuilder().build(reader);
		reader.close();

		log.info("SqlSessionManager를 초기화하였습니다.");
		log.info("************************************************************");
	}
	
	public static SqlSessionFactory getInstance() {
		if (sqlSession == null) {
			try {
				initInstance();
			} catch (Exception e) {
				log.error("", e);
			}
		}
		
		return sqlSession;
	}	
}

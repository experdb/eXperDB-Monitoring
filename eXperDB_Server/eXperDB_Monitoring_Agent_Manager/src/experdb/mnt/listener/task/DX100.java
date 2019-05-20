package experdb.mnt.listener.task;

import java.io.BufferedReader;
import java.io.ByteArrayOutputStream;
import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.nio.file.Files;
import java.security.MessageDigest;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.HashMap;

import org.apache.commons.codec.binary.Base64;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

import experdb.mnt.db.mybatis.SqlSessionManager;

public class DX100 implements SocketApplication{
	public static final String productName = "eXperDB.Monitoring";
	@Override
	public JSONObject perform(String tran_cd, String req_data) throws Exception {

		JSONParser parser=new JSONParser();
		Object reqDataObj=parser.parse(req_data);		
		JSONObject jReqDataObj = (JSONObject) reqDataObj;
		
		JSONObject resDataObj = new JSONObject();
		int nOffSet = Integer.parseInt(jReqDataObj.get("offset").toString());
		int nBlockSize = Integer.parseInt(jReqDataObj.get("blocksize").toString());
		
		SqlSessionFactory sqlSessionFactory = null;
		SqlSession sessionAgent  = null;
		
		
		int readBytes;
		byte[] buffer = new byte[1024];
		byte[] sendbuffer = new byte[nBlockSize*2];
		String FileName = "";
		String ChecksumFileName = "";
		String ServerVersion = "";
		File binaryfile = null;
		long filelength = 0;
		long totalReadBytes = 0;
		int sendBytes = 0;
		FileInputStream fisBinFile = null;
		try {

			// Version 및 Binary path를 가져온다
			sqlSessionFactory = SqlSessionManager.getInstance();
			sessionAgent = sqlSessionFactory.openSession();
			HashMap<String, Object> config = new HashMap<String, Object>();
			config = sessionAgent.selectOne("system.TB_CONFIG_R003");
			ServerVersion = config.get("version").toString().replace(".", "_");
			FileName = config.get("binary_path").toString() + "/" + productName + "_" + ServerVersion +".exe";

			// Check File
			binaryfile = new File(FileName);
			filelength = binaryfile.length();

			fisBinFile = new FileInputStream(binaryfile);
			
			// Read file
			fisBinFile.getChannel().position(nOffSet);
            while ((readBytes = fisBinFile.read(buffer)) > 0) {
                if (nBlockSize < (sendBytes + readBytes)) break;
               	System.arraycopy(buffer, 0, sendbuffer, sendBytes, readBytes);
               	sendBytes += readBytes;
            }
            fisBinFile.close();
            
            // convert from binary to base64 string for inclusion to JSON  
            ByteArrayOutputStream bos = new ByteArrayOutputStream();
            bos.write(sendbuffer, 0, sendBytes);
            String fileString = org.apache.commons.codec.binary.StringUtils.newStringUtf8(org.apache.commons.codec.binary.Base64.encodeBase64(bos.toByteArray()));
            resDataObj.put("filelength", filelength);
            resDataObj.put("sendbyte", sendBytes);
            resDataObj.put("sendbuffer", fileString);
            log.info("total length = [" +  resDataObj.size() + "]..." + "sendbuffer lendth = [" + fileString.length() + "]");
            if (filelength == (nOffSet + sendBytes)){
            	File checksumFile = new File(FileName + ".md5");
            	FileReader filereader = new FileReader(checksumFile);
            	BufferedReader bufReader = new BufferedReader(filereader);
            	String checksum = bufReader.readLine();                
                resDataObj.put("checksum", checksum);
            }
            	
		} catch (FileNotFoundException e1) {
			String message = "File not found [" + FileName + "]";
			resDataObj.put("error_cd", "DX100_E01");
			resDataObj.put("error_msg", "The setup or checksum file could not be found on the server.");
			log.error("", e1);
		} catch (Exception e) {
			resDataObj.put("error_cd", "DX100_E02");
			resDataObj.put("error_msg", "Error occured from the server.");
			log.error("", e);
		} finally {
			if(sessionAgent != null) sessionAgent.close();
			if(fisBinFile != null)fisBinFile.close(); 
		}

		return resDataObj;
	}

}

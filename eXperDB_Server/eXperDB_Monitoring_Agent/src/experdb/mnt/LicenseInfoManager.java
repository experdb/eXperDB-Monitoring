package experdb.mnt;

import java.io.ByteArrayOutputStream;
import java.net.InetAddress;
import java.net.NetworkInterface;
import java.security.spec.KeySpec;
import java.sql.Connection;
import java.sql.DriverManager;
import java.util.Calendar;
import java.util.Enumeration;
import java.util.HashMap;

import javax.crypto.Cipher;
import javax.crypto.SecretKey;
import javax.crypto.SecretKeyFactory;
import javax.crypto.spec.DESKeySpec;
import javax.crypto.spec.IvParameterSpec;

import org.apache.commons.codec.binary.Base64;
import org.apache.ibatis.session.SqlSession;
import org.apache.ibatis.session.SqlSessionFactory;
import org.apache.log4j.Logger;

import experdb.mnt.db.mybatis.SqlSessionManager;
import experdb.mnt.listener.SocketListenerInfo;

public class LicenseInfoManager {
	private static Logger log = Logger.getLogger(LicenseInfoManager.class);
	
/* Test Code*/
 	public static void main(String... args) {
		try {
			String encSerialKey = LicenseInfoManager.encrypt("EM10-O082-1504-6750-7521172.020.060.028005960054396N0000000005201711070000000008:00:27:d8:14:d7");
			String serialKey = LicenseInfoManager.decrypt(encSerialKey);
			System.out.println(encSerialKey); 
			System.out.println(serialKey);
			System.out.println(serialKey.substring(0, 24) ); //홈페이지 관리 SERIAL 번호  
			System.out.println(serialKey.substring(24, 39)); //AGENT IP (---.---.---.---) 
			System.out.println(serialKey.substring(39, 45));; //AGENT PORT(XXXXXX)
			System.out.println(serialKey.substring(45, 51));; //DB PORT(XXXXXX)
			System.out.println(serialKey.substring(51, 52));; //TRIAL 여부(기본30일)       
			System.out.println(serialKey.substring(52, 57));; //CORE 개수(00000)           
			System.out.println(serialKey.substring(57, 62));; //INSTANCE 개수(00000)       
			System.out.println(serialKey.substring(62, 70));; //라이선스 생성일자(00000000)
			System.out.println(serialKey.substring(70, 78));; //라이선스 만료일자(00000000) 
			System.out.println(serialKey.substring(78, 95)); //AGENT MAC (--:--:--:--:--:--) 
			
		} catch (Exception e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}
	
	public static void licenseVerification() {
		SqlSessionFactory sqlSessionFactory = SqlSessionManager.getInstance();
		SqlSession session = sqlSessionFactory.openSession();
		
		try {
			log.info("************************************************************");
			log.info("License Verification Start");
			
			
			//시리얼키를 가져온다.
			////////////////////////////////////////////////////////////////////////////////////////
			HashMap<String, Object> serialKeyMap = session.selectOne("system.TB_CONFIG_R002");
			
			if(serialKeyMap == null || serialKeyMap.get("serial_key").equals("")){
				log.info("등록된 License가 없습니다.");
				eXperDBMAExit("NO SERIAL_KEY");
			}
			
			String serialKey = decrypt((String) serialKeyMap.get("serial_key"));
			/* 2017.11.22 MAC Address 기반 라이센스 사용 */  
			String MAC			= serialKey.substring(78, 95); //AGENT MAC (--:--:--:--:--:--)
			if(MAC.equals("00:00:00:00:00:00")){
				log.info("MAC CHECK ==> SUCCESS");
			}else {
				Boolean isMAC = false;				
				
				for (Enumeration<NetworkInterface> en = NetworkInterface.getNetworkInterfaces(); en.hasMoreElements();)
			    {
			        NetworkInterface intf = en.nextElement();
			        if(intf != null){
			        	byte[] mac = intf.getHardwareAddress();
			        	if(mac != null){
			        		String LocalMAC ="";
				        	for (int i = 0; i < mac.length; i++)
				        		LocalMAC += String.format("%02X%s", mac[i], (i < mac.length -1) ? ":" : "");
				        	
				        	if(MAC.equalsIgnoreCase(LocalMAC)){
				        		isMAC = true;
				        		break;
				        	}
			        	}
			        }
			    }				
				  
				if(isMAC){
					log.info("MAC CHECK ==> SUCCESS");
				} else{
					log.info("MAC CHECK ==> FAIL");
					eXperDBMAExit("MAC");
				}
			}			
			
			/* 라이선스 */
			
//			log.debug("serialKey ===>>> " + serialKey);
			////////////////////////////////////////////////////////////////////////////////////////
			
			/* 2016.04.27 라이센스 미사용으로 인하여 해당 내용 주석처리
			//현재 날짜를 구해온다.
			////////////////////////////////////////////////////////////////////////////////////////
			String TODAY = "";
			
			HashMap<String, Object> randomKey = session.selectOne("system.TB_INSTANCE_INFO_R003");
			
			if(randomKey == null || randomKey.get("instance_id").equals("")){
				TODAY = getDate();
			} else{
				Connection connDB = null;
				SqlSession sessDB = null;
				
				try {
					HashMap<String, Object> instanceMap = MonitoringInfoManager.getInstanceMap(randomKey.get("instance_id").toString());
					
					connDB = DriverManager.getConnection(
							"jdbc:postgresql://" + instanceMap.get("server_ip") + ":" + instanceMap.get("service_port") + "/" + instanceMap.get("conn_db_name"), 
							(String) instanceMap.get("conn_user_id"),
							(String) instanceMap.get("conn_user_pwd"));
					
					sessDB = sqlSessionFactory.openSession(connDB);					
					HashMap<String, Object> nowDateMap = sessDB.selectOne("app.LICENSE_001");
					
					TODAY = (String) nowDateMap.get("today");
				} catch (Exception e1) {
					throw new Exception(e1);
				} finally {
					sessDB.close();
				}
			}
			////////////////////////////////////////////////////////////////////////////////////////
			
			String SERIAL  		= serialKey.substring(0, 24); //홈페이지 관리 SERIAL 번호  
			String IP           = serialKey.substring(24, 39); //AGENT IP (---.---.---.---) 
			String AGENT_PORT   = serialKey.substring(39, 45);; //AGENT PORT(XXXXXX)
			String DB_PORT   	= serialKey.substring(45, 51);; //DB PORT(XXXXXX)
			String TRIAL        = serialKey.substring(51, 52);; //TRIAL 여부(기본30일)       
			String CORE         = serialKey.substring(52, 57);; //CORE 개수(00000)           
			String INSTANCE     = serialKey.substring(57, 62);; //INSTANCE 개수(00000)       
			String CREATE_DATE  = serialKey.substring(62, 70);; //라이선스 생성일자(00000000)
			String EXPIRE_DATE  = serialKey.substring(70, 78);; //라이선스 만료일자(00000000) 
			String MAC			= serialKey.substring(78, 95)); //AGENT MAC (--:--:--:--:--:--) 
			

			//IP check
			if(IP.equals("000.000.000.000")){
				log.info("IP CHECK ==> SUCCESS");
			}else {
				String[] temp = IP.split("[.]");
			
				IP = Integer.valueOf(temp[0]) + "." + 
					 Integer.valueOf(temp[1]) + "." + 
					 Integer.valueOf(temp[2]) + "." + 
					 Integer.valueOf(temp[3]);
				
				Boolean isIP = false;
				
				for (Enumeration<NetworkInterface> en = NetworkInterface.getNetworkInterfaces(); en.hasMoreElements();)
			    {
			        NetworkInterface intf = en.nextElement();
			        for (Enumeration<InetAddress> enumIpAddr = intf.getInetAddresses(); enumIpAddr.hasMoreElements();)
			        {
			            InetAddress inetAddress = enumIpAddr.nextElement();
			            if (!inetAddress.isLoopbackAddress() && !inetAddress.isLinkLocalAddress() && inetAddress.isSiteLocalAddress())
			            {
			            	if(IP.equals(inetAddress.getHostAddress().toString())){
			            		isIP = true;
			            	}
			            }
			        }
			    }				
				  
				if(isIP){
					log.info("IP CHECK ==> SUCCESS");
				} else{
					log.info("IP CHECK ==> FAIL");
					eXperDBMAExit("IP");
				}
			}

			
			//AGENT_PORT check
			if(AGENT_PORT.equals("000000")){
				log.info("AGENT_PORT CHECK ==> SUCCESS");
			}else {
				AGENT_PORT = Integer.toString(Integer.valueOf(AGENT_PORT));
				
				if(AGENT_PORT.equals(Integer.toString(SocketListenerInfo.getInstance("eXperDBMA").getListenPort()))){
					log.info("AGENT_PORT CHECK ==> SUCCESS");
				} else{
					log.info("AGENT_PORT CHECK ==> FAIL");
					eXperDBMAExit("AGENT_PORT");
				}
			}
			
			
			//DB_PORT check
			if(DB_PORT.equals("000000")){
				log.info("DB_PORT CHECK ==> SUCCESS");
			}else {
				String dbUrl = session.getConnection().getMetaData().getURL();
				String[] temp = dbUrl.split("[:]");
				String[] temp1 = temp[3].split("[/]");
				String agentDbPort = temp1[0];
			
				DB_PORT = Integer.toString(Integer.valueOf(DB_PORT));
				
				if(DB_PORT.equals(agentDbPort)){
					log.info("DB_PORT CHECK ==> SUCCESS");
				} else{
					log.info("DB_PORT CHECK ==> FAIL");
					eXperDBMAExit("DB_PORT");
				}
			}			
			
			
			//CORE 갯수
//			if(CORE.equals("00000")){
//				log.info("CORE CHECK ==> SUCCESS");
//			}else {
//				log.info("CORE CHECK ==> FAIL");
//				eXperDBMAExit("CORE");				
//			}
			
			
			//INSTANCE 개수
			if(INSTANCE.equals("00000")){
				log.info("INSTANCE CHECK ==> SUCCESS");
			}else {
				Enumeration		e = MonitoringInfoManager.getInstance().getInstanceId();
				
				int i = 0;
				while (e.hasMoreElements()) {
					i++;
					e.nextElement();
				}
				
				if(i <= Integer.valueOf(INSTANCE)){
					log.info("INSTANCE CHECK ==> SUCCESS");
				} else{
					log.info("INSTANCE CHECK ==> FAIL");
					eXperDBMAExit("INSTANCE");					
				}
			}

			
			//만료일자 확인
			log.info("TRIAL CHECK ==> " + TRIAL);

			
			//생성일자 확인
			log.info("CREATE DATE ==> " + CREATE_DATE);
			
			
			if(EXPIRE_DATE.equals("00000000")){
				log.info("Expire Date ==> UNLIMITED");
				log.info("Expire Date CHECK ==> SUCCESS");
			} else{
				log.info("Expire Date ==> " + EXPIRE_DATE);
					
				if(Integer.valueOf(TODAY) <= Integer.valueOf(EXPIRE_DATE)){
					log.info("Expire Date CHECK ==> SUCCESS");
				}else {
					log.info("Expire Date CHECK ==> FAIL");
					eXperDBMAExit("EXPIRE_DATE");					
				}
			}
	*/
			
			HashMap<String, Object> updateMap = new HashMap<String, Object>();
			updateMap.put("status", 2);
			updateMap.put("comments", "");
			
			session.update("app.LICENSE_I001", updateMap);
			
			session.commit();			
			
			log.info("License Verification End");
			log.info("************************************************************");
		} catch (Exception e){
			session.rollback();
			log.error("LicenseInfoManager 읽는중 오류가 발생하였습니다.");
			log.error(e);
			eXperDBMAExit("LicenseInfoManager ERROR");
		} finally {
			session.close();
		}
		
	}

	public static void eXperDBMAExit(String comments){
		log.info("License Verification Failed");
		log.info("************************************************************");
		
		SqlSessionFactory sqlSessionFactory = SqlSessionManager.getInstance();
		SqlSession session = sqlSessionFactory.openSession();
		
		try {
			HashMap<String, Object> updateMap = new HashMap<String, Object>();
			updateMap.put("status", 3);
			updateMap.put("comments", comments);
			
			session.update("app.LICENSE_I001", updateMap);
			
			session.commit();
		} catch (Exception e){
			session.rollback();
			log.error("AGENT를 종료하는중 오류가 발생하였습니다.");
			log.error(e);
		} finally {
			session.close();
		}
		
		
		System.exit(0);
	}
	
	public static String decrypt(String inputText) throws Exception {
	    byte[] keyValue = new byte[] { 'W', 'e', 'b', 'C', 'a', 's', 'h', '9'};
	    ByteArrayOutputStream bout = new ByteArrayOutputStream();
	    try {
	        KeySpec keySpec = new DESKeySpec(keyValue);
	        SecretKey key = SecretKeyFactory.getInstance("DES").generateSecret(keySpec);
	        IvParameterSpec iv = new IvParameterSpec(keyValue);

	        Cipher cipher = Cipher.getInstance("DES/CBC/PKCS5Padding");
	        cipher.init(Cipher.DECRYPT_MODE,key,iv);
	        //byte[] decoded = Base64.decodeBase64(inputText); //Works with apache.commons.codec-1.8
	        byte[] decoded = Base64.decodeBase64(inputText.getBytes("ASCII"));// works with apache.commons.codec-1.3
	        bout.write(cipher.doFinal(decoded));
	    } catch(Exception e) {
	    	log.error(e);
	    }
	    return new String(bout.toByteArray(),"ASCII");
	}	
	
	public static String encrypt(String inputText) throws Exception {
	    byte[] keyValue = new byte[] { 'W', 'e', 'b', 'C', 'a', 's', 'h', '9'};
	    ByteArrayOutputStream bout = new ByteArrayOutputStream();
	    try {           
	        KeySpec keySpec = new DESKeySpec(keyValue);
	        SecretKey key = SecretKeyFactory.getInstance("DES").generateSecret(keySpec);
	        IvParameterSpec iv = new IvParameterSpec(keyValue);
	        Cipher cipher = Cipher.getInstance("DES/CBC/PKCS5Padding"); 
	        cipher.init(Cipher.ENCRYPT_MODE,key,iv);
	        bout.write(cipher.doFinal(inputText.getBytes("ASCII")));                        
	    } catch(Exception e) {
	    	log.error(e);
	    }
	    return new String(Base64.encodeBase64(bout.toByteArray()));
	}	
	
	public static String getDate() {
		Calendar temp=Calendar.getInstance();
		int year=temp.get(Calendar.YEAR);
		int month=temp.get(Calendar.MONTH)+1;
		int day=temp.get(Calendar.DAY_OF_MONTH);
		StringBuffer today=new StringBuffer();
		today.append(year);

		if(month<10) {
			today.append("0");
		}
		today.append(month);


		if(day<10) { 
			today.append("0");
		}
		today.append(day);
		
		return today.toString();
	}	
	
	public static String getDate(String strDate,int iDay,char flag) {

		if (strDate.length() != 8)
			return "";
			
		int nYYYY = Integer.parseInt(strDate.substring(0,4));
		int nMM   = Integer.parseInt(strDate.substring(4,6))-1;
		int nDD    = Integer.parseInt(strDate.substring(6));	

		Calendar today=Calendar.getInstance();
		today.set(nYYYY,nMM,nDD);
		
		switch(flag){
			case	'Y'	:	today.add(Calendar.YEAR,iDay);
						break;
			case	'M'	:	today.add(Calendar.MONTH,iDay);			
						break;
			case	'W'	:	today.add(Calendar.WEEK_OF_MONTH,iDay);						
						break;
			case	'D'	:	today.add(Calendar.DAY_OF_MONTH,iDay);						
						break;
		}

		String strYear		=	Integer.toString(today.get(Calendar.YEAR));
		String strMonth		=	Integer.toString(today.get(Calendar.MONTH)+1);
		String strDay		=	Integer.toString(today.get(Calendar.DAY_OF_MONTH));
		
		strMonth				=	(strMonth.length()==1) ? strMonth="0"+strMonth : strMonth;			
		strDay					=	(strDay.length()==1) ? strDay="0"+strDay : strDay;							

		return strYear+strMonth+strDay;
	}	
	
}

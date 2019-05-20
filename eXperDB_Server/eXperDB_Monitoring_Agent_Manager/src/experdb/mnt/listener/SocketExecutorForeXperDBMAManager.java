package experdb.mnt.listener;

import java.net.Socket;
import java.net.SocketTimeoutException;
import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.io.StringReader;
import java.util.Date;
import java.util.Map;
import java.util.HashMap;
import java.util.Iterator;
import java.util.List;
import java.util.LinkedList;
import java.util.Hashtable;
import java.util.Enumeration;
import java.sql.Connection;
import java.sql.ResultSet;
import java.sql.Statement;
import java.sql.PreparedStatement;
import java.text.NumberFormat;
import java.text.SimpleDateFormat;

import org.apache.log4j.Logger;
import org.json.simple.JSONArray;
import org.json.simple.JSONObject;
import org.json.simple.parser.JSONParser;

import experdb.mnt.client.ClientConnector;
import experdb.mnt.listener.task.SocketApplication;

public class SocketExecutorForeXperDBMAManager implements Runnable {
	private static Logger log = Logger.getLogger(SocketExecutorForeXperDBMAManager.class);
	
	private Socket			client = null;
	private int			localport = 0;
	private InputStream	is = null;
	private OutputStream	os = null;
	
	
	public SocketExecutorForeXperDBMAManager(Socket s) {
		client		= s;
		localport	= client.getLocalPort();
	}
	
	public void run() {
		try {
			is	= client.getInputStream();
			os	= client.getOutputStream();

			
			byte[]		recvLenBuff = recv(10);
	        byte[] 		sendBuff = null;			
			
			if(!(new String(recvLenBuff).trim()).equals("")){
		
				byte[]	recvBuff = recv(10, false, recvLenBuff);
				
				byte[]	temp = new byte[recvBuff.length - 10];
				System.arraycopy(recvBuff, 10, temp, 0, recvBuff.length - 10);
				
				JSONParser parser=new JSONParser();
				Object obj=parser.parse(new String(temp));
				
				JSONObject jObj = (JSONObject) obj;
				JSONArray jArray=(JSONArray) jObj.get("_tran_req_data");
				
				String _tran_cd = (String) jObj.get("_tran_cd");
				String _tran_req_data = jArray.get(0).toString();
				
				log.info("--------------------------------------------");
				log.info("LENGTH : [" + Integer.toString(recvBuff.length) + "], TRAN_CD : ["+ _tran_cd +"]");
				log.info("INPUT  : [" + new String(recvBuff) + "]");

//				log.debug("SocketApplication Loading START............");
				
				
				if(_tran_cd.startsWith("MDX")) // manager 처리 전문일 경우
				{
					SocketApplication clApp = null;
					
			        try {
			        	clApp	= (SocketApplication)Class.forName("experdb.mnt.listener.task." + _tran_cd).newInstance();
			        } catch (Exception e) {
			        	log.debug("experdb.mnt.listener.task." + _tran_cd + "\'를 찾을 수 없습니다.");
			        }
			        
	//		        log.debug("SocketApplication Loading END............");
	
			        String res_data = "";
			        
			        JSONObject resDataObj = new JSONObject();
			        
			        try {
			        	log.debug("SocketApplication [" + _tran_cd + "]을 기동합니다.");
				        	
			        	resDataObj = clApp.perform(_tran_cd, _tran_req_data);
	
			        } catch (Exception e) {
			        	resDataObj.put("_error_cd", "9999");
			        	resDataObj.put("_error_msg", "오류가 발생하였습니다. 관리자에게 문의하시기 바랍니다.");
			        	
			        	log.error("", e);
			        }				
	
			        JSONArray outputArray = new JSONArray();
			        outputArray.add(resDataObj);		        
			        
			        
			        JSONObject outputObj = new JSONObject();
			        outputObj.put("_tran_cd", _tran_cd);
			        outputObj.put("_tran_res_data", outputArray);
			        
			        
			        byte[] temp2 = outputObj.toString().getBytes();
			        byte[] temp3 = FillStringL(String.valueOf(temp2.length), '0', 10).getBytes();
			        
			        
			        sendBuff = new byte[temp2.length + 10];
			        System.arraycopy(temp2, 0, sendBuff, 10, temp2.length);
			        System.arraycopy(temp3, 0, sendBuff, 0, temp3.length);
			        
				} else if(_tran_cd.startsWith("DX100")) // manager 처리 전문일 경우
				{
					SocketApplication clApp = null;
					
			        try {
			        	clApp	= (SocketApplication)Class.forName("experdb.mnt.listener.task." + _tran_cd).newInstance();
			        } catch (Exception e) {
			        	log.debug("experdb.mnt.listener.task." + _tran_cd + "\'를 찾을 수 없습니다.");
			        }
			        
//			        log.debug("SocketApplication Loading END............");

			        String res_data = "";
			        
			        JSONObject resDataObj = new JSONObject();
			        
			        try {
			        	log.debug("SocketApplication [" + _tran_cd + "]을 기동합니다.");
				        resDataObj = clApp.perform(_tran_cd, _tran_req_data);

			        } catch (Exception e) {
			        	resDataObj.put("error_cd", "9999");
			        	resDataObj.put("error_msg", "오류가 발생하였습니다. 관리자에게 문의하시기 바랍니다.");
			        	log.error("", e);
			        }				
								        
			        JSONObject outputObj = new JSONObject();
			        outputObj.put("_tran_cd", _tran_cd);
			        outputObj.put("_tran_res_data", resDataObj);
			        log.info("Output length : [" + outputObj.toString().getBytes() + "]");
			        byte[] temp2 = outputObj.toString().getBytes();
			        byte[] temp3 = FillStringL(String.valueOf(temp2.length), '0', 10).getBytes();
			        
			        sendBuff = new byte[temp2.length + 10];
			        System.arraycopy(temp2, 0, sendBuff, 10, temp2.length);
			        System.arraycopy(temp3, 0, sendBuff, 0, temp3.length);
				} else{ //bypass 전문일 경우
					ClientConnector cconn = new ClientConnector();
					
					try {
						cconn.create(SocketListenerInfo.getInstance("eXperDBMA").getSocketHost(), SocketListenerInfo.getInstance("eXperDBMA").getSocketPort());
						cconn.trx(new String(recvBuff));
						
						sendBuff = cconn.getRecvMsg().getBytes();
					} catch (Exception e) {
						log.error("", e);
					} finally {
						if (cconn != null)	cconn.close();
					}
				}
				
			        
		        log.debug("OUTPUT : [" + new String(sendBuff) + "]");	
		        
				send(sendBuff);
				
			}
			
			////////////////////////////////////////////////
		} catch (Exception ee) {
			log.error("", ee);
		} finally {
			if (os != null) try { os.close(); } catch (Exception ie) {}
			if (is != null) try { is.close(); } catch (Exception ie) {}
			if (client != null) try { client.close(); } catch (Exception ie) {}
		}
	}

	private void send(byte[] buff) throws IOException, Exception {
		if (client == null) {
			throw new Exception("SocketExecutor : Socket이 생성되지 않았습니다.");
		}
		
		os.write(buff);
		os.flush();
	}
	
	private byte[] recv(int recvSize) throws IOException, SocketTimeoutException, Exception {
		if (client == null) {
			throw new Exception("SocketExecutor : Socket이 생성되지 않았습니다.");
		}
		
		byte[]	buff = new byte[recvSize];
		int		i = 0;
		
		while (true) {
			if (i >= recvSize)
				break;
			
			int		r = is.read(buff, i, recvSize - i);
			
			if (r == -1)
				break;
			
			i	+= r;
		}
		
		if (i == 0) {
			return buff;
		}
		
		if (i < recvSize) {
			throw new Exception("수신오류");
		}
			
		return buff;
	}
	
	private byte[] recv(int lengthFieldSize, boolean containLengthField, byte[] recvLenBuff) throws IOException, SocketTimeoutException, Exception {
		if (client == null) {
			throw new Exception("SocketExecutor : Socket이 생성되지 않았습니다.");
		}
		
		byte[]	lenBuff = recvLenBuff;
	
		int		totalLength;
		
		try {
			totalLength		= Integer.parseInt(new String(lenBuff));
		} catch (NumberFormatException nfe) {
			throw new Exception("길이부 데이타가 잘못되었습니다. : [" + new String(lenBuff) + "]");
		}
		
		if (!containLengthField)
			totalLength		= totalLength + lengthFieldSize;
		
		byte[]	totalBuff = new byte[totalLength];
		
		System.arraycopy(lenBuff, 0, totalBuff, 0, lengthFieldSize);
		
		byte[]	dataBuff = recv(totalLength - lengthFieldSize);
		
		System.arraycopy(dataBuff, 0, totalBuff, lengthFieldSize, totalLength - lengthFieldSize);
		
		return totalBuff;
	}

	private byte[] recv(int lengthFieldSize, boolean containLengthField) throws IOException, SocketTimeoutException, Exception {
		if (client == null) {
			throw new Exception("SocketExecutor : Socket이 생성되지 않았습니다.");
		}
		
		byte[]	lenBuff = recv(lengthFieldSize);
	
		int		totalLength;
		
		try {
			totalLength		= Integer.parseInt(new String(lenBuff));
		} catch (NumberFormatException nfe) {
			throw new Exception("길이부 데이타가 잘못되었습니다. : [" + new String(lenBuff) + "]");
		}
		
		if (!containLengthField)
			totalLength		= totalLength + lengthFieldSize;
		
		byte[]	totalBuff = new byte[totalLength];
		
		System.arraycopy(lenBuff, 0, totalBuff, 0, lengthFieldSize);
		
		byte[]	dataBuff = recv(totalLength - lengthFieldSize);
		
		System.arraycopy(dataBuff, 0, totalBuff, lengthFieldSize, totalLength - lengthFieldSize);
		
		return totalBuff;
	}	

	private String FillStringL(String s, char f, int len) {
		if (s.length() >= len)
			return s;
		
		String	r = s;
		
		for (int i = 0; i < (len - s.length()); i++) {
			r	= f + r;
		}
		
		return r;
	}
	
	private String FillStringR(String s, char f, int len) {
		if (s.length() >= len)
			return s;
		
		String	r = s;
		
		for (int i = 0; i < (len - s.length()); i++) {
			r	= r + f;
		}
		
		return r;

	}	

	private void printExtEncoding(String tmp) {
	    String [] charset = {"KSC5601", "8859_1" ,"UTF-8", "MS949", "EUC_KR"};

		try {
			for(int i=0; i<charset.length; i++) {
				for(int j=0; j<charset.length; j++) {
					System.out.println("tmp="+tmp);
					String n_tmp = new String(tmp.getBytes(charset[i]),charset[j]);
					System.out.println("n_tmp="+n_tmp);
					System.out.println(charset[i] + " =>" +  charset[j]);
				}
			}
		}catch(java.io.UnsupportedEncodingException uee) {
			System.err.println("printExtEncoding : "+uee.toString());
		}
    }	
	
}

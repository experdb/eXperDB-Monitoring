package experdb.mnt.client;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Hashtable;
import java.net.ConnectException;
import java.net.Socket;
import java.net.SocketTimeoutException;
import java.net.UnknownHostException;

import org.apache.log4j.Logger;

import experdb.mnt.listener.SocketExecutorForeXperDBMAManager;

public class ClientConnector {
	private static Logger log = Logger.getLogger(ClientConnector.class);
	
	private static int		DEFAULT_TIMEOUT = 30;
	private static int		DEFAULT_BUFFER_SIZE = 1024;
	
	private String		_caller = "unknown";	
	
	protected String	ipaddr;
	protected int		port;
	protected int		timeout = DEFAULT_TIMEOUT;
	protected int		bufferSize = DEFAULT_BUFFER_SIZE;
	
	protected Socket		client = null;
	protected InputStream	is = null;
	protected OutputStream	os = null;
	
	private String		sendmsg = "";
	private String		recvmsg = "";
	
	private String		srccharset = "";
	private String		dstcharset = "";
	
	public void create(String ipaddr, int port) throws UnknownHostException, ConnectException, IOException {		
		this.ipaddr		= ipaddr;
		this.port		= port;
		
		if (client == null) {
			client	= new Socket(this.ipaddr, this.port);
			
			client.setSoTimeout(timeout * 1000);
			
			os		= client.getOutputStream();
			is		= client.getInputStream();
		}
	}
	
	public void create(String ipaddr, int port, Object caller) throws UnknownHostException, ConnectException, IOException {
		create(ipaddr, port);
		
		if (caller != null) {
			this._caller	= caller.getClass().getName();
		}
	}
	
	public void create(Socket s) throws IOException {
		client	= s;
		
		client.setSoTimeout(timeout * 1000);
		
		os		= client.getOutputStream();
		is		= client.getInputStream();
	}
	
	public void setTimeout(int timeout) {
		this.timeout	= timeout;
		
		if (client != null) {
			try {
				client.setSoTimeout(this.timeout * 1000);
			} catch (Exception e) {
			}
		}
	}
	
	public int getTimeout() {
		return this.timeout;
	}
	
	public void setBufferSize(int bufferSize) {
		this.bufferSize		= bufferSize;
	}
	
	public int getBufferSize() {
		return this.bufferSize;
	}
		
	public void close() {
		try {
			if (is != null) { is.close(); is = null; }
			if (os != null) { os.close(); os = null; }
			if (client != null) { client.close(); client = null; }
		} catch (Exception e) {
		}
	}
	
	public void finalize() {
		if (client != null) {
			close();
			
			log.error("************************************************************");
			log.error("원격지와의 연결이 종료되지 않은 상태로 GC되었습니다. CALLER[" + _caller + "]를 확인하여 주십시오.");
			log.error("************************************************************");			
        }
	}	
	
	public ClientConnector() {
	}
	

	
	public void trx(String msg) throws Exception, IOException {
		sendmsg = msg;
		
		send(sendmsg.getBytes());
		recvmsg	= new String(recv(10, false));
	}
	
	
	private String makeString(String s, int length) {
		String	r = "";
		
		if (s == null)
			s	= "";
		
		if (s.length() > length) {
			r	= s.substring(0, length);
		} else if (s.length() < length) {
			r	= s;
			
			for (int i = 0; i < (length - s.length()); i++) {
				r	= r + " ";
			}			
		} else
			r	= s;
		
		return r;
	}
	
	public String getSendMsg() {
		return sendmsg;
	}
	
	public String getRecvMsg() {
		return recvmsg;
	}
	
	public void send(byte[] buff) throws Exception{
		if (client == null) {
			throw new Exception("TRConnector : Socket이 생성되지 않았습니다.");
		}
		
		os.write(buff);
		os.flush();
	}
	
	public void send(byte[] buff, int index, int length) throws Exception {
		if (client == null) {
			throw new Exception("TRConnector : Socket이 생성되지 않았습니다.");
		}
		
		os.write(buff, index, length);
		os.flush();
	}
	
	public byte[] recv() throws IOException, SocketTimeoutException, Exception {
		return recv(this.bufferSize);
	}
	
	public byte[] recv(int recvSize) throws IOException, SocketTimeoutException, Exception {
		if (client == null) {
			throw new Exception("TRConnector : Socket이 생성되지 않았습니다.");
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
		
		if (i < recvSize) {
			throw new Exception("수신오류");
		}
			
		return buff;
	}
	
	public byte[] recv(int lengthFieldSize, boolean containLengthField) throws IOException, SocketTimeoutException, Exception {
		if (client == null) {
			throw new Exception("TRConnector : Socket이 생성되지 않았습니다.");
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
	
	public int getLocalPort() {
		if (client == null)
			return 0;
		
		return client.getLocalPort();
	}
}

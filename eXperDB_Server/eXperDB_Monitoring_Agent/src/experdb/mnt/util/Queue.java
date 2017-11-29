package experdb.mnt.util;

import java.util.LinkedList;

import org.apache.log4j.Logger;

public class Queue {
	private static Logger log = Logger.getLogger(Queue.class);
	
	/** Queue의 이름 */
	private String name = null;
	
	/** 내부적으로 사용할 LinkedList */
	private LinkedList elements = null;
	
	private int maxLimit = -1;
	
	/**
	 * 생성자.
	 * @param name Queue의 이름
	 */
	public Queue(String name) {
		super();
		this.name = name;
		this.elements = new LinkedList();
	}
	
	public Queue(String name, int maxLimit) {
		super();
		this.name = name;
		this.elements = new LinkedList();
		this.maxLimit = maxLimit;
	}
	
	/**
	 * Queue의 이름을 리턴한다.
	 * @return	Queue의 이름
	 */
	public String getName() {
		return this.name;
	}
	
	/**
	 * Object를 Queue에 put한다.
	 */
	public synchronized void put(Object object) throws Exception {
		if ( maxLimit > -1 && size() >= maxLimit ) {
			throw new Exception("최대 QueueSize[" + maxLimit + "]를 초과하였습니다."); 
		}
		
		elements.addLast(object);
		notify();
	}
	
	/**
	 * Queue의 첫번째 Object를 가져오면서 Queue 내부에서 제거한다.
	 * 만일 Object가 없다면, 있을 때까지 wait한다.
	 * 
	 * @return	dequeuing되는 객체
	 */
	public synchronized Object pull() {
		while ( isEmpty() ) {
			try {
				wait();
			} catch(InterruptedException ex) {	}
		}
		return get();
	}
	
	/**
	 * Queue의 첫번째 Object를 가져오면서 Queue 내부에서 제거한다.
	 * 지정된 시간(<code>timeout</code>)이 지나면 Exception이 발생된다.
	 * <br>
	 * pull(0)은 pull()과 동일하다.
	 *  
	 * @param	timeout timeout 시간. long
	 * @return	dequeuing되는 객체
	 * @throws	Exception timeout 발생시.
	 */
	public synchronized Object pull(long timeout) throws Exception {
		Object obj = null;
		long _timeout = timeout;
		long startTime = System.currentTimeMillis();
		
		while ( _timeout >= 0 && elements.isEmpty() ) {
			try { wait(_timeout); } catch(Exception e) {}
			
			if ( elements.isEmpty() ) {
				_timeout = _timeout - ( System.currentTimeMillis()-startTime);
			} else {
				obj = get();
				break;
			}
		}
		
		
		//notify();
		if ( obj == null ) throw new Exception("Queue의 Pull Timeout[" + timeout + "] 발생"); 
		
		return obj;
	}
	
	/**
	 * Queue의 첫번째 Object를 가져오면서 Queue 내부에서 제거한다.
	 * 만일 Object가 없다면, <code>null</code>를 리턴한다.
	 */
	public synchronized Object get() {
		Object object = peek();
		if ( object != null )
			elements.removeFirst();
		return object;
	}
	
	/**
	 * Queue의 첫번째 Object를 Queue 내부에 유지시킨 채로 리턴한다.
	 * 만일 Object가 없다면 <code>null</code>를 리턴한다.
	 */
	public Object peek() {
		if ( isEmpty() )
			return null;
		return elements.getFirst();
	}
	
	/**
	 * 현재 Queue가 비어있는지를 리턴한다.
	 * @return	true:비어있음. false:element가 있음.
	 */
	public boolean isEmpty() {
		return elements.isEmpty();
	}
	
	/**
	 * Queue의 size를 리턴한다.
	 * @return	Queue의 size
	 */
	public int size() {
		return elements.size();
	}
	
	/**
	 * Queue의 상태를 출력한다.
	 */
	public void printStatus() {
		log.debug("QueueName [" + this.name + "] Size [" + this.size() + "]");
	}
	
	public String toString() {
		return "iEBP BaseQueue [" + elements.toString() + "]";
	}
}

#!/bin/sh

# -----------------------------------------------------------------------------
# Start/Stop Script for the eXperDBMA Server
#
# Environment Variable Prerequisites
#
# 	서버 hostname
		SERVER_HOSTNAME=127.0.0.1

# 	JMXREMOTE PORT
		JMXREMOTE_PORT=3333

# 	AGENT 홈디렉토리
		eXperDBMA_HOME=`dirname $(readlink -f $0)`/../.

# 	AGENT 프로세스명
		DNAME=eXperDBMA.process.name=eXperDBMA_POSTGRESQL

#
# -----------------------------------------------------------------------------


boot()
{
		PID=0
		
		IS_eXperDBMA_PID() {
		    PID=`ps -ef|grep ${DNAME}|grep -v grep|awk '{print $2}'`
		}
		PRINT_LOGO() {
			echo "   "
			echo "   ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"
			echo "   ▒                                                                   ▒"
			echo "   ▒          X      X                             DDDDDD     BBBBBBB  ▒"  
			echo "   ▒           X    X                              D     D    B      B ▒"  
			echo "   ▒  eeee      X  X     ppppp    eeee     r   r   D      D   B      B ▒"  
			echo "   ▒ e    e      X       p    p  e    e    r r     D      D   BBBBBBB  ▒"  
			echo "   ▒ eeeeee     X  X     p ppp   eeeeee    rr      D      D   B      B ▒"  
			echo "   ▒ e         X    X    p       e         r       D     D    B      B ▒"  
			echo "   ▒  eeee    X      X   p        eeee    rrr      DDDDDD     BBBBBBB  ▒"  
			echo "   ▒                                                                   ▒"
			echo "   ▒       SSSSS                                                       ▒"
			echo "   ▒      S     S                                                      ▒"
			echo "   ▒      S         eeee   r   r  v       v   eeee    r   r            ▒"
			echo "   ▒       SSSSS   e    e  r r     v     v   e    e   r r              ▒"
			echo "   ▒            S  eeeeee  rr       v   v    eeeeee   rr               ▒"
			echo "   ▒      S     S  e       r         v v     e        r                ▒"
			echo "   ▒       SSSSS    eeee  rrr         v       eeee   rrr               ▒"
			echo "   ▒                                                                   ▒"
			echo "   ▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒"
			echo "   "
		}
		
		IS_eXperDBMA_PID
		
		if [ "$PID" = "" ]; then
		    PRINT_LOGO
		    echo "   [`date`] Server Starting..."
		    cd ${eXperDBMA_HOME}/bin
		    java -Djava.rmi.server.hostname=${SERVER_HOSTNAME} -Dcom.sun.management.jmxremote.port=${JMXREMOTE_PORT} -Dcom.sun.management.jmxremote.ssl=false -Dcom.sun.management.jmxremote.authenticate=false -D${DNAME} -Xmx2048m -DeXperDBMA.config=eXperDBMA.config -DeXperDBMA_HOME=${eXperDBMA_HOME}/ -DCONFIG_DIR=config -classpath ../:../lib/commons-collections-3.1.jar:../lib/commons-dbcp-1.2.1.jar:../lib/commons-pool-1.2.jar:../lib/log4j-1.2.17.jar:../lib/mybatis-3.2.5.jar:../lib/postgresql-9.3-1100.jdbc4.jar:../lib/commons-codec-1.9.jar:../lib/json-simple-1.1.1.jar experdb.mnt.Server &
		    sleep 1
		    IS_eXperDBMA_PID
		    echo "   [`date`] Booting SUCCESS!!! (PID : $PID)"
		    echo " "
		else
		    echo "   Server is already run"
		    echo "   exit..."
		fi
}


down()
{
		CNT=`ps -ef | grep ${DNAME} | grep -v grep|wc -l`
		
		if [ $CNT -eq 1 ]; then
		
		  echo " "
		  echo "   ▒▒▒▒▒▒▒▒▒▒▒▒▒▒"
		  echo "   ▒                        ▒"
		  echo "   ▒        STOP eXperDBMA       ▒"
		  echo "   ▒                        ▒"
		  echo "   ▒▒▒▒▒▒▒▒▒▒▒▒▒▒"
		  echo "   [`date`] Try shutdown"
		  ps -ef | grep ${DNAME} | grep -v grep| awk '{print "kill -9 "$2}'|sh
		  sleep 1
		  echo "   [`date`] Shutdown SUCCESS!!!"
		  echo " "
		  
		elif [ $CNT -eq 0 ]; then
		  echo "   No Process"
		else
		  echo "   ambiguous Process"
		fi
}



ARGV="$@"

case "$ARGV" in
	start)
		boot
	;;

	
	stop)
		down
	;;


	restart)
		down
		boot
	;;

	
	now)
		ps -ef | grep ${DNAME} | grep -v "grep"
	;;

	
	*)
		echo "Usage: eXperDBMA.sh ( commands ... )"
		echo "commands:"
		
		echo "  start            Start eXperDBMA in a separate window"
		echo "  stop             Stop eXperDBMA"
		echo "  restart          Restart eXperDBMA"
		echo "  now              The process of running"
	;;
esac
exit 0



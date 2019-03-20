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
      echo "   **********************************"
      echo "   *    __  __            __  ___   *"
      echo "   *  __\ \/ /___ ___ _ _|  \|   \  *"
      echo "   * / _ \  /|- _/ _ ) '_| | | ' /  *"
      echo "   * \___/  \|_| \___|_| | | | ' \  *"
      echo "   *    /_/\_\           |__/|___/  *"
      echo "   **********************************"
			echo "   "
		}
		
		IS_eXperDBMA_PID
		
		if [ "$PID" = "" ]; then
		    PRINT_LOGO
		    echo "   [`date`] Server Starting..."
		    cd ${eXperDBMA_HOME}/bin
		    java -Djava.rmi.server.hostname=${SERVER_HOSTNAME} -Dcom.sun.management.jmxremote.port=${JMXREMOTE_PORT} -Dcom.sun.management.jmxremote.ssl=false -Dcom.sun.management.jmxremote.authenticate=false -D${DNAME} -Xmx2048m -DeXperDBMA.config=eXperDBMA.config -DeXperDBMA_HOME=${eXperDBMA_HOME}/ -DCONFIG_DIR=config -classpath ../:../lib/commons-collections-3.1.jar:../lib/commons-dbcp-1.4.jar:../lib/commons-pool-1.6.jar:../lib/log4j-1.2.17.jar:../lib/mybatis-3.2.5.jar:../lib/postgresql-42.2.2.jre7.jar:../lib/commons-codec-1.9.jar:../lib/json-simple-1.1.1.jar experdb.mnt.Server &
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



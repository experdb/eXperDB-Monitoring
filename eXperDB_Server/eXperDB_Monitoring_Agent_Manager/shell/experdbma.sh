#!/bin/sh

# -----------------------------------------------------------------------------
# Start/Stop Script for the eXperDBMA Server
#
# Environment Variable Prerequisites
#
# 	서버 hostname
		SERVER_HOSTNAME=127.0.0.1

# 	JMXREMOTE PORT
		JMXREMOTE_PORT=3301

# 	Manager AGENT 홈디렉토리
		eXperDBMA_HOME=`dirname $(readlink -f $0)`/../.

# 	AGENT 프로세스명
		DNAME=eXperDBMA.process.name=eXperDBMA_MANAGER_POSTGRESQL

# 	AGENT 홈디렉토리
		AGENT_HOME=`dirname $(readlink -f $0)`/../../eXperDBMA

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
		    echo "   [`date`] eXperDBMA_Manager Server Starting..."
		    cd ${eXperDBMA_HOME}/bin
		    java -Djava.rmi.server.hostname=${SERVER_HOSTNAME} -Dcom.sun.management.jmxremote.port=${JMXREMOTE_PORT} -Dcom.sun.management.jmxremote.ssl=false -Dcom.sun.management.jmxremote.authenticate=false -D${DNAME} -Xmx2048m -DeXperDBMA.config=eXperDBMA.config -DeXperDBMA_HOME=${eXperDBMA_HOME}/ -DAGENT_HOME=${AGENT_HOME}/ -DCONFIG_DIR=config -classpath ../:../lib/commons-collections-3.1.jar:../lib/commons-dbcp-1.2.1.jar:../lib/commons-pool-1.2.jar:../lib/log4j-api-2.17.1.jar:../lib/log4j-core-2.17.1.jar:../lib/mybatis-3.2.5.jar:../lib/postgresql-42.2.22.jar:../lib/commons-codec-1.9.jar:../lib/json-simple-1.1.1.jar:../lib/quartz-2.3.0-SNAPSHOT.jar:../lib/quartz-jobs-2.3.0-SNAPSHOT.jar:../lib/slf4j-log4j12-1.7.25.jar:../lib/slf4j-api-1.7.25.jar:../lib/slf4j-api-1.7.25.jar:../lib/log4j-slf4j-impl-2.17.0.jar experdb.mnt.Server &
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
      echo "   **********************************"
      echo "   *                                *"
		  echo "   *    STOP eXperDBMA Manager      *"
		  echo "   *                                *"
      echo "   **********************************"
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



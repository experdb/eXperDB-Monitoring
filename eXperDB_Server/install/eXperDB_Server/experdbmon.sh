#!/bin/sh

MANAGERPATH=eXperDBMA_MANAGER
SERVERPATH=eXperDBMA
MANAGERBIN=${MANAGERPATH}/bin
SERVERBIN=${SERVERPATH}/bin
MANAGERCONF=${MANAGERPATH}/config
SERVERCONF=${SERVERPATH}/config

ARGV="$@"

case "$ARGV" in
# for k8s
    kstart)
        if [ ! -z ${EXPERDBREPO} ] ; then
                sed -i "s/127.0.0.1/${EXPERDBREPO}/g" $SERVERCONF/MyBatisConfig.xml
                sed -i "s/127.0.0.1/${EXPERDBREPO}/g" $MANAGERCONF/MyBatisConfig.xml
        fi
        for ((i=0;i<=5;i++))
        do
                ${SERVERBIN}/experdbma.sh restart
                ${MANAGERBIN}/experdbma.sh restart
                sleep 20
                ISRUN=`${SERVERBIN}/experdbma.sh now|wc -l`
                if [ $ISRUN -gt 0 ]; then
                        break;
                fi
        done
    ;;
    start|stop|restart|now)
        ${SERVERBIN}/experdbma.sh $@
        ${MANAGERBIN}/experdbma.sh $@
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

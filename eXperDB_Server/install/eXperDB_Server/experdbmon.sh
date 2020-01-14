#!/bin/sh

MANAGERPATH=eXperDBMA_MANAGER
SERVERPATH=eXperDBMA
MANAGERBIN=${MANAGERPATH}/bin
SERVERBIN=${SERVERPATH}/bin

ARGV="$@"

case "$ARGV" in
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

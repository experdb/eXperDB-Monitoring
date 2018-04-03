#!/usr/bin/env sh
#import SCRIPT_DIR

cd `dirname $0`
SCRIPT_DIR=`pwd`

EXPERDB_AGENT=eXperDB_Agent
EXPERDB_AGENT_HOME=$SCRIPT_DIR
export EXPERDB_AGENT_HOME
EXPERDB_INSTALL_DIR=$EXPERDB_AGENT_HOME/install/eXperDB_Server
EMA=eXperDB_Monitoring_Agent
EMAM=eXperDB_Monitoring_Agent_Manager
EMA_DIR_NAME=eXperDBMA
EMAM_DIR_NAME=eXperDBMA_MANAGER

do_packing()
{
	echo do_packing
	VERSION=$1
	echo $VERSION
  cp -a ${EXPERDB_AGENT_HOME}/${EMA}/build/${EMA_DIR_NAME} ${EXPERDB_INSTALL_DIR}
  cp -a ${EXPERDB_AGENT_HOME}/${EMAM}/build/${EMAM_DIR_NAME} ${EXPERDB_INSTALL_DIR}
  dos2unix ${EXPERDB_INSTALL_DIR}/${EMA_DIR_NAME}/bin/*
  dos2unix ${EXPERDB_INSTALL_DIR}/${EMAM_DIR_NAME}/bin/*
  #tar zcvf ${EXPERDB_AGENT}_${VERSION}.tar.gz ${EMA_DIR_NAME} ${EMAM_DIR_NAME}
  #rm -rf ${EMA_DIR_NAME} ${EMAM_DIR_NAME}
}

build_agent()
{
	echo build_agent
	ant -buildfile eXperDB_Monitoring_Agent/ant_build/build.xml
	ant -buildfile eXperDB_Monitoring_Agent_Manager/ant_build/build.xml
}

build_agent

mkdir -p ${EXPERDB_INSTALL_DIR}

(cd ${EXPERDB_INSTALL_DIR} && do_packing $1)

echo "...done"
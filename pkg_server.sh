#!/bin/sh

cd `dirname $0`

mkdir -p install/eXperDB_Server
echo install/eXperDB_Server--------------------
cp -a eXperDB_Server/install/eXperDB_Server/* install/eXperDB_Server
cp -a eXperDB_Repository/eXperDB_Repository install/eXperDB_Server
cp -a eXperDB_Repository/eXperDB_Repository/install.sh install/eXperDB_Server
mkdir -p install/eXperDB_Server/files
cp -a install/${2}* install/eXperDB_Server/files/
#(cd install; tar zcvf eXperDB_Server_$1.tar.gz eXperDB_Server)
(cd install; tar zcvf eXperDB_Server_$1.tar.gz eXperDB_Server; rm -rf eXperDB_Server)

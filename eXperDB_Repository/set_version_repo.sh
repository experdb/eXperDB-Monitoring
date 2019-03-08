#!/bin/sh

cd `dirname $0`

cp -f ./pgmon_repository.txt ./pgmon_repository.sh
sed -i "s|\${EXPERDB_VERSION}|$3|g" ./pgmon_repository.sh
dos2unix ./pgmon_repository.sh install.sh
rm -rf eXperDB_Repository*
mkdir -p eXperDB_Repository
cp -a install.sh Korean_License.txt Korean_License.rtf ./pgmon_repository.sh eXperDB_Repository

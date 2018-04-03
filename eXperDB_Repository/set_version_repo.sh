#!/bin/sh

cd `dirname $0`

cp -f ./pgmon_repository.tmp.sql ./pgmon_repository.sql
sed -i "s|EXPERDB_VERSION|$1|g" ./pgmon_repository.sql
dos2unix pgmon_repository.sql install.sh
rm -rf eXperDB_Repository*
mkdir -p eXperDB_Repository
cp -a install.sh Korean_License.txt Korean_License.rtf pgmon_repository.sql eXperDB_Repository

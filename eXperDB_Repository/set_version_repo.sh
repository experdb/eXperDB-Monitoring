#!/bin/sh

cd `dirname $0`

cp -f ./pgmon_repository.tmp.sql ./pgmon_repository.sql
sed -i "s|EXPERDB_VERSION|$1|g" ./pgmon_repository.sql
dos2unix pgmon_repository.sql install.sh
rm -f eXperDB_Repository.tar.gz
mkdir eXperDB_Repository_$2
cp -a install.sh Korean_License.txt Korean_License.rtf pgmon_repository.sql eXperDB_Repository_$2
tar zcvf eXperDB_Repository_$2.tar.gz eXperDB_Repository_$2

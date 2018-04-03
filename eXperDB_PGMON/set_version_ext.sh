#!/bin/sh

cd `dirname $0`

dos2unix *.sql *.sh Makefile
rm -f eXperDB_PGMON*.tar.gz
mkdir -p eXperDB_PGMON_$1
cp -a experdb_pgmon.c experdb_pgmon.control experdb_pgmon--1.0.sql experdb_pgmon--unpackaged--1.0.sql \
      Korean_License.rtf Korean_License.txt Makefile uninstall.sh eXperDB_PGMON_$1
tar zcvf eXperDB_PGMON_$1.tar.gz eXperDB_PGMON_$1

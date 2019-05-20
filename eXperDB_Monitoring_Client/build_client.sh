#!/bin/sh

cd `dirname $0`

gen_version_assemblyinfo()
{		
    infofile=AssemblyInfo.vb
    echo "* write version config on '$infofile'"
    tmpfile=$infofile.tmp
    sed -e "s,\(AssemblyVersion(\)\"[^\"]*\",\1\"$1\"," \
        -e "s,\(AssemblyFileVersion(\)\"[^\"]*\",\1\"$1\"," $infofile > $tmpfile
    mv $tmpfile $infofile
}

set_version_installer()
{		
    infofile=Monitoring.iss
    echo "* write version config on '$infofile'"
    tmpfile=$infofile.tmp
    sed -e "s,\(MyAppVersion \)\"[^\"]*\",\1\"$1\"," \
        -e "s,\(MyAppVersionDir \)\"[^\"]*\",\1\"$2\"," $infofile > $tmpfile
    mv $tmpfile $infofile
}

(cd "iDast.MonPostgres/My Project/" && gen_version_assemblyinfo $1)
(cd "eXperDB.Downloader/My Project/" && gen_version_assemblyinfo $1)

msbuild.exe eXperDB.MonPostgres.sln -t:Clean -p:Configuration=Release
msbuild.exe eXperDB.MonPostgres.sln -t:Rebuild -p:Configuration=Release
msbuild.exe eXperDB.MonPostgres.sln -t:Publish -p:Configuration=Release -p:PublishDir=../eXperDB_Mon_Postgres_InnoSetup/Bin/ -p:ApplicationVersion=$1

(cd "eXperDB_Mon_Postgres_InnoSetup" && set_version_installer $1 $2)

ISCC.exe eXperDB_Mon_Postgres_InnoSetup/Monitoring.iss

@ECHO off

@setlocal

SET "PATH=%PATH%;%PROGRAMFILES%\Git\bin;C:\apache-ant-1.9.9-bin;C:\Program Files (x86)\Inno Setup 5;"

For /F %%g in ('git rev-parse HEAD ^| cut -b 1-7') Do (Set GIT_COMMIT_HASH=%%g)

set BASE_VER=10.4.4
set BASE_VER_UDERSCORE=10_4_4
For /F %%i in ('git rev-list HEAD ^| find /c /v ""') Do Set GIT_COMMIT_CNT=%%i


SET CLI=t
SET SVR=t
SET REP=t
SET DST=t

IF "%1"=="C" (
	SET CLI=t
	SET SVR=f
	SET REP=f
	SET DST=f
) ELSE IF "%1"=="S" (
	SET CLI=f
	SET SVR=t
	SET REP=f
	SET DST=f
) ELSE IF "%1"=="R" (
	ECHO "%1"
	SET CLI=f
	SET SVR=f
	SET REP=t
	SET DST=f
) ELSE IF "%1"=="E" (
	SET CLI=f
	SET SVR=f
	SET REP=f
	SET DST=t
)

IF "%CLI%"=="t" (
	ECHO "Build Client"
	sh -e eXperDB_Monitoring_Client\build_client.sh %BASE_VER%.%GIT_COMMIT_CNT% %BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%  
)
IF "%SVR%"=="t" (
	ECHO "Build Server"
	sh -e eXperDB_Server\build-agent.sh %BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%_%GIT_COMMIT_HASH%
)
IF "%REP%"=="t" (
	ECHO "Build Repository"
	sh -e eXperDB_Repository\set_version_repo.sh %BASE_VER%.%GIT_COMMIT_CNT%.%GIT_COMMIT_HASH% %BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%_%GIT_COMMIT_HASH% %BASE_VER%.%GIT_COMMIT_CNT%
)
IF "%DST%"=="t" (
	ECHO "Build DSTension"
	sh -e eXperDB_PGMON\set_version_ext.sh %BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%_%GIT_COMMIT_HASH%
)

md install

IF "%CLI%"=="t" (
	copy "eXperDB_Monitoring_Client\eXperDB_Mon_Postgres_InnoSetup\Output\eXperDB.Monitoring_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%.exe" install
	bash -c "md5sum install/eXperDB.Monitoring_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%.exe | awk '{print toupper($1)}' > install/eXperDB.Monitoring_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%.exe.md5"
)
REM IF "%SVR%"=="t" (
REM	copy eXperDB_Server\install\eXperDB_Agent_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%_%GIT_COMMIT_HASH%.tar.gz install
REM )
REM IF "%REP%"=="t" (
REM	copy eXperDB_Repository\eXperDB_Repository_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%_%GIT_COMMIT_HASH%.tar.gz install
REM )

IF "%REP%"=="t" (
	sh -e pkg_server.sh %BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%_%GIT_COMMIT_HASH% eXperDB.Monitoring_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%.exe
) else (
	IF "%SVR%"=="t" (
		sh -e pkg_server.sh %BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%_%GIT_COMMIT_HASH% eXperDB.Monitoring_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%.exe
	)
)
IF "%DST%"=="t" (
	copy eXperDB_PGMON\eXperDB_PGMON_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%_%GIT_COMMIT_HASH%.tar.gz install
)
@endlocal

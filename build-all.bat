@ECHO off

@setlocal

SET "PATH=%PATH%;%PROGRAMFILES%\Git\bin;C:\apache-ant-1.9.9-bin;C:\Program Files (x86)\Inno Setup 5;"

set BASE_VER=1.1.1
set BASE_VER_UDERSCORE=1_1_1
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
	sh -e eXperDB_Server\build-agent.sh %BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%
)
IF "%REP%"=="t" (
	ECHO "Build Repository"
	sh -e eXperDB_Repository\set_version_repo.sh %BASE_VER%.%GIT_COMMIT_CNT% %BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%
)
IF "%DST%"=="t" (
	ECHO "Build DSTension"
	sh -e eXperDB_PGMON\set_version_ext.sh %BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%
)

md install

IF "%CLI%"=="t" (
	copy "eXperDB_Monitoring_Client\DX_Mon_Postgres_InnoSetup\Output\eXperDB.Monitoring_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%.exe" install
)
IF "%SVR%"=="t" (
	copy eXperDB_Server\install\eXperDB_Agent_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%.tar.gz install
)
IF "%REP%"=="t" (
	copy eXperDB_Repository\eXperDB_Repository_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%.tar.gz install
)
IF "%DST%"=="t" (
	copy eXperDB_PGMON\eXperDB_PGMON_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%.tar.gz install
)
@endlocal
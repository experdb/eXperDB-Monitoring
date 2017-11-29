@ECHO off

@setlocal

SET "PATH=%PATH%;%PROGRAMFILES%\Git\bin;C:\apache-ant-1.9.9-bin;C:\Program Files (x86)\Inno Setup 5;"

ECHO Build Monitoring Client
set BASE_VER=1.1.1
set BASE_VER_UDERSCORE=1_1_1
For /F %%i in ('git rev-list HEAD ^| find /c /v ""') Do Set GIT_COMMIT_CNT=%%i

echo Build Monitorin Client
sh -e eXperDB_Monitoring_Client\build_client.sh %BASE_VER%.%GIT_COMMIT_CNT% %BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%
sh -e eXperDB_Server\build-agent.sh %BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%
sh -e eXperDB_Repository\set_version_repo.sh %BASE_VER%.%GIT_COMMIT_CNT% %BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%
sh -e eXperDB_PGMON\set_version_ext.sh %BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%

md install

copy "eXperDB_Monitoring_Client\DX_Mon_Postgres_InnoSetup\Output\eXperDB.Monitoring_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%.exe" install
copy eXperDB_Server\install\eXperDB_Agent_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%.tar.gz install
copy eXperDB_Repository\eXperDB_Repository_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%.tar.gz install
copy eXperDB_PGMON\eXperDB_PGMON_%BASE_VER_UDERSCORE%_%GIT_COMMIT_CNT%.tar.gz install

@endlocal
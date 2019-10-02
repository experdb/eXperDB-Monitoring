## v11.5.1

- CPU/Memory 사용률 관제(SMS) 추가
- HA Status, Virtual IP, Replication Slot 에대한 알럿 설정
- 알럿 설정화면 개선 및 일괄 설정
- 40개 동시 모니터링
- SMS 문자 내용 세분화
- Dashboard Radar 아이콘 표시
- Dashboard Health check 속도 개선(In memory query 제거)
- Partition table / constraint 생성 오류 개선(Hourly batch)
- Slave 중단시 Replication slot alert 발생 이슈 개선
- Alert insert 오류 개선
- Host name 상이시 수집 예외 적용
- 16개 이상의 클러스터 동시 등록시 초기 데이터 수집 제한
- 클러스터 등록 제한시 메시지 오류 수정


## v10.4.2

- Statements 통계 기능 추가
- 다중 클러스터 트렌드 차트
- 메인화면 Instance list 계층화
- 메모리, 디스크 사용률 트렌드 추가
- Autovacuum 활동정보 수집
- replication lag에 대한 Alert 추가
- replication lag에 대한 지연 크기 정보 수집
- ODBC driver 업데이트 (9.02->10.3)
- Client-Server version check
- 차트 성능 개선
- 수집데이터 성능 개선(partitioning 및 autovacuum)
- Wait progress 표시(Autovacuum, Timeline, Report, Statements)
- Physical Read 정보 수집
- 사용자  정보 수집
- 데이터베이스 정보 수집
- 실시간 구문 수집 기능 추가
- 클러스터 모니터링에서 세션 및 Lock 상세화
- 클러스터 모니터링 컬러톤 변경


## v10.4.1

Improvements
- 리포트 기능개선(Dashboard)
- 다중 클러스터 트렌드 기능 추가(Dashboard)
- Lock trend 분석 (실시간 분석 화면)
- bloating 정보 조회 기능 추가 (개별 상세 화면)
- TPS 차트 기능 추가 (개별 상세 화면)
- 차트 변경 기능 추가 (개별 상세 화면)

Fixes
- 1GB 이상 대용량 로그 읽기 오류 수정
- Storage device에서 CDROM drive 제외
- backend state column 추가
- 일부 폼에서 비정상 종료 이슈 수정
- 조회 쿼리 튜닝
- 수집서버 DBCP 패치(1.2.1 -> 1.4)
- 수집서버 POOL 패치(1.2 -> 1.6)
- CP full 이슈 수정 (Max Connection 증가 10 -> 30)
- 클러스터 삭제 이슈 수정


## v10.3.3

Improvements

- 오브젝트 수집주기 설정
- 복제 서버정보수집(v10)
- Dead tuple 수집 및 조회
- 클러스터 리스트 HA 현재 상태 표시
- 모니터링 상세 top 쿼리 통계 정보 추가
- Report/인쇄 기능 추가

Fixes

- 클러스터 3이상일 경우 오브젝트 정보수집 오류 수정
- 복제 지연 시간 오류 수정(지연시간 수집 기준 Last transaction -> 지연발생시간)
- Vacuum Analyze 테이블 크기 단위 오류 수정
- 오브젝트 정보 Database 단위 오류 수정


## v9.6.2

-v10 호환
-	UI Design 개선
-	Monitoring Detail 차트 누적정보 표시
-	대상 DB Version 표기
-	수집대상 서버 정보 암호화(Password)
-	세션/락 리스트 실시간 조회
-	세션 종료 및 쿼리 취소 기능
-	실시간 Alert 리스트 표시
-	Alert 리스트 관리 및 확인 기능
-	경고 일시 중지 기능
-	수집 항목별 상세 차트 및 세션리스트
-	관리자 암호 설정

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iDaaS
{    
    public static class MsgSYS
    {
        // System String - Status
        /// <summary>
        /// STS_READY
        /// </summary>
        public static string STS_READY = "STS_READY";
        public static string STS_CONFIGERROR = "STS_CONFIGERROR";
        public static string STS_SERVERERROR = "STS_SERVERERROR";
        public static string STS_REACHMAXCONN = "STS_REACHMAXCONN";
        public static string STS_PARSEERROR = "STS_PARSEERROR";
        public static string STS_FRAMEWORKERROR = "STS_FRAMEWORKERROR";
        public static string STS_ERROR = "STS_ERROR";

        public static string STS_PATCH = "STS_PATCH";        
    }
    public static class MsgERR
    {
        // Error Message    
        /// <summary>
        /// 오류 발생으로 작업을 완료하지 못했습니다.
        /// </summary>
        public static string ERR_COMPLETE = "오류 발생으로 작업을 완료하지 못했습니다.";
        /// <summary>
        /// 해당 오류가 다시 발생할 시 관리부서에 문의 바랍니다.
        /// </summary>
        public static string ERR_RETASK = "해당 오류가 다시 발생할 시 관리부서에 문의 바랍니다.";
        /// <summary>
        /// 관리자에게 문의 바랍니다.
        /// </summary>
        public static string ERR_ASK = "관리자에게 문의 바랍니다.";
        /// <summary>
        /// 오류가 발생하였습니다.
        /// </summary>
        public static string ERR_ERROR = "오류가 발생하였습니다.";
        /// <summary>
        /// 잠시후에 다시 시도해 주시기 바랍니다.
        /// </summary>
        public static string ERR_RETRY = "잠시후에 다시 시도해 주시기 바랍니다.";
        /// <summary>
        /// 서버에서 오류가 발생했습니다.
        /// </summary>
        public static string ERR_SVRERROR = "서버에서 오류가 발생했습니다.";
        /// <summary>
        /// 허용된 접속자 수를 초과하였습니다.
        /// </summary>
        public static string ERR_REACHMAXCONN = "허용된 접속자 수를 초과하였습니다.";
        /// <summary>
        /// 파일 적용 중 문제가 발생하였습니다.
        /// </summary>
        public static string ERR_COMMIT = "파일 적용 중 문제가 발생하였습니다.";
        /// <summary>
        /// 네트워크 혹은 업데이트 서버의 문제로 업데이트를 실행할 수 없습니다.
        /// </summary>
        public static string ERR_NETWORK = "네트워크 혹은 업데이트 서버의 문제로 업데이트를 실행할 수 없습니다.";
        /// <summary>
        /// 설정 정보가 잘못되어 업데이트를 실행할 수 없습니다.
        /// </summary>
        public static string ERR_SETTING = "설정 정보가 잘못되어 업데이트를 실행할 수 없습니다.";
        /// <summary>
        /// 실행 중 문제가 발생하였습니다.
        /// </summary>
        public static string ERR_RUN = "실행 중 문제가 발생하였습니다.";
        /// <summary>
        /// 다음과 같은 에러가 발생하였습니다
        /// </summary>
        public static string ERR_FOLLOW = "다음과 같은 에러가 발생하였습니다";
        /// <summary>
        /// 실패
        /// </summary>
        public static string ERR_FAIL = "실패";
    }
    public static class MsgForm
    {
        /// <summary>
        /// 작업 완료
        /// </summary>
        public static string COMPLETE = "작업 완료";
        /// <summary>
        /// 업데이트가 완료되었습니다.
        /// </summary>
        public static string COMPLETEUP = "업데이트가 완료되었습니다.";
        /// <summary>
        /// 닫기
        /// </summary>
        public static string CLOSE = "닫기";
        /// <summary>
        /// 로그 보기
        /// </summary>
        public static string LOG = "로그 보기";
        /// <summary>
        /// 작업 취소
        /// </summary>
        public static string CANCEL = "작업 취소";
        /// <summary>
        /// 업데이트
        /// </summary>
        public static string UPDATECANCEL = "업데이트 작업 취소";
        /// <summary>
        /// 업데이트
        /// </summary>
        public static string UPDATE = "업데이트";
        /// <summary>
        /// 업데이트 진행중...
        /// </summary>
        public static string UPDATEPROGRESS = "업데이트 진행중...";
        /// <summary>
        /// 업데이트 문제 발생
        /// </summary>
        public static string PROBLEM = "업데이트 문제 발생";
        /// <summary>
        /// 데이터 체크 중입니다. 잠시만 기다려 주세요.
        /// </summary>
        public static string DATAWAIT = "데이터 체크 중입니다. 잠시만 기다려 주세요.";
    }


    public static class Msg
    {
        // Normal Message
        /// <summary>
        /// 파일 적용을 완료하였습니다.
        /// </summary>
        public static string DEF_SETFILECOMPLETE = "파일 적용을 완료하였습니다.";
        /// <summary>
        /// 설정 변경사항 적용 완료
        /// </summary>
        public static string DEF_SETCONFCOMPLETE = "설정 변경사항 적용 완료";
        /// <summary>
        /// 업데이트 프로세스 종료
        /// </summary>
        public static string DEF_PROCCOMPLETE = "업데이트 프로세스 종료";
        /// <summary>
        /// 업데이트 프로세스 시작
        /// </summary>
        public static string DEF_PROCSTART = "업데이트 프로세스 시작";
        /// <summary>
        /// 업데이트가 완료되었습니다.
        /// </summary>
        public static string DEF_SETCOMPLETE = "업데이트가 완료되었습니다.";
        /// <summary>
        /// 파일이 현재 최신 버전입니다.
        /// </summary>
        public static string DEF_NOCHANGE = "파일이 현재 최신 버전입니다.";        
        /// <summary>
        /// 잠시 기다려 주시기 바랍니다.
        /// </summary>
        public static string DEF_WAIT = "잠시 기다려 주시기 바랍니다.";
        /// <summary>
        /// 업데이트 준비가 완료되었습니다.
        /// </summary>
        public static string DEF_READY = "업데이트 준비가 완료되었습니다.";
        /// <summary>
        /// 프로그램을 다시 실행해 주세요.
        /// </summary>
        public static string DEF_RESTART = "프로그램을 다시 실행해 주세요.";
        /// <summary>
        /// 적용할 파일을 다운로드 중입니다.
        /// </summary>
        public static string DEF_DOWNLOADING = "적용할 파일을 다운로드 중입니다.";
        /// <summary>
        /// 업데이트 다운로드
        /// </summary>
        public static string DEF_DOWNLOAD = "업데이트 다운로드";
        /// <summary>
        /// 추가된 설정요소 적용
        /// </summary>
        public static string DEF_SETCOMMIT = "추가된 설정요소 적용";
        /// <summary>
        /// 파일 적용
        /// </summary>
        public static string DEF_FILECOMMIT = "파일 적용";
        /// <summary>
        /// 파일을 적용하는 중입니다.
        /// </summary>
        public static string DEF_COMMITTING = "파일을 적용하는 중입니다.";
        /// <summary>
        /// i-Dast Update Program
        /// </summary>
        public static string DEF_TITLE="i-Dast Update Program";
        /// <summary>
        /// 성공
        /// </summary>
        public static string DEF_SUCCESS = "성공";
        /// <summary>
        /// 작업을 취소하였습니다.
        /// </summary>
        public static string DEF_CANCEL = "작업을 취소하였습니다.";
    }
}

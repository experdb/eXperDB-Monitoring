using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace iDaaS
{
     
        public delegate void MessageReceiveEventHandler(object sender, MessageReceiveEventArgs e);
        public delegate void ValidateEndEventHandler(object sender, ValidateEndEventArgs e);
        public delegate void DownProgressChangedEventHandler(object sender, DownProgressChangedEventArgs e);
        public delegate void DownProgressCompletedEventHandler(object sender, DownProgressCompletedEventArgs e);
        public delegate void FileApplyEventHandler(object sender, FileApplyEventArgs e);
        public delegate void FileApplyCompletedEventHandler(object sender, FileApplyCompletedEventArgs e);
        public delegate void ConfApplyEventHandler(object sender, ConfApplyEventArgs e);
        public delegate void ConfApplyCompletedEventHandler(object sender, ConfApplyCompletedEventArgs e);
        public delegate void WorkCompletedEventHandler(object sender, WorkCompletedEventArgs e);

        

        public class MessageReceiveEventArgs : EventArgs
        {
            /// <summary>
            /// 결과 메세지
            /// </summary>
            public int result = 0;
            public string errorMsg = "";
            /// <summary>
            /// 결과 메세지
            /// </summary>
            /// <param name="result"></param>
            public MessageReceiveEventArgs(int result, string errorMsg)
            {
                this.result = result;
                this.errorMsg = errorMsg;
            }
        }
        public class ValidateEndEventArgs : EventArgs
        {
            /// <summary>
            /// 파일 확인작업 정상 확인 여부 - True이면 비정상
            /// </summary>
            public Boolean isError = false;
            /// <summary>
            /// 비정상 작업일 시 에러메세지
            /// </summary>
            public string errorMsg = "";
            /// <summary>
            /// 파일 확인작업 정상 확인 여부 - True이면 비정상
            /// </summary>
            /// <param name="isError">비정상 작업일 시 True</param>
            public ValidateEndEventArgs(Boolean isError, string errorMsg)
            {
                this.isError = isError;
                this.errorMsg = errorMsg;
            }
        }
        public class DownProgressChangedEventArgs : EventArgs
        {
            /// <summary>
            /// 
            /// </summary>
            public int Percentage = 0;
            public double bytesIn = 0;
            public double progressMaxValue = 0;
            public DownProgressChangedEventArgs(int Percentage, double bytesIn, double progressMaxValue)
            {
                this.Percentage = Percentage;
                this.bytesIn = bytesIn;
                this.progressMaxValue = progressMaxValue;
            }
        }
        public class DownProgressCompletedEventArgs : EventArgs
        {
            /// <summary>
            /// 파일 다운로드 정상 확인 여부 - True이면 비정상
            /// </summary>
            public Boolean isError = false;
            /// <summary>
            /// 비정상 작업일 시 에러메세지
            /// </summary>
            public string errorMsg = "";
            /// <summary>
            /// 파일 다운로드 정상 확인 여부 - True이면 비정상
            /// </summary>
            /// <param name="isError">비정상 작업일 시 True</param>
            public DownProgressCompletedEventArgs(Boolean isError, string errorMsg)
            {
                this.isError = isError;
                this.errorMsg = errorMsg;
            }
        }
        public class FileApplyEventArgs : EventArgs
        {
            public Boolean isError = false;
            public static int STEP_COPY = 45;
            public static int STEP_END = 46;
            public int step;
            public string applyMsg = "";
            public FileApplyEventArgs(Boolean isError,string applyMsg,int step)
            {
                this.isError = isError;
                this.applyMsg = applyMsg;
                this.step = step;
            }
        }
        public class FileApplyCompletedEventArgs : EventArgs
        {
            /// <summary>
            /// 파일 적용작업 정상 확인 여부 - True이면 비정상
            /// </summary>
            public Boolean isError = false;
            /// <summary>
            /// 비정상 작업일 시 에러메세지
            /// </summary>
            public string errorMsg = "";
            /// <summary>
            /// 파일 적용작업 정상 확인 여부 - True이면 비정상
            /// </summary>
            /// <param name="isError">비정상 작업일 시 True</param>
            public FileApplyCompletedEventArgs(Boolean isError, string errorMsg)
            {
                this.isError = isError;
                this.errorMsg = errorMsg;
            }
        }
        public class ConfApplyEventArgs : EventArgs
        {
            public Boolean isError = false;
            public string applyMsg = "";
            public ConfApplyEventArgs(Boolean isError, string applyMsg)
            {
                this.isError = isError;
                this.applyMsg = applyMsg;                
            }
        }
        public class ConfApplyCompletedEventArgs : EventArgs
        {
            /// <summary>
            /// 설정파일 적용작업 정상 확인 여부 - True이면 비정상
            /// </summary>
            public Boolean isError = false;
            /// <summary>
            /// 비정상 작업일 시 에러메세지
            /// </summary>
            public string errorMsg = "";
            /// <summary>
            /// 설정파일 적용작업 정상 확인 여부 - True이면 비정상
            /// </summary>
            /// <param name="isError">비정상 작업일 시 True</param>
            public ConfApplyCompletedEventArgs(Boolean isError, string errorMsg)
            {
                this.isError = isError;
                this.errorMsg = errorMsg;
            }
        }
        public class WorkCompletedEventArgs : EventArgs
        {
            /// <summary>
            /// 모든 작업 정상 확인 여부 - True이면 비정상
            /// </summary>
            public Boolean isError = false;
            /// <summary>
            /// 비정상 작업일 시 에러메세지
            /// </summary>
            public string errorMsg = "";
            /// <summary>
            /// 모든 작업 정상 확인 여부 - True이면 비정상
            /// </summary>
            /// <param name="isError">비정상 작업일 시 True</param>
            public WorkCompletedEventArgs(Boolean isError, string errorMsg)
            {
                this.isError = isError;
                this.errorMsg = errorMsg;
            }
        }


    
}

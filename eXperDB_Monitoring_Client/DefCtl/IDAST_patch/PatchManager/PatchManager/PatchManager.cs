using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
using Ionic.Zip;
using System.Xml;
using System.Net.Sockets;

namespace iDaaS
{
    /// <summary>
    /// 메인 프로그램에 대한 패치를 수행하는 클래스. 
    /// </summary>
    /// <example>
    /// 해당 클래스의 사용법을 예시한다.
    /// <code>
    /// PatchManager pm = new PatchManager("C:\idaas");
    /// if(pm.getUpdateStatus().Equals("STS_PATCH")
    /// {
    ///     workerThread = new Thread(pm.DoWork);
    ///     workerThread.Start();
    /// }
    /// </code>
    /// </example>
    public class PatchManager
    {
        public static int JSON_COMPLETE = 0;
        public static int JSON_ERROR = 1;
        public static int JSON_XMLPATCH = 2;
        //static MessageContainer MSG;
        /*private JToken jtFileToken;

        private double dblTempSize;
        private double dblReceivedSize;
        private double dblTotalSize;
        private double dblLastbytes;

        private string strResultJson;*/
        private string strPatchDir;
        private string strPatchFile;
        private string strDestURL;
        private string strDestPath;
        private string strDestVer;
        private CookieContainer cookieContainer;
        private bool isFilePatched;
        private bool isFileError;
        private bool isConfigError;

        HttpWebRequest webRequest = null;
        HttpWebResponse webResponse = null;
        
        StreamModule st;
        
        /// <summary>
        /// 메세지 수신 이벤트 핸들러
        /// </summary>
        public event MessageReceiveEventHandler MessageReceiveEvent;
        /// <summary>
        /// 파일 확인 종료 이벤트 핸들러
        /// </summary>
        public event ValidateEndEventHandler ValidateEndEvent;
        /// <summary>
        /// 다운로드 진행 이벤트 핸들러
        /// </summary>
        public event DownProgressChangedEventHandler DownProgressChangedEvent;
        /// <summary>
        /// 다운로드 종료 이벤트 핸들러
        /// </summary>
        public event DownProgressCompletedEventHandler DownProgressCompletedEvent;
        /// <summary>
        /// 파일 적용 진행 이벤트 핸들러
        /// </summary>
        public event FileApplyEventHandler FileApplyEvent;
        /// <summary>
        /// 파일 적용 종료 이벤트 핸들러
        /// </summary>
        public event FileApplyCompletedEventHandler FileApplyCompletedEvent;
        /// <summary>
        /// 설정파일 적용 진행 이벤트 핸들러
        /// </summary>
        public event ConfApplyEventHandler ConfApplyEvent;
        /// <summary>
        /// 설정파일 적용 종료 이벤트 핸들러
        /// </summary>
        public event ConfApplyCompletedEventHandler ConfApplyCompletedEvent;
        /// <summary>
        /// 모든 작업 종료 이벤트 핸들러
        /// </summary>
        public event WorkCompletedEventHandler WorkCompletedEvent;

        protected virtual void OnMessageReceive(MessageReceiveEventArgs e)
        {
            if (MessageReceiveEvent != null)
            {
                MessageReceiveEvent(this, e);
            }
        }
        protected virtual void OnValidateEnd(ValidateEndEventArgs e)
        {
            if (ValidateEndEvent != null)
            {
                ValidateEndEvent(this, e);
            }
        }
        protected virtual void OnDownProgressChanged(DownProgressChangedEventArgs e)
        {
            if (DownProgressChangedEvent != null)
            {
                DownProgressChangedEvent(this, e);
            }
        }
        protected virtual void OnDownProgressCompleted(DownProgressCompletedEventArgs e)
        {
            if (DownProgressCompletedEvent != null)
            {
                DownProgressCompletedEvent(this, e);
            }
        }
        protected virtual void OnFileApply(FileApplyEventArgs e)
        {
            if (FileApplyEvent != null)
            {
                FileApplyEvent(this, e);
            }
        }
        protected virtual void OnFileApplyCompleted(FileApplyCompletedEventArgs e)
        {
            if (FileApplyCompletedEvent != null)
            {
                FileApplyCompletedEvent(this, e);
            }
        }
        protected virtual void OnConfApply(ConfApplyEventArgs e)
        {
            if (ConfApplyEvent != null)
            {
                ConfApplyEvent(this, e);
            }
        }
        protected virtual void OnConfApplyCompleted(ConfApplyCompletedEventArgs e)
        {
            if (ConfApplyCompletedEvent != null)
            {
                ConfApplyCompletedEvent(this, e);
            }
        }
        protected virtual void OnWorkCompleted(WorkCompletedEventArgs e)
        {
            if (WorkCompletedEvent != null)
            {
                WorkCompletedEvent(this, e);
            }
        }

        
        /// <summary>
        /// PatchManager 생성자
        /// </summary>
        /// <param name="strDestPath">메인 프로그램의 root 디렉토리</param>
        /// </param>
        public PatchManager(string strDestPath)
        {
            this.isConfigError = false;
            this.strDestPath = strDestPath.Replace("\"", "");
            Boolean isHasConfig=false;      
            try
            {
                XmlDocument xdConfig = new XmlDocument();
                xdConfig.Load(this.strDestPath + "\\Configure.xml");
                XmlNodeList xeConfigRoot = xdConfig.DocumentElement.SelectSingleNode("public").ChildNodes;
                Debug.WriteLine("xeConfigRoot");
                IEnumerator ien = xeConfigRoot.GetEnumerator();
                Debug.WriteLine("ien");
                while (ien.MoveNext()) 
                {
                    if(((XmlElement)ien.Current).GetAttribute("name").Equals("UpdateServer"))
                    {
                        Debug.WriteLine("do");
                        isHasConfig=true;
                        string strPort = ":" + ((XmlElement)((XmlElement)ien.Current).SelectSingleNode("Port")).GetAttribute("value").Trim();//":8080";
                        string strIP = ((XmlElement)((XmlElement)ien.Current).SelectSingleNode("IpAddress")).GetAttribute("value").Trim();
                        Boolean isSSL = ((XmlElement)((XmlElement)ien.Current).SelectSingleNode("UsingSSL")).GetAttribute("value").Trim().ToUpper().Equals("Y") ? true : false;

                        Debug.WriteLine("Xml Data - IP   : " + strIP);
                        Debug.WriteLine("Xml Data - Port : " + strPort);
                        Debug.WriteLine("Xml Data - Using SSL : " + isSSL);

                        if (strPort.Equals(":80") || strPort.Equals(":443"))
                            strPort = "";

                        this.strDestURL = isSSL ? "https" : "http" + "://" + strIP + strPort + "/validate"; //파일서버
                        //break;
                    }
                }
            }
            catch 
            {
                this.isConfigError = true;
                this.strDestURL = "http://192.168.1.1/validate";
            }
            if (!isHasConfig) 
            {
                this.isConfigError = true;
                this.strDestURL = "http://192.168.1.1/validate";
            }




            Debug.WriteLine("Xml Data - URL   : " + strDestURL);
            this.strDestVer = "iDaaSPkg_1_x_x_xxx";
            this.isFilePatched = false;
            this.isFileError = false; 

            Debug.WriteLine("this encoding = " + Encoding.Default.ToString());
            cookieContainer = new CookieContainer();
            string input = DateTime.Now.ToString("U");
            StringBuilder sbFile = new StringBuilder();
            StringBuilder sbDir = new StringBuilder();

            char[] values = input.ToCharArray();
            Random r = new Random();
            for (int i = 0; i < 9; i++)
            {
                int value = Convert.ToInt32(values[r.Next(0, 12)]);                
                string hexOutput = String.Format("{0:X}", value);
                sbFile.Append(hexOutput);
                value = Convert.ToInt32(values[r.Next(0, 12)]);
                hexOutput = String.Format("{0:X}", value);
                sbDir.Append(hexOutput);
            }
            strPatchDir = sbDir.ToString();
            strPatchFile = sbFile.ToString();
            Debug.WriteLine("Temp file name is " + strPatchFile);
            Debug.WriteLine("Temp path name is " + strPatchDir);

        }
        /// <summary>
        /// 업데이트가 필요한지의 여부를 판단함.
        /// </summary>
        /// <returns>
        /// <para>STS_READY - 모든 파일이 최신. 패치가 필요하지 않습니다.</para>
        /// <para>STS_PATCH - 패치가 필요합니다.</para>
        /// <para>STS_REACHMAXCONN - 허용된 접속자 수를 초과하였습니다.</para>
        /// <para>STS_NETWORKERROR - 네트워크 문제로 패치를 실행할 수 없습니다.</para>
        /// <para>STS_SERVERERROR - 패치 서버에 접속할 수 없습니다.</para>
        /// <para>STS_CONFIGERROR - 설정 파일에 문제가 발생하였습니다.</para>
        /// <para>STS_ERROR - 처리되지 않은 에러가 발생하였습니다.</para>        
        /// </returns>
        public string getUpdateStatus()
        {
            string update = MsgSYS.STS_READY;//"STS_READY";

            if (isConfigError)
                return MsgSYS.STS_CONFIGERROR;//"STS_CONFIGERROR";

            try
            {
                if (!isServerAvailable())
                {
                    return MsgSYS.STS_SERVERERROR;//"STS_SERVERERROR";
                }
                Uri destURI = new Uri(strDestURL);
                Debug.WriteLine("enter validating method");

                JObject sendJson = FileHashFilter.getJson(strDestPath,true);
                sendJson.Add(new JProperty("_patch_ver", strDestVer));
                sendJson.Add(new JProperty("_patch_method", "VALIDATE"));
                
                string jsonData = new JObject(sendJson).ToString();
                byte[] jsonByte = Encoding.Default.GetBytes(jsonData);
                Dictionary<string, string> postData = new Dictionary<string, string>();
                postData.Add("Method", "VALIDATE");
                st = new StreamModule();
                st.setEncoding(Encoding.UTF8);
                try
                {
                    webRequest = HttpWebRequest.Create(destURI) as HttpWebRequest;
                    webResponse = st.sendData(webRequest, jsonData, postData, Encoding.UTF8);
                }
                catch 
                {
                    return MsgSYS.STS_FRAMEWORKERROR;//reqE.ToString();
                }
                st.receiveData(webResponse);

                
                try
                {
                    JObject response = JObject.Parse(st.getJson());
                    if (response.GetValue("_is_error").ToString().ToLower().Equals("true"))
                    {
                        update = MsgSYS.STS_ERROR;//"STS_ERROR";
                    }
                    else if (response.GetValue("_is_update").ToString().ToLower().Equals("true"))
                    {
                        update = MsgSYS.STS_PATCH;//"STS_PATCH";
                    }
                    else if (response.GetValue("_is_maxreach").ToString().ToLower().Equals("true"))
                    {
                        update = MsgSYS.STS_REACHMAXCONN;// "STS_REACHMAXCONN";
                    }
                }
                catch//  (Exception parseE)
                {
                    //return parseE.ToString();
                    return MsgSYS.STS_PARSEERROR;//"STS_PARSEERROR";
                }
            }
            catch// (Exception eE)
            {
                //return eE.ToString();
                return MsgSYS.STS_ERROR;//"STS_ERROR";
            }            
            return update;
        }
        /// <summary>
        /// Configure.xml에 필요한 정보가 있는지를 판단.
        /// </summary>
        /// <returns>true일 시 설정 형식에 문제 없음</returns>
        public bool isConfigGenuine()
        {
            return !isConfigError;
        }
        /// <summary>
        /// 패치 서버에 접속 가능한지 여부를 판단.        
        /// </summary>
        /// <returns>
        /// False인 경우 접속 불가능.
        /// </returns>
        public bool isServerAvailable()
        {
            HttpWebResponse response=null;
            try
            {
                HttpWebRequest request = WebRequest.Create(strDestURL + "?Method=showStatus") as HttpWebRequest;
                IPAddress ipv4Addresses = Array.FindLast(Dns.GetHostEntry(string.Empty).AddressList, a => a.AddressFamily == AddressFamily.InterNetwork);
                request.Headers.Add("WL-Proxy-Client-IP", ipv4Addresses.ToString());
                request.Method = "HEAD";
                response = request.GetResponse() as HttpWebResponse;
                return (response.StatusCode == HttpStatusCode.OK);
            }
            catch
            {
                return false;
            }
            finally
            {
                if (response != null) response.Close();
            }
        }
        
        /// <summary>
        /// 패치 작업 시작
        /// </summary>
        public void DoWork()
        {
            startValidation(false);
        }

        private void startValidation(Boolean isGetJson)
        {            
            Uri destURI = new Uri(strDestURL);
            Debug.WriteLine("enter patch method");

            JObject sendJson = FileHashFilter.getJson(strDestPath);
            
            sendJson.Add(new JProperty("_patch_ver", strDestVer));
            sendJson.Add(new JProperty("_patch_method", "PATCH"));
            sendJson.Add(new JProperty("_patch_error", isFileError));
            
            string jsonData = new JObject(sendJson).ToString();
            Debug.WriteLine("sending json : " + jsonData);
           
            byte[] jsonByte = Encoding.Default.GetBytes(jsonData);
            Dictionary<string, string> postData = new Dictionary<string, string>();
            if (isGetJson)
                postData.Add("Method", "JSON");
            else
                postData.Add("Method", "UPDATE");
            st = new StreamModule();
            st.setEncoding(Encoding.UTF8);
            webRequest = HttpWebRequest.Create(destURI) as HttpWebRequest;

            webRequest.CookieContainer = cookieContainer;
            webResponse=st.sendData(webRequest, jsonData,postData, Encoding.UTF8);
            
            ValidateEndEventArgs vEe = new ValidateEndEventArgs(false, "");
            OnValidateEnd(vEe);            
            
            if (st.result().Equals(StreamModule.FILE))
            {                
                if (!isFilePatched)
                {
                    isFilePatched = true;
                    patchDownload();
                }
                else
                {
                    if (webResponse != null)
                        webResponse.Close();
                    StringBuilder sbError = new StringBuilder();
                    sbError.AppendLine(MsgERR.ERR_COMPLETE);
                    sbError.AppendLine(MsgERR.ERR_RETASK);
                    WorkCompletedEventArgs wCe = new WorkCompletedEventArgs(false, sbError.ToString());//(PatchManager.JSON_COMPLETE, "");
                    OnWorkCompleted(wCe);
                }
            }
            else if (st.result().Equals(StreamModule.JSON))
            {
                st.receiveData(webResponse);
                measureResponseData();                
            }
        }
        private void patchDownload()
        {
            st.receiveData(webResponse, new string[] { strDestPath, strPatchDir, strPatchFile }, ref DownProgressChangedEvent,ref DownProgressCompletedEvent);
            applyFile();
        }
        private void applyFile()
        {
            Debug.WriteLine("extracting start");
            extractZip(strDestPath, strPatchDir, strPatchFile);
            //measureResponseData();
            startValidation(true);
        }
        private void extractZip(String targetPath, String pathDir, String zipFileName)
        {
            string strApplyMsg = "";
            string strErrorMsg = Msg.DEF_SETFILECOMPLETE;
            string winTempDir = System.IO.Path.GetTempPath();
            Boolean isSuccessful = true;
            try
            {                
                string AbsoluteZipPath = winTempDir + "\\" + pathDir + "\\" + zipFileName;
                /// ------------ 적용 전 tmp파일 삭제
                DirectoryInfo targetDi = new DirectoryInfo(targetPath);                
                targetDi.GetFiles("*.tmp", SearchOption.AllDirectories).ToList().ForEach(
                    delegate(FileInfo file)
                    {
                        System.Text.RegularExpressions.Regex cntStr = new System.Text.RegularExpressions.Regex(".");
                        int cntDot = cntStr.Matches(file.FullName, 0).Count;
                        if (cntDot > 1) {
                            file.Delete();
                        }                    
                });

                using (ZipFile zip1 = ZipFile.Read(AbsoluteZipPath))
                {
                    foreach (ZipEntry e in zip1)
                    {
                        try
                        {
                            FileApplyEventArgs fAe = new FileApplyEventArgs(false, e.FileName, FileApplyEventArgs.STEP_COPY);
                            OnFileApply(fAe);
                            String[] strUpdate = { "PatchForm.exe", "PatchManager.dll", "Newtonsoft.Json.dll", "Ionic.Zip.dll" };
                            try
                            {
                                if (strUpdate.Contains(e.FileName))
                                {
                                    Debug.WriteLine("file move : " + e.FileName);
                                    targetDi.GetFiles(e.FileName).ToList().ForEach(file => file.MoveTo(targetPath+"\\"+e.FileName + ".oldFile"));                                    
                                }
                                else
                                {
                                    Debug.WriteLine("file delete : " + e.FileName);
                                    targetDi.GetFiles(e.FileName).ToList().ForEach(file => file.Delete());                                    
                                }
                            }
                            catch (System.IO.DirectoryNotFoundException de)
                            {
                                Debug.WriteLine("Error has occured during post-delete targetfile : " + de);
                            }
                            catch (Exception fe) 
                            {
                                Debug.WriteLine("Error has occured during post-delete targetfile : " + fe);
                            }
                            e.Extract(targetPath, ExtractExistingFileAction.OverwriteSilently);                            
                            fAe = new FileApplyEventArgs(false, "", FileApplyEventArgs.STEP_END);
                            OnFileApply(fAe);
                        }
                        catch (Exception zipE) 
                        {
                            isFileError = true;
                            FileApplyEventArgs fAe = new FileApplyEventArgs(true, zipE.ToString(), FileApplyEventArgs.STEP_END);
                            OnFileApply(fAe);
                        }
                    }
                }               
            }
            catch (Exception e)
            {
                Debug.WriteLine("an exception has occured : " + e.ToString());
                strApplyMsg = e.GetType().ToString() + "\n";
                strErrorMsg = e.ToString();
                isSuccessful = false;
            }
            finally
            {
                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(winTempDir + "\\" + pathDir);

                    if (dirInfo.Exists)
                    {
                        FileInfo[] sfiles = dirInfo.GetFiles();

                        foreach (FileInfo fi in sfiles)
                        {
                            fi.Delete();
                        }
                        dirInfo.Delete();
                    }
                }
                catch (Exception IOe)
                {
                    Debug.WriteLine("an exception has occured in extracting : " + IOe.ToString());
                    isSuccessful = false;
                    strErrorMsg = IOe.ToString();
                }
            }
            FileApplyCompletedEventArgs fAce = new FileApplyCompletedEventArgs(!isSuccessful, strErrorMsg);
            OnFileApplyCompleted(fAce);
        }



        /// <summary>
        /// 서버 Response가 file이 아닌 경우 그에 대한 데이터 검토
        /// [0] : 메세지 코드
        /// [1] : 메세지박스 문자열
        /// [2] : 작업진행창 문자열
        /// </summary>
        /// <returns></returns>
        private void measureResponseData() 
        {
            MessageReceiveEventArgs mRe = new MessageReceiveEventArgs(PatchManager.JSON_COMPLETE, "");
            OnMessageReceive(mRe);
            string[] msg = new string[3] { "","",""};
            
            Debug.WriteLine("received json = " + st.getJson());
            JObject response = JObject.Parse(st.getJson());
            
            try
            {
                if (st.result().Equals(StreamModule.JSON))
                /// JSON 수신 단계 (완료, 오류)
                {
                    if (response.GetValue("_is_error").ToString().ToLower().Equals("true"))
                    {
                        string errorMsg = response.GetValue("_error_msg").ToString().Trim();
                        if (errorMsg.Equals(""))
                        {
                            msg[1] = MsgERR.ERR_ERROR + " \n" + MsgERR.ERR_RETRY;
                            msg[2] = MsgERR.ERR_SVRERROR;
                        }
                        else
                        {
                            msg[1] = MsgERR.ERR_ERROR + " \n" + MsgERR.ERR_ASK;//"오류가 발생하였습니다. \n관리자에게 문의 바랍니다.";
                            msg[2] = MsgERR.ERR_ERROR + " : " + HttpUtility.UrlDecode(errorMsg);
                        }
                        WorkCompletedEventArgs wCe = new WorkCompletedEventArgs(true, msg[1]);//(PatchManager.JSON_COMPLETE, "");
                        OnWorkCompleted(wCe);
                    }
                    else if (response.GetValue("_is_update").ToString().ToLower().Equals("true"))
                    {
                        JObject xmlJson = JObject.Parse(response.GetValue("_xml_list").ToString());
                        PatchXMLData(xmlJson);
                    }
                    else if (response.GetValue("_is_maxreach").ToString().ToLower().Equals("true"))
                    {
                        msg[1] = MsgERR.ERR_REACHMAXCONN + "\n" + MsgERR.ERR_RETRY;//"허용된 접속자 수를 초과하였습니다.\n잠시 후 다시 시도해 주십시오.";
                        msg[2] = MsgERR.ERR_REACHMAXCONN;
                        WorkCompletedEventArgs wCe = new WorkCompletedEventArgs(true, msg[1]);//(PatchManager.JSON_COMPLETE, "");
                        OnWorkCompleted(wCe);
                    }
                    else if (isFileError)
                    {
                        msg[1] = MsgERR.ERR_COMMIT + "\n" + MsgERR.ERR_RETASK;
                        msg[2] = MsgERR.ERR_COMMIT;
                        WorkCompletedEventArgs wCe = new WorkCompletedEventArgs(true, msg[1]);//(PatchManager.JSON_COMPLETE, "");
                        OnWorkCompleted(wCe);
                    }
                    else
                    {
                        msg[1] = Msg.DEF_NOCHANGE;
                        msg[2] = Msg.DEF_NOCHANGE;
                        WorkCompletedEventArgs wCe = new WorkCompletedEventArgs(false, msg[1]);//(PatchManager.JSON_COMPLETE, "");
                        OnWorkCompleted(wCe);
                    }
                }
                else
                /// 파일 적용 단계
                {
                    if (isFileError)
                    {
                        msg[1] = MsgERR.ERR_COMMIT + "\n" + MsgERR.ERR_RETASK;
                        msg[2] = MsgERR.ERR_COMMIT;
                        WorkCompletedEventArgs wCe = new WorkCompletedEventArgs(true, msg[1]);//(PatchManager.JSON_COMPLETE, "");
                        OnWorkCompleted(wCe);
                    }
                    else
                    {
                        WorkCompletedEventArgs wCe = new WorkCompletedEventArgs(false, msg[1]);//(PatchManager.JSON_COMPLETE, "");
                        OnWorkCompleted(wCe);
                    }
                }
            }
            catch (Exception e)
            {
                WorkCompletedEventArgs wCe = new WorkCompletedEventArgs(true, e.ToString());//(PatchManager.JSON_COMPLETE, "");
                OnWorkCompleted(wCe);
            }
        }

        private void PatchXMLData(JObject xmlJson) 
        {

            //WorkCompletedEventArgs wCe = new WorkCompletedEventArgs(false, "");
            //OnWorkCompleted(wCe);

            
            Boolean isUpdateProcessed = false;
            Dictionary<string, string> dicXml = JsonConvert.DeserializeObject<Dictionary<string, string>>(xmlJson.ToString());
            
            foreach(KeyValuePair<string,string> value in dicXml)
            {
                XmlDocument xdClient = new XmlDocument();
                XmlDocument xdServer = new XmlDocument();
                try
                {
                    Boolean isUpdate=false;
                    Debug.WriteLine("Load : " + strDestPath + value.Key);
                    xdClient.Load(strDestPath + value.Key);
                    Debug.WriteLine("Load Complete");
                    Debug.WriteLine("Server XML : "+value.Value);
                    String xml = value.Value;
                    //String xml = HttpUtility.UrlDecode(value.Value, Encoding.UTF8);
                    xdServer.LoadXml(xml.TrimStart());
                                        
                    isUpdate=syncDiffData(xdClient.DocumentElement, xdServer.DocumentElement, ref xdClient, ref xdServer);
                    if (isUpdate)
                    {
                        ConfApplyEventArgs cAe = new ConfApplyEventArgs(false, strDestPath + value.Key);
                        OnConfApply(cAe);
                        isUpdateProcessed = true;
                    }
                    Debug.WriteLine("Save : " + strDestPath + value.Key);
                    xdClient.Save(strDestPath + value.Key);
                    Debug.WriteLine("Save Complete");

                }
                catch (Exception e) 
                {
                    Debug.WriteLine("An error has occured : " + e.ToString());
                    continue;
                }
            }
            if (isUpdateProcessed)
            {
                ConfApplyCompletedEventArgs cCe = new ConfApplyCompletedEventArgs(false, "");
                OnConfApplyCompleted(cCe);
            }
            else 
            {
                WorkCompletedEventArgs wCe = new WorkCompletedEventArgs(false, "");
                OnWorkCompleted(wCe);
            }
            
        }
        private Boolean syncDiffData(XmlElement target, XmlElement source, ref XmlDocument xmlTarget, ref XmlDocument xmlSource)
        {
            Boolean isUpdate = false;
            XmlNodeList targetList = target.ChildNodes;
            XmlNodeList sourceList = source.ChildNodes;
            for (int i = 0; i < sourceList.Count; i++)
            {
                if (sourceList[i].NodeType.Equals(XmlNodeType.Element))
                {
                    int j;
                    Boolean isHaveEqualNode = false;
                    for (j = 0; j < targetList.Count; j++)
                    {                        
                        if (targetList[j].NodeType.Equals(XmlNodeType.Element))
                        {
                            if (targetList[j].Name.Equals(sourceList[i].Name))
                            {
                                if (targetList[j].Name.Equals("appender"))
                                {
                                    if (targetList[j].Attributes.GetNamedItem("name").Value
                                        .Equals(sourceList[i].Attributes.GetNamedItem("name").Value))
                                    {
                                        isHaveEqualNode = true;
                                        break;
                                    }
                                }
                                else 
                                {
                                    isHaveEqualNode = true;
                                    break;
                                }
                            }                            
                        }
                    }
                    if (isHaveEqualNode)
                    {
                        if (syncDiffData((XmlElement)targetList[j], (XmlElement)sourceList[i], ref xmlTarget, ref xmlSource))
                            isUpdate = true;
                    }
                    else
                    {
                        //if (sourceList[i].Name)
                        target.AppendChild(xmlTarget.ImportNode(sourceList[i], true));
                        isUpdate = true;
                    }
                }
            }
            return isUpdate;
        }

        private static string CreateFilenameFromUri(Uri uri)
        {
            char[] invalidChars = Path.GetInvalidFileNameChars();
            StringBuilder sb = new StringBuilder(uri.OriginalString.Length);
            foreach (char c in uri.OriginalString)
            {
                sb.Append(Array.IndexOf(invalidChars, c) < 0 ? c : '_');
            }
            return sb.ToString();
        }    
    }
}

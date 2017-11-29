using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
//using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Web;

namespace iDaaS
{
    class StreamModule
    {
        public Encoding encStream;
        private string strError;
        private string strJson;
        public int workResult;
        public static int JSON = 1;
        public static int FILE = 2;
        public StreamModule()
        {
            strError = "";
            strJson = "";
            workResult = 1;
        }
        public void setEncoding(Encoding enc)
        {
            encStream = enc;
        }
        public Boolean isAvailable(Uri dest)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            bool status = true ;
            try
            {
                request = HttpWebRequest.Create(dest) as HttpWebRequest;
                //Debug.WriteLine(request.)
                response = (HttpWebResponse)request.GetResponse();
                if (response == null || response.StatusCode != HttpStatusCode.OK)
                {
                    status = false;
                }
            }
            catch (Exception e)
            {
                status = false;
                strError = e.ToString();
            }
            finally
            {
                if (request != null) { request.Abort(); }
                if (response != null) { response.Close();  }
            }
            return status;
        }
        public string getJson()
        {
            if (strJson == null || strJson.Trim().Equals(""))
            {
                if (strError == null || strError.Trim().Equals(""))
                    return "{\"_is_error\":true}";
                else
                    return "{\"_is_error\":true,\"_error_msg\":\"" + HttpUtility.UrlEncode(strError) + "\"}";

            }
            return strJson; 
        }
        public int result() 
        {
            return workResult;
        }
        public HttpWebResponse sendData(HttpWebRequest webRequest, string jsonStr,Dictionary<string,string> postDic, Encoding enc)
        {
            //WebResponse webResponse = null;
            Stream reqStream = null;
            //Stream resStream = null;
            MemoryStream sendStream = null;
            //MemoryStream recieveStream = null;
            try
            {
                if (!NetworkInterface.GetIsNetworkAvailable())
                {
                    strError = "네트워크 상태를 확인해 주세요.";
                    return null;
                }
                string boundary = "fU3W4Vzr4G3D54f3";//----------------------------


                byte[] fromBuff = new byte[256];

                IPAddress ipv4Addresses = Array.FindLast(Dns.GetHostEntry(string.Empty).AddressList, a => a.AddressFamily == AddressFamily.InterNetwork);

                IPAddress[] ipv4Arr = Array.FindAll(Dns.GetHostEntry(string.Empty).AddressList, a => a.AddressFamily == AddressFamily.InterNetwork);
                for (int ip = 0; ip < ipv4Arr.Length; ip++)
                {
                    Debug.WriteLine("IP List #" + ip + " : " + ipv4Arr[ip].ToString());
                }
                //webRequest = HttpWebRequest.Create(destURI) as HttpWebRequest;
                string postData = "";
                string headerData = "";
                string headerJSON = "";
                
                    headerData = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{2}\";\r\nContent-Type: {3}\r\n\r\n",
                    boundary,
                    "postData",
                    "nofile",
                    "text/plain");
                    headerJSON = string.Format("--{0}\r\nContent-Disposition: form-data; name=\"{1}\"; filename=\"{2}\";\r\nContent-Type: {3}\r\n\r\n",
                    boundary,
                    "postJSON",
                    "nofile",
                    "text/plain");

                {
                    //postData = "\r\n\r\n--" + boundary + "\r\nContent-Disposition: form-data; Content-Type: text/plain\r\n\r\n";
                    Boolean isFirst = true;
                    foreach (KeyValuePair<string, string> k in postDic)
                    {
                        postData += isFirst ? "" : "&";
                        isFirst = false;
                        postData += k.Key + "=" + k.Value;
                    }
                    //postData += "\r\n\r\n--" + boundary + "\r\nContent-Disposition: form-data; Content-Type: text/html\r\n\r\n";

                    //Debug.WriteLine("postData : " + postData);
                    //byte[] postByte = enc.GetBytes(postData);
                    webRequest.ContentType = "multipart/form-data; boundary=" + boundary;
                }

                webRequest.Method = "POST";
                webRequest.Accept = "*/*";
                webRequest.Headers.Add("WL-Proxy-Client-IP", ipv4Addresses.ToString());
                webRequest.UserAgent = "DLNADOC/1.50";//request.getHeader("WL-Proxy-Client-IP")
                webRequest.Timeout = System.Threading.Timeout.Infinite;
                //webRequest.ContentLength = postByte.Length + jsonByte.Length;
                webRequest.KeepAlive = true;
                webRequest.SendChunked = true;

                //byte[] jsonByte = enc.GetBytes(postData + jsonStr + "\r\n\r\n--" + boundary + "--");
                byte[] jsonByte = enc.GetBytes(jsonStr);

                sendStream = new MemoryStream(jsonByte);
                //webRequest.GetRequestStream().Write(postByte, 0, postByte.Length);

                Debug.WriteLine("webRequest.ContentType : " + webRequest.ContentType);
                //Debug.WriteLine("webRequest.ContentType : " + webRequest.ContentType);
                reqStream = webRequest.GetRequestStream();

                reqStream.Write(enc.GetBytes(headerData), 0, enc.GetByteCount(headerData));
                reqStream.Write(enc.GetBytes(postData), 0, enc.GetByteCount(postData));
                reqStream.Write(enc.GetBytes("\r\n"), 0, enc.GetByteCount("\r\n"));
                reqStream.Write(enc.GetBytes(headerJSON), 0, enc.GetByteCount(headerJSON));


                //reqStream.Write(postByte, 0, postByte.Length);
                int count = 0;
                while ((count = sendStream.Read(fromBuff, 0, fromBuff.Length)) > 0)
                {
                    reqStream.Write(fromBuff, 0, count);
                }
                string footer = "\r\n--" + boundary + "--\r\n";
                reqStream.Write(enc.GetBytes(footer), 0, enc.GetByteCount(footer));
                /*
                if (webRequest != null)
                {
                    webResponse = webRequest.GetResponse();
                    Debug.WriteLine("response type : "+webResponse.ContentType);
                    recieveStream = new MemoryStream();
                    byte[] tobuff = new byte[256];
                    resStream = webResponse.GetResponseStream();
                    count = 0;
                    while ((count = resStream.Read(tobuff, 0, tobuff.Length)) > 0)
                    {
                        recieveStream.Write(tobuff, 0, count);
                    }
                    strJson = encStream.GetString(recieveStream.ToArray());
                }*/
                if (webRequest != null)
                {
                    HttpWebResponse wr = (HttpWebResponse)webRequest.GetResponse();
                    Debug.WriteLine("ContentType : " + wr.ContentType);
                    if (wr.ContentType.Equals("application/zip") || wr.ContentType.Equals("application/octet-stream"))
                    {
                        workResult = StreamModule.FILE;
                    }
                    else
                    {
                        workResult = StreamModule.JSON;
                    }
                    //
                    return wr;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception e)
            {
                strError = e.ToString();
                return null;
            }
            finally
            {
                //if (webResponse != null) { webResponse.Close(); webResponse.Dispose(); }
                if (reqStream != null){reqStream.Close(); reqStream.Dispose(); }
                //if (resStream != null) { resStream.Close(); resStream.Dispose(); }
                if (sendStream != null) { sendStream.Close(); sendStream.Dispose(); }
                //if (recieveStream != null) { recieveStream.Close(); recieveStream.Dispose(); }                
            }

        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <param name="webResponse">WebResponse</param>
        /// <param name="path">0 - 절대경로, 1 - 상대경로, 2 - 파일이름</param>
        public void receiveData(WebResponse webResponse, string[] path, ref DownProgressChangedEventHandler DownProgressChangedEvent, ref DownProgressCompletedEventHandler DownProgressCompletedEvent)
            
        {
            FileStream fileStream = null;
            string destZipDir = "";
            try
            {
                string winTempDir = System.IO.Path.GetTempPath();
                Debug.WriteLine("Window Temp Directory : " + winTempDir);
                //string destZipDir = path[0] + "\\" +path[1] + "\\";
                destZipDir = winTempDir + "\\" + path[1] + "\\";

                Directory.CreateDirectory(Path.GetDirectoryName(destZipDir));

                byte[] fromBuff = new byte[256];
                fileStream = new FileStream(destZipDir + "\\" + path[2], FileMode.OpenOrCreate, FileAccess.Write);
                int count = 0;
                double progressMaxValue = double.Parse(webResponse.ContentLength.ToString());
                Stream readStream = webResponse.GetResponseStream();

                //            webResponse.GetResponseStream()
                /*
                 while ((read = bis.read(b)) != -1) {
                            outStream.write(b, 0, read);
                        }            
                 */

                //while ((count = webResponse.GetResponseStream().Read(fromBuff, 0, fromBuff.Length)) > 0)
                while ((count = readStream.Read(fromBuff, 0, fromBuff.Length)) > 0)
                {
                    //progressValue += fromBuff.Length;
                    fileStream.Write(fromBuff, 0, count);

                    //double bytesIn = double.Parse(progressValue.ToString());
                    double bytesIn = double.Parse(fileStream.Length.ToString());
                    //tempSize = double.Parse(e.TotalBytesToReceive.ToString());

                    double percentage = (bytesIn / progressMaxValue) * 100;



                    //ValidateEndEvent(this, e);
                    DownProgressChangedEventArgs vEe = new DownProgressChangedEventArgs(int.Parse(Math.Truncate(percentage > 100 ? 100 : percentage).ToString()), bytesIn, progressMaxValue);
                    if (DownProgressChangedEvent != null)
                    {
                        DownProgressChangedEvent(this, vEe);
                    }
                    //DownProgressChangedEvent(this,vEe);
                    //.ValidateEndEvent();//.ValidateEnd(vEe);   
                    //bg.ReportProgress(int.Parse(Math.Truncate(percentage > 100 ? 100 : percentage).ToString()), bytesIn);

                }
                DownProgressCompletedEventArgs dCe = new DownProgressCompletedEventArgs(false, "");//(int.Parse(Math.Truncate(percentage > 100 ? 100 : percentage).ToString()), bytesIn);
                if (DownProgressCompletedEvent != null)
                {
                    DownProgressCompletedEvent(this, dCe);
                }
            }
            catch (System.Threading.ThreadAbortException e)
            {
                Debug.WriteLine(e.ToString());
                try
                {
                    //DirectoryInfo dirInfo = new DirectoryInfo(targetPath + "\\" + pathDir);
                    DirectoryInfo dirInfo = new DirectoryInfo(destZipDir);

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
                }
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
                if (webResponse != null)
                    webResponse.Close();
            }
        }
        public void receiveData(WebResponse webResponse)
        {
            Stream resStream = null;
            MemoryStream recieveStream = null;
            try
            {
                
                int count;
                Debug.WriteLine("response type : " + webResponse.ContentType);
                recieveStream = new MemoryStream();
                byte[] tobuff = new byte[256];
                resStream = webResponse.GetResponseStream();
                count = 0;
                while ((count = resStream.Read(tobuff, 0, tobuff.Length)) > 0)
                {
                    recieveStream.Write(tobuff, 0, count);
                }
                strJson = encStream.GetString(recieveStream.ToArray());
                recieveStream.Close();
                resStream.Close();
                webResponse.Close();
            }
            catch
            {
                strJson = "{\"_is_error\":true,\"_error_msg\":\"처리되지 않은 오류 발생.\"}";
            }
            finally
            {
                if( recieveStream!=null ) recieveStream.Close();
                if (resStream != null) resStream.Close();
                if (webResponse != null) webResponse.Close();
            }
        }
    }
}

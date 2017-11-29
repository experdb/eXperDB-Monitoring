using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Security.Cryptography;
using Newtonsoft.Json.Linq;

namespace iDaaS
{
    class FileHashFilter
    
    {
        public static JObject getJson(string path)
        {
            return getJson(path, false);
        }
        public static JObject getJson(string path, Boolean isCheck)
        {
            Hashtable data = getList(path,isCheck);
            JArray listArray = new JArray();
            JObject list = new JObject();
            foreach (DictionaryEntry item in data)
            {
                list.Add(item.Key.ToString(), item.Value.ToString());
            }
            listArray.Add(list);
            
            JProperty patchData = new JProperty("_patch_data", listArray);
            //JProperty patchVer = new JProperty("_patch_ver",ver);

            JObject result = new JObject();

            //JProperty result=;
            result.Add(patchData);
            //result.Add(patchVer);
            //JToken list = JObject.;
            /*
            JsonArrayCollection list = new JsonArrayCollection();
            JsonArrayCollection result = new JsonArrayCollection();
            
            foreach (DictionaryEntry item in data)
            {
                list.Add(new JsonStringValue(item.Key.ToString(), item.Value.ToString()));
            }
            result.Add(new JsonObjectCollection(list));
            //result.Add(new JsonArrayCollection("_patch_data",new JsonObjectCollection("",new JsonArrayCollection("",list))));
            */
            return result;//new JObject(result).ToString();
        }
        /*public static Hashtable getList(string path)
        {
            return getList(path,false);
        }*/
        public static Hashtable getList(string path, Boolean isCheck)
        {
            Hashtable fileList = new Hashtable();
            ArrayList DirAll = new ArrayList();
            GetAllDirectories(path, ref DirAll);


            //파일의 목록
            ArrayList aPathFiles = new ArrayList();
            //앞에서 얻어온 모든 DirectoryInfo에 대한 루핑.
            foreach (DirectoryInfo d in DirAll)
            {
                foreach (FileInfo fi in d.GetFiles())
                {
                    if (isCheck&&fi.Name.Contains(".oldFile"))
                    {
                        fi.Delete();
                    }
                    else
                    {
                        using (FileStream stream = File.OpenRead(fi.FullName))
                        {
                            MD5 md5 = new MD5CryptoServiceProvider();
                            byte[] byteChecksum = md5.ComputeHash(stream);
                            fileList.Add(fi.FullName.Replace(path, "").Replace("\\", "/"), BitConverter.ToString(byteChecksum).Replace("-", String.Empty));
                        }
                    }
                }
            }
            return fileList;
        }
        private static void GetAllDirectories(string Path, ref ArrayList DirAll)
        {
            DirectoryInfo di = new DirectoryInfo(Path);
            DirAll.Add(di);
            foreach (DirectoryInfo d in di.GetDirectories())
            {
                GetAllDirectories(d.FullName, ref DirAll);
            }
        }
    }
}

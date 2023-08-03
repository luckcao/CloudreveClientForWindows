using CloudreveMiddleLayer.Data;
using CloudreveMiddleLayer.DataSet;
using CloudreveMiddleLayer.JsonEntiryClass;
using ComponentControls.Controls;
using ComponentControls.Helper.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudreveMiddleLayer.Entiry
{
    public class FileList
    {
        #region DB Method

        #region Download

        public static bool GetDownloadFileInfo(DataSetDownloadUpload.TBL_DownloadInfoDataTable dt)
        {
            using(DataHelper da = new DataHelper())
            {
                string sql = "Select " +
                             "      FileID, " +
                             "      FileName, " +
                             "      FileSizeDesc, " +
                             "      Case DownloadPercent When 100 Then DownloadPercent Else 0 End DownloadPercent, " +
                             "      DownloadStatus, " +
                             "      FilePathFrom, " +
                             "      DownloadFilePath, " +
                             "      '打开下载目录' OpenFolderDesc, " +
                             "      '删除' DeleteDesc " +
                             " From TBL_DownloadInfo";
                return da.GetData(sql, dt);
            }
        }

        public static bool AddDownloadTask(DataSetDownloadUpload.TBL_DownloadInfoRow dr)
        {
            using (DataHelper da = new DataHelper())
            {
                da.AddParameter("@FileID", dr.FileID);
                da.AddParameter("@FileName", dr.FileName);
                da.AddParameter("@FileSizeDesc", dr.FileSizeDesc);
                da.AddParameter("@DownloadPercent", dr.DownloadPercent);
                da.AddParameter("@DownloadStatus", dr.DownloadStatus);
                da.AddParameter("@FilePathFrom", dr.FilePathFrom);
                da.AddParameter("@DownloadFilePath", dr.DownloadFilePath);

                string sql = "INSERT INTO TBL_DownloadInfo " +
                            "       (" +
                            "           FileID, " +
                            "           FileName, " +
                            "           FileSizeDesc, " +
                            "           DownloadPercent, " +
                            "           DownloadStatus, " +
                            "           FilePathFrom, " +
                            "           DownloadFilePath" +
                            "       ) " +
                            " VALUES" +
                            "       (" +
                            "           @FileID, " +
                            "           @FileName, " +
                            "           @FileSizeDesc, " +
                            "           @DownloadPercent, " +
                            "           @DownloadStatus, " +
                            "           @FilePathFrom, " +
                            "           @DownloadFilePath" +
                            "       );";
                return da.ExecuteSQL(sql);
            }
        }

        public static bool UpdateDownloadStatus(string fileID, byte[] status)
        {
            using(DataHelper da = new DataHelper())
            {
                da.AddParameter("@FileID", fileID);
                da.AddParameter("@DownloadStatus", status);

                string sql = "Update TBL_DownloadInfo " +
                             " Set " +
                             "      DownloadStatus = @DownloadStatus, " +
                             "      DownloadPercent = '100' " +
                             " Where " +
                             "      FileID = @FileID";

                return da.ExecuteSQL(sql);
            }
        }

        public static bool DeleteDownloadTask(string fileID, string filePath, bool needDeleteFileFromDisk)
        {
            using (DataHelper da = new DataHelper())
            {
                da.AddParameter("@FileID", fileID);

                string sql = "DELETE FROM TBL_DownloadInfo WHERE FileID = @FileID";
                if (!da.ExecuteSQL(sql))
                {
                    return false;
                }

                if(needDeleteFileFromDisk)
                {
                    File.Delete(filePath);
                }
                return true;
            }
        }

        #endregion

        #region Upload

        public static bool GetUploadFileInfo(DataSetDownloadUpload.TBL_UploadInfoDataTable dt)
        {
            using (DataHelper da = new DataHelper())
            {
                string sql = "Select " +
                             "      FileID, " +
                             "      FileName, " +
                             "      FileSizeDesc, " +
                             "      Case UploadPercent When 100 Then UploadPercent Else 0 End UploadPercent, " +
                             "      UploadStatus, " +
                             "      FilePathFrom, " +
                             "      UploadFilePath, " +
                             "      '打开下载目录' OpenFolderDesc, " +
                             "      '删除' DeleteDesc " +
                             " From TBL_UploadInfo";
                return da.GetData(sql, dt);
            }
        }

        public static int AddUploadTask(string fileName, string fileSizeDesc, double uploadPercent, byte[] uploadStatus, string filePathFrom, string uploadFilePath)
        {
            using (DataHelper da = new DataHelper())
            {
                da.AddParameter("@FileName", fileName);
                da.AddParameter("@FileSizeDesc", fileSizeDesc);
                da.AddParameter("@UploadPercent", uploadPercent);
                da.AddParameter("@UploadStatus", uploadStatus);
                da.AddParameter("@FilePathFrom", filePathFrom);
                da.AddParameter("@UploadFilePath", uploadFilePath);
                //da.AddParameter("@ID", DataHelper.SqlNull(-1), System.Data.ParameterDirection.Output);

                string sql = "INSERT INTO TBL_UploadInfo " +
                            "       (" +
                            "           FileName, " +
                            "           FileSizeDesc, " +
                            "           UploadPercent, " +
                            "           UploadStatus, " +
                            "           FilePathFrom, " +
                            "           UploadFilePath" +
                            "       ) " +
                            " VALUES" +
                            "       (" +
                            "           @FileName, " +
                            "           @FileSizeDesc, " +
                            "           @UploadPercent, " +
                            "           @UploadStatus, " +
                            "           @FilePathFrom, " +
                            "           @UploadFilePath" +
                            "       );" +
                            " SELECT LAST_INSERT_ROWID() FROM TBL_UploadInfo;";
                int fileID = da.ExecuteReader(sql);
                return fileID;
            }
        }

        public static bool UpdateUploadStatus(string fileID, byte[] status)
        {
            using (DataHelper da = new DataHelper())
            {
                da.AddParameter("@FileID", fileID);
                da.AddParameter("@UploadStatus", status);

                string sql = "Update TBL_UploadInfo " +
                             " Set " +
                             "      UploadStatus = @UploadStatus, " +
                             "      UploadPercent = '100' " +
                             " Where " +
                             "      FileID = @FileID";

                return da.ExecuteSQL(sql);
            }
        }

        public static bool DeleteUploadTask(string fileID, string filePath)
        {
            using (DataHelper da = new DataHelper())
            {
                da.AddParameter("@FileID", fileID);

                string sql = "DELETE FROM TBL_UploadInfo WHERE FileID = @FileID";
                if (!da.ExecuteSQL(sql))
                {
                    return false;
                }
                return true;
            }
        }

        #endregion

        #endregion

        #region API Method

        #region FileList

        public static List<CloudreveMiddleLayer.JsonEntiryClass.GetFileListJson.ObjectsItem> GetFileList(string path)
        {
            string url = Util.GLOBLE_URL;
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += path;
            string tmpCookie = Util.GLOBLE_COOKIE;
            string responseContent = HttpClientHelper.Get(url, ref tmpCookie);
            if (!string.IsNullOrEmpty(responseContent))
            {
                CloudreveMiddleLayer.JsonEntiryClass.GetFileListJson.Root root = JsonConvert.DeserializeObject<CloudreveMiddleLayer.JsonEntiryClass.GetFileListJson.Root>(responseContent);
                Util.Current_Path_Storage_Policy = root.data.policy.id;
                return root.data.objects;
            }
            return null;
        }

        #endregion

        #region Create Directory

        public static bool CreateDirectory(string dirFullName, out int returnCode, out string returnMessage)
        {
            JObject obj = new JObject();
            obj.Add("path", dirFullName);

            string url = Util.GLOBLE_URL;
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += Util.CloudreveWebURL.CREATE_DIRECTORY_URL;
            string responseContent = HttpClientHelper.Put(url, obj.ToString(), ref Util.GLOBLE_COOKIE);
            returnMessage = String.Empty;
            returnCode = -1;
            if (!string.IsNullOrEmpty(responseContent))
            {
                JObject returnObj = (JObject)JsonConvert.DeserializeObject(responseContent);

                returnMessage = returnObj["msg"].ToString();
                returnCode = Convert.ToInt32(returnObj["code"].ToString());
                return returnCode == 0;
            }
            return false;
        }

        #endregion

        #region Download

        public static bool DownloadFile(DataSetDownloadUpload.TBL_DownloadInfoRow dr, TransferFileProgressBar pb, out int returnCode, out string returnMessage)
        {
            string url = Util.GLOBLE_URL;
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += Util.CloudreveWebURL.GET_DOWNLOAD_FILE_URL + "/" + dr.FileID.ToString();
            string responseContent = HttpClientHelper.Put(url, ref Util.GLOBLE_COOKIE);
            returnMessage = String.Empty;
            returnCode = -1;
            if (!string.IsNullOrEmpty(responseContent))
            {
                JObject returnObj = (JObject)JsonConvert.DeserializeObject(responseContent);
                returnMessage = returnObj["msg"].ToString();
                returnCode = Convert.ToInt32(returnObj["code"].ToString());

                if (returnCode == 0)
                {
                    string downloadURL = Util.GLOBLE_URL + returnObj["data"].ToString();
                    //开始下载文件
                    if (!DownLoadFile(downloadURL,
                                      dr.DownloadFilePath,
                                      dr.FileID
                                        , new Action<int>(
                                                              (int value)
                                                              =>
                                                              {

                                                                  try
                                                                  {
                                                                      pb.SetProgressBarValue(value, dr.FileID);
                                                                  }
                                                                  catch (Exception ex)
                                                                  {
                                                                      Console.WriteLine(ex.Message + "\r\n" + ex.StackTrace);
                                                                  }
                                                              })
                    ))
                    {
                        //下载文件出错的处理
                        returnMessage = "Download File Error.";
                        returnCode = -1;
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                returnCode = -1;
                returnMessage = "Get Download URL Error.";
                return false;
            }
            return true;
        }

        private static bool DownLoadFile(string URL, string fileNameWithPath, string fileID, Action<int> updateProgress = null)
        {
            Stream st = null;
            Stream so = null;
            System.Net.HttpWebRequest Myrq = null;
            System.Net.HttpWebResponse myrp = null;
            bool flag = false;
            try
            {
                Myrq = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(URL); //从URL地址得到一个WEB请求     
                myrp = (System.Net.HttpWebResponse)Myrq.GetResponse(); //从WEB请求得到WEB响应     
                double totalBytes = myrp.ContentLength; //从WEB响应得到总字节数
                //更新进度
                if (updateProgress != null)
                {
                    updateProgress(0);//从总字节数得到进度条的最大值  
                }
                st = myrp.GetResponseStream(); //从WEB请求创建流（读）     
                so = new System.IO.FileStream(fileNameWithPath, System.IO.FileMode.Create); //创建文件流（写）     
                Int64 totalDownloadedByte = 0; //下载文件大小     
                byte[] by = new byte[1024*1024];
                int osize = st.Read(by, 0, (int)by.Length); //读流     
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte; //更新文件大小     
                    so.Write(by, 0, osize); //写流     
                    //更新进度
                    Application.DoEvents();
                    
                    if (updateProgress != null)
                    {
                        updateProgress(Convert.ToInt32(totalDownloadedByte / totalBytes * 100.0));//更新进度条 
                    }
                    if (!Util.Paused_Download_Task.Contains(fileID))
                    {
                        osize = st.Read(by, 0, (int)by.Length); //读流     
                    }
                    else
                    {
                        return false;
                    }
                }
                //更新进度
                if (updateProgress != null)
                {
                    updateProgress(Convert.ToInt32(totalDownloadedByte / totalBytes * 100.0));
                }
                flag = true;
            }
            catch (Exception ex)
            {
                flag = false;
                //return false;
            }
            finally
            {
                if (Myrq != null)
                {
                    Myrq.Abort();//销毁关闭连接
                }
                if (myrp != null)
                {
                    myrp.Close();//销毁关闭响应
                }
                if (so != null)
                {
                    so.Close(); //关闭流 
                }
                if (st != null)
                {
                    st.Close(); //关闭流  
                }
            }
            return flag;
        }

        #endregion

        #region Delete File

        public static bool DeleteFile(List<string> fileID , out int returnCode, out string returnMessage)
        {
            JObject obj = new JObject();
            JArray objDir = new JArray();
            JArray objFile = new JArray();

            for (int i = 0; i < fileID.Count; i++)
            {
                string[] split = fileID[i].Split('_');

                if (split[0].ToUpper().Equals("DIR"))
                {
                    objDir.Add(split[1]);
                }
                else
                {
                    objFile.Add(split[1]);
                }
            }
            obj.Add("dirs", objDir);
            obj.Add("items", objFile);

            string url = Util.GLOBLE_URL;
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += Util.CloudreveWebURL.DELETE_FILE_URL;
            string responseContent = HttpClientHelper.Delete(url, obj.ToString(), ref Util.GLOBLE_COOKIE);
            returnMessage = String.Empty;
            returnCode = -1;
            if (!string.IsNullOrEmpty(responseContent))
            {
                JObject returnObj = (JObject)JsonConvert.DeserializeObject(responseContent);

                returnMessage = returnObj["msg"].ToString();
                returnCode = Convert.ToInt32(returnObj["code"].ToString());
                return returnCode == 0;
            }
            return false;
        }

        #endregion

        #region Rename File

        public static bool RenameFile(string fileID, string newName, bool isDir, out int returnCode, out string returnMessage)
        {
            JObject requestJsonObj = new JObject();
            requestJsonObj.Add("action", "rename");

            JObject pathJson = new JObject();
            pathJson.Add("dirs", new JArray() { });
            pathJson.Add("items", new JArray() { fileID });

            requestJsonObj.Add("src", pathJson);
            requestJsonObj.Add("new_name", newName);

            string url = Util.GLOBLE_URL;
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += Util.CloudreveWebURL.GET_RENAME_FILE_URL;
            string temp = Util.GLOBLE_COOKIE;
            string responseContent = HttpClientHelper.Post(url, requestJsonObj.ToString(), ref temp);
            returnCode = -1;
            returnMessage = String.Empty;
            if (!string.IsNullOrEmpty(responseContent))
            {
                JObject returnObj = (JObject)JsonConvert.DeserializeObject(responseContent);

                returnMessage = returnObj["msg"].ToString();
                returnCode = Convert.ToInt32(returnObj["code"].ToString());
                return returnCode == 0;
            }
            return false;
        }

        #endregion

        #region Share

        public static string GenerateShareJson(string fileID, bool isDir, string password,
                                               int downloadExpireCount, int downloadExpireDayCount,
                                               bool allowPreview)
        {
            JObject requestObj = new JObject();
            requestObj.Add("downloads", downloadExpireCount);
            requestObj.Add("expire", downloadExpireDayCount * 60 * 60 * 24);  //转换成秒
            requestObj.Add("id", fileID);
            requestObj.Add("is_dir", isDir);
            requestObj.Add("password", password);
            requestObj.Add("preview", allowPreview);

            return requestObj.ToString();
        }

        public static bool CreateShareFile(string jsonString, out int returnCode, out string returnMessage)
        {
            string url = Util.GLOBLE_URL;
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += Util.CloudreveWebURL.SHARE_FILE_URL;
            string temp = Util.GLOBLE_COOKIE;
            string responseContent = HttpClientHelper.Post(url, jsonString, ref temp);
            returnCode = -1;
            returnMessage = String.Empty;
            if (!string.IsNullOrEmpty(responseContent))
            {
                JObject returnObj = (JObject)JsonConvert.DeserializeObject(responseContent);

                returnMessage = returnObj["data"].ToString();
                returnCode = Convert.ToInt32(returnObj["code"].ToString());
                return returnCode == 0;
            }
            return false;
        }

        public static List<JsonEntiryClass.GetShareFileJson.ItemsItem> GetShareFileList(out int returnCode, out string returnMessage)
        {
            returnCode = 0;
            returnMessage = String.Empty;
            string responseContent = String.Empty;
            List<JsonEntiryClass.GetShareFileJson.ItemsItem> results = new List<GetShareFileJson.ItemsItem>();
            int pageCount = 1;
            bool getNextPageData = false, getWithError = false;

            do
            {
                string url = Util.GLOBLE_URL;
                if (!url.EndsWith("/"))
                {
                    url += "/";
                }
                url += string.Format(Util.CloudreveWebURL.GET_SHARE_FILE_LIST_URL, pageCount.ToString().Trim());
                string tmpCookie = Util.GLOBLE_COOKIE;
                responseContent = HttpClientHelper.Get(url, ref tmpCookie);
                JObject returnObj = (JObject)JsonConvert.DeserializeObject(responseContent);


                if (!string.IsNullOrEmpty(responseContent))
                {
                    CloudreveMiddleLayer.JsonEntiryClass.GetShareFileJson.Root root = JsonConvert.DeserializeObject<CloudreveMiddleLayer.JsonEntiryClass.GetShareFileJson.Root>(responseContent);
                    if(root.code != 0)
                    {
                        getWithError = true;
                    }
                    else if(Convert.ToInt32(root.data.items.Count) > 0)
                    {
                        for (int i = 0; i < root.data.items.Count; i++)
                        {
                            results.Add(root.data.items[i]);
                        }
                        getNextPageData = true;
                        pageCount++;
                    }
                    else
                    {
                        getNextPageData = false;
                    }
                }
                else
                {
                    getWithError = true;
                }
            }
            while (!getWithError && getNextPageData);
            
            if(getWithError)
            {
                return null;
            }
            else
            {
                return results;
            }
        }

        public static bool ShareSetPublicPrivate(string key, string password, out int returnCode, out string returnMessage)
        {
            JObject obj = new JObject();
            obj.Add("prop", "password");
            obj.Add("value", password);

            string url = Util.GLOBLE_URL;
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += Util.CloudreveWebURL.SHARE_FILE_URL + "/" + key;
            string temp = Util.GLOBLE_COOKIE;
            string responseContent = HttpClientHelper.Patch(url, obj.ToString(), ref temp);
            returnCode = -1;
            returnMessage = String.Empty;
            if (!string.IsNullOrEmpty(responseContent))
            {
                JObject returnObj = (JObject)JsonConvert.DeserializeObject(responseContent);

                returnMessage = returnObj["msg"].ToString();
                returnCode = Convert.ToInt32(returnObj["code"].ToString());
                return returnCode == 0;
            }
            return false;
        }

        public static string GenerateRandomSharePassword(int length)
        {
            StringBuilder charList = new StringBuilder();
            for(int i=48; i<=57; i++)
            {
                charList.Append(Convert.ToChar(i));
            }
            for (int i = 65; i <= 90; i++)
            {
                charList.Append(Convert.ToChar(i));
            }
            for (int i = 97; i <= 122; i++)
            {
                charList.Append(Convert.ToChar(i));
            }

            Random random = new Random();
            return new string(Enumerable.Repeat(charList.ToString(), length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static bool ShareSetPreview(string key, bool allowPreview, out int returnCode, out string returnMessage)
        {
            JObject obj = new JObject();
            obj.Add("prop", "preview_enabled");
            obj.Add("value", allowPreview.ToString().ToLower());

            string url = Util.GLOBLE_URL;
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += Util.CloudreveWebURL.SHARE_FILE_URL + "/" + key;
            string temp = Util.GLOBLE_COOKIE;
            string responseContent = HttpClientHelper.Patch(url, obj.ToString(), ref temp);
            returnCode = -1;
            returnMessage = String.Empty;
            if (!string.IsNullOrEmpty(responseContent))
            {
                JObject returnObj = (JObject)JsonConvert.DeserializeObject(responseContent);

                returnMessage = returnObj["msg"].ToString();
                returnCode = Convert.ToInt32(returnObj["code"].ToString());
                return returnCode == 0;
            }
            return false;
        }

        public static bool ShareSetCancel(string key, out int returnCode, out string returnMessage)
        {
            //JObject obj = new JObject();
            //obj.Add("prop", "preview_enabled");
            //obj.Add("value", allowPreview.ToString().ToLower());

            string url = Util.GLOBLE_URL;
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += Util.CloudreveWebURL.SHARE_FILE_URL + "/" + key;
            string temp = Util.GLOBLE_COOKIE;
            string responseContent = HttpClientHelper.Delete(url, String.Empty, ref temp);
            returnCode = -1;
            returnMessage = String.Empty;
            if (!string.IsNullOrEmpty(responseContent))
            {
                JObject returnObj = (JObject)JsonConvert.DeserializeObject(responseContent);

                returnMessage = returnObj["msg"].ToString();
                returnCode = Convert.ToInt32(returnObj["code"].ToString());
                return returnCode == 0;
            }
            return false;
        }

        #endregion

        #region Upload

        private static bool GetUploadSessionID(string fileName, 
                                                 string uploadPath,
                                                 Int64 fileSize,
                                                 Int64 lastModified,
                                                 string storagePolicyID,
                                                 string mimeType,
                                                 out string sessionID,
                                                 out Int64 chunkSize,
                                                 out Int64 expires,
                                                 out string returnMessage)
        {
            JObject obj = new JObject();
            obj.Add("path", uploadPath);
            obj.Add("size", fileSize);
            obj.Add("name", fileName);
            obj.Add("policy_id", storagePolicyID);
            obj.Add("last_modified", lastModified);
            obj.Add("mime_type", mimeType);


            string url = Util.GLOBLE_URL;
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += Util.CloudreveWebURL.GET_UPLOAD_SESSION_ID_URL;
            string temp = Util.GLOBLE_COOKIE;
            string responseContent = HttpClientHelper.Put(url, obj.ToString(), ref temp);
            int returnCode = -1;
            sessionID = String.Empty;
            chunkSize = 0;
            expires = 0;
            returnMessage = String.Empty;
            if (!string.IsNullOrEmpty(responseContent))
            {
                JObject returnObj = (JObject)JsonConvert.DeserializeObject(responseContent);

                returnMessage = returnObj["msg"].ToString();
                returnCode = Convert.ToInt32(returnObj["code"].ToString());

                if(returnCode == 0)
                {
                    //获取SessionID和其他的值
                    sessionID = returnObj["data"]["sessionID"].ToString();
                    chunkSize = Convert.ToInt32(returnObj["data"]["chunkSize"].ToString());
                    expires = Convert.ToInt32(returnObj["data"]["expires"].ToString());
                }
            }

            return returnCode == 0;
        }

        public static bool UploadFile(string fileName,
                                  string uploadPath,
                                  string mimeType,
                                  TransferFileProgressBar pb,
                                  out int returnCode, 
                                  out string returnMessage)
        {
            FileInfo f = new FileInfo(fileName);
            Int64 fileSize = f.Length;
            Int64 lastModified = (long)(f.LastWriteTime - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds;

            string sessionID = String.Empty;
            Int64 chunkSize = 0;
            Int64 expires = 0;
            returnCode = -1;
            if (!GetUploadSessionID(new FileInfo(fileName).Name, 
                                   uploadPath, 
                                   fileSize, 
                                   lastModified, 
                                   Util.Current_Path_Storage_Policy, 
                                   "",
                                   out sessionID,
                                   out chunkSize,
                                   out expires,
                                   out returnMessage))
            {
                return false;
            }

            int uploadChunkCount = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(fileSize) / chunkSize));
            bool hasError = false;

            for (int i=0;i<uploadChunkCount;i++)
            {
                string url = Util.GLOBLE_URL;
                if (!url.EndsWith("/"))
                {
                    url += "/";
                }
                url += string.Format(Util.CloudreveWebURL.GET_UPLOAD_FILE_URL, sessionID, i);
                byte[] content = null;
                if (i == uploadChunkCount - 1)
                {
                    content = ComponentControls.Helper.IO.FileInfo.ReadFromFile(fileName,
                                                                                i * chunkSize);
                }
                else
                {
                    content = ComponentControls.Helper.IO.FileInfo.ReadFromFile(fileName,
                                                                                i * chunkSize,
                                                                                chunkSize);
                }
                
                if(!HttpClientHelper.UploadFile(url, content, Util.GLOBLE_COOKIE))
                {
                    hasError = true;
                    break;
                }
                // Update the label text using Invoke method
                pb.Invoke(new Action(() => pb.SetProgressBarValue((i + 1) / uploadChunkCount * 100, fileName)));
            }

            if (!hasError)
            {
                return NotifyServerUploadFinished(sessionID, uploadChunkCount, out returnCode, out returnMessage);
            }
            else
            {
                return false;
            }
        }

        private static bool NotifyServerUploadFinished(string sessionID, int chunkCount, out int returnCode, out string returnMessage)
        {
            JObject obj = new JObject();
            obj.Add("id", sessionID);
            obj.Add("parts", chunkCount);

            string url = Util.GLOBLE_URL;
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += Util.CloudreveWebURL.GET_UPLOAD_FILE_URL;
            string temp = Util.GLOBLE_COOKIE;
            string responseContent = HttpClientHelper.Post(url, obj.ToString(), ref temp);
            returnMessage = String.Empty;
            returnCode = -1;
            if (!string.IsNullOrEmpty(responseContent))
            {
                JObject returnObj = (JObject)JsonConvert.DeserializeObject(responseContent);

                returnMessage = returnObj["msg"].ToString();
                returnCode = Convert.ToInt32(returnObj["code"].ToString());
                return returnCode == 0;
            }
            return false;

        }

        #endregion

        #endregion
    }
}
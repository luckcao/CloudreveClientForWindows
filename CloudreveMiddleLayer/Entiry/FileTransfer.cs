using CloudreveMiddleLayer.Controls;
using CloudreveMiddleLayer.DataSet;
using CloudreveMiddleLayer.Helper.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Windows.Forms;

namespace CloudreveMiddleLayer.Entiry
{
    public class FileTransfer
    {
        #region Upload

        private bool GetUploadSessionID(string fileName,
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

                if (returnCode == 0)
                {
                    //获取SessionID和其他的值
                    sessionID = returnObj["data"]["sessionID"].ToString();
                    chunkSize = Convert.ToInt32(returnObj["data"]["chunkSize"].ToString());
                    expires = Convert.ToInt32(returnObj["data"]["expires"].ToString());
                }
            }

            return returnCode == 0;
        }

        public bool UploadFile(string fileName,
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

            for (int i = 0; i < uploadChunkCount; i++)
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
                    content = CloudreveMiddleLayer.Helper.IO.FileInfo.ReadFromFile(fileName,
                                                                                i * chunkSize);
                }
                else
                {
                    content = CloudreveMiddleLayer.Helper.IO.FileInfo.ReadFromFile(fileName,
                                                                                i * chunkSize,
                                                                                chunkSize);
                }

                if (!HttpClientHelper.UploadFile(url, content, Util.GLOBLE_COOKIE))
                {
                    hasError = true;
                    break;
                }
                // Update the label text using Invoke method
                pb.Invoke(new Action(() => 
                    { 
                        pb.SetProgressBarValueInThread((i + 1) / uploadChunkCount * 100); 
                        //pb.Update(); 
                    }));
            }

            if (!hasError)
            {
                return true; // NotifyServerUploadFinished(sessionID, uploadChunkCount, out returnCode, out returnMessage);
            }
            else
            {
                return false;
            }
        }

        private bool NotifyServerUploadFinished(string sessionID, int chunkCount, out int returnCode, out string returnMessage)
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

        #region Download

        public bool DownloadFile(DataSetDownloadUpload.TBL_DownloadInfoRow dr, TransferFileProgressBar pb, out int returnCode, out string returnMessage)
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
                                                                      pb.SetProgressBarValueInThread(value);
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

        private bool DownLoadFile(string URL, string fileNameWithPath, string fileID, Action<int> updateProgress = null)
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
                byte[] by = new byte[1024 * 1024];
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
                    osize = st.Read(by, 0, (int)by.Length);
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

    }
}

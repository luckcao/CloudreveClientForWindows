using CloudreveMiddleLayer.Data;
using CloudreveMiddleLayer.DataSet;
using CloudreveMiddleLayer.JsonEntiryClass;
using ComponentControls.Helper.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudreveMiddleLayer.Entiry
{
    public class FileList
    {
        #region DB Method

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

        #region API Method

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
                return JsonConvert.DeserializeObject<CloudreveMiddleLayer.JsonEntiryClass.GetFileListJson.Root>(responseContent).data.objects;
            }
            return null;
        }

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

        public static bool DownloadFile(DataSetDownloadUpload.TBL_DownloadInfoRow dr, out int returnCode, out string returnMessage)
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
                                      dr.FileID,
                                      new Action<double>(
                                                            (double value)
                                                            =>
                                                            {
                                                                //更新进度条
                                                                dr.DownloadPercent = value;
                                                                //Console.WriteLine(value);
                                                                //dr.AcceptChanges();
                                                                Application.DoEvents();
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

        private static bool DownLoadFile(string URL, string fileNameWithPath, string fileID, Action<double> updateProgress = null)
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
                long totalBytes = myrp.ContentLength; //从WEB响应得到总字节数
                //更新进度
                if (updateProgress != null)
                {
                    updateProgress(0);//从总字节数得到进度条的最大值  
                }
                st = myrp.GetResponseStream(); //从WEB请求创建流（读）     
                so = new System.IO.FileStream(fileNameWithPath, System.IO.FileMode.Create); //创建文件流（写）     
                double totalDownloadedByte = 0; //下载文件大小     
                byte[] by = new byte[1024*1024];
                int osize = st.Read(by, 0, (int)by.Length); //读流     
                while (osize > 0)
                {
                    totalDownloadedByte = osize + totalDownloadedByte; //更新文件大小     
                    so.Write(by, 0, osize); //写流     
                    //更新进度
                    if (updateProgress != null)
                    {
                        updateProgress(Math.Round(totalDownloadedByte / totalBytes * 100, 2));//更新进度条 
                    }
                    if(!Util.Paused_Download_Task.Contains(fileID))
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
                    updateProgress(Math.Round(totalDownloadedByte / totalBytes * 100.0, 2));
                }
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
                throw;
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
    }
}

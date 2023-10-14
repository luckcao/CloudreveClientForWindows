using CloudreveMiddleLayer.Data;
using CloudreveMiddleLayer.DataSet;
using CloudreveMiddleLayer.JsonEntiryClass;
using CloudreveMiddleLayer.Controls;
using CloudreveMiddleLayer.Helper.Web;
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
using CloudreveMiddleLayer.Helper.Media;

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
                             "      Category, " +
                             "      UploadToCloudrevePath, " +
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
                da.AddParameter("@Category", dr.Category);
                da.AddParameter("@UploadToCloudrevePath", DataHelper.SqlNull(dr.UploadToCloudrevePath));

                string sql = "INSERT INTO TBL_DownloadInfo " +
                            "       (" +
                            "           FileID, " +
                            "           FileName, " +
                            "           FileSizeDesc, " +
                            "           DownloadPercent, " +
                            "           DownloadStatus, " +
                            "           FilePathFrom, " +
                            "           DownloadFilePath, " +
                            "           Category, " +
                            "           UploadToCloudrevePath " +
                            "       ) " +
                            " VALUES" +
                            "       (" +
                            "           @FileID, " +
                            "           @FileName, " +
                            "           @FileSizeDesc, " +
                            "           @DownloadPercent, " +
                            "           @DownloadStatus, " +
                            "           @FilePathFrom, " +
                            "           @DownloadFilePath, " +
                            "           @Category, " +
                            "           @UploadToCloudrevePath " +
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

        public static bool DeleteDownloadTask(string fileID, string localFilePath)
        {
            using (DataHelper da = new DataHelper())
            {
                da.AddParameter("@FileID", fileID);

                string sql = "DELETE FROM TBL_DownloadInfo WHERE FileID = @FileID";
                if (!da.ExecuteSQL(sql))
                {
                    return false;
                }

                if(!localFilePath.Trim().Equals(String.Empty))
                {
                    File.Delete(localFilePath);
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
                             "      Category, " +
                             "      '打开下载目录' OpenFolderDesc, " +
                             "      '删除' DeleteDesc " +
                             " From TBL_UploadInfo";
                return da.GetData(sql, dt);
            }
        }

        public static int AddUploadTask(string fileName, 
                                        string fileSizeDesc, 
                                        double uploadPercent, 
                                        byte[] uploadStatus, 
                                        string filePathFrom, 
                                        string uploadFilePath,
                                        int category)
        {
            using (DataHelper da = new DataHelper())
            {
                da.AddParameter("@FileName", fileName);
                da.AddParameter("@FileSizeDesc", fileSizeDesc);
                da.AddParameter("@UploadPercent", uploadPercent);
                da.AddParameter("@UploadStatus", uploadStatus);
                da.AddParameter("@FilePathFrom", filePathFrom);
                da.AddParameter("@UploadFilePath", uploadFilePath);
                da.AddParameter("@Category", category);

                string sql = "INSERT INTO TBL_UploadInfo " +
                            "       (" +
                            "           FileName, " +
                            "           FileSizeDesc, " +
                            "           UploadPercent, " +
                            "           UploadStatus, " +
                            "           FilePathFrom, " +
                            "           UploadFilePath, " +
                            "           Category " +
                            "       ) " +
                            " VALUES" +
                            "       (" +
                            "           @FileName, " +
                            "           @FileSizeDesc, " +
                            "           @UploadPercent, " +
                            "           @UploadStatus, " +
                            "           @FilePathFrom, " +
                            "           @UploadFilePath, " +
                            "           @Category " +
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
                             "      UploadPercent = 100 " +
                             " Where " +
                             "      FileID = @FileID";

                return da.ExecuteSQL(sql);
            }
        }

        public static bool DeleteUploadTask(string fileID)
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
                if(root.data!=null)
                {
                    Util.Current_Path_Storage_Policy = root.data.policy.id;
                    return root.data.objects;
                }
            }
            return null;
        }

        public static bool GetDirectorySizeAndSubDirFileCount(string fileID, out Int64 dirSize, out int subDirCount, out int subFileCount, out string policy, bool isFolder = true, bool traceRoot = false)
        {
            string url = Util.GLOBLE_URL;
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += String.Format(Util.CloudreveWebURL.GET_PROPERTY_URL, fileID, traceRoot.ToString().ToLower(), isFolder.ToString().ToLower());
            string tmpCookie = Util.GLOBLE_COOKIE;
            string responseContent = HttpClientHelper.Get(url, ref tmpCookie);
            if (!string.IsNullOrEmpty(responseContent))
            {
                JObject returnObj = (JObject)JsonConvert.DeserializeObject(responseContent);

                int returnCode = Convert.ToInt32(returnObj["code"].ToString());

                if(returnCode == 0)
                {
                    CloudreveMiddleLayer.JsonEntiryClass.GetPropertyJson.Root root = JsonConvert.DeserializeObject<CloudreveMiddleLayer.JsonEntiryClass.GetPropertyJson.Root>(responseContent);
                    dirSize = root.data.size;
                    subDirCount = root.data.child_folder_num;
                    subFileCount = root.data.child_file_num;
                    policy = root.data.policy;
                    return true;
                }
            }
            dirSize = 0;
            subDirCount = 0;
            subFileCount = 0;
            policy = String.Empty;
            return false;
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

        #region Image Thumb

        public static System.Drawing.Image GetImageThumb(string fileID)
        {
            string url = Util.GLOBLE_URL;
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += String.Format(Util.CloudreveWebURL.GET_IMAGE_THUMB_URL, fileID);
            string tmpCookie = Util.GLOBLE_COOKIE;
            System.Drawing.Image responseContent = HttpClientHelper.GetImage(url, ref tmpCookie);
            return responseContent;
        }

        #endregion

        #region Directory Tree

        public static List<GetFileListJson.ObjectsItem> GetDirectoryTree(string startPath)
        {
            List<GetFileListJson.ObjectsItem> result = new List<GetFileListJson.ObjectsItem>();
            List<GetFileListJson.ObjectsItem> list = GetFileList(startPath);
            if (list == null)
            {
                return null;
            }
            for (int i = 0; i < list.Count; i++)
            {
                if(list[i].type.Trim().ToUpper().Equals("DIR"))
                {
                    result.Add(list[i]);
                    List<GetFileListJson.ObjectsItem> subList = GetDirectoryTree(startPath + "/" + list[i].name);
                    if(subList != null)
                    {
                        result.AddRange(subList);
                    }
                }
            }
            return result.Count == 0 ? null : result;
        }

        #endregion

        #endregion
    }
}
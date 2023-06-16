﻿using ComponentControls.Helper.Web;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace CloudreveMiddleLayer
{
    public class Util
    {
        public static string GLOBLE_COOKIE = "";
        public static string GLOBLE_URL = "";
        public static CloudreveMiddleLayer.JsonEntiryClass.GetAuthConfigJson.Data AUTH_CONFIG_DATA = null;
        public static List<string> Paused_Download_Task = new List<string>();

        public class CloudreveWebURL
        {
            /// <summary>
            /// 获取服务器登录配置
            /// </summary>
            public const string GET_AUTH_CONFIG = "api/v3/site/config";

            /// <summary>
            ///获取登录验证码图片
            /// </summary>
            public const string GET_CAPTURE = "api/v3/site/captcha";

            /// <summary>
            ///获取注册页面
            /// </summary>
            public const string GET_REGISTER_URL = "signup";

            /// <summary>
            ///获取找回密码页面
            /// </summary>
            public const string GET_FORGET_PWD_URL = "forget";

            /// <summary>
            ///验证登录URL
            /// </summary>
            public const string AUTHENTICATION_URL = "api/v3/user/session";

            /// <summary>
            ///获取文件列表URL
            /// </summary>
            public const string GET_FILE_LIST_URL = "api/v3/directory";

            /// <summary>
            ///获取视频文件列表URL
            /// </summary>
            public const string GET_VIDEO_FILE_LIST_URL = "api/v3/file/search/video%2Finternal";

            /// <summary>
            ///获取图片文件列表URL
            /// </summary>
            public const string GET_IMAGE_FILE_LIST_URL = "api/v3/file/search/image%2Finternal";

            /// <summary>
            ///获取音频文件列表URL
            /// </summary>
            public const string GET_AUDIO_FILE_LIST_URL = "api/v3/file/search/audio%2Finternal";

            /// <summary>
            ///获取文档文件列表URL
            /// </summary>
            public const string GET_DOCUMENT_FILE_LIST_URL = "api/v3/file/search/doc%2Finternal";

            /// <summary>
            ///创建目录URL
            /// </summary>
            public const string CREATE_DIRECTORY_URL = "api/v3/directory";

            /// <summary>
            ///获取存储空间信息URL
            /// </summary>
            public const string GET_USER_STORAGE_URL = "api/v3/user/storage";

            /// <summary>
            ///删除文件/文件夹URL
            /// </summary>
            public const string DELETE_FILE_URL = "api/v3/object";

            /// <summary>
            ///获取下载文件的URL
            /// </summary>
            public const string GET_DOWNLOAD_FILE_URL = "api/v3/file/download";

            /// <summary>
            ///获取重命名URL
            /// </summary>
            public const string GET_RENAME_FILE_URL = "api/v3/object/rename";

            /// <summary>
            ///创建分享URL
            /// </summary>
            public const string SHARE_FILE_URL = "api/v3/share";

            /// <summary>
            ///获取分享文件列表URL
            /// </summary>
            public const string GET_SHARE_FILE_LIST_URL = "api/v3/share?page={0}&order_by=created_at&order=DESC";

            /// <summary>
            /// 设置分享文件访问级别（Private/Public）URL
            /// </summary>
            public const string SET_SHARE_FILE_PROTECTED_LEVEL_URL = "api/v3/share/";
        }

        public static string DataBaseFullPath
        {
            get { return GetApplicationPath() + @"system.db"; }
        }

        public enum CloudreveFileListType
        {
            Dir = 0,
            File = 1
        }

        public static string GetApplicationPath()
        {
            if(Application.StartupPath.EndsWith(@"\"))
            {
                return Application.StartupPath;
            }
            else
            {
                return Application.StartupPath + @"\";
            }
        }

        public static bool DataTableReadXML(string xml, DataTable dt)
        {
            try
            {
                StringReader stream = new StringReader(xml);
                XmlTextReader reader = new XmlTextReader(stream);
                dt.ReadXml(reader);
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static string DataTableWriteXML(DataTable dt)
        {
            try
            {
                StringWriter stream = new StringWriter();
                dt.WriteXml(stream, XmlWriteMode.WriteSchema);
                return stream.ToString();
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}

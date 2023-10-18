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
        public static string GLOBLE_COOKIE = String.Empty;
        public static string GLOBLE_URL = String.Empty;
        public static JsonEntiryClass.GetAuthConfigJson.Data AUTH_CONFIG_DATA = null;
        public static string Current_Path_Storage_Policy = String.Empty;
        public static string BAIDUPAN_TOKEN = String.Empty;
        public static string CACHE_FOLDER = @"Cache\{0}\";
        public static string CURRENT_USER_ID = String.Empty;

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

            /// <summary>
            /// 获取上传时的SessionID URL
            /// </summary>
            public const string GET_UPLOAD_SESSION_ID_URL = "api/v3/file/upload";

            /// <summary>
            /// 获取上传文件URL
            /// </summary>
            public const string GET_UPLOAD_FILE_URL = "api/v3/file/upload/{0}/{1}";

            /// <summary>
            /// 获取文件或者目录属性URL
            /// </summary>
            public const string GET_PROPERTY_URL = "api/v3/object/property/{0}?trace_root={1}&is_folder={2}";

            /// <summary>
            /// 获取图片的缩略图URL
            /// </summary>
            public const string GET_IMAGE_THUMB_URL = "api/v3/file/thumb/{0}";

            /// <summary>
            ///  获取目录下载时的压缩包签名
            /// </summary>
            public const string GET_ARCHIVE_DOWNLOAD_SIGN_URL = "api/v3/file/archive";
        }

        public static string DataBaseFullPath
        {
            get { return ApplicationPath + @"system.db"; }
        }

        public enum CloudreveFileListType
        {
            Dir = 0,
            File = 1
        }

        public enum SettingType
        {
            文件列表相关 = 0,
            分享相关 = 1,
            上传相关 = 2,
            下载相关 = 3,
            系统相关 = 4
        }

        public static string ApplicationPath
        {
            get
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

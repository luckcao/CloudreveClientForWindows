using ComponentControls.Helper.Web;
using Newtonsoft.Json;
using System;
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


        public class CloudreveWebURL
        {
            public const string GET_AUTH_CONFIG = "api/v3/site/config";                             //获取服务器登录配置
            public const string GET_CAPTURE = "api/v3/site/captcha";                                //获取登录验证码图片
            public const string GET_REGISTER_URL = "signup";                                        //获取注册页面
            public const string GET_FORGET_PWD_URL = "forget";                                      //获取找回密码页面
            public const string AUTHENTICATION_URL = "api/v3/user/session";                         //验证登录URL
            public const string GET_FILE_LIST_URL = "api/v3/directory";                             //获取文件列表URL
            public const string GET_VIDEO_FILE_LIST_URL = "api/v3/file/search/video%2Finternal";    //获取视频文件列表URL
            public const string GET_IMAGE_FILE_LIST_URL = "api/v3/file/search/image%2Finternal";    //获取图片文件列表URL
            public const string GET_AUDIO_FILE_LIST_URL = "api/v3/file/search/audio%2Finternal";    //获取音频文件列表URL
            public const string GET_DOCUMENT_FILE_LIST_URL = "api/v3/file/search/doc%2Finternal";   //获取文档文件列表URL
            public const string CREATE_DIRECTORY_URL = "api/v3/directory";                          //创建目录URL
            public const string GET_USER_STORAGE_URL = "api/v3/user/storage";                       //获取存储空间信息URL
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

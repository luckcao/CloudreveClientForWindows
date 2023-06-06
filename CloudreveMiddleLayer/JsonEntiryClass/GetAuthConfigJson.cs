using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudreveMiddleLayer.JsonEntiryClass
{
    public class GetAuthConfigJson
    {
        public class Group
        {
            /// <summary>
            /// 
            /// </summary>
            public int id { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string name { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string allowShare { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string allowRemoteDownload { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string allowArchiveDownload { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string shareDownload { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string compress { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string webdav { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public int sourceBatch { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string advanceDelete { get; set; }

        }



        public class User
        {
            /// <summary>
            /// 
            /// </summary>
            public string id { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string user_name { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string nickname { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public int status { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string avatar { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string created_at { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string preferred_theme { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string anonymous { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public Group group { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public List<string> tags { get; set; }

        }



        public class Data
        {
            /// <summary>
            /// Luckcao's网盘
            /// </summary>
            public string title { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string loginCaptcha { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string regCaptcha { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string forgetCaptcha { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string emailActive { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string themes { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string defaultTheme { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string home_view_method { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string share_view_method { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string authn { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public User user { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string captcha_ReCaptchaKey { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string captcha_type { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string tcaptcha_captcha_app_id { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string registerEnabled { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string app_promotion { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string wopi_exts { get; set; }

        }



        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public int code { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public Data data { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string msg { get; set; }

        }
    }
}

using CloudreveMiddleLayer.Helper.Web;
using CloudreveMiddleLayer.JsonEntiryClass;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudreveMiddleLayer.Entiry
{
    public class FileListBaidu
    {
        internal class BaiduURL
        {
            public const string LOGIN_URL = "https://openapi.baidu.com/oauth/2.0/authorize?response_type=token&client_id={0}&redirect_uri=oob&scope=basic,netdisk&display=popup&device_id={1}";

            public const string FILE_LIST_URL = "https://pan.baidu.com/rest/2.0/xpan/file?method=list&dir={0}&access_token={1}";

            public const string LOGOUT_URL = "https://openapi.baidu.com/connect/2.0/logout?access_token={0}";
        }

        private const string APP_KEY = "Gnf2zIMmbtoijma8G1AGU0nlrEtmyiE1";
        private const string APP_ID = "25840798";
        public static string Token = String.Empty;

        public static string LoginURL
        {
            get
            {
                return String.Format(BaiduURL.LOGIN_URL, APP_KEY, APP_ID);
            }
        }

        public static bool Logout()
        {
            string url = String.Format(BaiduURL.LOGOUT_URL, Token);
            string tmpCookie = Util.GLOBLE_COOKIE;
            string responseContent = HttpClientHelper.Get(url, ref tmpCookie);
            if (!string.IsNullOrEmpty(responseContent))
            {
                //CloudreveMiddleLayer.JsonEntiryClass.GetBaiduFileListJson.Root root = JsonConvert.DeserializeObject<CloudreveMiddleLayer.JsonEntiryClass.GetBaiduFileListJson.Root>(responseContent);
                //if (root.errno == 0)
                //{
                //    return root.list;
                //}
                //else
                //{
                //    return null;
                //}
                return true;
            }
            return false;
        }

        public static DateTime ConvertTimeStampToDateTime(long timeStamp)
        {
            DateTime defaultTime = new DateTime(1970, 1, 1, 0, 0, 0);
            long defaultTick = defaultTime.Ticks; // / 100000000;
            long timeTick = defaultTick + timeStamp * 10000000;
            //// 东八区 要加上8个小时
            DateTime dt = new DateTime(timeTick).AddHours(8);

            return dt;
        }

        public static List<GetBaiduFileListJson.ListItem> GetFileList(string path)
        {
            string url = String.Format(BaiduURL.FILE_LIST_URL, path, Token);
            string tmpCookie = Util.GLOBLE_COOKIE;
            string responseContent = HttpClientHelper.Get(url, ref tmpCookie);
            if (!string.IsNullOrEmpty(responseContent))
            {
                CloudreveMiddleLayer.JsonEntiryClass.GetBaiduFileListJson.Root root = JsonConvert.DeserializeObject<CloudreveMiddleLayer.JsonEntiryClass.GetBaiduFileListJson.Root>(responseContent);
                if(root.errno == 0)
                {
                    return root.list;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}

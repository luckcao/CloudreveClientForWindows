using ComponentControls.Helper.Media;
using ComponentControls.Helper.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudreveMiddleLayer.Entiry
{
    public class Login
    {
        public static bool LoadCloudreveServerAuthConfig(string url)
        {
            if(String.IsNullOrEmpty(url))
            {
                return false;
            }
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += Util.CloudreveWebURL.GET_AUTH_CONFIG;
            string responseContent = HttpClientHelper.Get(url, ref Util.GLOBLE_COOKIE);
            if (!string.IsNullOrEmpty(responseContent))
            {
                Util.AUTH_CONFIG_DATA =
                    JsonConvert.DeserializeObject<CloudreveMiddleLayer.JsonEntiryClass.GetAuthConfigJson.Root>(responseContent).data;
                return true;
            }
            return false;
        }

        public static bool StartAutoLogin()
        {
            if(Util.AUTH_CONFIG_DATA != null)
            {
                return !Convert.ToBoolean(Util.AUTH_CONFIG_DATA.user.anonymous);
            }
            return false;
        }

        public static Image GetCaptcha(string url)
        {
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += Util.CloudreveWebURL.GET_CAPTURE;
            string base64FormatImage = String.Empty;
            string responseContent = HttpClientHelper.Get(url, ref Util.GLOBLE_COOKIE);
            if (!string.IsNullOrEmpty(responseContent))
            {
                base64FormatImage =
                    JsonConvert.DeserializeObject<CloudreveMiddleLayer.JsonEntiryClass.GetLoginCaptchaJson.Root>(responseContent).data;
                base64FormatImage = base64FormatImage.Replace("data:image/png;base64,", "");

                return ImageHelper.DecodeImage(base64FormatImage);
            }
            return null;
        }

        public static bool AuthLogin(string url, string userName, string pwd, bool needCaptcha, string captcha, out int returnCode, out string returnMessage)
        {
            JObject obj = new JObject();
            obj.Add("userName", userName);
            obj.Add("Password", pwd);
            if(needCaptcha)
            {
                obj.Add("captchaCode", captcha);
            }

            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += Util.CloudreveWebURL.AUTHENTICATION_URL;

            string responseContent = HttpClientHelper.Post(url, obj.ToString(), ref Util.GLOBLE_COOKIE);
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
    }
}

using CloudreveMiddleLayer.Data;
using CloudreveMiddleLayer.DataSet;
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
        #region DB Method

        public static bool GetServerInfo(DataSetSystemConfig.TBL_ServerInfoDataTable dt)
        {
            using(DataHelper da = new DataHelper())
            {
                string sql = "Select * From TBL_ServerInfo";
                return da.GetData(sql, dt);
            }
        }

        public static bool SaveServerUrl(DataSetSystemConfig.TBL_ServerInfoDataTable dt)
        {
            using (DataHelper da = new DataHelper())
            {
                da.BeginTransaction();

                try
                {
                    string sql = "Delete From TBL_ServerInfo";
                    da.ExecuteSQL(sql);

                    for (int i = 0; i < dt.Count; i++)
                    {
                        da.AddParameter("@ServerUrl", DataHelper.SqlNull(dt[i].ServerUrl));
                        da.AddParameter("@UserName", DataHelper.SqlNull(dt[i].UserName));
                        da.AddParameter("@Password", DataHelper.SqlNull(dt[i].Password));
                        da.AddParameter("@Cookie", DataHelper.SqlNull(dt[i].Cookie));
                        da.AddParameter("@RememberUserInfo", DataHelper.SqlNull(dt[i].RememberUserInfo.ToString()));
                        da.AddParameter("@AutoLogin", DataHelper.SqlNull(dt[i].AutoLogin.ToString()));

                        sql = "INSERT INTO TBL_ServerInfo (ServerUrl, UserName, Password, Cookie, RememberUserInfo, AutoLogin) " +
                            " Values(@ServerUrl, @UserName, @Password, @Cookie, @RememberUserInfo, @AutoLogin)";

                        if (!da.ExecuteSQL(sql))
                        {
                            throw new Exception("Insert TBL_ServerInfo Record Error.");
                        }
                    }

                    da.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    da.RollBack();
                    return false;
                }
            }
        }

        #endregion

        #region API Method

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
            //string tmpCookie = String.Empty;
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

        #endregion
    }
}
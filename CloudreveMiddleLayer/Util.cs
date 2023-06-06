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

        public class CloudreveWebURL
        {
            public const string GET_AUTH_CONFIG = "api/v3/site/config";
        }

        public static CloudreveMiddleLayer.JsonEntiryClass.GetAuthConfigJson.Data AUTH_CONFIG_DATA = null;

        public static bool LoadCloudreveServerAuthConfig(string url)
        {
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += Util.CloudreveWebURL.GET_AUTH_CONFIG;
            string responseContent = HttpClientHelper.Get(url, ref GLOBLE_COOKIE);
            if (!string.IsNullOrEmpty(responseContent))
            {
                Util.AUTH_CONFIG_DATA =
                    JsonConvert.DeserializeObject<CloudreveMiddleLayer.JsonEntiryClass.GetAuthConfigJson.Root>(responseContent).data;
                return true;
            }
            return false;
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
                dt.WriteXml(stream);
                return stream.ToString();
            }
            catch(Exception ex)
            {
                return null;
            }
        }
    }
}

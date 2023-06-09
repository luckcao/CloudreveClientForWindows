using ComponentControls.Helper.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudreveMiddleLayer.Entiry
{
    public class FileList
    {
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
    }
}

using ComponentControls.Helper.Web;
using Newtonsoft.Json;
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
    }
}

using CloudreveMiddleLayer.Helper.IO;
using CloudreveMiddleLayer.Helper.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudreveMiddleLayer.Entiry
{
    public class SystemEnvironment
    {
        public class StorageInfo
        {
            double usedSpace, totalSpace;
            string unitName;

            public StorageInfo(double usedSpace, double totalSpace, string unitName)
            {
                this.usedSpace = usedSpace;
                this.totalSpace = totalSpace;
                this.unitName = unitName;
            }

            public double UsedSpace { get { return usedSpace; } }

            public double TotalSpace { get { return totalSpace; } }

            public string UnitName { get { return unitName; } }
        }

        public static StorageInfo GetStorageInfo(out int returnCode, out string returnMessage)
        {
            string url = Util.GLOBLE_URL;
            if (!url.EndsWith("/"))
            {
                url += "/";
            }
            url += Util.CloudreveWebURL.GET_USER_STORAGE_URL;
            string tmpCookie = Util.GLOBLE_COOKIE;
            string responseContent = HttpClientHelper.Get(url, ref tmpCookie);
            returnCode = -1;
            returnMessage = String.Empty;
            if (!string.IsNullOrEmpty(responseContent))
            {
                JObject returnObj = (JObject)JsonConvert.DeserializeObject(responseContent);

                returnCode = Convert.ToInt32(returnObj["code"].ToString());
                if (returnCode != 0)
                {
                    returnMessage = returnObj["msg"].ToString();
                }
                else
                {
                    string used = returnObj["data"]["used"].ToString();
                    string total = returnObj["data"]["total"].ToString();

                    FileInfo.GetTwoSizeInShortFormat(ref total, ref used);

                    StorageInfo s = new StorageInfo(Convert.ToDouble(used.Split(' ')[0]),
                                                    Convert.ToDouble(total.Split(' ')[0]),
                                                    total.Split(' ')[1]);

                    return s;
                }
            }
            return null;
        }
    }
}

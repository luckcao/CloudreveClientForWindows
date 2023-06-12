using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudreveMiddleLayer.JsonEntiryClass
{
    public class GetFileListJson
    {
        public class ObjectsItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string id { get; set; }

            /// <summary>
            /// 作品
            /// </summary>
            public string name { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string path { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public bool thumb { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public long size { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string type { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string date { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string create_date { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string source_enabled { get; set; }

        }



        public class Policy
        {
            /// <summary>
            /// 
            /// </summary>
            public string id { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string name { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string type { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public int max_size { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public List<string> file_type { get; set; }

        }



        public class Data
        {
            /// <summary>
            /// 
            /// </summary>
            public string parent { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public List<ObjectsItem> objects { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public Policy policy { get; set; }

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

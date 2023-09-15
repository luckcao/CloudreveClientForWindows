using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudreveMiddleLayer.JsonEntiryClass
{
    public class GetPropertyJson
    {
        public class Data
        {
            /// <summary>
            /// 
            /// </summary>
            public string created_at { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string updated_at { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string policy { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public Int64 size { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public int child_folder_num { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public int child_file_num { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string path { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string query_date { get; set; }

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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudreveMiddleLayer.JsonEntiryClass
{
    public class GetShareFileJson
    {
        public class Source
        {
            /// <summary>
            /// 
            /// </summary>
            public string name { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public int size { get; set; }

        }



        public class ItemsItem
        {
            /// <summary>
            /// 
            /// </summary>
            public string key { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string is_dir { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string password { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string create_date { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public int downloads { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public int remain_downloads { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public int views { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public int expire { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string preview { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public Source source { get; set; }

        }



        public class Data
        {
            /// <summary>
            /// 
            /// </summary>
            public List<ItemsItem> items { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public int total { get; set; }

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

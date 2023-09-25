using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudreveMiddleLayer.JsonEntiryClass
{
    public class GetBaiduFileDetailInfoJson
    {
        //如果好用，请收藏地址，帮忙分享。
        public class Thumbs
        {
            /// <summary>
            /// 
            /// </summary>
            public string icon { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string url1 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string url2 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string url3 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string url4 { get; set; }
        }

        public class ListItem
        {
            /// <summary>
            /// 
            /// </summary>
            public int category { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int date_taken { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string dlink { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int duration { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string filename { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Int64 fs_id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int height { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int isdir { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int local_ctime { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int local_mtime { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string md5 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Int64 oper_id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string orientation { get; set; }
            /// <summary>
            /// /家庭/tina/AA9Z6170.jpg
            /// </summary>
            public string path { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int server_ctime { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int server_mtime { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Int64 size { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Thumbs thumbs { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int width { get; set; }
        }

        public class Names
        {
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public string errmsg { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int errno { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<ListItem> list { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Names names { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string request_id { get; set; }
        }

    }
}

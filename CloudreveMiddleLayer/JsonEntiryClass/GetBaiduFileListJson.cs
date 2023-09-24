using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudreveMiddleLayer.JsonEntiryClass
{
    public class GetBaiduFileListJson
    {
        public class ListItem
        {
            /// <summary>
            /// 
            /// </summary>
            public int tkbind_id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int server_atime { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int category { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string real_category { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int isdir { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int owner_type { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int wpfile { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Int64 oper_id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int server_ctime { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int extent_tinyint7 { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Int64 owner_id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int unlist { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int local_mtime { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Int64 size { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int server_mtime { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int share { get; set; }
            /// <summary>
            /// Good Lucky Charlie S01-04 1080p 好运查理
            /// </summary>
            public string server_filename { get; set; }
            /// <summary>
            /// /我的资源/Good Lucky Charlie S01-04 1080p 好运查理
            /// </summary>
            public string path { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int local_ctime { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int pl { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Int64 fs_id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int from_type { get; set; }
        }

        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public int errno { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public string guid_info { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public List<ListItem> list { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public Int64 request_id { get; set; }
            /// <summary>
            /// 
            /// </summary>
            public int guid { get; set; }
        }

    }
}

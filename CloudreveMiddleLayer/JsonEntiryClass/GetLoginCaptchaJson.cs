using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudreveMiddleLayer.JsonEntiryClass
{
    public class GetLoginCaptchaJson
    {
        public class Root
        {
            /// <summary>
            /// 
            /// </summary>
            public int code { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string data { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string msg { get; set; }

        }
    }
}

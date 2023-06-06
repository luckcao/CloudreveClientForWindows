using ComponentControls.Helper.Web;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudreveMiddleLayer.Entiry
{
    public class Login
    {
        public static bool StartAutoLogin()
        {
            if(Util.AUTH_CONFIG_DATA != null)
            {
                return !Convert.ToBoolean(Util.AUTH_CONFIG_DATA.user.anonymous);
            }
            return false;
        }
    }
}

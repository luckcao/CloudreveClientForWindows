using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentControls.Helper.Media
{
    public class ImageHelper
    {
        public static Image DecodeImage(string strImage)
        {
            try
            {
                var ms = new MemoryStream(System.Convert.FromBase64String(strImage));
                return Image.FromStream(ms);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}

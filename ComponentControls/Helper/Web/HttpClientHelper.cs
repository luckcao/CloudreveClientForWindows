﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ComponentControls.Helper.Web
{
    public class HttpClientHelper
    {
        public static string Get(string url, ref string cookie)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream myResponseStream = null;
            StreamReader myStreamReader = null;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("Cookie", "cookie");
                request.Proxy = null;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json; charset=UTF-8";
                request.AutomaticDecompression = DecompressionMethods.GZip;

                response = (HttpWebResponse)request.GetResponse();
                cookie = response.Headers["Set-Cookie"];
                myResponseStream = response.GetResponseStream();
                myStreamReader = new StreamReader(myResponseStream, Encoding.UTF8);
                return myStreamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if(myStreamReader != null)
                {
                    myStreamReader.Close();
                }
                if(myResponseStream != null)
                {
                    myResponseStream.Close();
                }
                if (response != null)
                {
                    response.Close();
                }
                if (request != null)
                {
                    request.Abort();
                }
            }
        }
    }
}

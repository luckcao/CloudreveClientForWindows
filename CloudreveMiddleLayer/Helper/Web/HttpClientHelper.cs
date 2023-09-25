using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CloudreveMiddleLayer.Helper.Web
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
                request.Headers.Add("Cookie", cookie);
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

        public static string Get(string url, ref string cookie, ref string redirectURL)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream myResponseStream = null;
            StreamReader myStreamReader = null;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("Cookie", cookie);
                request.Proxy = null;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json; charset=UTF-8";
                request.AutomaticDecompression = DecompressionMethods.GZip;

                response = (HttpWebResponse)request.GetResponse();
                redirectURL = response.ResponseUri.ToString();
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
                if (myStreamReader != null)
                {
                    myStreamReader.Close();
                }
                if (myResponseStream != null)
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

        public static Image GetImage(string url, ref string cookie)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream myResponseStream = null;
            StreamReader myStreamReader = null;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("Cookie", cookie);
                request.Proxy = null;
                request.KeepAlive = false;
                request.Method = "GET";
                request.ContentType = "application/json; charset=UTF-8";
                request.AutomaticDecompression = DecompressionMethods.GZip;

                response = (HttpWebResponse)request.GetResponse();
                cookie = response.Headers["Set-Cookie"];
                myResponseStream = response.GetResponseStream();
                return Image.FromStream(myResponseStream);
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (myStreamReader != null)
                {
                    myStreamReader.Close();
                }
                if (myResponseStream != null)
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

        public static string Post(string url, string json, ref string cookie)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream myResponseStream = null;
            StreamReader myStreamReader = null;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("Cookie", cookie);
                request.ContentType = "application/json; charset=utf-8";
                request.Method = "POST";
                request.Proxy = null;
                //request.KeepAlive = false;

                byte[] btBodys = Encoding.UTF8.GetBytes(json);
                request.ContentLength = btBodys.Length;
                request.GetRequestStream().Write(btBodys, 0, btBodys.Length);

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
                if (myStreamReader != null)
                {
                    myStreamReader.Close();
                }
                if (myResponseStream != null)
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

        public static string Post(string url, string contentType, string userAgent, string json,  ref string cookie)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream myResponseStream = null;
            StreamReader myStreamReader = null;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("Cookie", cookie);
                request.UserAgent = userAgent;
                request.ContentType = contentType;
                request.Method = "POST";
                request.Proxy = null;
                //request.KeepAlive = false;

                byte[] btBodys = Encoding.UTF8.GetBytes(json);
                request.ContentLength = btBodys.Length;
                request.GetRequestStream().Write(btBodys, 0, btBodys.Length);

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
                if (myStreamReader != null)
                {
                    myStreamReader.Close();
                }
                if (myResponseStream != null)
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

        public static string Patch(string url, string json, ref string cookie)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream myResponseStream = null;
            StreamReader myStreamReader = null;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("Cookie", cookie);
                request.ContentType = "application/json; charset=utf-8";
                request.Method = "PATCH";
                request.Proxy = null;

                byte[] btBodys = Encoding.UTF8.GetBytes(json);
                request.ContentLength = btBodys.Length;
                request.GetRequestStream().Write(btBodys, 0, btBodys.Length);

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
                if (myStreamReader != null)
                {
                    myStreamReader.Close();
                }
                if (myResponseStream != null)
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

        public static string Put(string url, string json, ref string cookie)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream myResponseStream = null;
            StreamReader myStreamReader = null;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("Cookie", cookie);
                request.ContentType = "application/json; charset=utf-8";
                request.Method = "PUT";
                request.Proxy = null;
                //request.KeepAlive = false;

                byte[] btBodys = Encoding.UTF8.GetBytes(json);
                request.ContentLength = btBodys.Length;
                request.GetRequestStream().Write(btBodys, 0, btBodys.Length);

                response = (HttpWebResponse)request.GetResponse();
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
                if (myStreamReader != null)
                {
                    myStreamReader.Close();
                }
                if (myResponseStream != null)
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

        public static string Put(string url, ref string cookie)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream myResponseStream = null;
            StreamReader myStreamReader = null;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("Cookie", cookie);
                request.Method = "PUT";
                request.Proxy = null;
                //request.KeepAlive = false;

                response = (HttpWebResponse)request.GetResponse();
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
                if (myStreamReader != null)
                {
                    myStreamReader.Close();
                }
                if (myResponseStream != null)
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

        public static string Delete(string url, string json, ref string cookie)
        {
            HttpWebRequest request = null;
            HttpWebResponse response = null;
            Stream myResponseStream = null;
            StreamReader myStreamReader = null;

            try
            {
                
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("Cookie", cookie);
                request.ContentType = "application/json; charset=utf-8";
                request.Method = "DELETE";
                request.Proxy = null;
                //request.KeepAlive = false;

                byte[] btBodys = Encoding.UTF8.GetBytes(json);
                request.ContentLength = btBodys.Length;
                request.GetRequestStream().Write(btBodys, 0, btBodys.Length);

                response = (HttpWebResponse)request.GetResponse();
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
                if (myStreamReader != null)
                {
                    myStreamReader.Close();
                }
                if (myResponseStream != null)
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

        public static bool UploadFile(string url, byte[] data, string cookie)
        {
            // Check if the arguments are valid
            if (url == null || url == "")
            {
                throw new ArgumentException("Url cannot be null or empty.");
            }
            if (data == null || data.Length == 0)
            {
                throw new ArgumentException("Data cannot be null or empty.");
            }

            // Create a web request to the url
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Headers.Add("Cookie", cookie);
            // Set the method to POST
            request.Method = "POST";

            // Set the content type to octet-stream
            request.ContentType = "application/octet-stream";

            // Set the content length to the data length
            request.ContentLength = data.Length;

            // Get the request stream to write the data
            using (Stream stream = request.GetRequestStream())
            {
                // Write the data to the stream
                stream.Write(data, 0, data.Length);
            }

            // Get the response from the server
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                // Check if the status code is OK
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    // Return true to indicate success
                    return true;
                }
                else
                {
                    // Return false to indicate failure
                    return false;
                }
            }
        }

        #region 解析Url

        public static string GetUrlParameterValue(string url, string paraName)
        {
            Uri uri = new Uri(url);
            string queryString = uri.Fragment;
            NameValueCollection col = GetQueryString(queryString);
            if (col.Get(paraName) != null || col.AllKeys.Contains(paraName))
            {
                return col[paraName];
            }
            else
            {
                return null;
            }
        }

        ///   <summary> 
        ///  将查询字符串解析转换为名值集合.
        ///   </summary> 
        ///   <param name="queryString"></param> 
        ///   <returns></returns> 
        private static NameValueCollection GetQueryString(string queryString)
        {
            return GetQueryString(queryString, null, true);
        }

        ///   <summary> 
        ///  将查询字符串解析转换为名值集合.
        ///   </summary> 
        ///   <param name="queryString"></param> 
        ///   <param name="encoding"></param> 
        ///   <param name="isEncoded"></param> 
        ///   <returns></returns> 
        private static NameValueCollection GetQueryString(string queryString, Encoding encoding, bool isEncoded)
        {
            queryString = queryString.Replace("?", "");
            NameValueCollection result = new NameValueCollection(StringComparer.OrdinalIgnoreCase);
            if (!string.IsNullOrEmpty(queryString))
            {
                int count = queryString.Length;
                for (int i = 0; i < count; i++)
                {
                    int startIndex = i;
                    int index = -1;
                    while (i < count)
                    {
                        char item = queryString[i];
                        if (item == '=')
                        {
                            if (index < 0)
                            {
                                index = i;
                            }
                        }
                        else if (item == '&')
                        {
                            break;
                        }
                        i++;
                    }
                    string key = null;
                    string value = null;
                    if (index >= 0)
                    {
                        key = queryString.Substring(startIndex, index - startIndex);
                        value = queryString.Substring(index + 1, (i - index) - 1);
                    }
                    else
                    {
                        key = queryString.Substring(startIndex, i - startIndex);
                    }
                    if(string.IsNullOrEmpty(key))
                    {
                        break;
                    }
                    if (isEncoded)
                    {
                        result[MyUrlDeCode(key, encoding)] = MyUrlDeCode(value, encoding);
                    }
                    else
                    {
                        result[key] = value;
                    }
                    if ((i == (count - 1)) && (queryString[i] == '&'))
                    {
                        result[key] = string.Empty;
                    }
                }
            }
            return result;
        }

        ///   <summary> 
        ///  解码URL.
        ///   </summary> 
        ///   <param name="encoding"> null为自动选择编码 </param> 
        ///   <param name="str"></param> 
        ///   <returns></returns> 
        private static string MyUrlDeCode(string str, Encoding encoding)
        {
            if(string.IsNullOrEmpty(str))
            {
                return null;
            }
            if (encoding == null)
            {
                Encoding utf8 = Encoding.UTF8;
                // 首先用utf-8进行解码                      
                string code = HttpUtility.UrlDecode(str.ToUpper(), utf8);
                // 将已经解码的字符再次进行编码. 
                string encode = HttpUtility.UrlEncode(code, utf8).ToUpper();
                if (str == encode)
                    encoding = Encoding.UTF8;
                else
                    encoding = Encoding.GetEncoding("gb2312");
            }
            return HttpUtility.UrlDecode(str, encoding);
        }

        #endregion
    }
}

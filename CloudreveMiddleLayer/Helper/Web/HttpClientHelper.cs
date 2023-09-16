using System;
using System.Collections.Generic;
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

        //public static string HttpUploadFile(string url, string poststr, string fileformname, string fileName, byte[] bt, Stream stream = null)
        //{
        //    try
        //    {
        //        // 这个可以是改变的，也可以是下面这个固定的字符串 
        //        string boundary = "split";

        //        // 创建request对象 
        //        HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
        //        webrequest.ContentType = "multipart/form-data;boundary=" + boundary;
        //        webrequest.Method = "POST";

        //        // 构造发送数据
        //        StringBuilder sb = new StringBuilder();

        //        // 文本域的数据，将user=eking&pass=123456 格式的文本域拆分 ，然后构造 
        //        if (poststr.Contains("&"))
        //        {
        //            foreach (string c in poststr.Split('&'))
        //            {
        //                string[] item = c.Split('=');
        //                if (item.Length != 2)
        //                {
        //                    break;
        //                }
        //                string name = item[0];
        //                string value = item[1];
        //                sb.Append("--" + boundary);
        //                sb.Append("\r\n");
        //                sb.Append("Content-Disposition: form-data; name=\"" + name + "\"");
        //                sb.Append("\r\n\r\n");
        //                sb.Append(value);
        //                sb.Append("\r\n");
        //            }
        //        }
        //        else
        //        {
        //            string[] item = poststr.Split('=');
        //            if (item.Length != 2)
        //            {
        //                return "";
        //            }
        //            string name = item[0];
        //            string value = item[1];
        //            sb.Append("--" + boundary);
        //            sb.Append("\r\n");
        //            sb.Append("Content-Disposition: form-data; name=\"" + name + "\"");
        //            sb.Append("\r\n\r\n");
        //            sb.Append(value);
        //            sb.Append("\r\n");
        //        }

        //        // 文件域的数据
        //        sb.Append("--" + boundary);
        //        sb.Append("\r\n");
        //        sb.Append("Content-Type:application/octet-stream");
        //        sb.Append("\r\n");
        //        sb.Append("Content-Disposition: form-data; name=\"" + fileformname + "\"; filename=\"" + fileName + "\"");
        //        sb.Append("\r\n\r\n");

        //        string postHeader = sb.ToString();
        //        byte[] postHeaderBytes = Encoding.UTF8.GetBytes(postHeader);

        //        //构造尾部数据 
        //        byte[] boundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");

        //        //string filePath = @"C:/2.html";
        //        //string fileName = "2.html";

        //        //byte[] fileContentByte = new byte[1024]; // 文件内容二进制
        //        if (bt != null && stream == null)
        //        {
        //            long length = postHeaderBytes.Length + bt.Length + boundaryBytes.Length;
        //            webrequest.ContentLength = length;
        //        }
        //        else if (bt == null && stream != null)
        //        {
        //            long length = postHeaderBytes.Length + stream.Length + boundaryBytes.Length;
        //            webrequest.ContentLength = length;
        //        }

        //        Stream requestStream = webrequest.GetRequestStream();

        //        // 输入头部数据 要按顺序
        //        requestStream.Write(postHeaderBytes, 0, postHeaderBytes.Length);

        //        // 输入文件流数据 
        //        if (bt != null && stream == null)
        //        {
        //            requestStream.Write(bt, 0, bt.Length);
        //        }
        //        else if (bt == null && stream != null)
        //        {
        //            stream.CopyTo(requestStream);
        //        }

        //        // 输入尾部数据 
        //        requestStream.Write(boundaryBytes, 0, boundaryBytes.Length);
        //        WebResponse responce = webrequest.GetResponse();
        //        Stream s = responce.GetResponseStream();
        //        StreamReader sr = new StreamReader(s);

        //        // 返回数据流(源码) 
        //        return sr.ReadToEnd();
        //    }
        //    catch (Exception ex)
        //    {
        //        //GlobalFunc.LogError("HttpUploadFile错误：" + ex.Message + ex.StackTrace);
        //        return "";
        //    }
        //    finally
        //    {
        //        if (stream != null)
        //        {
        //            stream.Close();
        //        }
        //    }
        //}

    }
}

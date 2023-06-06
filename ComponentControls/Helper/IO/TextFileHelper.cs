using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ComponentControls.Helper.IO
{
    public class TextFileHelper
    {
        public static void OpenFileFolder(string filePath)
        {
            FileInfo f = new FileInfo(filePath);
            System.Diagnostics.Process.Start("Explorer.exe", f.DirectoryName);
        }

        public static void OpenFile(string filePath)
        {
            System.Diagnostics.Process.Start(filePath);
        }

        public static byte[] File2Bytes(string fileName)
        {
            FileStream fs;
            try
            {
                fs = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read);
                byte[] fileDatas = new byte[fs.Length];
                fs.Read(fileDatas, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
                return fileDatas;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static bool Bytes2File(byte[] bytes, string fileName)
        {
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    fs.Write(bytes, 0, bytes.Length);
                }
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool WriteTextFile(string fileName, string[] value, bool appendMode)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(fileName, appendMode, Encoding.UTF8))
                {
                    foreach (string s in value)
                    {
                        sw.WriteLine(s);
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static string[] ReadTextFileEachLine(string fileName)
        {
            List<string> values = new List<string>();

            string line = "";
            using (StreamReader sr = new StreamReader(fileName))
            {
                try
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        values.Add(line);
                    }
                    return values.ToArray();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public static string ReadTextFile(string fileName)
        {
            StringBuilder line = new StringBuilder();

            using (StreamReader sr = new StreamReader(fileName))
            {
                try
                {
                    string temp = string.Empty;
                    while ((temp = sr.ReadLine()) != null)
                    {
                        line.Append(line);
                    }
                    return line.ToString();
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
        }

        public static byte[] GetFileHashByte(string filePaht)
        {
            using (System.Security.Cryptography.HashAlgorithm hash = HashAlgorithm.Create("SHA1"))
            {
                using (FileStream file1 = new FileStream(filePaht, FileMode.Open))
                {
                    return hash.ComputeHash(file1);
                }
            }
        }

        public static bool CompareTwoFileHash(byte[] file1Hash, byte[] file2Hash)
        {
            if (file1Hash == null || file2Hash == null)
            {
                return false;
            }

            if (file1Hash.Length != file2Hash.Length)
            {
                return false;
            }

            for (int i = 0; i < file1Hash.Length; i++)
            {
                if (file1Hash[i] != file2Hash[i])
                {
                    return false;
                }
            }

            return true;
        }

        public static string GetFileExtention(string fileName)
        {
            if (fileName == null || fileName.Equals(System.String.Empty))
            {
                return "";
            }

            return fileName.Substring(fileName.LastIndexOf(".") + 1).ToUpper();
        }

        public static bool IsImageFile(string fileName)
        {
            string ext = GetFileExtention(fileName);
            return ext.Equals("JPG") || ext.Equals("PNG") || ext.Equals("BMP") || ext.Equals("GIF");
        }
    }
}

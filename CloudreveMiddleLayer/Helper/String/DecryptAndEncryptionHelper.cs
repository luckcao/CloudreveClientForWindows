using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CloudreveMiddleLayer.Helper.String
{
    public class DecryptAndEncryptionHelper
    {
        private static readonly SymmetricAlgorithm _symmetricAlgorithm = new RijndaelManaged();
        private static string _key = "27e167e9-2660-4bc1-bea0-c8781a9f01cb";
        private static string _iv = "8280d587-f9bf-4127-bbfa-5e0b4b672958";

        public string Key
        {
            get { return _key; }
            set { _key = value; }
        }

        public string IV
        {
            get { return _iv; }
            set { _iv = value; }
        }

        /// <summary>
        /// Get Key
        /// </summary>
        /// <returns>密钥</returns>
        private static byte[] GetLegalKey()
        {
            _symmetricAlgorithm.GenerateKey();
            byte[] bytTemp = _symmetricAlgorithm.Key;
            int KeyLength = bytTemp.Length;
            if (_key.Length > KeyLength)
                _key = _key.Substring(0, KeyLength);
            else if (_key.Length < KeyLength)
                _key = _key.PadRight(KeyLength, '#');
            return ASCIIEncoding.ASCII.GetBytes(_key);
        }

        /// <summary>
        /// Get IV
        /// </summary>
        private static byte[] GetLegalIV()
        {
            _symmetricAlgorithm.GenerateIV();
            byte[] bytTemp = _symmetricAlgorithm.IV;
            int IVLength = bytTemp.Length;
            if (_iv.Length > IVLength)
                _iv = _iv.Substring(0, IVLength);
            else if (_iv.Length < IVLength)
                _iv = _iv.PadRight(IVLength, '#');
            return ASCIIEncoding.ASCII.GetBytes(_iv);
        }

        /// <summary>
        /// Encrypto 加密
        /// </summary>
        public static string Encrypto(string Source)
        {
            byte[] bytIn = UTF8Encoding.UTF8.GetBytes(Source);
            MemoryStream ms = new MemoryStream();
            _symmetricAlgorithm.Key = GetLegalKey();
            _symmetricAlgorithm.IV = GetLegalIV();
            ICryptoTransform encrypto = _symmetricAlgorithm.CreateEncryptor();
            CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Write);
            cs.Write(bytIn, 0, bytIn.Length);
            cs.FlushFinalBlock();
            ms.Close();
            byte[] bytOut = ms.ToArray();
            return Convert.ToBase64String(bytOut);
        }

        /// <summary>
        /// Decrypto 解密
        /// </summary>
        public static string Decrypto(string Source)
        {
            if (Source != null)
            {
                byte[] bytIn = Convert.FromBase64String(Source);
                MemoryStream ms = new MemoryStream(bytIn, 0, bytIn.Length);
                _symmetricAlgorithm.Key = GetLegalKey();
                _symmetricAlgorithm.IV = GetLegalIV();
                ICryptoTransform encrypto = _symmetricAlgorithm.CreateDecryptor();
                CryptoStream cs = new CryptoStream(ms, encrypto, CryptoStreamMode.Read);
                StreamReader sr = new StreamReader(cs);
                return sr.ReadToEnd();
            }
            else
            {
                return "";
            }
        }
    }
}

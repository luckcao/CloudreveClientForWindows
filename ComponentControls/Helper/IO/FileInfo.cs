﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentControls.Helper.IO
{
    public class FileInfo
    {
        public static string GetSizeInShortFormat(Int64 size)
        {
            if (size > 0 && size < 1024)
            {
                return size.ToString() + " B";
            }
            else if (size >= 1024 && size < 1048576)  //1048576是1M
            {
                return Math.Round((size / 1024.0), 2).ToString() + " KB";
            }
            else if (size >= 1048576 && size < 1073741824)  //1073741824是1G
            {
                return Math.Round((size / 1024.0 / 1024.0), 2).ToString() + " MB";
            }
            else if (size >= 1073741824 && size < 1099511627776)  //1099511627776是1T
            {
                return Math.Round((size / 1024.0 / 1024.0 / 1024.0), 2).ToString() + " GB";
            }
            else
            {
                return Math.Round((size / 1024.0 / 1024.0 / 1024.0 / 1024.0), 2).ToString() + " TB";
            }
        }

        public static void GetTwoSizeInShortFormat(ref string strSize1, ref string strSize2)
        {
            Int64 size1 = Convert.ToInt64(strSize1);
            Int64 size2 = Convert.ToInt64(strSize2);

            //size1是大的值
            if (size1 > 0 && size1 < 1024)
            {
                strSize1 = size1.ToString() + " B";
                strSize2 = size2.ToString() + " B";
            }
            else if (size1 >= 1024 && size1 < 1048576)  //1048576是1M
            {
                strSize1 = Math.Round((size1 / 1024.0), 2).ToString() + " KB";
                strSize2 = Math.Round((size2 / 1024.0), 2).ToString() + " KB";
            }
            else if (size1 >= 1048576 && size1 < 1073741824)  //1073741824是1G
            {
                strSize1 = Math.Round((size1 / 1024.0 / 1024.0), 2).ToString() + " MB";
                strSize2 = Math.Round((size2 / 1024.0 / 1024.0), 2).ToString() + " MB";
            }
            else if (size1 >= 1073741824 && size1 < 1099511627776)  //1099511627776是1T
            {
                strSize1 = Math.Round((size1 / 1024.0 / 1024.0 / 1024.0), 2).ToString() + " GB";
                strSize2 = Math.Round((size2 / 1024.0 / 1024.0 / 1024.0), 2).ToString() + " GB";
            }
            else
            {
                strSize1 = Math.Round((size1 / 1024.0 / 1024.0 / 1024.0 / 1024.0), 2).ToString() + " TB";
                strSize2 = Math.Round((size2 / 1024.0 / 1024.0 / 1024.0 / 1024.0), 2).ToString() + " TB";
            }

        }
    }
}

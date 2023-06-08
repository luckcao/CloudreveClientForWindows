using CloudreveMiddleLayer;
using CloudreveMiddleLayer.Entiry;
using CloudreveMiddleLayer.JsonEntiryClass;
using ComponentControls.Controls;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace CloudreveForWindows.Forms
{
    public partial class Main : Form
    {
        string filterType = "all";
        List<string> currentPathList = new List<string>();
        List<GetFileListJson.ObjectsItem> currentFileList = new List<GetFileListJson.ObjectsItem>();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            StartWait();

            InitialLeftMenu();
            RefreshFileList();

            EndWait();
        }

        private void StartWait()
        {
            panTop.Enabled = false;
            panLeftMenu.Enabled = false;
            panLeftBottom.Enabled = false;
            panMiddleTop.Enabled = false;
            panRightMenu.Enabled = false;
            lblWait.Image = global::CloudreveForWindows.Properties.Resources.wait;
            lblWait.Visible = true;
            lblWait.BringToFront();
            Application.DoEvents();
        }

        private void EndWait()
        {
            lblWait.Visible = false;
            lblWait.Image = null;
            panTop.Enabled = true;
            panLeftMenu.Enabled = true;
            panLeftBottom.Enabled = true;
            panMiddleTop.Enabled = true;
            panRightMenu.Enabled = true;
        }

        private void btnShowLeftMenu_Click(object sender, EventArgs e)
        {
            panLeftMenu.Visible = !panLeftMenu.Visible;
        }

        private void btnShowProfile_Click(object sender, EventArgs e)
        {
            panRightMenu.Visible = !panRightMenu.Visible;
        }

        private void InitialLeftMenu()
        {
            List<NavigateMenuItem> items = new List<NavigateMenuItem>();

            items.Insert(0, new NavigateMenuItem(0, global::CloudreveForWindows.Properties.Resources.myfile, "我的文件"));
            items.Insert(1, new NavigateMenuItem(0, global::CloudreveForWindows.Properties.Resources.home, "根目录", 0));
            items.Insert(2, new NavigateMenuItem(1, global::CloudreveForWindows.Properties.Resources.video, "视频", 0));
            items.Insert(3, new NavigateMenuItem(2, global::CloudreveForWindows.Properties.Resources.image, "图片", 0));
            items.Insert(4, new NavigateMenuItem(3, global::CloudreveForWindows.Properties.Resources.music, "音乐", 0));
            items.Insert(5, new NavigateMenuItem(4, global::CloudreveForWindows.Properties.Resources.document, "文档", 0));
            items.Insert(6, new NavigateMenuItem(5, global::CloudreveForWindows.Properties.Resources.addTag, "添加标签", 0));

            items.Insert(7, new NavigateMenuItem(6, global::CloudreveForWindows.Properties.Resources.share, "我的分享"));
            items.Insert(8, new NavigateMenuItem(7, global::CloudreveForWindows.Properties.Resources.download, "离线下载"));
            items.Insert(9, new NavigateMenuItem(8, global::CloudreveForWindows.Properties.Resources.task, "任务队列"));

            menuLeft.BindDataSource(items, true);
        }

        private void menuLeft_MenuItemClick(object sender, NavigateMenuItemClickedArgs e)
        {
            StartWait();

            switch(e.MenuItemID)
            {
                case 1:
                    filterType = "All";
                    break;
                case 2:
                    //视频文件
                    filterType = "Video";
                    break;
                case 3:
                    //图片文件
                    filterType = "Image";
                    break;
                case 4:
                    //音乐文件
                    filterType = "Audio";
                    break;
                case 5:
                    //音乐文件
                    filterType = "文档";
                    break;
            }
            RefreshFileList();

            EndWait();
        }

        private void RefreshFileList()
        {
            currentFileList.Clear();
            currentPathList.Clear();

            string dirPathString = GetDirStringByList();
            dirPathString = dirPathString.Replace("%2F", "/");
            lblPath.Text = dirPathString;
            switch(filterType.ToUpper())
            {
                case "ALL":
                    currentFileList = FileList.GetFileList(Util.CloudreveWebURL.GET_FILE_LIST_URL + GetDirStringByList());
                    break;
                case "VIDEO":
                    currentFileList = FileList.GetFileList(Util.CloudreveWebURL.GET_VIDEO_FILE_LIST_URL);
                    break;
                case "IMAGE":
                    currentFileList = FileList.GetFileList(Util.CloudreveWebURL.GET_IMAGE_FILE_LIST_URL);
                    break;
                case "AUDIO":
                    currentFileList = FileList.GetFileList(Util.CloudreveWebURL.GET_AUDIO_FILE_LIST_URL);
                    break;
                case "DOC":
                    currentFileList = FileList.GetFileList(Util.CloudreveWebURL.GET_DOCUMENT_FILE_LIST_URL);
                    break;
            }

        }

        private String GetDirStringByList()
        {
            StringBuilder convertedPathString = new StringBuilder("%2F");
            for (int i = 0; i< currentPathList.Count; i++) // String dirName : currentFileTreePath)
            {
                convertedPathString.Append(currentPathList[i]).Append("%2F");
            }
            if (currentPathList.Count != 0)
                convertedPathString = new StringBuilder(convertedPathString.ToString().Substring(0, convertedPathString.Length - 3));
            return convertedPathString.ToString();
        }

    }
}
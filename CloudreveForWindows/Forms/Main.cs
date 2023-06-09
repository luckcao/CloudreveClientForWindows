using CloudreveMiddleLayer;
using CloudreveMiddleLayer.DataSet;
using CloudreveMiddleLayer.Entiry;
using CloudreveMiddleLayer.JsonEntiryClass;
using ComponentControls.Controls;
using ComponentControls.Helper.Media;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CloudreveForWindows.Forms
{
    public partial class Main : Form
    {
        string filterType = "all", sortString = "";
        List<GetFileListJson.ObjectsItem> currentFileList = new List<GetFileListJson.ObjectsItem>();
        DataSetFileInfo.TBL_FileInfoDataTable dtFileList = new DataSetFileInfo.TBL_FileInfoDataTable();
        List<ToolStripMenuItem> sortMenu = new List<ToolStripMenuItem>();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            StartWait();

            directoryPath1.AddPath("/");
            InitialSortMenu();
            InitialFileTypeIconImageList();
            InitialLeftMenu();
            RefreshFileList();

            EndWait();
        }

        private void InitialSortMenu()
        {
            aZToolStripMenuItem.Checked = true;
            sortString = aZToolStripMenuItem.Tag.ToString();
            sortMenu.Add(aZToolStripMenuItem);
            sortMenu.Add(zAToolStripMenuItem);
            sortMenu.Add(最早上传ToolStripMenuItem);
            sortMenu.Add(最新上传ToolStripMenuItem);
            sortMenu.Add(最早修改ToolStripMenuItem);
            sortMenu.Add(最新修改ToolStripMenuItem);
            sortMenu.Add(最小ToolStripMenuItem);
            sortMenu.Add(最大ToolStripMenuItem);
        }

        private void SortMenuItem_Click(object sender, EventArgs e)
        {
            StartWait();

            for (int i = 0; i < sortMenu.Count; i++)
            {
                sortMenu[i].Checked = false;
            }
            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            sortString = item.Tag.ToString();
            item.Checked = true;

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

        private void InitialFileTypeIconImageList()
        {
            imglstFileTypeIcon.Images.AddRange(new System.Drawing.Image[]
            {
                global::CloudreveForWindows.Properties.Resources.dir

            });
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
            items.Insert(1, new NavigateMenuItem(0, global::CloudreveForWindows.Properties.Resources.home, "主目录", 0));
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
            dtFileList.Clear();
            dtFileList.AcceptChanges();
            dgvFileList.DataSource = null;
            lblFileCount.Text = "共有 {0} 个项目（ {1} 个文件夹，{2} 个文件）";

            switch(filterType.ToUpper())
            {
                case "ALL":
                    currentFileList = FileList.GetFileList(Util.CloudreveWebURL.GET_FILE_LIST_URL + directoryPath1.CurrentFullPath);
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

            int dirCount = 0, fileCount = 0;

            for (int i = 0; i < currentFileList.Count; i++)
            {
                DataSetFileInfo.TBL_FileInfoRow dr = dtFileList.NewTBL_FileInfoRow();
                dr.Tick = false;
                dr.FileName = currentFileList[i].name.Trim();
                string ext = String.Empty;
                if(dr.FileName.Contains("."))
                {
                    ext = dr.FileName.Substring(dr.FileName.LastIndexOf('.') + 1).ToUpper();
                }
                dr.Path = currentFileList[i].path.Trim();
                dr.Pic = currentFileList[i].pic.Trim();
                dr.Size = currentFileList[i].size;
                if(dr.Size <= 0)
                {
                    dr.SizeDesc = "";
                }
                else
                {
                    if(dr.Size > 0 && dr.Size < 1024)
                    {
                        dr.SizeDesc = dr.Size.ToString() + "B";
                    }
                    else if (dr.Size >= 1024 && dr.Size < 1048576)  //1048576是1M
                    {
                        dr.SizeDesc = Math.Round((dr.Size/1024.0), 2).ToString() + "KB";
                    }
                    else if (dr.Size >= 1048576 && dr.Size < 1073741824)  //1073741824是1G
                    {
                        dr.SizeDesc = Math.Round((dr.Size / 1024.0 / 1024.0), 2).ToString() + "M";
                    }
                    else if (dr.Size >= 1073741824 && dr.Size < 1099511627776)  //1099511627776是1T
                    {
                        dr.SizeDesc = Math.Round((dr.Size / 1024.0 / 1024.0 / 1024.0), 2).ToString() + "G";
                    }
                    else
                    {
                        dr.SizeDesc = Math.Round((dr.Size / 1024.0 / 1024.0 / 1024.0 / 1024.0), 2).ToString() + "T";
                    }
                }
                switch (currentFileList[i].type.Trim().ToUpper())
                {
                    case "DIR":
                        dirCount++;
                        dr.Type = (int)Util.CloudreveFileListType.Dir;
                        dr.TypeImage = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.dir);
                        break;
                    case "FILE":
                        fileCount++;
                        dr.Type = (int)Util.CloudreveFileListType.File;

                        #region 设置文件图标

                        switch (ext)
                        {
                            case "PDF":
                                dr.TypeImage = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.pdf_file);
                                break;
                            case "MP3":
                            case "WAV":
                            case "MIDI":
                            case "CDA":
                            case "WMA":
                            case "AAC":
                            case "OGG":
                            case "VQF":
                                dr.TypeImage = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.audio_file);
                                break;
                            case "AVI":
                            case "WMV":
                            case "MPG":
                            case "MPEG":
                            case "MOV":
                            case "RM":
                            case "RAM":
                            case "RMVB":
                            case "FLV":
                            case "MP4":
                                dr.TypeImage = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.video_file);
                                break;
                            case "BMP":
                            case "JPEG":
                            case "TIF":
                            case "PNG":
                            case "GIF":
                            case "PSD":
                            case "RAW":
                            case "EPS":
                            case "SVG":
                            case "CDR":
                            case "AI":
                            case "JPG":
                            case "TIFF":
                                dr.TypeImage = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.img_file);
                                break;
                            case "TXT":
                            case "INI":
                            case "XML":
                            case "MD":
                                dr.TypeImage = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.txt_file);
                                break;
                            case "DOC":
                            case "DOCX":
                            case "XPS":
                            case "RTF":
                                dr.TypeImage = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.word_file);
                                break;
                            case "XLS":
                            case "XLSX":
                            case "CVS":
                                dr.TypeImage = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.excel_file);
                                break;
                            case "ZIP":
                            case "7Z":
                            case "BZIP2":
                            case "GZIP":
                            case "TAR":
                            case "RAR":
                            case "XZ":
                            case "ISO":
                                dr.TypeImage = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.zip_file);
                                break;
                            default:
                                dr.TypeImage = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.unknow_file);
                                break;
                        }

                        #endregion

                        break;
                }
                dr.ModifyDate = Convert.ToDateTime(currentFileList[i].date.Trim()).ToString("yyyy-MM-dd HH:mm:ss");
                dr.CreateDate = Convert.ToDateTime(currentFileList[i].create_date.Trim()).ToString("yyyy-MM-dd HH:mm:ss");
                dr.SourceEnabled = Convert.ToBoolean(currentFileList[i].source_enabled);
                dtFileList.AddTBL_FileInfoRow(dr);
            }

            DataView dv = dtFileList.DefaultView;
            dv.AllowEdit = true;
            dv.AllowNew = false;
            dv.AllowDelete = false;
            dv.Sort = sortString;
            dgvFileList.AutoGenerateColumns = false;
            dgvFileList.DataSource = dv;
            if(dgvFileList.Rows.Count > 0)
            {
                //默认选中第一条记录
                dgvFileList.Rows[0].Selected = false;
                dgvFileList.CurrentCell = null;
                dgvFileList.ClearSelection();
            }

            lblFileCount.Text = String.Format(lblFileCount.Text, currentFileList.Count, dirCount, fileCount);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(!directoryPath1.CurrentFullPath.Equals("/"))
            {
                StartWait();

                directoryPath1.RemoveLastPath();
                RefreshFileList();

                EndWait();
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
        }

        private void directoryPath1_PathItemClick(object sender, DirecrotyPathItemClickedArgs e)
        {
            StartWait();

            RefreshFileList();

            EndWait();
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int ShowScrollBar(IntPtr hWnd, int bar, int show);

        private void Main_Resize(object sender, EventArgs e)
        {
            ShowScrollBar(directoryPath1.Handle, 3, 0);
            ShowScrollBar(panMiddleTopMiddle.Handle, 3, 0);
        }

        private void dgvFileList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFileList.CurrentRow != null && dgvFileList.CurrentRow.Index >= 0)
            {
                DataView dv = (DataView)dgvFileList.DataSource;
                switch ((int)(dv[dgvFileList.CurrentRow.Index]["Type"]))
                {
                    case (int)Util.CloudreveFileListType.Dir:
                        StartWait();

                        directoryPath1.AddPath(dv[dgvFileList.CurrentRow.Index]["FileName"].ToString());
                        Application.DoEvents();
                        RefreshFileList();

                        EndWait();
                        break;
                    case (int)Util.CloudreveFileListType.File:
                        break;
                }
            }

            ShowScrollBar(directoryPath1.Handle, 3, 0);
            ShowScrollBar(panMiddleTopMiddle.Handle, 3, 0);
        }
    }
}
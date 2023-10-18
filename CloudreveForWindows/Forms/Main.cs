using CloudreveMiddleLayer;
using CloudreveMiddleLayer.DataSet;
using CloudreveMiddleLayer.Entiry;
using CloudreveMiddleLayer.JsonEntiryClass;
using ComponentControls.Controls;
using ComponentControls.Forms;
using CloudreveMiddleLayer.Helper.IO;
using CloudreveMiddleLayer.Helper.Media;
using CloudreveMiddleLayer.Helper.String;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using static CloudreveMiddleLayer.Entiry.SystemEnvironment;
using CloudreveMiddleLayer.Controls;
using MessageBox = ComponentControls.Forms.MessageBox;
using System.ComponentModel;
using Microsoft.Win32;
using CloudreveMiddleLayer.Helper.Web;

namespace CloudreveForWindows.Forms
{
    public partial class Main : Form
    {
        enum DisplayPanel
        {
            FileList = 0,
            Download = 1,
            Upload = 2,
            MyShare = 3,
            SynchronousBaidu = 4
        }

        enum WebBrowserStatus
        {
            Unused = -1,
            Login = 0,
            Logout = 1
        }

        string filterType = "all", sortString = "";
        DataSetFileInfo.TBL_FileInfoDataTable dtFileList = new DataSetFileInfo.TBL_FileInfoDataTable();
        DataSetFileInfo.TBL_FileInfoDataTable dtBaiduFileList = new DataSetFileInfo.TBL_FileInfoDataTable();
        DataSetDownloadUpload.TBL_DownloadInfoDataTable dtDownload = new DataSetDownloadUpload.TBL_DownloadInfoDataTable();
        DataSetDownloadUpload.TBL_UploadInfoDataTable dtUpload = new DataSetDownloadUpload.TBL_UploadInfoDataTable();
        List<ToolStripMenuItem> sortMenu = new List<ToolStripMenuItem>();
        WebBrowserStatus ws = WebBrowserStatus.Unused;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int ShowScrollBar(IntPtr hWnd, int bar, int show);

        public Main()
        {
            //SetFeatures(6000);
            InitializeComponent();
        }

        private void SetFeatures(UInt32 ieMode)
        {
            if (LicenseManager.UsageMode != LicenseUsageMode.Runtime)
            {
                throw new ApplicationException();
            }
            //获取程序及名称
            string appName = System.IO.Path.GetFileName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
            string featureControlRegKey = "HKEY_CURRENT_USER\\Software\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\";
            //设置浏览器对应用程序(appName)以什么模式(ieMode)运行
            Registry.SetValue(featureControlRegKey + "FEATURE_BROWSER_EMULATION", appName, ieMode, RegistryValueKind.DWord);
            //不晓得设置有什么用
            Registry.SetValue(featureControlRegKey + "FEATURE_ENABLE_CLIPCHILDREN_OPTIMIZATION", appName, 1, RegistryValueKind.DWord);
        }

        #region Form Events

        private void Main_Load(object sender, EventArgs e)
        {
            StartWait();

            panFileList.Dock = DockStyle.Fill;
            panDownload.Dock = DockStyle.Fill;
            panUpload.Dock = DockStyle.Fill;
            panMyShare.Dock = DockStyle.Fill;
            panSyncBaidu.Dock = DockStyle.Fill;

            DisplayMiddlePanleContent(DisplayPanel.FileList);
            directoryPath1.SetPadding(new Padding(15, 0, 0, 4));
            directoryPath1.AddPath("/");
            directoryPathBaidu.SetPadding(new Padding(15, 0, 0, 4));
            directoryPathBaidu.AddPath("/");
            InitialSortMenu();
            InitialLeftMenu();
            RefreshFileList();
            RefreshStorage();
            InitialDownloadTask();
            InitialUploadTask();

            EndWait();
        }

        private void DisplayMiddlePanleContent(DisplayPanel dp)
        {
            panFileList.Visible = dp == DisplayPanel.FileList;
            panDownload.Visible = dp == DisplayPanel.Download;
            panUpload.Visible = dp == DisplayPanel.Upload;
            panMyShare.Visible = dp == DisplayPanel.MyShare;
            panSyncBaidu.Visible = dp == DisplayPanel.SynchronousBaidu;
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            ShowScrollBar(directoryPath1.Handle, 3, 0);
            ShowScrollBar(panMiddleTopMiddle.Handle, 3, 0);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = ExMessageBox.Show("您确定要退出么？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (d == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #endregion

        #region Download

        private void InitialDownloadTask()
        {
            if (FileList.GetDownloadFileInfo(dtDownload))
            {
                for (int i = 0; i < dtDownload.Count; i++)
                {
                    //完成状态的图标不变，其余的变成start_task图标
                    if (dtDownload[i].DownloadPercent != 100)
                    {
                        dtDownload[i].DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task);
                    }
                    AddDownloadTaskToTransferFileControl(dtDownload[i], false, false, (TransferFileItem.TransferCategory)dtDownload[i].Category);
                }
            }
        }

        #region Add Download Task

        private void AddDownloadTaskToTransferFileControl(DataSetDownloadUpload.TBL_DownloadInfoRow dr, 
                                                          bool needAddToDB = false, 
                                                          bool autoStart = false,
                                                          TransferFileItem.TransferCategory category = TransferFileItem.TransferCategory.CloudreveTransfer)
        {
            tfDownload.Add(dr.FileID, dr.FileName, dr.FilePathFrom, dr.DownloadFilePath, dr.FileSizeDesc,
                           dr.DownloadStatus.SequenceEqual(ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task)) ? 100 : 0,
                           dr, TransferFileItem.TransferType.下载, autoStart, category, dr.UploadToCloudrevePath);

            if (needAddToDB && !FileList.AddDownloadTask(dr))
            {
                ExMessageBox.Show("添加下载任务到数据库失败！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddDownloadTaskToDataTableAndTransferFileControlAndDataBase(string fileID,
                                                                                 string fileName,
                                                                                 string sizeDesc,
                                                                                 string downloadPath, 
                                                                                 bool needAddToDB = true,
                                                                                 bool autoStart = false,
                                                                                 string filePathFrom = "",
                                                                                 TransferFileItem.TransferCategory category = TransferFileItem.TransferCategory.CloudreveTransfer,
                                                                                 string uploadToCloudrevePath = "")
        {
            DataSetDownloadUpload.TBL_DownloadInfoRow newRow = dtDownload.NewTBL_DownloadInfoRow();
            newRow.FileID = fileID;
            newRow.FileName = fileName;
            newRow.FileSizeDesc = sizeDesc;
            newRow.DownloadPercent = 0;
            newRow.DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task);
            newRow.FilePathFrom = filePathFrom;
            newRow.DownloadFilePath = downloadPath;
            newRow.OpenFolderDesc = "打开下载目录";
            newRow.DeleteDesc = "删除";
            newRow.Category = (int)category;
            newRow.UploadToCloudrevePath = uploadToCloudrevePath;

            dtDownload.AddTBL_DownloadInfoRow(newRow);
            dtDownload.AcceptChanges();

            AddDownloadTaskToTransferFileControl(newRow, needAddToDB, autoStart, category);
        }

        private void 下载WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //对单个文件点击鼠标右键进行下载
            //判断要下载的文件是否已经存在于下载列表里
            //如果存在，则提示用户。
            //如果不在，则添加到下载列表里，并启动下载。
            DataView dv = (DataView)dgvFileList.DataSource;
            if (dtDownload.Select("FileID = '" + dv[dgvFileList.CurrentRow.Index]["ID"].ToString().Trim() + "'").Length > 0)
            {
                ExMessageBox.Show("文件“" + dv[dgvFileList.CurrentRow.Index]["FileName"].ToString().Trim() + "”已经存在于下载任务列表。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                saveFileDialog1.FileName = dv[dgvFileList.CurrentRow.Index]["FileName"].ToString().Trim();
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    AddDownloadTaskToDataTableAndTransferFileControlAndDataBase(dv[dgvFileList.CurrentRow.Index]["ID"].ToString().Trim(),
                                                                                dv[dgvFileList.CurrentRow.Index]["FileName"].ToString().Trim(),
                                                                                dv[dgvFileList.CurrentRow.Index]["SizeDesc"].ToString().Trim(),
                                                                                saveFileDialog1.FileName,
                                                                                true,
                                                                                true);
                    ExMessageBox.Show("已添加到下载列表，请在下载列表中查看！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            //从文件列表中选择文件（允许多选）之后，点击下载按钮进行多文件下载
            dtFileList.AcceptChanges();
            DataSetFileInfo.TBL_FileInfoRow[] rows = (DataSetFileInfo.TBL_FileInfoRow[])dtFileList.Select("Tick=true");
            if (rows == null || rows.Length == 0)
            {
                ExMessageBox.Show("请选择要下载的文件！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog1.SelectedPath;
                    if (!selectedPath.EndsWith(@"\"))
                    {
                        selectedPath += @"\";
                    }
                    //判断要下载的文件是否已经存在于下载列表里
                    //如果存在，则提示用户。
                    //如果不在，则添加到下载列表里，并启动下载。
                    bool hasNewDownload = false;

                    for (int i = 0; i < rows.Count(); i++)
                    {
                        DataView dv = (DataView)dgvFileList.DataSource;
                        if (rows[i].Type == (int)Util.CloudreveFileListType.Dir)
                        {
                            ExMessageBox.Show("暂不支持下载文件夹。\r\n该文件夹内的文件将不被下载。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }
                        if (dtDownload.Select("FileID = '" + rows[i].ID + "'").Length > 0)
                        {
                            ExMessageBox.Show("文件“" + rows[i].FileName + "”已经存在于下载任务列表。\r\n将取消将此文件加入下载列表。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }
                        AddDownloadTaskToDataTableAndTransferFileControlAndDataBase(rows[i].ID,
                                                                                    rows[i].FileName,
                                                                                    rows[i].SizeDesc,
                                                                                    selectedPath + rows[i].FileName,
                                                                                    true,
                                                                                    true);

                        hasNewDownload = true;
                    }

                    if (hasNewDownload)
                    {
                        dtDownload.AcceptChanges();
                        //RefreshDownloadDataGridView();

                        ExMessageBox.Show("已添加到下载列表，请在下载列表中查看！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void tfDownload_TransferItemDeleted(object sender, int index, bool removeLocalFile)
        {
            dtDownload.Rows.RemoveAt(index);
            if(!removeLocalFile)
            {
                FileList.DeleteDownloadTask(tfDownload[index].FileID, String.Empty);
            }
            else
            {
                FileList.DeleteDownloadTask(tfDownload[index].FileID, tfDownload[index].FilePathTo);
            }
        }

        private void tfDownload_TransferItemCompleted(object sender, string fileID)
        {
            TransferFileItem t = (TransferFileItem)sender;
            if(t.Category != TransferFileItem.TransferCategory.CloudreveTransfer)
            {
                //如果不是CloudreveTransfer，则表示是从其他网盘转存过来，那么就要创建一个上传任务
                AddUploadTask(t.FilePathTo, t.UploadToCloudrevePath, t.Category);
            }

            if (!FileList.UpdateDownloadStatus(fileID, ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task)))
            {
                ExMessageBox.Show("保存下载状态到数据库失败！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        #region Start All Download Task

        private void btnStartAllDownloadTask_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tfDownload.ItemCount(TransferFileItem.Status.所有状态); i++)
            {
                if (tfDownload[i].CurrentStatus == TransferFileItem.Status.暂停)
                {
                    tfDownload[i].CurrentStatus = TransferFileItem.Status.正在传输;
                }
            }
        }

        #endregion

        #region Pause All Download Task

        private void btnPauseAllDownloadTask_Click(object sender, EventArgs e)
        {
            if (ExMessageBox.Show("您确定要取消全部的下载么？\r\n本次下载不支持断点续传，\r\n下次下载将从头开始下载。", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                for (int i = 0; i < tfDownload.ItemCount(TransferFileItem.Status.所有状态); i++)
                {
                    if (tfDownload[i].CurrentStatus == TransferFileItem.Status.正在传输)
                    {
                        tfDownload[i].CurrentStatus = TransferFileItem.Status.暂停;
                    }
                }
            }
        }

        #endregion

        #region Delete All Download Task

        private void btnDeleteAllDownloadTask_Click(object sender, EventArgs e)
        {
            MessageBox msg = new MessageBox("您确定要清空下载列表么？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, true, true, "同时删除本地文件");
            if (msg.ShowDialog() == DialogResult.Yes)
            {
                tfDownload.Clear(msg.Checked);
            }
        }

        #endregion

        #endregion

        #endregion

        #region Upload

        private void InitialUploadTask()
        {
            if (FileList.GetUploadFileInfo(dtUpload))
            {
                for (int i = 0; i < dtUpload.Count; i++)
                {
                    //完成状态的图标不变，其余的变成start_task图标
                    if (dtUpload[i].UploadPercent != 100)
                    {
                        dtUpload[i].UploadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task);
                    }
                    else
                    {
                        dtUpload[i].UploadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task);
                    }
                    AddUploadTaskToTransferFileControl(dtUpload[i]);
                }
            }
        }

        #region Add Upload Task

        private void AddUploadTaskToTransferFileControl(DataSetDownloadUpload.TBL_UploadInfoRow dr, bool needAddToDB = false)
        {
            tfUpload.Add(dr.FileID,
                                           dr.FileName,
                                           dr.FilePathFrom,
                                           dr.UploadFilePath,
                                           dr.FileSizeDesc,
                                           dr.UploadStatus.SequenceEqual(ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task)) ? 100 : 0,
                                           dr,
                                           TransferFileItem.TransferType.上传);

            if (needAddToDB && FileList.AddUploadTask(dr.FileName,
                                                       dr.FileSizeDesc,
                                                       0.0,
                                                       ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task),
                                                       dr.FileName,
                                                       dr.UploadFilePath,
                                                       dr.Category) == -1)
            {
                ExMessageBox.Show("添加下载任务到数据库失败！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddUploadTask(string localFileFullName, string destPath, TransferFileItem.TransferCategory category = TransferFileItem.TransferCategory.CloudreveTransfer)
        {
            System.IO.FileInfo f = new System.IO.FileInfo(localFileFullName);

            int fileID = FileList.AddUploadTask(f.Name,
                                                CloudreveMiddleLayer.Helper.IO.FileInfo.GetSizeInShortFormat(f.Length),
                                                0,
                                                ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task),
                                                f.FullName,
                                                destPath,
                                                (int)category);

            if (fileID == -1)
            {
                ExMessageBox.Show("添加上传任务至数据库失败！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tfUpload.Add(fileID.ToString().Trim(),
                             f.Name,
                             f.FullName,
                             destPath,
                             CloudreveMiddleLayer.Helper.IO.FileInfo.GetSizeInShortFormat(f.Length),
                             0,
                             null,
                             TransferFileItem.TransferType.上传,
                             true,
                             category);
            }
        }

        #endregion

        private void 上传文件UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            for(int i=0;i<openFileDialog1.FileNames.Length;i++)
            {
                AddUploadTask(openFileDialog1.FileNames[i], directoryPath1.CurrentFullPath);
            }
        }



        private void tfUpload_TransferItemDeleted(object sender, int index, bool removeLocalFile)
        {
            dtUpload.Rows.RemoveAt(index);
            FileList.DeleteUploadTask(tfUpload[index].FileID);
        }

        private void tfUpload_TransferItemCompleted(object sender, string fileID)
        {
            TransferFileItem t = (TransferFileItem)sender;
            if(t.Category != TransferFileItem.TransferCategory.CloudreveTransfer)
            {
                File.Delete(t.FilePathFrom);
            }

            if (!FileList.UpdateUploadStatus(fileID, ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task)))
            {
                ExMessageBox.Show("上传完成，更新状态失败!", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            RefreshStorage();
        }

        private void btnPauseAllUploadTask_Click(object sender, EventArgs e)
        {
            if (ExMessageBox.Show("您确定要暂停全部的上传么？\r\n本次下载不支持断点续传，\r\n下次上传将从头开始上传。", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                for (int i = 0; i < tfUpload.ItemCount(TransferFileItem.Status.所有状态); i++)
                {
                    if (tfUpload[i].CurrentStatus == TransferFileItem.Status.正在传输)
                    {
                        tfUpload[i].CurrentStatus = TransferFileItem.Status.暂停;
                    }
                }
            }
        }

        private void btnStartAllUploadTask_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tfUpload.ItemCount(TransferFileItem.Status.所有状态); i++)
            {
                if (tfUpload[i].CurrentStatus == TransferFileItem.Status.暂停)
                {
                    tfUpload[i].CurrentStatus = TransferFileItem.Status.正在传输;
                }
            }
        }

        private void btnDeleteAllUploadTask_Click(object sender, EventArgs e)
        {
            MessageBox msg = new MessageBox("您确定要清空上传列表么？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, true, true, "同时删除本地文件");
            if (msg.ShowDialog() == DialogResult.Yes)
            {
                tfUpload.Clear(msg.Checked);
            }
        }

        #endregion

        #region Share List Panel

        private void RefreshShareFileList()
        {
            sfList.Clear();

            int returnCode;
            string returnMsg;
            List<GetShareFileJson.ItemsItem> items = FileList.GetShareFileList(out returnCode, out returnMsg);
            if(returnCode == 0)
            {
                int dirCount = 0, fileCount = 0;
                for (int i = 0; i < items.Count; i++)
                {
                    ShareFileItem sfi = new ShareFileItem(items[i].key,
                                                          items[i].source.name,
                                                          Convert.ToBoolean(items[i].is_dir),
                                                          Convert.ToBoolean(items[i].is_dir) ? "" : CloudreveMiddleLayer.Helper.IO.FileInfo.GetSizeInShortFormat(items[i].source.size),
                                                          Convert.ToDateTime(items[i].create_date).ToString("yyyy-MM-dd HH:mm:ss"),
                                                          Convert.ToInt32(items[i].expire.ToString()),
                                                          items[i].password,
                                                          items[i].downloads,
                                                          items[i].remain_downloads,
                                                          items[i].views,
                                                          Convert.ToBoolean(items[i].preview),
                                                          items[i]
                                                          );
                    if(Convert.ToBoolean(items[i].is_dir))
                    {
                        dirCount++;
                    }
                    else
                    {
                        fileCount++;
                    }
                    sfi.ShareCancelClicked += Sfi_ShareCancelClicked;
                    sfi.ShareCannotPreviewClicked += Sfi_SharePreviewClicked;
                    sfi.ShareCanPreviewClicked += Sfi_SharePreviewClicked;
                    sfi.SharePrivateClicked += Sfi_SharePrivateClicked;
                    sfi.SharePublicClicked += Sfi_SharePublicClicked;
                    sfList.AddShareFile(sfi);
                }

                lblMyShareFileCount.Text = "本页共有 {0} 个分享（ {1} 个文件夹，{2} 个文件）";
                lblMyShareFileCount.Text = string.Format(lblMyShareFileCount.Text, items.Count.ToString().Trim(), dirCount.ToString().Trim(), fileCount.ToString().Trim());
            }
            else
            {
                ExMessageBox.Show("获取分享文件列表出错，错误信息如下：\r\n" + returnMsg, "出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Sfi_SharePublicClicked(object sender, ShareFileItem.ClickedEventArgs e)
        {
            //用户点击了设为公开分享
            ShareFileItem sfi = (ShareFileItem)sender;
            int returnCode;
            string returnMsg;
            StartWait();
            if (FileList.ShareSetPublicPrivate(sfi.FileID, "", out returnCode, out returnMsg))
            {
                RefreshShareFileList();
            }
            else
            {
                ExMessageBox.Show("设为公开分享出错，错误信息如下：\r\n" + returnMsg, "出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            EndWait();
        }

        private void Sfi_SharePrivateClicked(object sender, ShareFileItem.ClickedEventArgs e)
        {
            //用户点击了设为私密分享
            //用户点击了设为公开分享
            ShareFileItem sfi = (ShareFileItem)sender;
            string password = FileList.GenerateRandomSharePassword(5);
            int returnCode;
            string returnMsg;
            StartWait();
            if (FileList.ShareSetPublicPrivate(sfi.FileID, password, out returnCode, out returnMsg))
            {
                ExMessageBox.Show("设为私密分享成功，分享密码是： " + password, "成功！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshShareFileList();
            }
            else
            {
                ExMessageBox.Show("设为私密分享出错，错误信息如下：\r\n" + returnMsg, "出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            EndWait();
        }

        private void Sfi_SharePreviewClicked(object sender, ShareFileItem.ClickedEventArgs e)
        {
            //用户点击了设为（不）允许预览
            ShareFileItem sfi = (ShareFileItem)sender;
            int returnCode;
            string returnMsg;
            StartWait();
            if (FileList.ShareSetPreview(sfi.FileID, !sfi.AllowPreview, out returnCode, out returnMsg))
            {
                RefreshShareFileList();
            }
            else
            {
                ExMessageBox.Show("出错，错误信息如下：\r\n" + returnMsg, "出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            EndWait();
        }

        private void Sfi_ShareCancelClicked(object sender, ShareFileItem.ClickedEventArgs e)
        {
            //用户点击了取消分享
            ShareFileItem sfi = (ShareFileItem)sender;
            int returnCode;
            string returnMsg;
            StartWait();
            if (FileList.ShareSetCancel(sfi.FileID, out returnCode, out returnMsg))
            {
                RefreshShareFileList();
            }
            else
            {
                ExMessageBox.Show("取消分享出错，错误信息如下：\r\n" + returnMsg, "出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
            }
            EndWait();
        }

        private void btnRefreshShareFileList_Click(object sender, EventArgs e)
        {
            StartWait();

            RefreshShareFileList();

            EndWait();
        }


        private void btnDeleteAllShareFile_Click(object sender, EventArgs e)
        {
            if(ExMessageBox.Show("您确定要取消所有分享么？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)== DialogResult.Yes)
            {
                StartWait();
                for (int i=0;i<sfList.GetDataSource().Count; i++)
                {
                    ShareFileItem sfi = sfList.GetDataSource()[i];
                    int returnCode;
                    string returnMsg;
                    if (!FileList.ShareSetCancel(sfi.FileID, out returnCode, out returnMsg))
                    {
                        ExMessageBox.Show(sfi.FileName + "取消分享出错，错误信息如下：\r\n" + returnMsg, "出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                RefreshShareFileList();
                EndWait();
            }
        }

        #endregion

        #region File List Panel

        #region 文件列表

        private void RefreshFileList()
        {
            List<GetFileListJson.ObjectsItem> currentFileList = new List<GetFileListJson.ObjectsItem>();

            chkSelectAll.CheckState = CheckState.Unchecked;
            dtFileList.Clear();
            dtFileList.AcceptChanges();
            dgvFileList.DataSource = null;
            lblFileListFileCount.Text = "共有 {0} 个项目（ {1} 个文件夹，{2} 个文件）";

            switch (filterType.ToUpper())
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
                dr.ID = currentFileList[i].id;
                dr.Tick = false;
                dr.FileName = currentFileList[i].name.Trim();
                string ext = String.Empty;
                if (dr.FileName.Contains("."))
                {
                    ext = dr.FileName.Substring(dr.FileName.LastIndexOf('.') + 1).ToUpper();
                }
                dr.Path = currentFileList[i].path.Trim();
                dr.Thumb = currentFileList[i].thumb;
                dr.Size = currentFileList[i].size;
                if (dr.Size <= 0)
                {
                    dr.SizeDesc = "";
                }
                else
                {
                    dr.SizeDesc = CloudreveMiddleLayer.Helper.IO.FileInfo.GetSizeInShortFormat(dr.Size);
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
                                dr.IsImage = true;
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
            if (dgvFileList.Rows.Count > 0)
            {
                //默认选中第一条记录
                dgvFileList.CurrentCell = dgvFileList.Rows[0].Cells[0];
                dgvFileList.ClearSelection();
                dgvFileList.Rows[0].Selected = false;
                dgvFileList.CurrentCell = null;
            }

            lblFileListFileCount.Text = String.Format(lblFileListFileCount.Text, currentFileList.Count, dirCount, fileCount);
        }

        private void dgvFileList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StartWait();

            FileListDoubleClick();

            EndWait();
        }

        private void FileListDoubleClick()
        {
            if (dgvFileList.CurrentRow != null && dgvFileList.CurrentRow.Index >= 0)
            {
                DataView dv = (DataView)dgvFileList.DataSource;
                switch ((int)(dv[dgvFileList.CurrentRow.Index]["Type"]))
                {
                    case (int)Util.CloudreveFileListType.Dir:
                        StartWait();

                        OpenDirectory(dv[dgvFileList.CurrentRow.Index]["FileName"].ToString());

                        EndWait();
                        break;
                    case (int)Util.CloudreveFileListType.File:
                        if (ExMessageBox.Show("您是否想要将该文件加入下载任务列表？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            AddDownloadTaskToDataTableAndTransferFileControlAndDataBase(dv[dgvFileList.CurrentRow.Index]["ID"].ToString().Trim(),
                                                                                        dv[dgvFileList.CurrentRow.Index]["FileName"].ToString().Trim(),
                                                                                        dv[dgvFileList.CurrentRow.Index]["SizeDesc"].ToString().Trim(),
                                                                                        saveFileDialog1.FileName);
                        }
                        break;
                }
            }

            ShowScrollBar(directoryPath1.Handle, 3, 0);
            ShowScrollBar(panMiddleTopMiddle.Handle, 3, 0);
        }

        private void OpenDirectory(string dirName)
        {
            directoryPath1.AddPath(dirName);
            Application.DoEvents();
            RefreshFileList();
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileListDoubleClick();
        }

        private void 属性PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayFileDirectoryProperty();
        }

        private void DisplayFileDirectoryProperty()
        {
            DataRowView drv = dgvFileList.SelectedRows[0].DataBoundItem as DataRowView;
            int index = dtFileList.Rows.IndexOf(drv.Row);

            Int64 dirSize = 0;
            int subDirCount = 0, subFileCount = 0;
            string policy = String.Empty;
            if (FileList.GetDirectorySizeAndSubDirFileCount(dtFileList[index].ID, out dirSize, out subDirCount, out subFileCount, out policy, dtFileList[index].Type == (int)Util.CloudreveFileListType.Dir))
            {
                //如果是图片类型，并且自动显示缩略图
                if(dtFileList[index].IsImage && Convert.ToBoolean(SystemSetting.GetSettings(SystemSetting.SettingsName.点击图片文件时自动预览图片)))
                {
                    picDetail_FileTypeImage.Image = FileList.GetImageThumb(dtFileList[index].ID);
                }
                else
                {
                    picDetail_FileTypeImage.Image = ImageHelper.BytesToImage(dtFileList[index].TypeImage);
                }
                lblDetail_FileName.Text = dtFileList[index].FileName;

                switch (dtFileList[index].Type)
                {
                    case (int)Util.CloudreveFileListType.Dir:
                        lblDetail_Type.Text = "目录";
                        panDetail_DirFileCount.Visible = true;
                        lblDetail_Size.Text = CloudreveMiddleLayer.Helper.IO.FileInfo.GetSizeInShortFormat(dirSize) + " (" + dirSize + "字节)";
                        lblDetail_SubDirCount.Text = subDirCount.ToString();
                        lblDetail_SubFileCount.Text = subFileCount.ToString();
                        break;
                    case (int)Util.CloudreveFileListType.File:
                        lblDetail_Type.Text = "文件";
                        panDetail_DirFileCount.Visible = false;
                        lblDetail_Size.Text = dtFileList[index].SizeDesc + " (" +
                                              dtFileList[index].Size + "字节)";
                        lblDetail_StoragePolicy.Text = policy;
                        break;
                }
                lblDetail_CreateDate.Text = dtFileList[index].CreateDate;
                lblDetail_ModifyDate.Text = dtFileList[index].ModifyDate;

                panRightMenu.Visible = true;
                tabRightMenu.SelectedTab = tabDetail;
            }
            else
            {
                ExMessageBox.Show("获取属性失败，请稍后重试！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvFileList_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgvFileList.Rows[e.RowIndex].Selected = true;
                dgvFileList.CurrentCell = dgvFileList.Rows[e.RowIndex].Cells[e.ColumnIndex];

                DataView dv = (DataView)dgvFileList.DataSource;

                打开OToolStripMenuItem.Enabled = Convert.ToInt32(dv[e.RowIndex]["Type"]) == (int)Util.CloudreveFileListType.Dir;
                下载WToolStripMenuItem.Enabled = Convert.ToInt32(dv[e.RowIndex]["Type"]) == (int)Util.CloudreveFileListType.File;
                menuClickedFile.Show(MousePosition.X, MousePosition.Y);
            }
            else if(e.Button == MouseButtons.Left)
            {
                dgvFileList.Rows[e.RowIndex].Selected = true;
            }
            if (panRightMenu.Visible)
            {
                DisplayFileDirectoryProperty();
            }
        }

        #region Tick列操作代码

        private void dgvFileList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //判断是否点击的是Tick列
            if (dgvFileList.Columns[e.ColumnIndex].DataPropertyName.Equals("Tick") && e.RowIndex >= 0 && dgvFileList.SelectedRows.Count > 0)
            {
                dgvFileList.RefreshEdit();   //重要的是这句话，否则不会在界面上立刻生效
                //判断是否都全选了
                int selectedCount = 0;

                for (int i = 0; i < dgvFileList.Rows.Count; i++)
                {
                    bool ticked = Convert.ToBoolean(dgvFileList.Rows[i].Cells[e.ColumnIndex].Value);
                    if (ticked)
                    {
                        selectedCount++;
                    }
                }

                if (selectedCount == 0)
                {
                    chkSelectAll.CheckState = CheckState.Unchecked;
                }
                else if (selectedCount == dtFileList.Count)
                {
                    chkSelectAll.CheckState = CheckState.Checked;
                }
                else
                {
                    chkSelectAll.CheckState = CheckState.Indeterminate;
                }
            }
        }

        private void dgvFileList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //对Tick列操作时自动提交更改，方便触发CellValue事件检查数据有效性
            if (dgvFileList.IsCurrentCellDirty)
            {
                dgvFileList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void chkSelectAll_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkSelectAll.CheckState != CheckState.Indeterminate)
            {
                for (int i = 0; i < dtFileList.Count; i++)
                {
                    dtFileList[i].Tick = chkSelectAll.Checked;
                }
            }
        }

        #endregion

        #endregion

        #region Path

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!directoryPath1.CurrentFullPath.Equals("/"))
            {
                StartWait();

                directoryPath1.RemoveLastPath();
                RefreshFileList();

                EndWait();
            }
        }

        private void directoryPath1_PathItemClick(object sender, DirecrotyPathItemClickedArgs e)
        {
            StartWait();

            filterType = "ALL";
            RefreshFileList();

            EndWait();
        }

        #endregion

        #region 刷新

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            StartWait();

            RefreshFileList();

            EndWait();
        }

        #endregion

        #region 创建目录

        private void 创建目录DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateDir();
        }

        private void CreateDir()
        {
            ComponentControls.Forms.MessageBox msg = new ComponentControls.Forms.MessageBox("", "请输入要创建的目录名称", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, false, false);

            if (msg.ShowDialog() == DialogResult.OK)
            {
                StartWait();

                string dirFullPath = directoryPath1.CurrentFullPath;
                if (!dirFullPath.EndsWith("/"))
                {
                    dirFullPath += "/";
                }
                dirFullPath += msg.InputText;
                int returnCode;
                string returnMsg;
                if (FileList.CreateDirectory(dirFullPath, out returnCode, out returnMsg))
                {
                    directoryPath1.AddPath(msg.InputText);
                    RefreshFileList();
                }
                else
                {
                    ExMessageBox.Show("保存失败！错误信息如下：\r\n" + returnMsg, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                EndWait();
            }
        }

        private void btnCreateDir_Click(object sender, EventArgs e)
        {
            menuUpload.Show(MousePosition.X, MousePosition.Y);
        }

        #endregion

        #region 删除

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (chkSelectAll.CheckState == CheckState.Unchecked)
            {
                ExMessageBox.Show("请勾选要删除的文件/文件夹！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (ExMessageBox.Show("您确定要删除勾选的文件么？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                dtFileList.AcceptChanges();
                DataSetFileInfo.TBL_FileInfoRow[] rows = (DataSetFileInfo.TBL_FileInfoRow[])(dtFileList.Select("Tick=true"));
                List<string> fileNames = new List<string>();
                for (int i = 0; i < rows.Length; i++)
                {
                    fileNames.Add(Enum.GetName(typeof(Util.CloudreveFileListType), rows[i].Type).ToLower() + "_" + rows[i].ID);
                }

                StartWait();

                DeleteFile(fileNames);
                RefreshStorage();

                EndWait();
            }
        }

        private void DeleteFile(List<string> fileNames)
        {

            if (ExMessageBox.Show("您确定要删除所选中的文件/文件夹么？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.No)
            {
                return;
            }

            int returnCode;
            string returnMsg;
            if (FileList.DeleteFile(fileNames, out returnCode, out returnMsg))
            {
                RefreshFileList();
                RefreshStorage();
            }
            else
            {
                ExMessageBox.Show("删除失败，错误信息如下：\r\n" + returnMsg, "提醒", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void 删除DToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> fileNames = new List<string>();
            DataView dv = (DataView)dgvFileList.DataSource;
            fileNames.Add(Enum.GetName(typeof(Util.CloudreveFileListType), dv[dgvFileList.CurrentRow.Index]["Type"]).ToLower() + "_" + dv[dgvFileList.CurrentRow.Index]["ID"].ToString().Trim());

            StartWait();

            DeleteFile(fileNames);

            EndWait();
        }

        #endregion

        #region Sort Menu

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

        private void btnSort_Click(object sender, EventArgs e)
        {
            menuSort.Show(MousePosition.X, MousePosition.Y);
        }

        #endregion

        #region 重命名

        private void 重命名RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView drv = dgvFileList.SelectedRows[0].DataBoundItem as DataRowView;
            int index = dtFileList.Rows.IndexOf(drv.Row);
            string currentFileName = dtFileList[index].FileName;
            ComponentControls.Forms.MessageBox m = new ComponentControls.Forms.MessageBox(currentFileName, "请在下方输入框输入新名称", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, false, false);
            int returnCode = -1;
            string returnMsg = String.Empty;
            if(m.ShowDialog() == DialogResult.OK)
            {
                StartWait();

                if (!FileList.RenameFile(dtFileList[index].ID, m.InputText, 
                                         dtFileList[index].Type == (int)Util.CloudreveFileListType.Dir ? false : true ,
                                         out returnCode, out returnMsg))
                {
                    ExMessageBox.Show("删除文件出错！错误信息如下：\r\n" + returnMsg, "出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    RefreshFileList();
                }

                EndWait();
            }
        }

        #endregion

        #region 分享

        private void 分享SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataRowView drv = dgvFileList.SelectedRows[0].DataBoundItem as DataRowView;
            int index = dtFileList.Rows.IndexOf(drv.Row);
            bool isDir = dtFileList[index].Type == (int)Util.CloudreveFileListType.Dir;

            Share s = new Share(dtFileList[index].ID, isDir);
            if(s.ShowDialog() == DialogResult.OK)
            {
                int returnCode = -1;
                string returnMsg = String.Empty;

                StartWait();

                if (!FileList.CreateShareFile(s.Json, out returnCode, out returnMsg))
                {
                    ExMessageBox.Show("分享文件出错！错误信息如下：\r\n" + returnMsg, "出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ExMessageBox.Show(returnMsg, "请复制下方链接发送给您朋友：", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                EndWait();
            }
        }

        #endregion

        #endregion

        #region Left Menu

        private void btnShowLeftMenu_Click(object sender, EventArgs e)
        {
            panLeftMenu.Visible = !panLeftMenu.Visible;
        }

        private void InitialLeftMenu()
        {
            List<NavigateMenuItem> items = new List<NavigateMenuItem>();

            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.myfile, "我的文件"));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.home, "主目录", 0, true));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.video, "视频", 0));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.image, "图片", 0));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.music, "音乐", 0));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.document, "文档", 0));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.addTag, "添加标签", 0));

            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.share, "我的分享"));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.download, "下载任务"));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.upload1, "上传任务"));

            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.synchronous, "网盘迁移"));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.baidupan, "百度网盘迁入", 10));

            menuLeft.BindDataSource(items, true);
        }


        private void menuLeft_MenuItemClick(object sender, NavigateMenuItemClickedArgs e)
        {
            StartWait();

            directoryPath1.ClearAllPath();
            directoryPath1.AddPath("/");

            DisplayMiddlePanleContent(DisplayPanel.FileList);

            switch (e.MenuItemID)
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
                    filterType = "Doc";
                    break;
                case 7:
                    //我的分享
                    ShowScrollBar(sfList.Handle, 1, 1);
                    StartWait();
                    DisplayMiddlePanleContent(DisplayPanel.MyShare);
                    RefreshShareFileList();
                    EndWait();
                    break;
                case 8:
                    DisplayMiddlePanleContent(DisplayPanel.Download);
                    break;
                case 9:
                    DisplayMiddlePanleContent(DisplayPanel.Upload);
                    break;
                case 11:
                    DisplayMiddlePanleContent(DisplayPanel.SynchronousBaidu);
                    panBaiduFileList.Dock = DockStyle.Fill;
                    panBaiduLogin.Dock = DockStyle.Fill;
                    ws = WebBrowserStatus.Login;
                    if (Util.BAIDUPAN_TOKEN.Equals(String.Empty))
                    {
                        panBaiduFileList.Visible = false;
                        panBaiduLogin.Visible = true;
                        wbBaiduLogin.Url = new Uri(FileListBaidu.LoginURL);
                    }
                    else
                    {
                        panBaiduFileList.Visible = true;
                        panBaiduLogin.Visible = false;
                    }
                    break;
            }
            RefreshFileList();

            EndWait();
        }


        private void RefreshStorage()
        {
            int returnCode;
            string returnMsg;
            StorageInfo s = SystemEnvironment.GetStorageInfo(out returnCode, out returnMsg);
            if (returnCode != 0)
            {
                ExMessageBox.Show("获取存储空间信息失败！\r\n错误信息如下：\r\n" + returnMsg, "出错", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                prgStorage.Maximum = Convert.ToInt32(s.TotalSpace * 100);
                prgStorage.Minimum = 0;
                prgStorage.Value = Convert.ToInt32(s.UsedSpace * 100);

                lblStorage.Text = String.Format("{0} / {1}", s.UsedSpace.ToString() + " " + s.UnitName, s.TotalSpace.ToString() + " " + s.UnitName);
            }
        }

        #endregion

        #region Right Menu

        private void btnShowProfile_Click(object sender, EventArgs e)
        {
            panRightMenu.Visible = !panRightMenu.Visible;
        }

        #endregion

        #region 等待图标

        private void StartWait()
        {
            panTop.Enabled = false;
            panLeftMenu.Enabled = false;
            panStorageInfo.Enabled = false;
            panFileListTop.Enabled = false;
            panRightMenu.Enabled = false;
            lblWait.Visible = true;
            lblWait.BringToFront();
            Application.DoEvents();
        }

        private void btnCloseDetail_Click(object sender, EventArgs e)
        {
            this.panRightMenu.Visible = false;
        }

        private void EndWait()
        {
            lblWait.Visible = false;
            lblWait.Image = null;
            panTop.Enabled = true;
            panLeftMenu.Enabled = true;
            panStorageInfo.Enabled = true;
            panFileListTop.Enabled = true;
            panRightMenu.Enabled = true;
        }

        private void StartBaiduWait()
        {
            panTop.Enabled = false;
            panLeftMenu.Enabled = false;
            panStorageInfo.Enabled = false;
            panFileListTop.Enabled = false;
            panRightMenu.Enabled = false;
            lblWaitBaidu.Visible = true;
            lblWaitBaidu.BringToFront();
            Application.DoEvents();
        }

        private void EndBaiduWait()
        {
            lblWaitBaidu.Visible = false;
            lblWaitBaidu.Image = null;
            panTop.Enabled = true;
            panLeftMenu.Enabled = true;
            panStorageInfo.Enabled = true;
            panFileListTop.Enabled = true;
            panRightMenu.Enabled = true;
        }

        #endregion

        #region 百度网盘相关

        private void wbBaiduLogin_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            switch(ws)
            {
                case WebBrowserStatus.Login:
                    string token = HttpClientHelper.GetUrlParameterValue(wbBaiduLogin.Url.AbsoluteUri, "access_token");
                    if (!String.IsNullOrEmpty(token))
                    {
                        FileListBaidu.Token = token;
                        panBaiduLogin.Visible = false;
                        panBaiduFileList.Visible = true;
                        RefreshBaiduFileList();
                    }
                    break;
                case WebBrowserStatus.Logout:
                    FileListBaidu.Token = null;
                    panBaiduLogin.Visible = true;
                    panBaiduFileList.Visible = false;
                    break;
            }
        }

        #region Baidu File List

        private void RefreshBaiduFileList()
        {
            List<GetBaiduFileListJson.ListItem> currentFileList = new List<GetBaiduFileListJson.ListItem>();

            chkBaiduSelectAll.CheckState = CheckState.Unchecked;
            dtBaiduFileList.Clear();
            dtBaiduFileList.AcceptChanges();
            dgvBaiduFileList.DataSource = null;
            lblBaiduFileListFileCount.Text = "共有 {0} 个项目（ {1} 个文件夹，{2} 个文件）";

            currentFileList = FileListBaidu.GetFileList(directoryPathBaidu.CurrentFullPath);

            int dirCount = 0, fileCount = 0;

            if(currentFileList != null)
            {
                for (int i = 0; i < currentFileList.Count; i++)
                {
                    DataSetFileInfo.TBL_FileInfoRow dr = dtBaiduFileList.NewTBL_FileInfoRow();
                    dr.ID = currentFileList[i].fs_id.ToString();
                    dr.Tick = false;
                    dr.FileName = currentFileList[i].server_filename.Trim();
                    string ext = String.Empty;
                    if (dr.FileName.Contains("."))
                    {
                        ext = dr.FileName.Substring(dr.FileName.LastIndexOf('.') + 1).ToUpper();
                    }
                    dr.Path = currentFileList[i].path.Trim();
                    //dr.Thumb = currentFileList[i].thumb;
                    dr.Size = currentFileList[i].size;
                    if (dr.Size <= 0)
                    {
                        dr.SizeDesc = "";
                    }
                    else
                    {
                        dr.SizeDesc = CloudreveMiddleLayer.Helper.IO.FileInfo.GetSizeInShortFormat(dr.Size);
                    }
                    switch (currentFileList[i].isdir)
                    {
                        case 1:  //Dir
                            dirCount++;
                            dr.Type = (int)Util.CloudreveFileListType.Dir;
                            dr.TypeImage = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.dir);
                            break;
                        case 0:  //File
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
                                    dr.IsImage = true;
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
                    dr.ModifyDate = FileListBaidu.ConvertTimeStampToDateTime(currentFileList[i].server_mtime).ToString("yyyy-MM-dd HH:mm:ss");
                    dr.CreateDate = FileListBaidu.ConvertTimeStampToDateTime(currentFileList[i].server_ctime).ToString("yyyy-MM-dd HH:mm:ss");
                    //dr.SourceEnabled = Convert.ToBoolean(currentFileList[i].source_enabled);
                    dtBaiduFileList.AddTBL_FileInfoRow(dr);
                }
            }

            DataView dv = dtBaiduFileList.DefaultView;
            dv.AllowEdit = true;
            dv.AllowNew = false;
            dv.AllowDelete = false;
            dv.Sort = sortString;
            dgvBaiduFileList.AutoGenerateColumns = false;
            dgvBaiduFileList.DataSource = dv;
            if (dgvBaiduFileList.Rows.Count > 0)
            {
                //默认选中第一条记录
                dgvBaiduFileList.CurrentCell = dgvFileList.Rows[0].Cells[0];
                dgvBaiduFileList.ClearSelection();
                dgvBaiduFileList.Rows[0].Selected = false;
                dgvBaiduFileList.CurrentCell = null;
            }

            lblBaiduFileListFileCount.Text = String.Format(lblBaiduFileListFileCount.Text, currentFileList.Count, dirCount, fileCount);
        }

        private void dgvBaiduFileList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            StartBaiduWait();

            BaiduFileListDoubleClick();

            EndBaiduWait();
        }

        private void BaiduFileListDoubleClick()
        {
            if (dgvBaiduFileList.CurrentRow != null && dgvBaiduFileList.CurrentRow.Index >= 0)
            {
                DataView dv = (DataView)dgvBaiduFileList.DataSource;
                switch ((int)(dv[dgvBaiduFileList.CurrentRow.Index]["Type"]))
                {
                    case (int)Util.CloudreveFileListType.Dir:
                        StartBaiduWait();

                        OpenBaiduDirectory(dv[dgvBaiduFileList.CurrentRow.Index]["FileName"].ToString());

                        EndBaiduWait();
                        break;
                    case (int)Util.CloudreveFileListType.File:
                        //if (ExMessageBox.Show("您是否想要将该文件加入下载任务列表？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        //{
                        //    AddDownloadTaskToDataTableAndTransferFileControlAndDataBase(dv[dgvFileList.CurrentRow.Index]["ID"].ToString().Trim(),
                        //                                                                dv[dgvFileList.CurrentRow.Index]["FileName"].ToString().Trim(),
                        //                                                                dv[dgvFileList.CurrentRow.Index]["SizeDesc"].ToString().Trim(),
                        //                                                                saveFileDialog1.FileName);
                        //}
                        break;
                }
            }

            ShowScrollBar(directoryPathBaidu.Handle, 3, 0);
            ShowScrollBar(panMiddleTopMiddle.Handle, 3, 0);
        }

        private void directoryPathBaidu_PathItemClick(object sender, DirecrotyPathItemClickedArgs e)
        {
            StartBaiduWait();

            RefreshBaiduFileList();

            EndBaiduWait();
        }

        private void btnBaiduBack_Click(object sender, EventArgs e)
        {
            if (!directoryPathBaidu.CurrentFullPath.Equals("/"))
            {
                StartBaiduWait();

                directoryPathBaidu.RemoveLastPath();
                RefreshBaiduFileList();

                EndBaiduWait();
            }
        }

        private void btnBaiduLogout_Click(object sender, EventArgs e)
        {
            panBaiduLogin.Visible = true;
            panBaiduFileList.Visible = false;
            wbBaiduLogin.Url = new Uri( "https://pan.baidu.com");
            ws = WebBrowserStatus.Logout;
        }

        private void btnSaveToCloudreve_Click(object sender, EventArgs e)
        {
            //先添加下载任务（从百度云盘上将文件下载下来），保存在本地缓存目录
            //再添加上传任务（将缓存目录里的文件上传到Cloudreve服务器）

            //从文件列表中选择文件（允许多选）之后，点击下载按钮进行多文件下载

            dtBaiduFileList.AcceptChanges();
            DataSetFileInfo.TBL_FileInfoRow[] rows = (DataSetFileInfo.TBL_FileInfoRow[])dtBaiduFileList.Select("Tick=true");
            if (rows == null || rows.Length == 0)
            {
                ExMessageBox.Show("请选择要转存至Cloudreve服务器的文件！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string cachePath = Util.ApplicationPath + String.Format(Util.CACHE_FOLDER, DateTime.Now.ToString("yyyyMMddHHmmss"));
                if (!Directory.Exists(cachePath))
                {
                    Directory.CreateDirectory(cachePath);
                }
                SelectPathDialog s = new SelectPathDialog("请选择要保存到Cloudreve服务器的路径", MessageBoxDefaultButton.Button2);
                if (s.ShowDialog() == DialogResult.OK)
                {
                    string selectedCloudrevePath = s.SelectedPath, selectedCloudrevePathID = s.SelectedPathID;

                    //判断要下载的文件是否已经存在于下载列表里
                    //如果存在，则提示用户。
                    //如果不在，则添加到下载列表里，并启动下载。
                    bool hasNewDownload = false;

                    for (int i = 0; i < rows.Count(); i++)
                    {
                        if (rows[i].Type == (int)Util.CloudreveFileListType.Dir)
                        {
                            ExMessageBox.Show("暂不支持下载文件夹。\r\n该文件夹内的文件将不被下载。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }
                        if (dtDownload.Select("FileID = '" + rows[i].ID + "'").Length > 0)
                        {
                            ExMessageBox.Show("文件“" + rows[i].FileName + "”已经存在于下载任务列表。\r\n将取消将此文件加入下载列表。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }
                        List<GetBaiduFileDetailInfoJson.ListItem> detail = FileListBaidu.GetFileInfo(Convert.ToInt64(rows[i].ID));
                        if (detail != null)
                        {
                            AddDownloadTaskToDataTableAndTransferFileControlAndDataBase(rows[i].ID,
                                                                                        rows[i].FileName,
                                                                                        rows[i].SizeDesc,
                                                                                        cachePath + rows[i].FileName,
                                                                                        true,
                                                                                        true,
                                                                                        detail[0].dlink,
                                                                                        TransferFileItem.TransferCategory.BaiduPanTransfer,
                                                                                        selectedCloudrevePath);

                            hasNewDownload = true;
                        }
                    }

                    if (hasNewDownload)
                    {
                        dtDownload.AcceptChanges();

                        ExMessageBox.Show("已添加到下载列表，请在下载列表中查看！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnBaiduDelete_Click(object sender, EventArgs e)
        {
            if (chkBaiduSelectAll.CheckState == CheckState.Unchecked)
            {
                ExMessageBox.Show("请勾选要删除的文件/文件夹！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(ExMessageBox.Show("您确定要删除勾选的文件/文件夹么？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                dtBaiduFileList.AcceptChanges();
                DataSetFileInfo.TBL_FileInfoRow[] rows = (DataSetFileInfo.TBL_FileInfoRow[])(dtBaiduFileList.Select("Tick=true"));
                StartBaiduWait();

                for (int i = 0; i < rows.Length; i++)
                {
                    FileListBaidu.DeleteFile(directoryPathBaidu.CurrentFullPath + "/" + rows[i].FileName);
                }

                RefreshBaiduFileList();

                EndBaiduWait();
            }
        }

        private void OpenBaiduDirectory(string dirName)
        {
            directoryPathBaidu.AddPath(dirName);
            Application.DoEvents();
            RefreshBaiduFileList();
        }

        #region Tick列操作代码

        private void dgvBaiduFileList_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //判断是否点击的是Tick列
            if (dgvBaiduFileList.Columns[e.ColumnIndex].DataPropertyName.Equals("Tick") && e.RowIndex >= 0 && dgvBaiduFileList.SelectedRows.Count > 0)
            {
                dgvBaiduFileList.RefreshEdit();   //重要的是这句话，否则不会在界面上立刻生效
                //判断是否都全选了
                int selectedCount = 0;

                for (int i = 0; i < dgvBaiduFileList.Rows.Count; i++)
                {
                    bool ticked = Convert.ToBoolean(dgvBaiduFileList.Rows[i].Cells[e.ColumnIndex].Value);
                    if (ticked)
                    {
                        selectedCount++;
                    }
                }

                if (selectedCount == 0)
                {
                    chkBaiduSelectAll.CheckState = CheckState.Unchecked;
                }
                else if (selectedCount == dtBaiduFileList.Count)
                {
                    chkBaiduSelectAll.CheckState = CheckState.Checked;
                }
                else
                {
                    chkBaiduSelectAll.CheckState = CheckState.Indeterminate;
                }
            }
        }

        private void dgvBaiduFileList_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            //对Tick列操作时自动提交更改，方便触发CellValue事件检查数据有效性
            if (dgvBaiduFileList.IsCurrentCellDirty)
            {
                dgvBaiduFileList.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void chkBaiduSelectAll_CheckStateChanged(object sender, EventArgs e)
        {
            if (chkBaiduSelectAll.CheckState != CheckState.Indeterminate)
            {
                for (int i = 0; i < dtBaiduFileList.Count; i++)
                {
                    dtBaiduFileList[i].Tick = chkBaiduSelectAll.Checked;
                }
            }
        }

        #endregion

        #endregion

        #endregion
    }
}
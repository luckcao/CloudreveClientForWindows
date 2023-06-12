using CloudreveMiddleLayer;
using CloudreveMiddleLayer.DataSet;
using CloudreveMiddleLayer.Entiry;
using CloudreveMiddleLayer.JsonEntiryClass;
using ComponentControls.Controls;
using ComponentControls.Forms;
using ComponentControls.Helper.IO;
using ComponentControls.Helper.Media;
using ComponentControls.Helper.String;
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

namespace CloudreveForWindows.Forms
{
    public partial class Main : Form
    {
        string filterType = "all", sortString = "";
        //string downloadDBFile = Util.GetApplicationPath() + "DownloadTask.config";
        List<GetFileListJson.ObjectsItem> currentFileList = new List<GetFileListJson.ObjectsItem>();
        DataSetFileInfo.TBL_FileInfoDataTable dtFileList = new DataSetFileInfo.TBL_FileInfoDataTable();
        DataSetDownloadUpload.TBL_DownloadInfoDataTable dtDownload = new DataSetDownloadUpload.TBL_DownloadInfoDataTable();
        List<ToolStripMenuItem> sortMenu = new List<ToolStripMenuItem>();
        List<string> needDeleteFileID = new List<string>();

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int ShowScrollBar(IntPtr hWnd, int bar, int show);

        public Main()
        {
            InitializeComponent();
        }

        #region Form Events

        private void Main_Load(object sender, EventArgs e)
        {
            StartWait();

            directoryPath1.AddPath("/");
            InitialSortMenu();
            InitialFileTypeIconImageList();
            InitialLeftMenu();
            RefreshFileList();
            RefreshStorage();
            InitialDownloadTask();

            EndWait();
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
                    if (!dtDownload[i].DownloadStatus.SequenceEqual(ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task)))
                    {
                        dtDownload[i].DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task);
                    }
                }
            }

            RefreshDownloadDataGridView();
        }

        private void RefreshDownloadDataGridView()
        {
            DataView dv = dtDownload.DefaultView;
            dv.AllowDelete = false;
            dv.AllowEdit = false;
            dv.AllowNew = false;
            dgvDownload.AutoGenerateColumns = false;
            dgvDownload.DataSource = dv;
            if (dgvDownload.Rows.Count > 0)
            {
                //默认选中第一条记录
                dgvDownload.CurrentCell = dgvDownload.Rows[0].Cells[0];
                dgvDownload.CurrentCell = null;
                dgvDownload.Rows[0].Selected = false;
                dgvDownload.ClearSelection();
            }
        }

        private void 下载WToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDownloadTask();
        }

        private void AddDownloadTask()
        {
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
                    DataSetDownloadUpload.TBL_DownloadInfoRow newRow = dtDownload.NewTBL_DownloadInfoRow();
                    newRow.FileID = dv[dgvFileList.CurrentRow.Index]["ID"].ToString().Trim();
                    newRow.FileName = dv[dgvFileList.CurrentRow.Index]["FileName"].ToString().Trim();
                    newRow.FileSizeDesc = dv[dgvFileList.CurrentRow.Index]["SizeDesc"].ToString().Trim();
                    newRow.DownloadPercent = 0;
                    newRow.DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task);
                    newRow.FilePathFrom = "";
                    newRow.DownloadFilePath = saveFileDialog1.FileName;
                    newRow.OpenFolderDesc = "打开下载目录";
                    newRow.DeleteDesc = "删除";

                    dtDownload.AddTBL_DownloadInfoRow(newRow);

                    dtDownload.AcceptChanges();
                    dgvDownload.Refresh();
                    //RefreshDownloadDataGridView();
                    AddDownloadFile(newRow);

                    ExMessageBox.Show("已添加到下载列表，请手动启动下载任务！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void StartDownload()
        {
            DataRowView drv = dgvDownload.SelectedRows[0].DataBoundItem as DataRowView;
            int index = dtDownload.Rows.IndexOf(drv.Row);
            int returnCode;
            string returnMessage;
            if (FileList.DownloadFile(dtDownload[index], out returnCode, out returnMessage))
            {
                //下载成功
                dtDownload[index].DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task);
                if(!FileList.UpdateDownloadStatus(dtDownload[index].FileID, ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task)))
                {
                    //ExMessageBox.Show("保存下载状态到数据库失败！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (Util.Paused_Download_Task.Contains(dtDownload[index].FileID))
                {
                    //说明用户点了暂停，判断是否需要删除该任务
                    if(!needDeleteFileID.Contains(dtDownload[index].FileID))
                    {
                        dtDownload[index].DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task);
                    }
                    else
                    {
                        if(FileList.DeleteDownloadTask(dtDownload[index].FileID, dtDownload[index].DownloadFilePath, true))
                        {
                            needDeleteFileID.Remove(dtDownload[index].FileID);
                            dtDownload.Rows.Remove(dtDownload[index]);
                            dtDownload.AcceptChanges();
                            this.Invoke((MethodInvoker)delegate ()
                            {
                                try
                                {
                                    dgvDownload.Refresh();
                                }
                                catch
                                { }
                            });
                        }
                    }
                    //dgvDownload.Refresh();
                }
                else
                {
                    //说明出错了，提示错误信息
                    //ExMessageBox.Show("下载出错。错误信息如下：\r\n" + returnMessage, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dtDownload[index].DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task);
                    //dgvDownload.Refresh();
                }
            }
        }

        private void T_Tick(object sender, EventArgs e)
        {
            //RefreshDownloadDataGridView();
            dgvDownload.Refresh();
            System.Windows.Forms.Timer t = (System.Windows.Forms.Timer)sender;
            t.Enabled = false;
        }

        private void dgvDownload_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            ExMessageBox.Show("有错误发生。错误信息如下：\r\n" + e.Exception.Message + "\r\n" + e.Exception.StackTrace, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void AddDownloadFile(DataSetDownloadUpload.TBL_DownloadInfoRow dr)
        {
            if (!FileList.AddDownloadTask(dr))
            {
                ExMessageBox.Show("添加下载任务到数据库失败！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvDownload_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDownload.CurrentRow != null && e.RowIndex >= 0)
            {
                byte[] currentImg = dtDownload[e.RowIndex].DownloadStatus;
                byte[] pauseTaskImg = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.pause_task);

                if (dgvDownload.Columns[e.ColumnIndex].DataPropertyName.Equals(dtDownload.DownloadStatusColumn.ColumnName))
                {
                    //点的是"下载"状态图片
                    byte[] startTaskImg = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task);
                    if (currentImg.SequenceEqual(startTaskImg))
                    {
                        //开始下载
                        dtDownload[e.RowIndex].DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.pause_task);
                        Util.Paused_Download_Task.Remove(dtDownload[e.RowIndex].FileID);
                        Thread thread = new Thread(new ThreadStart(StartDownload));
                        thread.Start();
                    }
                    else if (currentImg.SequenceEqual(pauseTaskImg))  
                    {
                        //暂停下载
                        if (ExMessageBox.Show("您确定要停止下载么？\r\n此次下载不支持断点续传，您下次下载时，将从新下载该文件。", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            Util.Paused_Download_Task.Add(dtDownload[e.RowIndex].FileID);
                        }
                    }
                }
                else if (dgvDownload.Columns[e.ColumnIndex].DataPropertyName.Equals(dtDownload.OpenFolderDescColumn.ColumnName))
                {
                    DirectoryInfo dir = new DirectoryInfo(dtDownload[e.RowIndex].DownloadFilePath);
                    System.Diagnostics.Process.Start("Explorer.exe", dir.Parent.FullName);
                }
                else if (dgvDownload.Columns[e.ColumnIndex].DataPropertyName.Equals(dtDownload.DeleteDescColumn.ColumnName))
                {
                    //提示用户是否确定删除(如果状态为正在下载，也提示用户。)
                    if(ExMessageBox.Show("您确定要删除该任务么？\r\n删除已完成的任务并不会从磁盘中删除已下载的文件。\r\n但删除未完成的任务会从磁盘中删除。", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
                    {
                        if(currentImg.SequenceEqual(pauseTaskImg))
                        {
                            //说明正在下载
                            Util.Paused_Download_Task.Add(dtDownload[e.RowIndex].FileID);
                            needDeleteFileID.Add(dtDownload[e.RowIndex].FileID);
                        }
                        else
                        {
                            if(FileList.DeleteDownloadTask(dtDownload[e.RowIndex].FileID, dtDownload[e.RowIndex].DownloadFilePath, true))
                            {
                                if(needDeleteFileID.Count != 0 && needDeleteFileID.Contains(dtDownload[e.RowIndex].FileID))
                                {
                                    needDeleteFileID.Remove(dtDownload[e.RowIndex].FileID);
                                }
                                dtDownload.Rows.Remove(dtDownload[e.RowIndex]);
                                dtDownload.AcceptChanges();
                                dgvDownload.Refresh();
                            }
                        }
                    }
                }
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            dtFileList.AcceptChanges();
            DataSetFileInfo.TBL_FileInfoRow[] rows = (DataSetFileInfo.TBL_FileInfoRow[])dtFileList.Select("Tick=true");
            if (rows == null || rows.Length ==0)
            {
                ExMessageBox.Show("请选择要下载的文件！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {
                    string selectedPath = folderBrowserDialog1.SelectedPath;
                    if(!selectedPath.EndsWith(@"\"))
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
                        if(rows[i].Type == (int)Util.CloudreveFileListType.Dir)
                        {
                            ExMessageBox.Show("暂不支持下载文件夹。\r\n该文件夹内的文件将不被下载。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }
                        if (dtDownload.Select("FileID = '" + rows[i].ID + "'").Length > 0)
                        {
                            ExMessageBox.Show("文件“" + rows[i].FileName + "”已经存在于下载任务列表。\r\n将取消将此文件加入下载列表。", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            continue;
                        }
                        DataSetDownloadUpload.TBL_DownloadInfoRow newRow = dtDownload.NewTBL_DownloadInfoRow();
                        newRow.FileID = rows[i].ID;
                        newRow.FileName = rows[i].FileName;
                        newRow.FileSizeDesc = rows[i].SizeDesc;
                        newRow.DownloadPercent = 0;
                        newRow.DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task);
                        newRow.FilePathFrom = "";
                        newRow.DownloadFilePath = selectedPath + rows[i].FileName;
                        newRow.OpenFolderDesc = "打开下载目录";
                        newRow.DeleteDesc = "删除";

                        dtDownload.AddTBL_DownloadInfoRow(newRow);
                        AddDownloadFile(newRow);
                        hasNewDownload = true;
                    }

                    if(hasNewDownload)
                    {
                        dtDownload.AcceptChanges();
                        dgvDownload.Refresh();
                        //RefreshDownloadDataGridView();

                        ExMessageBox.Show("添加到下载列表操作完成，请手动启动下载任务！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        #endregion

        #region File List Panel

        #region 文件列表

        private void InitialFileTypeIconImageList()
        {
            imglstFileTypeIcon.Images.AddRange(new System.Drawing.Image[]
            {
                global::CloudreveForWindows.Properties.Resources.dir

            });
        }

        private void RefreshFileList()
        {
            chkSelectAll.CheckState = CheckState.Unchecked;
            currentFileList.Clear();
            dtFileList.Clear();
            dtFileList.AcceptChanges();
            dgvFileList.DataSource = null;
            lblFileCount.Text = "共有 {0} 个项目（ {1} 个文件夹，{2} 个文件）";

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
                    dr.SizeDesc = ComponentControls.Helper.IO.FileInfo.GetSizeInShortFormat(dr.Size);
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
            if (dgvFileList.Rows.Count > 0)
            {
                //默认选中第一条记录
                dgvFileList.CurrentCell = dgvFileList.Rows[0].Cells[0];
                dgvFileList.ClearSelection();
                dgvFileList.Rows[0].Selected = false;
                dgvFileList.CurrentCell = null;
            }

            lblFileCount.Text = String.Format(lblFileCount.Text, currentFileList.Count, dirCount, fileCount);
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
                            AddDownloadTask();
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
            dtFileList.AcceptChanges();
            DataSetFileInfo.TBL_FileInfoRow[] rows = (DataSetFileInfo.TBL_FileInfoRow[])(dtFileList.Select("Tick=true"));
            List<string> fileNames = new List<string>();
            for (int i = 0; i < rows.Length; i++)
            {
                fileNames.Add(Enum.GetName(typeof(Util.CloudreveFileListType), rows[i].Type).ToLower() + "_" + rows[i].ID);
            }

            StartWait();

            DeleteFile(fileNames);

            EndWait();
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
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.home, "主目录", 0));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.video, "视频", 0));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.image, "图片", 0));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.music, "音乐", 0));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.document, "文档", 0));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.addTag, "添加标签", 0));

            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.share, "我的分享"));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.download, "离线下载"));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.task, "下载任务队列"));

            menuLeft.BindDataSource(items, true);
        }

        private void menuLeft_MenuItemClick(object sender, NavigateMenuItemClickedArgs e)
        {
            StartWait();

            directoryPath1.ClearAllPath();
            directoryPath1.AddPath("/");

            SwitchDataGrid(false);

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
                case 9:
                    SwitchDataGrid(true);
                    break;
            }
            RefreshFileList();

            EndWait();
        }

        private void SwitchDataGrid(bool showDownTask)
        {
            panMiddleTop.Visible = !showDownTask;
            panMiddleBottom.Visible = !showDownTask;
            dgvFileList.Visible = !showDownTask;
            dgvDownload.Visible = showDownTask;
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

                lblStorage.Text = String.Format(lblStorage.Text.Trim(), s.UsedSpace.ToString() + " " + s.UnitName, s.TotalSpace.ToString() + " " + s.UnitName);
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
            panLeftBottom.Enabled = false;
            panMiddleTop.Enabled = false;
            panRightMenu.Enabled = false;
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

        #endregion
    }
}
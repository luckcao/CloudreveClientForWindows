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
        enum DisplayPanel
        {
            FileList = 0,
            Download = 1,
            Upload = 2,
            MyShare = 3
        }

        private class ProgressBarInfo
        {
            public TransferFileProgressBar ProgressBar = null;
            public int Value;
            public string FileID = String.Empty;

            public ProgressBarInfo(TransferFileProgressBar progressBar, int value, string fileID)
            {
                this.ProgressBar = progressBar;
                this.Value = value;
                this.FileID = fileID;
            }
        }

        private class ThreadInfo
        {
            public Thread Thread = null;
            public int Index;
            public DataSetDownloadUpload.TBL_DownloadInfoRow Row = null;

            public ThreadInfo(Thread thread, int index, DataSetDownloadUpload.TBL_DownloadInfoRow row)
            {
                this.Thread = thread;
                this.Index = index;
                this.Row = row;
            }
        }

        string filterType = "all", sortString = "";
        //string downloadDBFile = Util.GetApplicationPath() + "DownloadTask.config";
        List<GetFileListJson.ObjectsItem> currentFileList = new List<GetFileListJson.ObjectsItem>();
        DataSetFileInfo.TBL_FileInfoDataTable dtFileList = new DataSetFileInfo.TBL_FileInfoDataTable();
        DataSetDownloadUpload.TBL_DownloadInfoDataTable dtDownload = new DataSetDownloadUpload.TBL_DownloadInfoDataTable();
        List<ToolStripMenuItem> sortMenu = new List<ToolStripMenuItem>();
        List<ProgressBarInfo> pbi = new List<ProgressBarInfo>();
        List<ThreadInfo> threadList = new List<ThreadInfo>();
        bool showMessageDeleteDownloadTaskForEachTask = true;

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

            panFileList.Dock = DockStyle.Fill;
            panDownload.Dock = DockStyle.Fill;
            panUpload.Dock = DockStyle.Fill;
            panMyShare.Dock = DockStyle.Fill;

            DisplayMiddlePanleContent(DisplayPanel.FileList);
            directoryPath1.AddPath("/");
            InitialSortMenu();
            InitialFileTypeIconImageList();
            InitialLeftMenu();
            RefreshFileList();
            RefreshStorage();
            InitialDownloadTask();
            InitialUploadTask();

            EndWait();
        }

        private void DisplayMiddlePanleContent(DisplayPanel dp)
        {
            switch(dp)
            {
                case DisplayPanel.FileList:
                    panFileList.Visible = true;
                    panDownload.Visible = false;
                    panUpload.Visible = false;
                    panMyShare.Visible = false;
                    break;
                case DisplayPanel.Download:
                    panFileList.Visible = false;
                    panDownload.Visible = true;
                    panUpload.Visible = false;
                    panMyShare.Visible = false;
                    break;
                case DisplayPanel.Upload:
                    panFileList.Visible = false;
                    panDownload.Visible = false;
                    panUpload.Visible = true;
                    panMyShare.Visible = false;
                    break;
                case DisplayPanel.MyShare:
                    panFileList.Visible = false;
                    panDownload.Visible = false;
                    panUpload.Visible = false;
                    panMyShare.Visible = true;
                    break;
            }
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
                    AddDownloadTaskToTransferFileControl(dtDownload[i]);
                }
            }
        }

        #region Add Download Task

        private void AddDownloadTaskToTransferFileControl(DataSetDownloadUpload.TBL_DownloadInfoRow dr, bool needAddToDB = false)
        {
            TransferFileItem tfi = new TransferFileItem(dr.FileID,
                                           dr.FileName,
                                           dr.DownloadFilePath,
                                           dr.FileSizeDesc,
                                           dr.DownloadStatus.SequenceEqual(ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task)) ? 100 : 0,
                                           dr);
            tfi.TransferItemStartClicked += Tfi_TransferItemStartClicked;
            tfi.TransferItemPauseClicked += Tfi_TransferItemPauseClicked;
            tfi.TransferItemDeleteClicked += Tfi_TransferItemDeleteClicked;
            tfi.ProgressBar.SetValue += ProgressBar_SetValue;
            pbi.Add(new ProgressBarInfo(tfi.ProgressBar, 0, dr.FileID));
            tfDownload.AddTransferFile(tfi);

            if (needAddToDB && !FileList.AddDownloadTask(dr))
            {
                ExMessageBox.Show("添加下载任务到数据库失败！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void AddDownloadTaskToDataTableAndTransferFileControlAndDataBase(string fileID,
                                                                                 string fileName,
                                                                                 string sizeDesc,
                                                                                 string downloadPath, 
                                                                                 bool needAddToDB = true)
        {
            DataSetDownloadUpload.TBL_DownloadInfoRow newRow = dtDownload.NewTBL_DownloadInfoRow();
            newRow.FileID = fileID;
            newRow.FileName = fileName;
            newRow.FileSizeDesc = sizeDesc;
            newRow.DownloadPercent = 0;
            newRow.DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task);
            newRow.FilePathFrom = "";
            newRow.DownloadFilePath = downloadPath;
            newRow.OpenFolderDesc = "打开下载目录";
            newRow.DeleteDesc = "删除";

            dtDownload.AddTBL_DownloadInfoRow(newRow);
            dtDownload.AcceptChanges();

            AddDownloadTaskToTransferFileControl(newRow, needAddToDB);
        }

        private void 下载WToolStripMenuItem_Click(object sender, EventArgs e)
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
                    AddDownloadTaskToDataTableAndTransferFileControlAndDataBase(dv[dgvFileList.CurrentRow.Index]["ID"].ToString().Trim(),
                                                                                dv[dgvFileList.CurrentRow.Index]["FileName"].ToString().Trim(),
                                                                                dv[dgvFileList.CurrentRow.Index]["SizeDesc"].ToString().Trim(),
                                                                                saveFileDialog1.FileName);
                    ExMessageBox.Show("已添加到下载列表，请手动启动下载任务！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
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
                                                                                    selectedPath + rows[i].FileName);

                        hasNewDownload = true;
                    }

                    if (hasNewDownload)
                    {
                        dtDownload.AcceptChanges();
                        //RefreshDownloadDataGridView();

                        ExMessageBox.Show("添加到下载列表操作完成，请手动启动下载任务！", "提醒", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        #endregion

        #region Update Download Percent Value

        private void ProgressBar_SetValue(object sender, int newValue, string fileID)
        {
            ProgressBarInfo p = pbi.Find(t => t.FileID == fileID);
            if (p != null)
            {
                p.Value = newValue;
            }
        }

        private void timerUpdateProgressBarValue_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < pbi.Count; i++)
            {
                pbi[i].ProgressBar.Value = pbi[i].Value;
                pbi[i].ProgressBar.Update();
            }
        }

        #endregion

        #region Start Download Task

        private void btnStartAllDownloadTask_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtDownload.Count; i++)
            {
                if (dtDownload[i].DownloadStatus.SequenceEqual(ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task)))
                {
                    tfDownload.GetDataSource()[i].TransferStart();
                }
            }
        }

        private void Tfi_TransferItemStartClicked(object sender, EventArgs e)
        {
            //点击了开始下载
            //开始下载
            DataSetDownloadUpload.TBL_DownloadInfoRow row = (DataSetDownloadUpload.TBL_DownloadInfoRow)(((TransferFileItem)sender).Tag);
            row.DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.pause_task);
            Util.Paused_Download_Task.Remove(row.FileID);
            Thread thread = new Thread(new ParameterizedThreadStart(StartOneFileDownload));
            thread.IsBackground = true;
            thread.Start(row);
            ThreadInfo t = new ThreadInfo(thread, threadList.Count, row);
            threadList.Add(t);
            timerUpdateProgressBarValue.Enabled = true;
        }

        #region Start Thread

        private void StartOneFileDownload(object obj)
        {
            int returnCode;
            DataSetDownloadUpload.TBL_DownloadInfoRow dr = (DataSetDownloadUpload.TBL_DownloadInfoRow)obj;
            string returnMessage;
            if (FileList.DownloadFile(dr, tfDownload.GetItems(dr.FileID).ProgressBar, out returnCode, out returnMessage))
            {
                //下载成功
                dr.DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task);
                try
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        try
                        {
                            tfDownload.GetItems(dr.FileID).TransferComplete();
                        }
                        catch
                        { }
                    });
                }
                catch (Exception ex)
                {

                }
                if (!FileList.UpdateDownloadStatus(dr.FileID, ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task)))
                {
                    //ExMessageBox.Show("保存下载状态到数据库失败！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (Util.Paused_Download_Task.Count == 0 || Util.Paused_Download_Task.Contains(dr.FileID))
                {
                    //说明用户点了暂停
                    dr.DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task);
                    try
                    {
                        this.Invoke((MethodInvoker)delegate ()
                        {
                            try
                            {
                                tfDownload.GetItems(dr.FileID).DownloadStatusImage = global::CloudreveForWindows.Properties.Resources.start_task;
                            }
                            catch
                            { }
                        });
                    }
                    catch (Exception ex)
                    {

                    }
                }
                else
                {
                    //说明出错了，提示错误信息
                    //ExMessageBox.Show("下载出错。错误信息如下：\r\n" + returnMessage, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dr.DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task);
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        try
                        {
                            tfDownload.GetItems(dr.FileID).DownloadStatusImage = global::CloudreveForWindows.Properties.Resources.start_task;
                        }
                        catch
                        { }
                    });
                    //dgvDownload.Refresh();
                }
            }
            dtDownload.AcceptChanges();
        }

        //private void StartOneFileDownload(object obj)
        //{
        //    int returnCode;
        //    DataSetDownloadUpload.TBL_DownloadInfoRow dr = (DataSetDownloadUpload.TBL_DownloadInfoRow)obj;
        //    string returnMessage;
        //    if (FileList.DownloadFile(dr, tfDownload.GetItems(dr.FileID).ProgressBar, out returnCode, out returnMessage))
        //    {
        //        //下载成功
        //        dr.DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task);
        //        try
        //        {
        //            this.Invoke((MethodInvoker)delegate ()
        //            {
        //                try
        //                {
        //                    tfDownload.GetItems(dr.FileID).TransferComplete();
        //                }
        //                catch
        //                { }
        //            });
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //        if (!FileList.UpdateDownloadStatus(dr.FileID, ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task)))
        //        {
        //            //ExMessageBox.Show("保存下载状态到数据库失败！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        if (Util.Paused_Download_Task.Count == 0 || Util.Paused_Download_Task.Contains(dr.FileID))
        //        {
        //            //说明用户点了暂停，判断是否需要删除该任务
        //            if (!needDeleteFileID.Contains(dr.FileID))
        //            {
        //                dr.DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task);
        //                try
        //                {
        //                    this.Invoke((MethodInvoker)delegate ()
        //                    {
        //                        try
        //                        {
        //                            tfDownload.GetItems(dr.FileID).DownloadStatusImage = global::CloudreveForWindows.Properties.Resources.start_task;
        //                        }
        //                        catch
        //                        { }
        //                    });
        //                }
        //                catch (Exception ex)
        //                {

        //                }
        //            }
        //            else if (FileList.DeleteDownloadTask(dr.FileID, dr.DownloadFilePath, true))
        //            {
        //                needDeleteFileID.Remove(dr.FileID);
        //                dtDownload.Rows.Remove(dr);
        //                dtDownload.AcceptChanges();
        //                try
        //                {
        //                    this.Invoke((MethodInvoker)delegate ()
        //                    {
        //                        try
        //                        {
        //                            tfDownload.RemoveTransferFile(dr.FileID);
        //                        }
        //                        catch
        //                        { }
        //                    });
        //                }
        //                catch (Exception ex)
        //                {

        //                }
        //            }
        //            //dgvDownload.Refresh();
        //        }
        //        else
        //        {
        //            //说明出错了，提示错误信息
        //            //ExMessageBox.Show("下载出错。错误信息如下：\r\n" + returnMessage, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            dr.DownloadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task);
        //            this.Invoke((MethodInvoker)delegate ()
        //            {
        //                try
        //                {
        //                    tfDownload.GetItems(dr.FileID).DownloadStatusImage = global::CloudreveForWindows.Properties.Resources.start_task;
        //                }
        //                catch
        //                { }
        //            });
        //            //dgvDownload.Refresh();
        //        }
        //    }
        //    dtDownload.AcceptChanges();
        //}

        #endregion

        #endregion

        #region Pause All Download Task

        private void btnPauseAllDownloadTask_Click(object sender, EventArgs e)
        {
            if (ExMessageBox.Show("您确定要取消全部的下载么？\r\n本次下载不支持断点续传，\r\n下次下载将从头开始下载。", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                for (int i = 0; i < dtDownload.Count; i++)
                {
                    if (dtDownload[i].DownloadStatus.SequenceEqual(ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.pause_task)))
                    {
                        if (Util.Paused_Download_Task.Count == 0 || !Util.Paused_Download_Task.Contains(dtDownload[i].FileID))
                        {
                            Util.Paused_Download_Task.Add(dtDownload[i].FileID);
                        }
                    }
                }
            }
        }

        private void Tfi_TransferItemPauseClicked(object sender, EventArgs e)
        {
            //点击了暂停下载
            TransferFileItem item = (TransferFileItem)sender;
            DataSetDownloadUpload.TBL_DownloadInfoRow row = (DataSetDownloadUpload.TBL_DownloadInfoRow)((item).Tag);
            if (ExMessageBox.Show("您确定要停止下载么？\r\n此次下载不支持断点续传，您下次下载时，将从新下载该文件。", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Util.Paused_Download_Task.Add(row.FileID);
            }
            else
            {
                item.TransferPause(false);
            }
        }

        #endregion

        #region Delete Download Task

        private void btnDeleteAllDownloadTask_Click(object sender, EventArgs e)
        {
            if (ExMessageBox.Show("您确定要清空下载列表么？\r\n清空后，下载完的文件不会从磁盘中删除，\r\n但未下载完的文件会从磁盘中删除。", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                showMessageDeleteDownloadTaskForEachTask = false;

                while (tfDownload.GetDataSource().Count > 0)
                {
                    tfDownload.GetDataSource()[0].TransferDelete();
                }

                showMessageDeleteDownloadTaskForEachTask = true;
            }
        }

        private void Tfi_TransferItemDeleteClicked(object sender, EventArgs e)
        {
            //点击了删除下载
            //提示用户是否确定删除(如果状态为正在下载，也提示用户。)
            TransferFileItem item = (TransferFileItem)sender;
            DataSetDownloadUpload.TBL_DownloadInfoRow row = (DataSetDownloadUpload.TBL_DownloadInfoRow)((item).Tag);
            if (!showMessageDeleteDownloadTaskForEachTask || ExMessageBox.Show("您确定要删除该任务么？\r\n删除已完成的任务并不会从磁盘中删除已下载的文件。\r\n但删除未完成的任务会从磁盘中删除。", "提醒", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                ThreadInfo tmp = threadList.Find(t => t.Row.FileID == row.FileID);
                if(tmp == null)
                {
                    tmp = new ThreadInfo(null, 0, row);
                }
                DeleteOneDownloadTask(tmp);
            }
        }


        private void DeleteOneDownloadTask(ThreadInfo t)
        {
            try
            {
                if (t.Thread != null && t.Row.DownloadStatus.SequenceEqual(ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.pause_task)))
                {
                    //说明正在下载
                    t.Thread.Abort();
                    while(t.Thread.ThreadState != ThreadState.Aborted)
                    {

                    }
                    threadList.Remove(t);
                }
                if (FileList.DeleteDownloadTask(t.Row.FileID, t.Row.DownloadFilePath, true))
                {
                    tfDownload.RemoveTransferFile(t.Row.FileID);
                    dtDownload.Rows.Remove(t.Row);
                    dtDownload.AcceptChanges();
                }
            }
            catch (Exception ex)
            {

            }
        }

        //private void DeleteOneDownloadTask(DataSetDownloadUpload.TBL_DownloadInfoRow dr, byte[] pauseTaskImg)
        //{
        //    try
        //    {
        //        if (dr.DownloadStatus.SequenceEqual(pauseTaskImg))
        //        {
        //            //说明正在下载
        //            needDeleteFileID.Add(dr.FileID);
        //            Util.Paused_Download_Task.Add(dr.FileID);
        //        }
        //        else
        //        {
        //            if (FileList.DeleteDownloadTask(dr.FileID, dr.DownloadFilePath, true))
        //            {
        //                if (needDeleteFileID.Count != 0 && needDeleteFileID.Contains(dr.FileID))
        //                {
        //                    needDeleteFileID.Remove(dr.FileID);
        //                }
        //                tfDownload.RemoveTransferFile(dr.FileID);
        //                dtDownload.Rows.Remove(dr);
        //                dtDownload.AcceptChanges();
        //            }
        //        }
        //    }
        //    catch(Exception ex)
        //    {

        //    }
        //}

        #endregion

        #endregion

        #region Upload

        private void InitialUploadTask()
        {
            DataSetDownloadUpload.TBL_UploadInfoDataTable dtUpload = new DataSetDownloadUpload.TBL_UploadInfoDataTable();
            if (FileList.GetUploadFileInfo(dtUpload))
            {
                for (int i = 0; i < dtUpload.Count; i++)
                {
                    //完成状态的图标不变，其余的变成start_task图标
                    if (!dtUpload[i].UploadStatus.SequenceEqual(ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task)))
                    {
                        dtUpload[i].UploadStatus = ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task);
                    }
                    AddUploadTaskToTransferFileControl(dtUpload[i]);
                }
            }
        }

        #region Add Upload Task

        private void AddUploadTaskToTransferFileControl(DataSetDownloadUpload.TBL_UploadInfoRow dr, bool needAddToDB = false)
        {
            TransferFileItem tfi = new TransferFileItem(dr.FileID,
                                           dr.FileName,
                                           dr.FilePathFrom,
                                           dr.UploadFilePath,
                                           dr.FileSizeDesc,
                                           dr.UploadStatus.SequenceEqual(ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task)) ? 100 : 0,
                                           dr);
            tfi.TransferItemStartClicked += Tfi_UploadTransferItemStartClicked;
            tfi.TransferItemPauseClicked += Tfi_UploadTransferItemPauseClicked;
            tfi.TransferItemDeleteClicked += Tfi_UploadTransferItemDeleteClicked;
            tfUpload.AddTransferFile(tfi);

            if (needAddToDB && FileList.AddUploadTask(dr.FileName,
                                                       dr.FileSizeDesc,
                                                       0.0,
                                                       ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task),
                                                       dr.FileName,
                                                       dr.UploadFilePath) == -1)
            {
                ExMessageBox.Show("添加下载任务到数据库失败！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        private void 上传文件UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            System.IO.FileInfo f = new System.IO.FileInfo(openFileDialog1.FileName);

            int fileID = FileList.AddUploadTask(f.Name,
                                                ComponentControls.Helper.IO.FileInfo.GetSizeInShortFormat(f.Length),
                                                0,
                                                ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.start_task),
                                                f.FullName,
                                                directoryPath1.CurrentFullPath);

            if(fileID == -1)
            {
                ExMessageBox.Show("添加上传任务至数据库失败！", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TransferFileItem tfi = new TransferFileItem(fileID.ToString().Trim(),
                                                               f.Name,
                                                               f.FullName,
                                                               directoryPath1.CurrentFullPath,
                                                               ComponentControls.Helper.IO.FileInfo.GetSizeInShortFormat(f.Length),
                                                               0,
                                                               null);
                tfi.TransferItemStartClicked += Tfi_UploadTransferItemStartClicked;
                tfi.TransferItemPauseClicked += Tfi_UploadTransferItemPauseClicked;
                tfi.TransferItemDeleteClicked += Tfi_UploadTransferItemDeleteClicked;

                tfUpload.AddTransferFile(tfi);
            }
        }

        private void Tfi_UploadTransferItemDeleteClicked(object sender, EventArgs e)
        {
            //点击了删除上传按钮
        }

        private void Tfi_UploadTransferItemPauseClicked(object sender, EventArgs e)
        {
            //点击了暂停上传按钮
        }

        private void Tfi_UploadTransferItemStartClicked(object sender, EventArgs e)
        {
            //点击了开始上传
            Thread thread = new Thread(new ParameterizedThreadStart(StartOneFileUpload));
            thread.IsBackground = true;
            thread.Start((TransferFileItem)sender);
        }

        private void StartOneFileUpload(object sender)
        {
            TransferFileItem item = (TransferFileItem)sender;
            int returnCode = -1;
            string returnMessage = String.Empty;
            if(FileList.UploadFile(item.FilePathFrom, item.FilePathTo, "", item.ProgressBar, out returnCode, out returnMessage))
            {
                if(!FileList.UpdateUploadStatus(item.FileID, ImageHelper.ImageToBytes(global::CloudreveForWindows.Properties.Resources.finished_task)))
                {
                    ExMessageBox.Show("上传完成，更新状态失败!", "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                ExMessageBox.Show("上传失败，错误信息如下：\r\n" + returnMessage, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                                          Convert.ToBoolean(items[i].is_dir) ? "" : ComponentControls.Helper.IO.FileInfo.GetSizeInShortFormat(items[i].source.size),
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
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.home, "主目录", 0));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.video, "视频", 0));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.image, "图片", 0));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.music, "音乐", 0));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.document, "文档", 0));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.addTag, "添加标签", 0));

            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.share, "我的分享"));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.download, "下载任务"));
            items.Add(new NavigateMenuItem(global::CloudreveForWindows.Properties.Resources.upload1, "上传任务"));

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
            panStorageInfo.Enabled = false;
            panFileListTop.Enabled = false;
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
            panStorageInfo.Enabled = true;
            panFileListTop.Enabled = true;
            panRightMenu.Enabled = true;
        }

        #endregion
    }
}
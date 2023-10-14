using CloudreveMiddleLayer.Controls;
using CloudreveMiddleLayer.DataSet;
using CloudreveMiddleLayer.Entiry;
using ComponentControls.Forms;
using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using MessageBox = ComponentControls.Forms.MessageBox;

namespace ComponentControls.Controls
{
    [Serializable]
    public partial class TransferFileItem : UserControl
    {
        string fileID = String.Empty;
        string filePathFrom = String.Empty, filePathTo = String.Empty, uploadToCloudrevePath = String.Empty;

        public delegate void TransferItemStartClickedEvent(object sender, EventArgs e);
        public event TransferItemStartClickedEvent TransferItemStartClicked;
        public delegate void TransferItemPauseClickedEvent(object sender, EventArgs e);
        public event TransferItemPauseClickedEvent TransferItemPauseClicked;
        public delegate void TransferItemDeleteClickedEvent(object sender, bool removeLocalFile);
        public event TransferItemDeleteClickedEvent TransferItemDeleteClicked;
        public delegate void TransferItemOpenPathClickedEvent(object sender, EventArgs e);
        public event TransferItemOpenPathClickedEvent TransferItemOpenFolderClicked;
        public delegate void TransferItemCompletedEvent(object sender, string fileID);
        public event TransferItemCompletedEvent TransferItemCompleted;

        private Status status = Status.暂停;
        private TransferType transType = TransferType.下载;
        private TransferCategory transCategory = TransferCategory.CloudreveTransfer;
        private Thread thread = null;

        public enum Status
        {
            所有状态 = -1,
            暂停 = 0,
            正在传输 = 1,
            传输完毕 = 2
        }

        public enum TransferType
        {
            下载 = 0,
            上传 = 1
        }

        public enum TransferCategory
        {
            CloudreveTransfer = 0,  //Cloudreve网盘传输文件
            BaiduPanTransfer = 1    //百度网盘保存文件至Cloudreve网盘
        }

        public TransferFileItem()
        {
            InitializeComponent();
        }

        public TransferFileItem(string fileID, string fileName, string filePathFrom, string filePathTo, 
                                string fileSize, int percent, object tag, TransferType transType, 
                                TransferCategory transCategory, string uploadToCloudrevePath)
        {
            InitializeComponent();
            this.fileID = fileID;
            lblFileName.Text = fileName;
            this.toolTip1.SetToolTip(lblFileName, fileName);
            this.filePathFrom = filePathFrom;
            this.filePathTo = filePathTo;
            lblFileSize.Text = fileSize;
            pbPercent.Value = percent;
            this.transType = transType;
            this.transCategory = transCategory;
            this.uploadToCloudrevePath = uploadToCloudrevePath;
            if (pbPercent.Value == 100)
            {
                CurrentStatus = Status.传输完毕;
            }
            this.Tag = tag;
            if (transType == TransferType.下载)
            {
                switch(transCategory)
                {
                    case TransferCategory.CloudreveTransfer:
                        thread = new Thread(StartDownload);
                        break;
                    case TransferCategory.BaiduPanTransfer:
                        thread = new Thread(StartBaiduDownload);
                        break;
                }
            }
            else if(transType == TransferType.上传)
            {
                //if (transCategory == TransferCategory.CloudreveTransfer)
                //{
                //    thread = new Thread(StartUpload);
                //}
                thread = new Thread(StartUpload);
            }
            thread.IsBackground = true;
        }

        public Image DownloadStatusImage
        {
            get { return btnStartOrPause.Image; }
            set { btnStartOrPause.Image = value; }
        }

        public string FileID
        {
            get { return fileID; }
            set { fileID = value; }
        }

        public string FileName
        {
            get { return lblFileName.Text.Trim(); }
            set { lblFileName.Text = value; }
        }

        public int Percent
        {
            get { return pbPercent.Value; }
            set 
            { 
                pbPercent.Value = value;
                if (pbPercent.Value == 100)
                {
                    btnStartOrPause.Image = global::ComponentControls.Properties.Resources.finished_task;
                }
            }
        }

        public string FilePathFrom
        {
            get { return filePathFrom; }
            set { filePathFrom = value; }
        }

        public string FilePathTo
        {
            get { return filePathTo; }
            set { filePathTo = value; }
        }

        public TransferFileProgressBar ProgressBar
        {
            get { return pbPercent; }
        }

        public Status CurrentStatus
        {
            get { return status; }
            set
            {
                status = value;
                switch (status)
                {
                    case Status.正在传输:
                        btnStartOrPause.Image = global::ComponentControls.Properties.Resources.pause_task;
                        //timerUpdateProgressBarValue.Enabled = true;
                        thread.Start();
                        break;
                    case Status.暂停:
                        btnStartOrPause.Image = global::ComponentControls.Properties.Resources.start_task;
                        //timerUpdateProgressBarValue.Enabled = false;
                        thread.Abort();
                        break;
                    case Status.传输完毕:
                        btnStartOrPause.Image = global::ComponentControls.Properties.Resources.finished_task;
                        pbPercent.Value = 100;
                        //timerUpdateProgressBarValue.Enabled = false;
                        if (TransferItemCompleted!=null)
                        {
                            TransferItemCompleted(this, fileID);
                        }
                        break;
                }
            }
        }

        public TransferCategory Category
        {
            get { return this.transCategory; }
        }

        public string UploadToCloudrevePath
        {
            get { return uploadToCloudrevePath; }
        }

        private void btnStartOrPause_Click(object sender, EventArgs e)
        {
            switch(status)
            {
                case Status.暂停:
                    if (TransferItemStartClicked != null)
                    {
                        TransferItemStartClicked(this, new EventArgs());
                    }
                    CurrentStatus = Status.正在传输;
                    break;
                case Status.正在传输:
                    if (TransferItemPauseClicked != null)
                    {
                        TransferItemPauseClicked(this, new EventArgs());
                    }
                    CurrentStatus = Status.暂停;
                    break;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox msg = null;
            if(transType == TransferType.下载)
            {
                msg = new MessageBox("您确定要删除该任务么？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, true, true, "同时删除本地文件");
            }
            else
            {
                msg = new MessageBox("您确定要删除该任务么？", "提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
            
            if(msg.ShowDialog() == DialogResult.Yes)
            {
                Remove(msg.Checked);
            }
        }

        public void Remove(bool removeLocalFile)
        {
            CurrentStatus = Status.暂停;
            if (TransferItemDeleteClicked != null)
            {
                TransferItemDeleteClicked(this, removeLocalFile);
            }
        }

        #region Start 

        private void StartDownload()
        {
            int returnCode;
            DataSetDownloadUpload.TBL_DownloadInfoRow dr = (DataSetDownloadUpload.TBL_DownloadInfoRow)this.Tag;
            string returnMessage;
            if (new FileTransfer().DownloadFile(dr, this.ProgressBar, out returnCode, out returnMessage))
            {
                //下载成功
                UpdateCurrentStatusToFinish();
            }
        }

        private void StartUpload()
        {
            int returnCode = -1;
            string returnMessage = String.Empty;
            if (new FileTransfer().UploadFile(this.FilePathFrom, this.FilePathTo, "", this.ProgressBar, out returnCode, out returnMessage))
            {
                //下载成功
                UpdateCurrentStatusToFinish();
            }
            else
            {
                ExMessageBox.Show("上传失败，错误信息如下：\r\n" + returnMessage, "失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartBaiduDownload()
        {
            int returnCode;
            string returnMessage;
            if (new FileTransfer().DownloadBaiduFile(filePathFrom, filePathTo , this.ProgressBar, out returnCode, out returnMessage))
            {
                //下载成功
                UpdateCurrentStatusToFinish();
            }
        }

        #endregion

        private void UpdateCurrentStatusToFinish()
        {
            try
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    try
                    {
                        CurrentStatus = Status.传输完毕;
                    }
                    catch
                    { }
                });
            }
            catch (Exception ex)
            {

            }
        }

        #region Open Folder

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            TransferOpenFolder();
        }

        public void TransferOpenFolder()
        {
            if(!string.IsNullOrEmpty(filePathFrom))
            {
                DirectoryInfo dir = new DirectoryInfo(filePathFrom);
                System.Diagnostics.Process.Start("Explorer.exe", dir.Parent.FullName);
                if (TransferItemOpenFolderClicked != null)
                {
                    TransferItemOpenFolderClicked(this, new EventArgs());
                }
            }
            else
            {
                DirectoryInfo dir = new DirectoryInfo(filePathTo);
                System.Diagnostics.Process.Start("Explorer.exe", dir.Parent.FullName);
                if (TransferItemOpenFolderClicked != null)
                {
                    TransferItemOpenFolderClicked(this, new EventArgs());
                }
            }
        }

        #endregion
    }
}

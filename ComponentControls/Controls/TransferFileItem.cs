using ComponentControls.Helper.Media;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentControls.Controls
{
    [Serializable]
    public partial class TransferFileItem : UserControl
    {
        string fileID = String.Empty;
        string filePathFrom = String.Empty, filePathTo = String.Empty;

        public delegate void TransferItemStartClickedEvent(object sender, EventArgs e);
        public event TransferItemStartClickedEvent TransferItemStartClicked;
        public delegate void TransferItemPauseClickedEvent(object sender, EventArgs e);
        public event TransferItemPauseClickedEvent TransferItemPauseClicked;
        public delegate void TransferItemDeleteClickedEvent(object sender, EventArgs e);
        public event TransferItemDeleteClickedEvent TransferItemDeleteClicked;
        public delegate void TransferItemOpenPathClickedEvent(object sender, EventArgs e);
        public event TransferItemOpenPathClickedEvent TransferItemOpenFolderClicked;

        public TransferFileItem()
        {
            InitializeComponent();
            
        }

        public TransferFileItem(string fileID, string fileName, string filePathFrom, string filePathTo, string fileSize, int percent, object tag)
        {
            InitializeComponent();
            this.fileID = fileID;
            lblFileName.Text = fileName;
            this.toolTip1.SetToolTip(lblFileName, fileName);
            this.filePathFrom = filePathFrom;
            this.filePathTo = filePathTo;
            lblFileSize.Text = fileSize;
            pbPercent.Value = percent;
            if (pbPercent.Value == 100)
            {
                btnStartOrPause.Image = global::ComponentControls.Properties.Resources.finished_task;
                pbPercent.Value = 0;
            }
            this.Tag = tag;
        }

        public TransferFileItem(string fileID, string fileName, string filePathFrom, string fileSize, int percent, object tag)
        {
            InitializeComponent();
            this.fileID = fileID;
            lblFileName.Text = fileName;
            this.toolTip1.SetToolTip(lblFileName, fileName);
            this.filePathFrom = filePathFrom;
            lblFileSize.Text = fileSize;
            pbPercent.Value = percent;
            if (pbPercent.Value == 100)
            {
                btnStartOrPause.Image = global::ComponentControls.Properties.Resources.finished_task;
                pbPercent.Value = 0;
            }
            this.Tag = tag;
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

        public bool IsTransferComplete
        {
            get { return ImageHelper.ImageToBytes(btnStartOrPause.Image).SequenceEqual(ImageHelper.ImageToBytes(global::ComponentControls.Properties.Resources.finished_task)); }
        }

        public bool IsTransferStart
        {
            get { return ImageHelper.ImageToBytes(btnStartOrPause.Image).SequenceEqual(ImageHelper.ImageToBytes(global::ComponentControls.Properties.Resources.pause_task)); }
        }

        private void btnStartOrPause_Click(object sender, EventArgs e)
        {
            if (ImageHelper.ImageToBytes(btnStartOrPause.Image).SequenceEqual(ImageHelper.ImageToBytes(global::ComponentControls.Properties.Resources.start_task)))
            {
                TransferStart();
            }
            else if(ImageHelper.ImageToBytes(btnStartOrPause.Image).SequenceEqual(ImageHelper.ImageToBytes(global::ComponentControls.Properties.Resources.pause_task)))
            {
                TransferPause();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TransferDelete();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            TransferOpenFolder();
        }

        public void TransferStart()
        {
            btnStartOrPause.Image = global::ComponentControls.Properties.Resources.pause_task;
            if (TransferItemStartClicked != null)
            {
                TransferItemStartClicked(this, new EventArgs());
            }
        }

        public void TransferPause(bool raisEvents = true)
        {
            btnStartOrPause.Image = global::ComponentControls.Properties.Resources.start_task;
            if (raisEvents && TransferItemPauseClicked != null)
            {
                TransferItemPauseClicked(this, new EventArgs());
            }
        }

        public void TransferDelete()
        {
            btnStartOrPause.Image = global::ComponentControls.Properties.Resources.start_task;
            if (TransferItemDeleteClicked != null)
            {
                TransferItemDeleteClicked(this, new EventArgs());
            }
        }

        public void TransferComplete()
        {
            btnStartOrPause.Image = global::ComponentControls.Properties.Resources.finished_task;
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
    }
}

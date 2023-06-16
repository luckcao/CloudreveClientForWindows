using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentControls.Controls
{
    public partial class ShareFileItem : UserControl
    {
        public class ClickedEventArgs : EventArgs
        {
            bool cancel = false;

            public ClickedEventArgs()
            {

            }

            public ClickedEventArgs(bool cancel)
            {
                this.cancel = cancel;
            }

            public bool Cancel
            {
                get { return cancel; }
                set { this.cancel = value; }
            }
        }

        string fileID = String.Empty, password = String.Empty;
        bool isPublic = true, allowPreview = true;
        public delegate void SetAsPrivateShareClickedEvent(object sender, ClickedEventArgs e);
        public event SetAsPrivateShareClickedEvent SharePrivateClicked;
        public delegate void SetAsPublicShareClickedEvent(object sender, ClickedEventArgs e);
        public event SetAsPublicShareClickedEvent SharePublicClicked;
        public delegate void SetCanPreviewClickedEvent(object sender, ClickedEventArgs e);
        public event SetCanPreviewClickedEvent ShareCanPreviewClicked;
        public delegate void SetCanNotPreviewClickedEvent(object sender, ClickedEventArgs e);
        public event SetCanNotPreviewClickedEvent ShareCannotPreviewClicked;
        public delegate void SetShareCancelClickedEvent(object sender, ClickedEventArgs e);
        public event SetShareCancelClickedEvent ShareCancelClicked;

        public ShareFileItem()
        {
            InitializeComponent();
        }

        public ShareFileItem(string fileID, 
                             string fileName, 
                             bool isDir, 
                             string fileSize, 
                             string createShareDate,
                             int expireLeftSecond, 
                             string password,
                             int downloadCount,
                             int leftDownloadCount,
                             int viewCount,
                             bool allowPreview,
                             object tag)
        {
            InitializeComponent();
            this.fileID = fileID;
            lblFileName.Text = fileName;
            this.password = password;
            this.toolTip1.SetToolTip(lblFileName, fileName);
            lblFileSize.Text = fileSize;
            this.allowPreview = allowPreview;
            if(isDir)
            {
                picFileType.Image = global::ComponentControls.Properties.Resources.dir;
            }
            else
            {
                string ext = String.Empty;
                if (fileName.Contains("."))
                {
                    ext = fileName.Substring(fileName.LastIndexOf('.') + 1).ToUpper();
                }
                #region 设置文件图标

                switch (ext)
                {
                    case "PDF":
                        picFileType.Image = global::ComponentControls.Properties.Resources.pdf_file;
                        break;
                    case "MP3":
                    case "WAV":
                    case "MIDI":
                    case "CDA":
                    case "WMA":
                    case "AAC":
                    case "OGG":
                    case "VQF":
                        picFileType.Image = global::ComponentControls.Properties.Resources.audio_file;
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
                        picFileType.Image = global::ComponentControls.Properties.Resources.video_file;
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
                        picFileType.Image = global::ComponentControls.Properties.Resources.img_file;
                        break;
                    case "TXT":
                    case "INI":
                    case "XML":
                    case "MD":
                        picFileType.Image = global::ComponentControls.Properties.Resources.txt_file;
                        break;
                    case "DOC":
                    case "DOCX":
                    case "XPS":
                    case "RTF":
                        picFileType.Image = global::ComponentControls.Properties.Resources.word_file;
                        break;
                    case "XLS":
                    case "XLSX":
                    case "CVS":
                        picFileType.Image = global::ComponentControls.Properties.Resources.excel_file;
                        break;
                    case "ZIP":
                    case "7Z":
                    case "BZIP2":
                    case "GZIP":
                    case "TAR":
                    case "RAR":
                    case "XZ":
                    case "ISO":
                        picFileType.Image = global::ComponentControls.Properties.Resources.zip_file;
                        break;
                    default:
                        picFileType.Image = global::ComponentControls.Properties.Resources.unknow_file;
                        break;
                }

                #endregion
            }
            if(allowPreview)
            {
                btnAllowPreview.Image = global::ComponentControls.Properties.Resources.set_private;
                this.toolTip1.SetToolTip(btnAllowPreview, "设为不可预览");
            }
            else
            {
                btnAllowPreview.Image = global::ComponentControls.Properties.Resources.set_public;
                this.toolTip1.SetToolTip(btnAllowPreview, "设为可预览");
            }
            if(password.Equals(String.Empty))
            {
                //说明是公开的
                btnSetPublic.Image = global::ComponentControls.Properties.Resources.unlock;
                this.toolTip1.SetToolTip(btnSetPublic, "设为私密分享");
                isPublic = true;
            }
            else
            {
                //说明是私密的
                btnSetPublic.Image = global::ComponentControls.Properties.Resources._lock;
                this.toolTip1.SetToolTip(btnSetPublic, "设为公开分享");
                isPublic = false;
            }

            lblDesc.Text = "查看{0}次     下载{1}次     剩余下载次数：{2}     创建分享时间：{3}     结束分享时间：{4}";
            lblDesc.Text = string.Format(lblDesc.Text, viewCount, downloadCount, leftDownloadCount, createShareDate, DateTime.Now.AddSeconds(expireLeftSecond).ToString("yyyy-MM-dd HH:mm:ss"));

            this.Tag = tag;
        }

        public string FileID
        {
            get { return fileID; }
        }

        public bool AllowPreview
        {
            get { return allowPreview; }
        }

        public string FileName
        {
            get { return lblFileName.Text; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (ShareCancelClicked != null)
            {
                ShareCancelClicked(this, new ClickedEventArgs());
            }
        }

        private void btnAllowPreview_Click(object sender, EventArgs e)
        {
            if (allowPreview && ShareCannotPreviewClicked != null)
            {
                ClickedEventArgs ee = new ClickedEventArgs();
                ShareCannotPreviewClicked(this, ee);
                if(!ee.Cancel)
                {
                    btnAllowPreview.Image = global::ComponentControls.Properties.Resources.set_public;
                    this.toolTip1.SetToolTip(btnAllowPreview, "设为可预览");
                }
            }
            else if (!allowPreview && ShareCannotPreviewClicked != null)
            {
                ClickedEventArgs ee = new ClickedEventArgs();
                ShareCanPreviewClicked(this, ee);
                if (!ee.Cancel)
                {
                    btnAllowPreview.Image = global::ComponentControls.Properties.Resources.set_private;
                    this.toolTip1.SetToolTip(btnAllowPreview, "设为不可预览");
                }
            }
        }

        private void btnSetPublic_Click(object sender, EventArgs e)
        {
            if (isPublic && SharePrivateClicked != null)
            {
                ClickedEventArgs ee = new ClickedEventArgs();
                SharePrivateClicked(this, ee);
                if (!ee.Cancel)
                {
                    btnSetPublic.Image = global::ComponentControls.Properties.Resources._lock;
                    this.toolTip1.SetToolTip(btnAllowPreview, "设为公开分享");
                }
            }
            else if (!isPublic && SharePublicClicked != null)
            {
                ClickedEventArgs ee = new ClickedEventArgs();
                SharePublicClicked(this, ee);
                if (!ee.Cancel)
                {
                    btnSetPublic.Image = global::ComponentControls.Properties.Resources.unlock;
                    this.toolTip1.SetToolTip(btnAllowPreview, "设为私密分享");
                }
            }
        }
    }
}

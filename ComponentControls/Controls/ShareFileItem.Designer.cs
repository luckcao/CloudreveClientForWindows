
namespace ComponentControls.Controls
{
    partial class ShareFileItem
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.panOperation = new System.Windows.Forms.Panel();
            this.btnSetPublic = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnAllowPreview = new System.Windows.Forms.PictureBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picFileType = new System.Windows.Forms.PictureBox();
            this.panOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSetPublic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAllowPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileType)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFileSize
            // 
            this.lblFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileSize.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFileSize.Location = new System.Drawing.Point(248, 6);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(118, 27);
            this.lblFileSize.TabIndex = 6;
            this.lblFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panOperation
            // 
            this.panOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panOperation.Controls.Add(this.btnSetPublic);
            this.panOperation.Controls.Add(this.btnDelete);
            this.panOperation.Controls.Add(this.btnAllowPreview);
            this.panOperation.Location = new System.Drawing.Point(375, 6);
            this.panOperation.Name = "panOperation";
            this.panOperation.Size = new System.Drawing.Size(93, 27);
            this.panOperation.TabIndex = 5;
            // 
            // btnSetPublic
            // 
            this.btnSetPublic.Image = global::ComponentControls.Properties.Resources._lock;
            this.btnSetPublic.Location = new System.Drawing.Point(3, 3);
            this.btnSetPublic.Name = "btnSetPublic";
            this.btnSetPublic.Size = new System.Drawing.Size(20, 20);
            this.btnSetPublic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSetPublic.TabIndex = 5;
            this.btnSetPublic.TabStop = false;
            this.btnSetPublic.Click += new System.EventHandler(this.btnSetPublic_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::ComponentControls.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(69, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 20);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 2;
            this.btnDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDelete, "取消分享");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAllowPreview
            // 
            this.btnAllowPreview.Image = global::ComponentControls.Properties.Resources.set_public;
            this.btnAllowPreview.Location = new System.Drawing.Point(36, 3);
            this.btnAllowPreview.Name = "btnAllowPreview";
            this.btnAllowPreview.Size = new System.Drawing.Size(20, 20);
            this.btnAllowPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnAllowPreview.TabIndex = 1;
            this.btnAllowPreview.TabStop = false;
            this.btnAllowPreview.Click += new System.EventHandler(this.btnAllowPreview_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFileName.Location = new System.Drawing.Point(39, 6);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(203, 27);
            this.lblFileName.TabIndex = 4;
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDesc
            // 
            this.lblDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDesc.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDesc.Location = new System.Drawing.Point(3, 44);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(465, 27);
            this.lblDesc.TabIndex = 4;
            this.lblDesc.Text = "查看{0}次     下载{1}次     剩余下载次数：{2}     创建分享时间：{3}     结束分享时间：{4}";
            this.lblDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // picFileType
            // 
            this.picFileType.Image = global::ComponentControls.Properties.Resources.dir;
            this.picFileType.Location = new System.Drawing.Point(3, 4);
            this.picFileType.Name = "picFileType";
            this.picFileType.Size = new System.Drawing.Size(30, 30);
            this.picFileType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFileType.TabIndex = 7;
            this.picFileType.TabStop = false;
            // 
            // ShareFileItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.picFileType);
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.panOperation);
            this.Controls.Add(this.lblDesc);
            this.Controls.Add(this.lblFileName);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "ShareFileItem";
            this.Size = new System.Drawing.Size(474, 76);
            this.panOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSetPublic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAllowPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFileType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Panel panOperation;
        private System.Windows.Forms.PictureBox btnSetPublic;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnAllowPreview;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.PictureBox picFileType;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

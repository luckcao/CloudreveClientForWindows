
using CloudreveMiddleLayer.Controls;

namespace ComponentControls.Controls
{
    partial class TransferFileItem
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
            this.lblFileName = new System.Windows.Forms.Label();
            this.panOperation = new System.Windows.Forms.Panel();
            this.btnStartOrPause = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnOpenFolder = new System.Windows.Forms.PictureBox();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pbPercent = new CloudreveMiddleLayer.Controls.TransferFileProgressBar(this.components);
            this.panOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartOrPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFolder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFileName
            // 
            this.lblFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFileName.Location = new System.Drawing.Point(4, 4);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(89, 27);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panOperation
            // 
            this.panOperation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panOperation.Controls.Add(this.btnStartOrPause);
            this.panOperation.Controls.Add(this.btnDelete);
            this.panOperation.Controls.Add(this.btnOpenFolder);
            this.panOperation.Location = new System.Drawing.Point(226, 4);
            this.panOperation.Name = "panOperation";
            this.panOperation.Size = new System.Drawing.Size(93, 27);
            this.panOperation.TabIndex = 2;
            // 
            // btnStartOrPause
            // 
            this.btnStartOrPause.Image = global::ComponentControls.Properties.Resources.start_task;
            this.btnStartOrPause.Location = new System.Drawing.Point(3, 3);
            this.btnStartOrPause.Name = "btnStartOrPause";
            this.btnStartOrPause.Size = new System.Drawing.Size(20, 20);
            this.btnStartOrPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStartOrPause.TabIndex = 5;
            this.btnStartOrPause.TabStop = false;
            this.btnStartOrPause.Click += new System.EventHandler(this.btnStartOrPause_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::ComponentControls.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(36, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 20);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 2;
            this.btnDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDelete, "删除");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Image = global::ComponentControls.Properties.Resources.open_folder;
            this.btnOpenFolder.Location = new System.Drawing.Point(69, 3);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(20, 20);
            this.btnOpenFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOpenFolder.TabIndex = 1;
            this.btnOpenFolder.TabStop = false;
            this.toolTip1.SetToolTip(this.btnOpenFolder, "打开下载目录");
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // lblFileSize
            // 
            this.lblFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileSize.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFileSize.Location = new System.Drawing.Point(99, 4);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(118, 27);
            this.lblFileSize.TabIndex = 3;
            this.lblFileSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbPercent
            // 
            this.pbPercent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbPercent.Location = new System.Drawing.Point(8, 37);
            this.pbPercent.Name = "pbPercent";
            this.pbPercent.Size = new System.Drawing.Size(311, 7);
            this.pbPercent.Step = 1;
            this.pbPercent.TabIndex = 1;
            // 
            // TransferFileItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblFileSize);
            this.Controls.Add(this.panOperation);
            this.Controls.Add(this.pbPercent);
            this.Controls.Add(this.lblFileName);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TransferFileItem";
            this.Size = new System.Drawing.Size(328, 50);
            this.panOperation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStartOrPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOpenFolder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFileName;
        private TransferFileProgressBar pbPercent;
        private System.Windows.Forms.Panel panOperation;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox btnOpenFolder;
        private System.Windows.Forms.PictureBox btnStartOrPause;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

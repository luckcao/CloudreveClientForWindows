
namespace ComponentControls.Controls
{
    partial class NavigateMenuItem
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
            this.lblMenuText = new System.Windows.Forms.Label();
            this.picStatus = new System.Windows.Forms.PictureBox();
            this.picMenuIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMenuText
            // 
            this.lblMenuText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenuText.AutoSize = true;
            this.lblMenuText.BackColor = System.Drawing.Color.Transparent;
            this.lblMenuText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMenuText.Location = new System.Drawing.Point(88, 10);
            this.lblMenuText.Name = "lblMenuText";
            this.lblMenuText.Size = new System.Drawing.Size(59, 22);
            this.lblMenuText.TabIndex = 1;
            this.lblMenuText.Text = "label1";
            this.lblMenuText.Click += new System.EventHandler(this.NavigateMenuItem_Click);
            this.lblMenuText.MouseEnter += new System.EventHandler(this.NavigateMenuItem_MouseEnter);
            // 
            // picStatus
            // 
            this.picStatus.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picStatus.Image = global::ComponentControls.Properties.Resources.js_assets_xiala;
            this.picStatus.Location = new System.Drawing.Point(211, 15);
            this.picStatus.Name = "picStatus";
            this.picStatus.Size = new System.Drawing.Size(15, 7);
            this.picStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStatus.TabIndex = 2;
            this.picStatus.TabStop = false;
            this.picStatus.Click += new System.EventHandler(this.NavigateMenuItem_Click);
            this.picStatus.MouseEnter += new System.EventHandler(this.NavigateMenuItem_MouseEnter);
            // 
            // picMenuIcon
            // 
            this.picMenuIcon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picMenuIcon.BackColor = System.Drawing.Color.Transparent;
            this.picMenuIcon.Location = new System.Drawing.Point(21, 10);
            this.picMenuIcon.Name = "picMenuIcon";
            this.picMenuIcon.Size = new System.Drawing.Size(20, 20);
            this.picMenuIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMenuIcon.TabIndex = 0;
            this.picMenuIcon.TabStop = false;
            this.picMenuIcon.Click += new System.EventHandler(this.NavigateMenuItem_Click);
            this.picMenuIcon.MouseEnter += new System.EventHandler(this.NavigateMenuItem_MouseEnter);
            // 
            // NavigateMenuItem
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.picStatus);
            this.Controls.Add(this.lblMenuText);
            this.Controls.Add(this.picMenuIcon);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "NavigateMenuItem";
            this.Size = new System.Drawing.Size(240, 40);
            this.Click += new System.EventHandler(this.NavigateMenuItem_Click);
            this.MouseEnter += new System.EventHandler(this.NavigateMenuItem_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.NavigateMenuItem_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.picStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMenuIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picMenuIcon;
        private System.Windows.Forms.Label lblMenuText;
        private System.Windows.Forms.PictureBox picStatus;
    }
}

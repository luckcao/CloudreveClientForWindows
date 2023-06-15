
namespace CloudreveForWindows.Forms
{
    partial class Share
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Share));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnShowPassword = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dudExpireDayCount = new System.Windows.Forms.DomainUpDown();
            this.dudDownloadTimes = new System.Windows.Forms.DomainUpDown();
            this.chkAllowPreview = new System.Windows.Forms.CheckBox();
            this.chkAutoExpire = new System.Windows.Forms.CheckBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkUsePassword = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.requirementErrorProvider1 = new ComponentControls.Components.RequirementErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPassword)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.requirementErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnShowPassword);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dudExpireDayCount);
            this.panel2.Controls.Add(this.dudDownloadTimes);
            this.panel2.Controls.Add(this.chkAllowPreview);
            this.panel2.Controls.Add(this.chkAutoExpire);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.chkUsePassword);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(506, 138);
            this.panel2.TabIndex = 1;
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Enabled = false;
            this.btnShowPassword.Image = global::CloudreveForWindows.Properties.Resources.show_password;
            this.btnShowPassword.Location = new System.Drawing.Point(462, 22);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(22, 12);
            this.btnShowPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShowPassword.TabIndex = 5;
            this.btnShowPassword.TabStop = false;
            this.btnShowPassword.Click += new System.EventHandler(this.btnShowPassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "天后过期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(242, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "次下载或者";
            // 
            // dudExpireDayCount
            // 
            this.dudExpireDayCount.Location = new System.Drawing.Point(343, 57);
            this.dudExpireDayCount.Name = "dudExpireDayCount";
            this.dudExpireDayCount.ReadOnly = true;
            this.dudExpireDayCount.Size = new System.Drawing.Size(65, 29);
            this.dudExpireDayCount.TabIndex = 3;
            this.dudExpireDayCount.Text = "1";
            this.dudExpireDayCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dudDownloadTimes
            // 
            this.dudDownloadTimes.Location = new System.Drawing.Point(168, 57);
            this.dudDownloadTimes.Name = "dudDownloadTimes";
            this.dudDownloadTimes.ReadOnly = true;
            this.dudDownloadTimes.Size = new System.Drawing.Size(65, 29);
            this.dudDownloadTimes.TabIndex = 3;
            this.dudDownloadTimes.Text = "1";
            this.dudDownloadTimes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chkAllowPreview
            // 
            this.chkAllowPreview.AutoSize = true;
            this.chkAllowPreview.Location = new System.Drawing.Point(16, 103);
            this.chkAllowPreview.Name = "chkAllowPreview";
            this.chkAllowPreview.Size = new System.Drawing.Size(93, 26);
            this.chkAllowPreview.TabIndex = 2;
            this.chkAllowPreview.Text = "允许预览";
            this.chkAllowPreview.UseVisualStyleBackColor = true;
            // 
            // chkAutoExpire
            // 
            this.chkAutoExpire.AutoSize = true;
            this.chkAutoExpire.Location = new System.Drawing.Point(16, 57);
            this.chkAutoExpire.Name = "chkAutoExpire";
            this.chkAutoExpire.Size = new System.Drawing.Size(93, 26);
            this.chkAutoExpire.TabIndex = 2;
            this.chkAutoExpire.Text = "自动过期";
            this.chkAutoExpire.UseVisualStyleBackColor = true;
            this.chkAutoExpire.CheckedChanged += new System.EventHandler(this.chkAutoExpire_CheckedChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(168, 12);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(278, 29);
            this.txtPassword.TabIndex = 1;
            // 
            // chkUsePassword
            // 
            this.chkUsePassword.AutoSize = true;
            this.chkUsePassword.Location = new System.Drawing.Point(16, 12);
            this.chkUsePassword.Name = "chkUsePassword";
            this.chkUsePassword.Size = new System.Drawing.Size(125, 26);
            this.chkUsePassword.TabIndex = 0;
            this.chkUsePassword.Text = "使用密码保护";
            this.chkUsePassword.UseVisualStyleBackColor = true;
            this.chkUsePassword.CheckedChanged += new System.EventHandler(this.chkUsePassword_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 40);
            this.panel1.TabIndex = 2;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(481, 22);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnOK);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 176);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 48);
            this.panel3.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(248, 42);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.White;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.ForeColor = System.Drawing.Color.Black;
            this.btnOK.Location = new System.Drawing.Point(254, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(248, 42);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "确定(&O)";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // requirementErrorProvider1
            // 
            this.requirementErrorProvider1.BindControl = null;
            this.requirementErrorProvider1.ContainerControl = this;
            this.requirementErrorProvider1.ErrorMessage = "不能为空";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "是否允许在分享页面预览文件内容";
            // 
            // Share
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(506, 224);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Share";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "创建共享链接";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowPassword)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.requirementErrorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private ComponentControls.Components.RequirementErrorProvider requirementErrorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown dudExpireDayCount;
        private System.Windows.Forms.DomainUpDown dudDownloadTimes;
        private System.Windows.Forms.CheckBox chkAllowPreview;
        private System.Windows.Forms.CheckBox chkAutoExpire;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkUsePassword;
        private System.Windows.Forms.PictureBox btnShowPassword;
        private System.Windows.Forms.Label label3;
    }
}
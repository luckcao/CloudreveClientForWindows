
namespace CloudreveForWindows.Forms
{
    partial class Login
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picCaptcha = new System.Windows.Forms.PictureBox();
            this.cboDB = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.chkAutoLogin = new System.Windows.Forms.CheckBox();
            this.chkRememberInfo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnReg = new System.Windows.Forms.LinkLabel();
            this.btnForgotPWD = new System.Windows.Forms.LinkLabel();
            this.txtCaptchaCode = new ComponentControls.Controls.HintTextBox();
            this.txtUserName = new ComponentControls.Controls.HintTextBox();
            this.txtPWD = new ComponentControls.Controls.HintTextBox();
            this.requirementErrorProvider1 = new ComponentControls.Components.RequirementErrorProvider(this.components);
            this.requirementErrorProvider2 = new ComponentControls.Components.RequirementErrorProvider(this.components);
            this.requirementErrorProvider3 = new ComponentControls.Components.RequirementErrorProvider(this.components);
            this.checkFormatErrorProvider1 = new ComponentControls.Components.CheckFormatErrorProvider(this.components);
            this.checkFormatErrorProvider2 = new ComponentControls.Components.CheckFormatErrorProvider(this.components);
            this.requirementErrorProvider4 = new ComponentControls.Components.RequirementErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementErrorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementErrorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkFormatErrorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkFormatErrorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementErrorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(101)))), ((int)(((byte)(220)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 541);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 118);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(82, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "您的私有网盘您作主";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(83, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 46);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cloudreve";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnForgotPWD);
            this.panel2.Controls.Add(this.btnReg);
            this.panel2.Controls.Add(this.picCaptcha);
            this.panel2.Controls.Add(this.txtCaptchaCode);
            this.panel2.Controls.Add(this.cboDB);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.chkAutoLogin);
            this.panel2.Controls.Add(this.chkRememberInfo);
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.txtPWD);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(13, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 360);
            this.panel2.TabIndex = 0;
            // 
            // picCaptcha
            // 
            this.picCaptcha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picCaptcha.Location = new System.Drawing.Point(197, 190);
            this.picCaptcha.Name = "picCaptcha";
            this.picCaptcha.Size = new System.Drawing.Size(120, 43);
            this.picCaptcha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCaptcha.TabIndex = 15;
            this.picCaptcha.TabStop = false;
            this.picCaptcha.Visible = false;
            this.picCaptcha.Click += new System.EventHandler(this.picCaptcha_Click);
            // 
            // cboDB
            // 
            this.cboDB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cboDB.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboDB.FormattingEnabled = true;
            this.cboDB.Location = new System.Drawing.Point(22, 55);
            this.cboDB.Name = "cboDB";
            this.cboDB.Size = new System.Drawing.Size(295, 30);
            this.cboDB.TabIndex = 0;
            this.cboDB.SelectedIndexChanged += new System.EventHandler(this.cboDB_SelectedIndexChanged);
            this.cboDB.Leave += new System.EventHandler(this.cboDB_Leave);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(22, 274);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(295, 42);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "登录(&L)";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // chkAutoLogin
            // 
            this.chkAutoLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkAutoLogin.AutoSize = true;
            this.chkAutoLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkAutoLogin.Location = new System.Drawing.Point(224, 241);
            this.chkAutoLogin.Name = "chkAutoLogin";
            this.chkAutoLogin.Size = new System.Drawing.Size(93, 25);
            this.chkAutoLogin.TabIndex = 5;
            this.chkAutoLogin.Text = "自动登录";
            this.chkAutoLogin.UseVisualStyleBackColor = true;
            // 
            // chkRememberInfo
            // 
            this.chkRememberInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.chkRememberInfo.AutoSize = true;
            this.chkRememberInfo.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkRememberInfo.Location = new System.Drawing.Point(22, 241);
            this.chkRememberInfo.Name = "chkRememberInfo";
            this.chkRememberInfo.Size = new System.Drawing.Size(93, 25);
            this.chkRememberInfo.TabIndex = 4;
            this.chkRememberInfo.Text = "记住密码";
            this.chkRememberInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "登录到Cloudreve服务器";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::CloudreveForWindows.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(118, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnReg
            // 
            this.btnReg.AutoSize = true;
            this.btnReg.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReg.Location = new System.Drawing.Point(218, 323);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(74, 21);
            this.btnReg.TabIndex = 16;
            this.btnReg.TabStop = true;
            this.btnReg.Text = "立即注册";
            this.btnReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnReg_LinkClicked);
            // 
            // btnForgotPWD
            // 
            this.btnForgotPWD.AutoSize = true;
            this.btnForgotPWD.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnForgotPWD.Location = new System.Drawing.Point(40, 323);
            this.btnForgotPWD.Name = "btnForgotPWD";
            this.btnForgotPWD.Size = new System.Drawing.Size(74, 21);
            this.btnForgotPWD.TabIndex = 16;
            this.btnForgotPWD.TabStop = true;
            this.btnForgotPWD.Text = "找回密码";
            this.btnForgotPWD.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnForgotPWD_LinkClicked);
            // 
            // txtCaptchaCode
            // 
            this.txtCaptchaCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCaptchaCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCaptchaCode.HintText = "验证码";
            this.txtCaptchaCode.Location = new System.Drawing.Point(22, 197);
            this.txtCaptchaCode.Name = "txtCaptchaCode";
            this.txtCaptchaCode.PWDChar = '\0';
            this.txtCaptchaCode.Size = new System.Drawing.Size(144, 29);
            this.txtCaptchaCode.TabIndex = 3;
            this.txtCaptchaCode.Visible = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.HintText = "电子邮箱";
            this.txtUserName.Location = new System.Drawing.Point(22, 100);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PWDChar = '\0';
            this.txtUserName.Size = new System.Drawing.Size(295, 29);
            this.txtUserName.TabIndex = 1;
            // 
            // txtPWD
            // 
            this.txtPWD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPWD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPWD.HintText = "密码";
            this.txtPWD.Location = new System.Drawing.Point(22, 144);
            this.txtPWD.Name = "txtPWD";
            this.txtPWD.PWDChar = '*';
            this.txtPWD.Size = new System.Drawing.Size(295, 29);
            this.txtPWD.TabIndex = 2;
            // 
            // requirementErrorProvider1
            // 
            this.requirementErrorProvider1.BindControl = this.cboDB;
            this.requirementErrorProvider1.ContainerControl = this;
            this.requirementErrorProvider1.ErrorMessage = "不能为空";
            // 
            // requirementErrorProvider2
            // 
            this.requirementErrorProvider2.BindControl = this.txtUserName;
            this.requirementErrorProvider2.ContainerControl = this;
            this.requirementErrorProvider2.ErrorMessage = "不能为空";
            // 
            // requirementErrorProvider3
            // 
            this.requirementErrorProvider3.BindControl = this.txtPWD;
            this.requirementErrorProvider3.ContainerControl = this;
            this.requirementErrorProvider3.ErrorMessage = "不能为空";
            // 
            // checkFormatErrorProvider1
            // 
            this.checkFormatErrorProvider1.BindControl = this.cboDB;
            this.checkFormatErrorProvider1.CheckType = ComponentControls.Components.CheckFormatErrorProvider.CheckTypeList.WebURL;
            this.checkFormatErrorProvider1.ContainerControl = this;
            this.checkFormatErrorProvider1.ErrorMessage = "格式不正确";
            // 
            // checkFormatErrorProvider2
            // 
            this.checkFormatErrorProvider2.BindControl = this.txtUserName;
            this.checkFormatErrorProvider2.CheckType = ComponentControls.Components.CheckFormatErrorProvider.CheckTypeList.EmailFormat;
            this.checkFormatErrorProvider2.ContainerControl = this;
            this.checkFormatErrorProvider2.ErrorMessage = "格式不正确";
            // 
            // requirementErrorProvider4
            // 
            this.requirementErrorProvider4.BindControl = this.txtCaptchaCode;
            this.requirementErrorProvider4.ContainerControl = this;
            this.requirementErrorProvider4.ErrorMessage = "不能为空";
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 659);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录 - Cloudreve For Windows";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCaptcha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementErrorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementErrorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkFormatErrorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkFormatErrorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requirementErrorProvider4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.CheckBox chkAutoLogin;
        private System.Windows.Forms.CheckBox chkRememberInfo;
        private ComponentControls.Controls.HintTextBox txtUserName;
        private ComponentControls.Controls.HintTextBox txtPWD;
        private System.Windows.Forms.ComboBox cboDB;
        private System.Windows.Forms.PictureBox picCaptcha;
        private ComponentControls.Controls.HintTextBox txtCaptchaCode;
        private ComponentControls.Components.RequirementErrorProvider requirementErrorProvider1;
        private ComponentControls.Components.RequirementErrorProvider requirementErrorProvider2;
        private ComponentControls.Components.RequirementErrorProvider requirementErrorProvider3;
        private ComponentControls.Components.CheckFormatErrorProvider checkFormatErrorProvider1;
        private ComponentControls.Components.CheckFormatErrorProvider checkFormatErrorProvider2;
        private System.Windows.Forms.LinkLabel btnReg;
        private System.Windows.Forms.LinkLabel btnForgotPWD;
        private ComponentControls.Components.RequirementErrorProvider requirementErrorProvider4;
    }
}


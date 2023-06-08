
namespace CloudreveForWindows.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panLeftMenu = new System.Windows.Forms.Panel();
            this.panLeftBottom = new System.Windows.Forms.Panel();
            this.panRightMenu = new System.Windows.Forms.Panel();
            this.panMiddle = new System.Windows.Forms.Panel();
            this.panMiddleBottom = new System.Windows.Forms.Panel();
            this.panMiddleTop = new System.Windows.Forms.Panel();
            this.panMiddleTopMiddle = new System.Windows.Forms.Panel();
            this.lblPath = new System.Windows.Forms.Label();
            this.panMiddleTopRight = new System.Windows.Forms.Panel();
            this.panMiddleTopLeft = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuLeft = new ComponentControls.Controls.NavigateMenu();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShowProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnShowLeftMenu = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colTick = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewImageColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWait = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panTop.SuspendLayout();
            this.panLeftMenu.SuspendLayout();
            this.panMiddle.SuspendLayout();
            this.panMiddleBottom.SuspendLayout();
            this.panMiddleTop.SuspendLayout();
            this.panMiddleTopMiddle.SuspendLayout();
            this.panMiddleTopRight.SuspendLayout();
            this.panMiddleTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowLeftMenu)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panTop
            // 
            this.panTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.panTop.Controls.Add(this.btnShowProfile);
            this.panTop.Controls.Add(this.label1);
            this.panTop.Controls.Add(this.pictureBox2);
            this.panTop.Controls.Add(this.btnShowLeftMenu);
            this.panTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panTop.Location = new System.Drawing.Point(0, 0);
            this.panTop.Name = "panTop";
            this.panTop.Size = new System.Drawing.Size(1317, 56);
            this.panTop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(582, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cloudreve For Windows";
            // 
            // panLeftMenu
            // 
            this.panLeftMenu.Controls.Add(this.menuLeft);
            this.panLeftMenu.Controls.Add(this.panLeftBottom);
            this.panLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLeftMenu.Location = new System.Drawing.Point(0, 56);
            this.panLeftMenu.MaximumSize = new System.Drawing.Size(240, 0);
            this.panLeftMenu.MinimumSize = new System.Drawing.Size(240, 0);
            this.panLeftMenu.Name = "panLeftMenu";
            this.panLeftMenu.Size = new System.Drawing.Size(240, 699);
            this.panLeftMenu.TabIndex = 1;
            // 
            // panLeftBottom
            // 
            this.panLeftBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panLeftBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panLeftBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panLeftBottom.Location = new System.Drawing.Point(0, 590);
            this.panLeftBottom.Name = "panLeftBottom";
            this.panLeftBottom.Size = new System.Drawing.Size(240, 109);
            this.panLeftBottom.TabIndex = 0;
            // 
            // panRightMenu
            // 
            this.panRightMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panRightMenu.Location = new System.Drawing.Point(1077, 56);
            this.panRightMenu.MaximumSize = new System.Drawing.Size(240, 0);
            this.panRightMenu.MinimumSize = new System.Drawing.Size(240, 0);
            this.panRightMenu.Name = "panRightMenu";
            this.panRightMenu.Size = new System.Drawing.Size(240, 699);
            this.panRightMenu.TabIndex = 2;
            this.panRightMenu.Visible = false;
            // 
            // panMiddle
            // 
            this.panMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panMiddle.Controls.Add(this.panMiddleBottom);
            this.panMiddle.Controls.Add(this.panMiddleTop);
            this.panMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMiddle.Location = new System.Drawing.Point(240, 56);
            this.panMiddle.Name = "panMiddle";
            this.panMiddle.Size = new System.Drawing.Size(837, 699);
            this.panMiddle.TabIndex = 3;
            // 
            // panMiddleBottom
            // 
            this.panMiddleBottom.BackColor = System.Drawing.Color.White;
            this.panMiddleBottom.Controls.Add(this.lblWait);
            this.panMiddleBottom.Controls.Add(this.dataGridView1);
            this.panMiddleBottom.Controls.Add(this.panel1);
            this.panMiddleBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMiddleBottom.Location = new System.Drawing.Point(0, 40);
            this.panMiddleBottom.Name = "panMiddleBottom";
            this.panMiddleBottom.Size = new System.Drawing.Size(835, 657);
            this.panMiddleBottom.TabIndex = 2;
            // 
            // panMiddleTop
            // 
            this.panMiddleTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panMiddleTop.Controls.Add(this.panMiddleTopMiddle);
            this.panMiddleTop.Controls.Add(this.panMiddleTopRight);
            this.panMiddleTop.Controls.Add(this.panMiddleTopLeft);
            this.panMiddleTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMiddleTop.Location = new System.Drawing.Point(0, 0);
            this.panMiddleTop.Name = "panMiddleTop";
            this.panMiddleTop.Size = new System.Drawing.Size(835, 40);
            this.panMiddleTop.TabIndex = 1;
            // 
            // panMiddleTopMiddle
            // 
            this.panMiddleTopMiddle.AutoScroll = true;
            this.panMiddleTopMiddle.Controls.Add(this.lblPath);
            this.panMiddleTopMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMiddleTopMiddle.Location = new System.Drawing.Point(40, 0);
            this.panMiddleTopMiddle.Name = "panMiddleTopMiddle";
            this.panMiddleTopMiddle.Size = new System.Drawing.Size(755, 40);
            this.panMiddleTopMiddle.TabIndex = 2;
            // 
            // lblPath
            // 
            this.lblPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPath.Location = new System.Drawing.Point(0, 0);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(755, 40);
            this.lblPath.TabIndex = 0;
            this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panMiddleTopRight
            // 
            this.panMiddleTopRight.Controls.Add(this.pictureBox3);
            this.panMiddleTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panMiddleTopRight.Location = new System.Drawing.Point(795, 0);
            this.panMiddleTopRight.MaximumSize = new System.Drawing.Size(40, 0);
            this.panMiddleTopRight.MinimumSize = new System.Drawing.Size(40, 0);
            this.panMiddleTopRight.Name = "panMiddleTopRight";
            this.panMiddleTopRight.Size = new System.Drawing.Size(40, 40);
            this.panMiddleTopRight.TabIndex = 1;
            // 
            // panMiddleTopLeft
            // 
            this.panMiddleTopLeft.Controls.Add(this.pictureBox1);
            this.panMiddleTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMiddleTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panMiddleTopLeft.Name = "panMiddleTopLeft";
            this.panMiddleTopLeft.Size = new System.Drawing.Size(40, 40);
            this.panMiddleTopLeft.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuLeft
            // 
            this.menuLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuLeft.Location = new System.Drawing.Point(0, 0);
            this.menuLeft.MenuItemBackgroundColor = System.Drawing.Color.White;
            this.menuLeft.MenuItemForeColor = System.Drawing.Color.Black;
            this.menuLeft.MenuItemHeight = 40;
            this.menuLeft.MenuItemMouseOnBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.menuLeft.MenuItemMouseOnForeColor = System.Drawing.Color.Black;
            this.menuLeft.Name = "menuLeft";
            this.menuLeft.Size = new System.Drawing.Size(240, 590);
            this.menuLeft.TabIndex = 1;
            this.menuLeft.MenuItemClick += new ComponentControls.Controls.NavigateMenu.MenuItemClickEvent(this.menuLeft_MenuItemClick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.Image = global::CloudreveForWindows.Properties.Resources.sort;
            this.pictureBox3.Location = new System.Drawing.Point(10, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.Image = global::CloudreveForWindows.Properties.Resources.image_ic_undo_disable;
            this.pictureBox1.Location = new System.Drawing.Point(10, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnShowProfile
            // 
            this.btnShowProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnShowProfile.Image")));
            this.btnShowProfile.Location = new System.Drawing.Point(1264, 14);
            this.btnShowProfile.Name = "btnShowProfile";
            this.btnShowProfile.Size = new System.Drawing.Size(30, 30);
            this.btnShowProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShowProfile.TabIndex = 5;
            this.btnShowProfile.TabStop = false;
            this.toolTip1.SetToolTip(this.btnShowProfile, "显示/隐藏用户信息导航栏");
            this.btnShowProfile.Click += new System.EventHandler(this.btnShowProfile_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = global::CloudreveForWindows.Properties.Resources.Logo;
            this.pictureBox2.Location = new System.Drawing.Point(530, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnShowLeftMenu
            // 
            this.btnShowLeftMenu.Image = global::CloudreveForWindows.Properties.Resources.show_nav_button1_white;
            this.btnShowLeftMenu.Location = new System.Drawing.Point(17, 14);
            this.btnShowLeftMenu.Name = "btnShowLeftMenu";
            this.btnShowLeftMenu.Size = new System.Drawing.Size(30, 30);
            this.btnShowLeftMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShowLeftMenu.TabIndex = 0;
            this.btnShowLeftMenu.TabStop = false;
            this.toolTip1.SetToolTip(this.btnShowLeftMenu, "显示/隐藏导航栏");
            this.btnShowLeftMenu.Click += new System.EventHandler(this.btnShowLeftMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 617);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 40);
            this.panel1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTick,
            this.colType,
            this.colFileName,
            this.colSize,
            this.colModifyDate});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(835, 617);
            this.dataGridView1.TabIndex = 4;
            // 
            // colTick
            // 
            this.colTick.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colTick.DataPropertyName = "Tick";
            this.colTick.HeaderText = "选择";
            this.colTick.Name = "colTick";
            this.colTick.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTick.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colTick.Width = 67;
            // 
            // colType
            // 
            this.colType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colType.DataPropertyName = "TypeImage";
            this.colType.HeaderText = "类型";
            this.colType.Name = "colType";
            this.colType.ReadOnly = true;
            this.colType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colType.Width = 48;
            // 
            // colFileName
            // 
            this.colFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFileName.DataPropertyName = "FileName";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colFileName.DefaultCellStyle = dataGridViewCellStyle10;
            this.colFileName.HeaderText = "文件名";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            // 
            // colSize
            // 
            this.colSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSize.DataPropertyName = "Size";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSize.DefaultCellStyle = dataGridViewCellStyle11;
            this.colSize.HeaderText = "大小";
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            this.colSize.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSize.Width = 67;
            // 
            // colModifyDate
            // 
            this.colModifyDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colModifyDate.DataPropertyName = "ModifyDate";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colModifyDate.DefaultCellStyle = dataGridViewCellStyle12;
            this.colModifyDate.HeaderText = "修改日期";
            this.colModifyDate.Name = "colModifyDate";
            this.colModifyDate.ReadOnly = true;
            this.colModifyDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colModifyDate.Width = 99;
            // 
            // lblWait
            // 
            this.lblWait.Image = global::CloudreveForWindows.Properties.Resources.wait;
            this.lblWait.Location = new System.Drawing.Point(401, 312);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(32, 32);
            this.lblWait.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.label3.Size = new System.Drawing.Size(835, 40);
            this.label3.TabIndex = 0;
            this.label3.Text = "共有 {0} 个项目（ {1} 个文件夹，{2} 个文件）";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1317, 755);
            this.Controls.Add(this.panMiddle);
            this.Controls.Add(this.panRightMenu);
            this.Controls.Add(this.panLeftMenu);
            this.Controls.Add(this.panTop);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloudreve For Windows";
            this.Load += new System.EventHandler(this.Main_Load);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            this.panLeftMenu.ResumeLayout(false);
            this.panMiddle.ResumeLayout(false);
            this.panMiddleBottom.ResumeLayout(false);
            this.panMiddleTop.ResumeLayout(false);
            this.panMiddleTopMiddle.ResumeLayout(false);
            this.panMiddleTopRight.ResumeLayout(false);
            this.panMiddleTopLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowLeftMenu)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panTop;
        private System.Windows.Forms.Panel panLeftMenu;
        private System.Windows.Forms.PictureBox btnShowLeftMenu;
        private System.Windows.Forms.PictureBox btnShowProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panRightMenu;
        private System.Windows.Forms.Panel panMiddle;
        private System.Windows.Forms.Panel panLeftBottom;
        private System.Windows.Forms.Panel panMiddleBottom;
        private System.Windows.Forms.Panel panMiddleTop;
        private System.Windows.Forms.Panel panMiddleTopMiddle;
        private System.Windows.Forms.Panel panMiddleTopRight;
        private System.Windows.Forms.Panel panMiddleTopLeft;
        private ComponentControls.Controls.NavigateMenu menuLeft;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTick;
        private System.Windows.Forms.DataGridViewImageColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModifyDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}
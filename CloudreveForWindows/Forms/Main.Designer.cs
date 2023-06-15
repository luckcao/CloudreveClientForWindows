
using ComponentControls.Controls;
using System.Collections.Generic;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panTop = new System.Windows.Forms.Panel();
            this.btnShowProfile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnShowLeftMenu = new System.Windows.Forms.PictureBox();
            this.panLeftMenu = new System.Windows.Forms.Panel();
            this.menuLeft = new ComponentControls.Controls.NavigateMenu();
            this.panStorageInfo = new System.Windows.Forms.Panel();
            this.lblStorage = new System.Windows.Forms.Label();
            this.prgStorage = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panRightMenu = new System.Windows.Forms.Panel();
            this.panMiddle = new System.Windows.Forms.Panel();
            this.panMyShare = new System.Windows.Forms.Panel();
            this.dgvMyShare = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewButtonColumn4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panMyShareFileCount = new System.Windows.Forms.Panel();
            this.lblMyShareFileCount = new System.Windows.Forms.Label();
            this.panMyShareTop = new System.Windows.Forms.Panel();
            this.我的分享列表 = new System.Windows.Forms.Label();
            this.panMyShareToolBar = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.panUpload = new System.Windows.Forms.Panel();
            this.tfUpload = new ComponentControls.Controls.TransferFile();
            this.panUploadFileCount = new System.Windows.Forms.Panel();
            this.lblUploadFileCount = new System.Windows.Forms.Label();
            this.panUploadTop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panUploadToolBar = new System.Windows.Forms.Panel();
            this.btnStartAllUploadTask = new System.Windows.Forms.PictureBox();
            this.btnUploadSetting = new System.Windows.Forms.PictureBox();
            this.btnDeleteAllUploadTask = new System.Windows.Forms.PictureBox();
            this.btnPauseAllUploadTask = new System.Windows.Forms.PictureBox();
            this.panDownload = new System.Windows.Forms.Panel();
            this.tfDownload = new ComponentControls.Controls.TransferFile();
            this.panDownloadFileCount = new System.Windows.Forms.Panel();
            this.lblDownloadFileCount = new System.Windows.Forms.Label();
            this.panDownloadTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panDownloadToolBar = new System.Windows.Forms.Panel();
            this.btnStartAllDownloadTask = new System.Windows.Forms.PictureBox();
            this.btnDownloadSetting = new System.Windows.Forms.PictureBox();
            this.btnDeleteAllDownloadTask = new System.Windows.Forms.PictureBox();
            this.btnPauseAllDownloadTask = new System.Windows.Forms.PictureBox();
            this.panFileList = new System.Windows.Forms.Panel();
            this.panFileList_FileList = new System.Windows.Forms.Panel();
            this.lblWait = new System.Windows.Forms.Label();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.dgvFileList = new System.Windows.Forms.DataGridView();
            this.colTick = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewImageColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panFileListFileCount = new System.Windows.Forms.Panel();
            this.lblFileListFileCount = new System.Windows.Forms.Label();
            this.panFileListTop = new System.Windows.Forms.Panel();
            this.panMiddleTopMiddle = new System.Windows.Forms.Panel();
            this.directoryPath1 = new ComponentControls.Controls.DirectoryPath();
            this.panFileListToolBar = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnDownload = new System.Windows.Forms.PictureBox();
            this.btnCreateDir = new System.Windows.Forms.PictureBox();
            this.btnSort = new System.Windows.Forms.PictureBox();
            this.panFileListBackPath = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.menuSort = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aZToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最早上传ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最新上传ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最早修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最新修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.最大ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.imglstFileTypeIcon = new System.Windows.Forms.ImageList(this.components);
            this.menuUpload = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.创建目录DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.上传文件UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传目录RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClickedFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.下载WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.分享SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.重命名RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.删除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.transferFile1 = new ComponentControls.Controls.TransferFile();
            this.transferFile2 = new ComponentControls.Controls.TransferFile();
            this.transferFile3 = new ComponentControls.Controls.TransferFile();
            this.transferFile4 = new ComponentControls.Controls.TransferFile();
            this.transferFile5 = new ComponentControls.Controls.TransferFile();
            this.transferFile6 = new ComponentControls.Controls.TransferFile();
            this.timerUpdateProgressBarValue = new System.Windows.Forms.Timer(this.components);
            this.panTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowLeftMenu)).BeginInit();
            this.panLeftMenu.SuspendLayout();
            this.panStorageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panMiddle.SuspendLayout();
            this.panMyShare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyShare)).BeginInit();
            this.panMyShareFileCount.SuspendLayout();
            this.panMyShareTop.SuspendLayout();
            this.panMyShareToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panUpload.SuspendLayout();
            this.panUploadFileCount.SuspendLayout();
            this.panUploadTop.SuspendLayout();
            this.panUploadToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartAllUploadTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUploadSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAllUploadTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPauseAllUploadTask)).BeginInit();
            this.panDownload.SuspendLayout();
            this.panDownloadFileCount.SuspendLayout();
            this.panDownloadTop.SuspendLayout();
            this.panDownloadToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartAllDownloadTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAllDownloadTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPauseAllDownloadTask)).BeginInit();
            this.panFileList.SuspendLayout();
            this.panFileList_FileList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).BeginInit();
            this.panFileListFileCount.SuspendLayout();
            this.panFileListTop.SuspendLayout();
            this.panMiddleTopMiddle.SuspendLayout();
            this.panFileListToolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSort)).BeginInit();
            this.panFileListBackPath.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            this.menuSort.SuspendLayout();
            this.menuUpload.SuspendLayout();
            this.menuClickedFile.SuspendLayout();
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
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(530, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // btnShowLeftMenu
            // 
            this.btnShowLeftMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnShowLeftMenu.Image")));
            this.btnShowLeftMenu.Location = new System.Drawing.Point(17, 14);
            this.btnShowLeftMenu.Name = "btnShowLeftMenu";
            this.btnShowLeftMenu.Size = new System.Drawing.Size(30, 30);
            this.btnShowLeftMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShowLeftMenu.TabIndex = 0;
            this.btnShowLeftMenu.TabStop = false;
            this.toolTip1.SetToolTip(this.btnShowLeftMenu, "显示/隐藏导航栏");
            this.btnShowLeftMenu.Click += new System.EventHandler(this.btnShowLeftMenu_Click);
            // 
            // panLeftMenu
            // 
            this.panLeftMenu.Controls.Add(this.menuLeft);
            this.panLeftMenu.Controls.Add(this.panStorageInfo);
            this.panLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLeftMenu.Location = new System.Drawing.Point(0, 56);
            this.panLeftMenu.MaximumSize = new System.Drawing.Size(240, 0);
            this.panLeftMenu.MinimumSize = new System.Drawing.Size(240, 0);
            this.panLeftMenu.Name = "panLeftMenu";
            this.panLeftMenu.Size = new System.Drawing.Size(240, 699);
            this.panLeftMenu.TabIndex = 1;
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
            // panStorageInfo
            // 
            this.panStorageInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panStorageInfo.Controls.Add(this.lblStorage);
            this.panStorageInfo.Controls.Add(this.prgStorage);
            this.panStorageInfo.Controls.Add(this.label2);
            this.panStorageInfo.Controls.Add(this.pictureBox1);
            this.panStorageInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panStorageInfo.Location = new System.Drawing.Point(0, 590);
            this.panStorageInfo.Name = "panStorageInfo";
            this.panStorageInfo.Size = new System.Drawing.Size(240, 109);
            this.panStorageInfo.TabIndex = 0;
            // 
            // lblStorage
            // 
            this.lblStorage.AutoSize = true;
            this.lblStorage.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblStorage.Location = new System.Drawing.Point(67, 68);
            this.lblStorage.Name = "lblStorage";
            this.lblStorage.Size = new System.Drawing.Size(65, 21);
            this.lblStorage.TabIndex = 3;
            this.lblStorage.Text = "{0} / {1}";
            // 
            // prgStorage
            // 
            this.prgStorage.BackColor = System.Drawing.Color.White;
            this.prgStorage.Location = new System.Drawing.Point(71, 48);
            this.prgStorage.Name = "prgStorage";
            this.prgStorage.Size = new System.Drawing.Size(158, 8);
            this.prgStorage.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(67, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "存储空间";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.panMiddle.Controls.Add(this.panMyShare);
            this.panMiddle.Controls.Add(this.panUpload);
            this.panMiddle.Controls.Add(this.panDownload);
            this.panMiddle.Controls.Add(this.panFileList);
            this.panMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMiddle.Location = new System.Drawing.Point(240, 56);
            this.panMiddle.Name = "panMiddle";
            this.panMiddle.Size = new System.Drawing.Size(837, 699);
            this.panMiddle.TabIndex = 3;
            // 
            // panMyShare
            // 
            this.panMyShare.Controls.Add(this.dgvMyShare);
            this.panMyShare.Controls.Add(this.panMyShareFileCount);
            this.panMyShare.Controls.Add(this.panMyShareTop);
            this.panMyShare.Location = new System.Drawing.Point(410, 0);
            this.panMyShare.Name = "panMyShare";
            this.panMyShare.Size = new System.Drawing.Size(422, 166);
            this.panMyShare.TabIndex = 3;
            this.panMyShare.Visible = false;
            // 
            // dgvMyShare
            // 
            this.dgvMyShare.AllowUserToAddRows = false;
            this.dgvMyShare.AllowUserToDeleteRows = false;
            this.dgvMyShare.AllowUserToResizeColumns = false;
            this.dgvMyShare.AllowUserToResizeRows = false;
            this.dgvMyShare.BackgroundColor = System.Drawing.Color.White;
            this.dgvMyShare.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMyShare.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvMyShare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyShare.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewImageColumn2,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewButtonColumn3,
            this.dataGridViewButtonColumn4});
            this.dgvMyShare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMyShare.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvMyShare.Location = new System.Drawing.Point(0, 50);
            this.dgvMyShare.MultiSelect = false;
            this.dgvMyShare.Name = "dgvMyShare";
            this.dgvMyShare.RowHeadersVisible = false;
            this.dgvMyShare.RowTemplate.Height = 50;
            this.dgvMyShare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMyShare.Size = new System.Drawing.Size(422, 76);
            this.dgvMyShare.TabIndex = 12;
            this.toolTip1.SetToolTip(this.dgvMyShare, "下载");
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "DownloadStatus";
            this.dataGridViewImageColumn2.HeaderText = "操作";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FileName";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridViewTextBoxColumn5.HeaderText = "文件名";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "FileSizeDesc";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn6.DefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridViewTextBoxColumn6.HeaderText = "大小";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn6.Width = 48;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DownloadPercent";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridViewTextBoxColumn7.HeaderText = "下载进度(%)";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn7.Width = 107;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "FileID";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridViewTextBoxColumn8.HeaderText = "文件编号";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn8.Visible = false;
            // 
            // dataGridViewButtonColumn3
            // 
            this.dataGridViewButtonColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewButtonColumn3.DataPropertyName = "OpenFolderDesc";
            this.dataGridViewButtonColumn3.HeaderText = "";
            this.dataGridViewButtonColumn3.Name = "dataGridViewButtonColumn3";
            this.dataGridViewButtonColumn3.ReadOnly = true;
            this.dataGridViewButtonColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewButtonColumn3.Width = 5;
            // 
            // dataGridViewButtonColumn4
            // 
            this.dataGridViewButtonColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewButtonColumn4.DataPropertyName = "DeleteDesc";
            this.dataGridViewButtonColumn4.HeaderText = "";
            this.dataGridViewButtonColumn4.Name = "dataGridViewButtonColumn4";
            this.dataGridViewButtonColumn4.ReadOnly = true;
            this.dataGridViewButtonColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewButtonColumn4.Width = 5;
            // 
            // panMyShareFileCount
            // 
            this.panMyShareFileCount.Controls.Add(this.lblMyShareFileCount);
            this.panMyShareFileCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panMyShareFileCount.Location = new System.Drawing.Point(0, 126);
            this.panMyShareFileCount.Name = "panMyShareFileCount";
            this.panMyShareFileCount.Size = new System.Drawing.Size(422, 40);
            this.panMyShareFileCount.TabIndex = 11;
            // 
            // lblMyShareFileCount
            // 
            this.lblMyShareFileCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMyShareFileCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyShareFileCount.Location = new System.Drawing.Point(0, 0);
            this.lblMyShareFileCount.Name = "lblMyShareFileCount";
            this.lblMyShareFileCount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblMyShareFileCount.Size = new System.Drawing.Size(422, 40);
            this.lblMyShareFileCount.TabIndex = 2;
            this.lblMyShareFileCount.Text = "本页共有 {0} 个分享（ {1} 个文件夹，{2} 个文件）";
            this.lblMyShareFileCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panMyShareTop
            // 
            this.panMyShareTop.Controls.Add(this.我的分享列表);
            this.panMyShareTop.Controls.Add(this.panMyShareToolBar);
            this.panMyShareTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMyShareTop.Location = new System.Drawing.Point(0, 0);
            this.panMyShareTop.Name = "panMyShareTop";
            this.panMyShareTop.Size = new System.Drawing.Size(422, 50);
            this.panMyShareTop.TabIndex = 10;
            // 
            // 我的分享列表
            // 
            this.我的分享列表.AutoSize = true;
            this.我的分享列表.Location = new System.Drawing.Point(4, 14);
            this.我的分享列表.Name = "我的分享列表";
            this.我的分享列表.Size = new System.Drawing.Size(106, 22);
            this.我的分享列表.TabIndex = 4;
            this.我的分享列表.Text = "我的分享列表";
            // 
            // panMyShareToolBar
            // 
            this.panMyShareToolBar.BackColor = System.Drawing.Color.White;
            this.panMyShareToolBar.Controls.Add(this.pictureBox3);
            this.panMyShareToolBar.Controls.Add(this.pictureBox4);
            this.panMyShareToolBar.Controls.Add(this.pictureBox5);
            this.panMyShareToolBar.Controls.Add(this.pictureBox6);
            this.panMyShareToolBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panMyShareToolBar.Location = new System.Drawing.Point(262, 0);
            this.panMyShareToolBar.MaximumSize = new System.Drawing.Size(160, 0);
            this.panMyShareToolBar.MinimumSize = new System.Drawing.Size(160, 0);
            this.panMyShareToolBar.Name = "panMyShareToolBar";
            this.panMyShareToolBar.Size = new System.Drawing.Size(160, 50);
            this.panMyShareToolBar.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.Image = global::CloudreveForWindows.Properties.Resources.start_task;
            this.pictureBox3.Location = new System.Drawing.Point(10, 15);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "全部开始");
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(131, 15);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "设置");
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(93, 15);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "清空列表");
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox6.Image = global::CloudreveForWindows.Properties.Resources.pause_task;
            this.pictureBox6.Location = new System.Drawing.Point(51, 15);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox6, "全部停止");
            // 
            // panUpload
            // 
            this.panUpload.Controls.Add(this.tfUpload);
            this.panUpload.Controls.Add(this.panUploadFileCount);
            this.panUpload.Controls.Add(this.panUploadTop);
            this.panUpload.Location = new System.Drawing.Point(275, 363);
            this.panUpload.Name = "panUpload";
            this.panUpload.Size = new System.Drawing.Size(557, 156);
            this.panUpload.TabIndex = 2;
            this.panUpload.Visible = false;
            // 
            // tfUpload
            // 
            this.tfUpload.AutoScroll = true;
            this.tfUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tfUpload.Location = new System.Drawing.Point(0, 50);
            this.tfUpload.Name = "tfUpload";
            this.tfUpload.Size = new System.Drawing.Size(557, 66);
            this.tfUpload.TabIndex = 12;
            // 
            // panUploadFileCount
            // 
            this.panUploadFileCount.Controls.Add(this.lblUploadFileCount);
            this.panUploadFileCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panUploadFileCount.Location = new System.Drawing.Point(0, 116);
            this.panUploadFileCount.Name = "panUploadFileCount";
            this.panUploadFileCount.Size = new System.Drawing.Size(557, 40);
            this.panUploadFileCount.TabIndex = 11;
            // 
            // lblUploadFileCount
            // 
            this.lblUploadFileCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUploadFileCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUploadFileCount.Location = new System.Drawing.Point(0, 0);
            this.lblUploadFileCount.Name = "lblUploadFileCount";
            this.lblUploadFileCount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblUploadFileCount.Size = new System.Drawing.Size(557, 40);
            this.lblUploadFileCount.TabIndex = 2;
            this.lblUploadFileCount.Text = "共有 {0} 个上传任务（ {1} 个停止，{2} 个正在上传， {3}个上传完成）";
            this.lblUploadFileCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panUploadTop
            // 
            this.panUploadTop.Controls.Add(this.label4);
            this.panUploadTop.Controls.Add(this.panUploadToolBar);
            this.panUploadTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panUploadTop.Location = new System.Drawing.Point(0, 0);
            this.panUploadTop.Name = "panUploadTop";
            this.panUploadTop.Size = new System.Drawing.Size(557, 50);
            this.panUploadTop.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "上传任务列表";
            // 
            // panUploadToolBar
            // 
            this.panUploadToolBar.BackColor = System.Drawing.Color.White;
            this.panUploadToolBar.Controls.Add(this.btnStartAllUploadTask);
            this.panUploadToolBar.Controls.Add(this.btnUploadSetting);
            this.panUploadToolBar.Controls.Add(this.btnDeleteAllUploadTask);
            this.panUploadToolBar.Controls.Add(this.btnPauseAllUploadTask);
            this.panUploadToolBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panUploadToolBar.Location = new System.Drawing.Point(397, 0);
            this.panUploadToolBar.MaximumSize = new System.Drawing.Size(160, 0);
            this.panUploadToolBar.MinimumSize = new System.Drawing.Size(160, 0);
            this.panUploadToolBar.Name = "panUploadToolBar";
            this.panUploadToolBar.Size = new System.Drawing.Size(160, 50);
            this.panUploadToolBar.TabIndex = 2;
            // 
            // btnStartAllUploadTask
            // 
            this.btnStartAllUploadTask.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStartAllUploadTask.Image = global::CloudreveForWindows.Properties.Resources.start_task;
            this.btnStartAllUploadTask.Location = new System.Drawing.Point(10, 15);
            this.btnStartAllUploadTask.Name = "btnStartAllUploadTask";
            this.btnStartAllUploadTask.Size = new System.Drawing.Size(20, 20);
            this.btnStartAllUploadTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStartAllUploadTask.TabIndex = 14;
            this.btnStartAllUploadTask.TabStop = false;
            this.toolTip1.SetToolTip(this.btnStartAllUploadTask, "全部开始");
            // 
            // btnUploadSetting
            // 
            this.btnUploadSetting.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnUploadSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnUploadSetting.Image")));
            this.btnUploadSetting.Location = new System.Drawing.Point(131, 15);
            this.btnUploadSetting.Name = "btnUploadSetting";
            this.btnUploadSetting.Size = new System.Drawing.Size(20, 20);
            this.btnUploadSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUploadSetting.TabIndex = 13;
            this.btnUploadSetting.TabStop = false;
            this.toolTip1.SetToolTip(this.btnUploadSetting, "设置");
            // 
            // btnDeleteAllUploadTask
            // 
            this.btnDeleteAllUploadTask.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeleteAllUploadTask.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllUploadTask.Image")));
            this.btnDeleteAllUploadTask.Location = new System.Drawing.Point(93, 15);
            this.btnDeleteAllUploadTask.Name = "btnDeleteAllUploadTask";
            this.btnDeleteAllUploadTask.Size = new System.Drawing.Size(20, 20);
            this.btnDeleteAllUploadTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeleteAllUploadTask.TabIndex = 12;
            this.btnDeleteAllUploadTask.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDeleteAllUploadTask, "清空列表");
            // 
            // btnPauseAllUploadTask
            // 
            this.btnPauseAllUploadTask.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPauseAllUploadTask.Image = global::CloudreveForWindows.Properties.Resources.pause_task;
            this.btnPauseAllUploadTask.Location = new System.Drawing.Point(51, 15);
            this.btnPauseAllUploadTask.Name = "btnPauseAllUploadTask";
            this.btnPauseAllUploadTask.Size = new System.Drawing.Size(20, 20);
            this.btnPauseAllUploadTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPauseAllUploadTask.TabIndex = 10;
            this.btnPauseAllUploadTask.TabStop = false;
            this.toolTip1.SetToolTip(this.btnPauseAllUploadTask, "全部停止");
            // 
            // panDownload
            // 
            this.panDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panDownload.Controls.Add(this.tfDownload);
            this.panDownload.Controls.Add(this.panDownloadFileCount);
            this.panDownload.Controls.Add(this.panDownloadTop);
            this.panDownload.Location = new System.Drawing.Point(275, 183);
            this.panDownload.Name = "panDownload";
            this.panDownload.Size = new System.Drawing.Size(557, 161);
            this.panDownload.TabIndex = 1;
            this.panDownload.Visible = false;
            // 
            // tfDownload
            // 
            this.tfDownload.AutoScroll = true;
            this.tfDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tfDownload.Location = new System.Drawing.Point(0, 50);
            this.tfDownload.Name = "tfDownload";
            this.tfDownload.Size = new System.Drawing.Size(557, 71);
            this.tfDownload.TabIndex = 11;
            // 
            // panDownloadFileCount
            // 
            this.panDownloadFileCount.Controls.Add(this.lblDownloadFileCount);
            this.panDownloadFileCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panDownloadFileCount.Location = new System.Drawing.Point(0, 121);
            this.panDownloadFileCount.Name = "panDownloadFileCount";
            this.panDownloadFileCount.Size = new System.Drawing.Size(557, 40);
            this.panDownloadFileCount.TabIndex = 10;
            // 
            // lblDownloadFileCount
            // 
            this.lblDownloadFileCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDownloadFileCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDownloadFileCount.Location = new System.Drawing.Point(0, 0);
            this.lblDownloadFileCount.Name = "lblDownloadFileCount";
            this.lblDownloadFileCount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblDownloadFileCount.Size = new System.Drawing.Size(557, 40);
            this.lblDownloadFileCount.TabIndex = 1;
            this.lblDownloadFileCount.Text = "共有 {0} 个下载任务（ {1} 个停止，{2} 个正在下载， {3}个下载完成）";
            this.lblDownloadFileCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panDownloadTop
            // 
            this.panDownloadTop.Controls.Add(this.label3);
            this.panDownloadTop.Controls.Add(this.panDownloadToolBar);
            this.panDownloadTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDownloadTop.Location = new System.Drawing.Point(0, 0);
            this.panDownloadTop.Name = "panDownloadTop";
            this.panDownloadTop.Size = new System.Drawing.Size(557, 50);
            this.panDownloadTop.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "下载任务列表";
            // 
            // panDownloadToolBar
            // 
            this.panDownloadToolBar.BackColor = System.Drawing.Color.White;
            this.panDownloadToolBar.Controls.Add(this.btnStartAllDownloadTask);
            this.panDownloadToolBar.Controls.Add(this.btnDownloadSetting);
            this.panDownloadToolBar.Controls.Add(this.btnDeleteAllDownloadTask);
            this.panDownloadToolBar.Controls.Add(this.btnPauseAllDownloadTask);
            this.panDownloadToolBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panDownloadToolBar.Location = new System.Drawing.Point(397, 0);
            this.panDownloadToolBar.MaximumSize = new System.Drawing.Size(160, 0);
            this.panDownloadToolBar.MinimumSize = new System.Drawing.Size(160, 0);
            this.panDownloadToolBar.Name = "panDownloadToolBar";
            this.panDownloadToolBar.Size = new System.Drawing.Size(160, 50);
            this.panDownloadToolBar.TabIndex = 2;
            // 
            // btnStartAllDownloadTask
            // 
            this.btnStartAllDownloadTask.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnStartAllDownloadTask.Image = global::CloudreveForWindows.Properties.Resources.start_task;
            this.btnStartAllDownloadTask.Location = new System.Drawing.Point(10, 15);
            this.btnStartAllDownloadTask.Name = "btnStartAllDownloadTask";
            this.btnStartAllDownloadTask.Size = new System.Drawing.Size(20, 20);
            this.btnStartAllDownloadTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnStartAllDownloadTask.TabIndex = 14;
            this.btnStartAllDownloadTask.TabStop = false;
            this.toolTip1.SetToolTip(this.btnStartAllDownloadTask, "全部开始");
            this.btnStartAllDownloadTask.Click += new System.EventHandler(this.btnStartAllDownloadTask_Click);
            // 
            // btnDownloadSetting
            // 
            this.btnDownloadSetting.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDownloadSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnDownloadSetting.Image")));
            this.btnDownloadSetting.Location = new System.Drawing.Point(131, 15);
            this.btnDownloadSetting.Name = "btnDownloadSetting";
            this.btnDownloadSetting.Size = new System.Drawing.Size(20, 20);
            this.btnDownloadSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDownloadSetting.TabIndex = 13;
            this.btnDownloadSetting.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDownloadSetting, "设置");
            // 
            // btnDeleteAllDownloadTask
            // 
            this.btnDeleteAllDownloadTask.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeleteAllDownloadTask.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllDownloadTask.Image")));
            this.btnDeleteAllDownloadTask.Location = new System.Drawing.Point(93, 15);
            this.btnDeleteAllDownloadTask.Name = "btnDeleteAllDownloadTask";
            this.btnDeleteAllDownloadTask.Size = new System.Drawing.Size(20, 20);
            this.btnDeleteAllDownloadTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeleteAllDownloadTask.TabIndex = 12;
            this.btnDeleteAllDownloadTask.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDeleteAllDownloadTask, "清空列表");
            this.btnDeleteAllDownloadTask.Click += new System.EventHandler(this.btnDeleteAllDownloadTask_Click);
            // 
            // btnPauseAllDownloadTask
            // 
            this.btnPauseAllDownloadTask.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPauseAllDownloadTask.Image = global::CloudreveForWindows.Properties.Resources.pause_task;
            this.btnPauseAllDownloadTask.Location = new System.Drawing.Point(51, 15);
            this.btnPauseAllDownloadTask.Name = "btnPauseAllDownloadTask";
            this.btnPauseAllDownloadTask.Size = new System.Drawing.Size(20, 20);
            this.btnPauseAllDownloadTask.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnPauseAllDownloadTask.TabIndex = 10;
            this.btnPauseAllDownloadTask.TabStop = false;
            this.toolTip1.SetToolTip(this.btnPauseAllDownloadTask, "全部停止");
            this.btnPauseAllDownloadTask.Click += new System.EventHandler(this.btnPauseAllDownloadTask_Click);
            // 
            // panFileList
            // 
            this.panFileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panFileList.Controls.Add(this.panFileList_FileList);
            this.panFileList.Controls.Add(this.panFileListTop);
            this.panFileList.Location = new System.Drawing.Point(0, 0);
            this.panFileList.Name = "panFileList";
            this.panFileList.Size = new System.Drawing.Size(406, 166);
            this.panFileList.TabIndex = 0;
            // 
            // panFileList_FileList
            // 
            this.panFileList_FileList.BackColor = System.Drawing.Color.White;
            this.panFileList_FileList.Controls.Add(this.lblWait);
            this.panFileList_FileList.Controls.Add(this.chkSelectAll);
            this.panFileList_FileList.Controls.Add(this.dgvFileList);
            this.panFileList_FileList.Controls.Add(this.panFileListFileCount);
            this.panFileList_FileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFileList_FileList.Location = new System.Drawing.Point(0, 50);
            this.panFileList_FileList.Name = "panFileList_FileList";
            this.panFileList_FileList.Size = new System.Drawing.Size(406, 116);
            this.panFileList_FileList.TabIndex = 2;
            // 
            // lblWait
            // 
            this.lblWait.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWait.Image = ((System.Drawing.Image)(resources.GetObject("lblWait.Image")));
            this.lblWait.Location = new System.Drawing.Point(187, 42);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(32, 32);
            this.lblWait.TabIndex = 7;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.AutoSize = true;
            this.chkSelectAll.BackColor = System.Drawing.Color.Transparent;
            this.chkSelectAll.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chkSelectAll.Location = new System.Drawing.Point(6, 8);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(15, 14);
            this.chkSelectAll.TabIndex = 6;
            this.chkSelectAll.ThreeState = true;
            this.chkSelectAll.UseVisualStyleBackColor = false;
            this.chkSelectAll.CheckStateChanged += new System.EventHandler(this.chkSelectAll_CheckStateChanged);
            // 
            // dgvFileList
            // 
            this.dgvFileList.AllowUserToAddRows = false;
            this.dgvFileList.AllowUserToDeleteRows = false;
            this.dgvFileList.AllowUserToResizeColumns = false;
            this.dgvFileList.AllowUserToResizeRows = false;
            this.dgvFileList.BackgroundColor = System.Drawing.Color.White;
            this.dgvFileList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFileList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvFileList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFileList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colTick,
            this.colType,
            this.colFileName,
            this.colSize,
            this.colModifyDate});
            this.dgvFileList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFileList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvFileList.Location = new System.Drawing.Point(0, 0);
            this.dgvFileList.MultiSelect = false;
            this.dgvFileList.Name = "dgvFileList";
            this.dgvFileList.RowHeadersVisible = false;
            this.dgvFileList.RowTemplate.Height = 50;
            this.dgvFileList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFileList.Size = new System.Drawing.Size(406, 76);
            this.dgvFileList.TabIndex = 4;
            this.toolTip1.SetToolTip(this.dgvFileList, "下载");
            this.dgvFileList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFileList_CellDoubleClick);
            this.dgvFileList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFileList_CellMouseDown);
            this.dgvFileList.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFileList_CellValueChanged);
            this.dgvFileList.CurrentCellDirtyStateChanged += new System.EventHandler(this.dgvFileList_CurrentCellDirtyStateChanged);
            // 
            // colTick
            // 
            this.colTick.DataPropertyName = "Tick";
            this.colTick.HeaderText = "选择";
            this.colTick.Name = "colTick";
            this.colTick.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTick.Width = 80;
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colFileName.DefaultCellStyle = dataGridViewCellStyle16;
            this.colFileName.HeaderText = "文件名";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            this.colFileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colSize
            // 
            this.colSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colSize.DataPropertyName = "SizeDesc";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSize.DefaultCellStyle = dataGridViewCellStyle17;
            this.colSize.HeaderText = "大小";
            this.colSize.Name = "colSize";
            this.colSize.ReadOnly = true;
            this.colSize.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSize.Width = 48;
            // 
            // colModifyDate
            // 
            this.colModifyDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colModifyDate.DataPropertyName = "ModifyDate";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colModifyDate.DefaultCellStyle = dataGridViewCellStyle18;
            this.colModifyDate.HeaderText = "修改日期";
            this.colModifyDate.Name = "colModifyDate";
            this.colModifyDate.ReadOnly = true;
            this.colModifyDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colModifyDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colModifyDate.Width = 80;
            // 
            // panFileListFileCount
            // 
            this.panFileListFileCount.Controls.Add(this.lblFileListFileCount);
            this.panFileListFileCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFileListFileCount.Location = new System.Drawing.Point(0, 76);
            this.panFileListFileCount.Name = "panFileListFileCount";
            this.panFileListFileCount.Size = new System.Drawing.Size(406, 40);
            this.panFileListFileCount.TabIndex = 3;
            // 
            // lblFileListFileCount
            // 
            this.lblFileListFileCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileListFileCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileListFileCount.Location = new System.Drawing.Point(0, 0);
            this.lblFileListFileCount.Name = "lblFileListFileCount";
            this.lblFileListFileCount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblFileListFileCount.Size = new System.Drawing.Size(406, 40);
            this.lblFileListFileCount.TabIndex = 0;
            this.lblFileListFileCount.Text = "共有 {0} 个项目（ {1} 个文件夹，{2} 个文件）";
            this.lblFileListFileCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panFileListTop
            // 
            this.panFileListTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panFileListTop.Controls.Add(this.panMiddleTopMiddle);
            this.panFileListTop.Controls.Add(this.panFileListToolBar);
            this.panFileListTop.Controls.Add(this.panFileListBackPath);
            this.panFileListTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panFileListTop.Location = new System.Drawing.Point(0, 0);
            this.panFileListTop.Name = "panFileListTop";
            this.panFileListTop.Size = new System.Drawing.Size(406, 50);
            this.panFileListTop.TabIndex = 1;
            // 
            // panMiddleTopMiddle
            // 
            this.panMiddleTopMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panMiddleTopMiddle.Controls.Add(this.directoryPath1);
            this.panMiddleTopMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMiddleTopMiddle.Location = new System.Drawing.Point(40, 0);
            this.panMiddleTopMiddle.Name = "panMiddleTopMiddle";
            this.panMiddleTopMiddle.Size = new System.Drawing.Size(126, 50);
            this.panMiddleTopMiddle.TabIndex = 2;
            // 
            // directoryPath1
            // 
            this.directoryPath1.AutoScroll = true;
            this.directoryPath1.AutoScrollMinSize = new System.Drawing.Size(670, 50);
            this.directoryPath1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryPath1.Location = new System.Drawing.Point(0, 0);
            this.directoryPath1.Name = "directoryPath1";
            this.directoryPath1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.directoryPath1.Size = new System.Drawing.Size(126, 50);
            this.directoryPath1.TabIndex = 0;
            this.directoryPath1.PathItemClick += new ComponentControls.Controls.DirectoryPath.PathItemClickedEvent(this.directoryPath1_PathItemClick);
            // 
            // panFileListToolBar
            // 
            this.panFileListToolBar.BackColor = System.Drawing.Color.White;
            this.panFileListToolBar.Controls.Add(this.btnRefresh);
            this.panFileListToolBar.Controls.Add(this.btnSettings);
            this.panFileListToolBar.Controls.Add(this.btnDelete);
            this.panFileListToolBar.Controls.Add(this.btnDownload);
            this.panFileListToolBar.Controls.Add(this.btnCreateDir);
            this.panFileListToolBar.Controls.Add(this.btnSort);
            this.panFileListToolBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panFileListToolBar.Location = new System.Drawing.Point(166, 0);
            this.panFileListToolBar.MaximumSize = new System.Drawing.Size(240, 0);
            this.panFileListToolBar.MinimumSize = new System.Drawing.Size(240, 0);
            this.panFileListToolBar.Name = "panFileListToolBar";
            this.panFileListToolBar.Size = new System.Drawing.Size(240, 50);
            this.panFileListToolBar.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(10, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(20, 20);
            this.btnRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefresh.TabIndex = 14;
            this.btnRefresh.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRefresh, "刷新");
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(212, 15);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(20, 20);
            this.btnSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSettings.TabIndex = 13;
            this.btnSettings.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSettings, "设置");
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(93, 15);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(20, 20);
            this.btnDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDelete.TabIndex = 12;
            this.btnDelete.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDelete, "删除");
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDownload.Image = ((System.Drawing.Image)(resources.GetObject("btnDownload.Image")));
            this.btnDownload.Location = new System.Drawing.Point(133, 15);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(20, 20);
            this.btnDownload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDownload.TabIndex = 11;
            this.btnDownload.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDownload, "下载");
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnCreateDir
            // 
            this.btnCreateDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCreateDir.Image = ((System.Drawing.Image)(resources.GetObject("btnCreateDir.Image")));
            this.btnCreateDir.Location = new System.Drawing.Point(51, 15);
            this.btnCreateDir.Name = "btnCreateDir";
            this.btnCreateDir.Size = new System.Drawing.Size(20, 20);
            this.btnCreateDir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCreateDir.TabIndex = 10;
            this.btnCreateDir.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCreateDir, "创建/上传");
            this.btnCreateDir.Click += new System.EventHandler(this.btnCreateDir_Click);
            // 
            // btnSort
            // 
            this.btnSort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSort.Image = ((System.Drawing.Image)(resources.GetObject("btnSort.Image")));
            this.btnSort.Location = new System.Drawing.Point(172, 15);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(20, 20);
            this.btnSort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnSort.TabIndex = 9;
            this.btnSort.TabStop = false;
            this.toolTip1.SetToolTip(this.btnSort, "排序");
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // panFileListBackPath
            // 
            this.panFileListBackPath.BackColor = System.Drawing.Color.White;
            this.panFileListBackPath.Controls.Add(this.btnBack);
            this.panFileListBackPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.panFileListBackPath.Location = new System.Drawing.Point(0, 0);
            this.panFileListBackPath.Name = "panFileListBackPath";
            this.panFileListBackPath.Size = new System.Drawing.Size(40, 50);
            this.panFileListBackPath.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(8, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(24, 24);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 8;
            this.btnBack.TabStop = false;
            this.toolTip1.SetToolTip(this.btnBack, "返回上一层");
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // menuSort
            // 
            this.menuSort.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZToolStripMenuItem,
            this.zAToolStripMenuItem,
            this.最早上传ToolStripMenuItem,
            this.最新上传ToolStripMenuItem,
            this.最早修改ToolStripMenuItem,
            this.最新修改ToolStripMenuItem,
            this.最小ToolStripMenuItem,
            this.最大ToolStripMenuItem});
            this.menuSort.Name = "contextMenuStrip1";
            this.menuSort.Size = new System.Drawing.Size(125, 180);
            // 
            // aZToolStripMenuItem
            // 
            this.aZToolStripMenuItem.Checked = true;
            this.aZToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.aZToolStripMenuItem.Name = "aZToolStripMenuItem";
            this.aZToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.aZToolStripMenuItem.Tag = "Type, FileName";
            this.aZToolStripMenuItem.Text = "A-Z";
            this.aZToolStripMenuItem.Click += new System.EventHandler(this.SortMenuItem_Click);
            // 
            // zAToolStripMenuItem
            // 
            this.zAToolStripMenuItem.Name = "zAToolStripMenuItem";
            this.zAToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.zAToolStripMenuItem.Tag = "Type, FileName Desc";
            this.zAToolStripMenuItem.Text = "Z-A";
            this.zAToolStripMenuItem.Click += new System.EventHandler(this.SortMenuItem_Click);
            // 
            // 最早上传ToolStripMenuItem
            // 
            this.最早上传ToolStripMenuItem.Name = "最早上传ToolStripMenuItem";
            this.最早上传ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.最早上传ToolStripMenuItem.Tag = "Type, CreateDate";
            this.最早上传ToolStripMenuItem.Text = "最早上传";
            this.最早上传ToolStripMenuItem.Click += new System.EventHandler(this.SortMenuItem_Click);
            // 
            // 最新上传ToolStripMenuItem
            // 
            this.最新上传ToolStripMenuItem.Name = "最新上传ToolStripMenuItem";
            this.最新上传ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.最新上传ToolStripMenuItem.Tag = "Type, CreateDate Desc";
            this.最新上传ToolStripMenuItem.Text = "最新上传";
            this.最新上传ToolStripMenuItem.Click += new System.EventHandler(this.SortMenuItem_Click);
            // 
            // 最早修改ToolStripMenuItem
            // 
            this.最早修改ToolStripMenuItem.Name = "最早修改ToolStripMenuItem";
            this.最早修改ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.最早修改ToolStripMenuItem.Tag = "Type, ModifyDate";
            this.最早修改ToolStripMenuItem.Text = "最早修改";
            this.最早修改ToolStripMenuItem.Click += new System.EventHandler(this.SortMenuItem_Click);
            // 
            // 最新修改ToolStripMenuItem
            // 
            this.最新修改ToolStripMenuItem.Name = "最新修改ToolStripMenuItem";
            this.最新修改ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.最新修改ToolStripMenuItem.Tag = "Type, ModifyDate Desc";
            this.最新修改ToolStripMenuItem.Text = "最新修改";
            this.最新修改ToolStripMenuItem.Click += new System.EventHandler(this.SortMenuItem_Click);
            // 
            // 最小ToolStripMenuItem
            // 
            this.最小ToolStripMenuItem.Name = "最小ToolStripMenuItem";
            this.最小ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.最小ToolStripMenuItem.Tag = "Type, Size";
            this.最小ToolStripMenuItem.Text = "最小";
            this.最小ToolStripMenuItem.Click += new System.EventHandler(this.SortMenuItem_Click);
            // 
            // 最大ToolStripMenuItem
            // 
            this.最大ToolStripMenuItem.Name = "最大ToolStripMenuItem";
            this.最大ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.最大ToolStripMenuItem.Tag = "Type, Size Desc";
            this.最大ToolStripMenuItem.Text = "最大";
            this.最大ToolStripMenuItem.Click += new System.EventHandler(this.SortMenuItem_Click);
            // 
            // imglstFileTypeIcon
            // 
            this.imglstFileTypeIcon.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imglstFileTypeIcon.ImageSize = new System.Drawing.Size(16, 16);
            this.imglstFileTypeIcon.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // menuUpload
            // 
            this.menuUpload.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.创建目录DToolStripMenuItem,
            this.toolStripMenuItem1,
            this.上传文件UToolStripMenuItem,
            this.上传目录RToolStripMenuItem});
            this.menuUpload.Name = "menuUpload";
            this.menuUpload.Size = new System.Drawing.Size(142, 76);
            // 
            // 创建目录DToolStripMenuItem
            // 
            this.创建目录DToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("创建目录DToolStripMenuItem.Image")));
            this.创建目录DToolStripMenuItem.Name = "创建目录DToolStripMenuItem";
            this.创建目录DToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.创建目录DToolStripMenuItem.Text = "创建目录(&D)";
            this.创建目录DToolStripMenuItem.Click += new System.EventHandler(this.创建目录DToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
            // 
            // 上传文件UToolStripMenuItem
            // 
            this.上传文件UToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("上传文件UToolStripMenuItem.Image")));
            this.上传文件UToolStripMenuItem.Name = "上传文件UToolStripMenuItem";
            this.上传文件UToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.上传文件UToolStripMenuItem.Text = "文件上传(&U)";
            // 
            // 上传目录RToolStripMenuItem
            // 
            this.上传目录RToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("上传目录RToolStripMenuItem.Image")));
            this.上传目录RToolStripMenuItem.Name = "上传目录RToolStripMenuItem";
            this.上传目录RToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.上传目录RToolStripMenuItem.Text = "目录上传(&R)";
            // 
            // menuClickedFile
            // 
            this.menuClickedFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开OToolStripMenuItem,
            this.toolStripMenuItem5,
            this.下载WToolStripMenuItem,
            this.toolStripMenuItem2,
            this.分享SToolStripMenuItem,
            this.toolStripMenuItem3,
            this.重命名RToolStripMenuItem,
            this.toolStripMenuItem4,
            this.删除DToolStripMenuItem});
            this.menuClickedFile.Name = "menuClickedFile";
            this.menuClickedFile.Size = new System.Drawing.Size(129, 138);
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Image = global::CloudreveForWindows.Properties.Resources.open_folder;
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(177, 6);
            // 
            // 下载WToolStripMenuItem
            // 
            this.下载WToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("下载WToolStripMenuItem.Image")));
            this.下载WToolStripMenuItem.Name = "下载WToolStripMenuItem";
            this.下载WToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.下载WToolStripMenuItem.Text = "下载(&W)";
            this.下载WToolStripMenuItem.Click += new System.EventHandler(this.下载WToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(177, 6);
            // 
            // 分享SToolStripMenuItem
            // 
            this.分享SToolStripMenuItem.Image = global::CloudreveForWindows.Properties.Resources.share;
            this.分享SToolStripMenuItem.Name = "分享SToolStripMenuItem";
            this.分享SToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.分享SToolStripMenuItem.Text = "分享(&S)";
            this.分享SToolStripMenuItem.Click += new System.EventHandler(this.分享SToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(177, 6);
            // 
            // 重命名RToolStripMenuItem
            // 
            this.重命名RToolStripMenuItem.Image = global::CloudreveForWindows.Properties.Resources.edit;
            this.重命名RToolStripMenuItem.Name = "重命名RToolStripMenuItem";
            this.重命名RToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.重命名RToolStripMenuItem.Text = "重命名(&R)";
            this.重命名RToolStripMenuItem.Click += new System.EventHandler(this.重命名RToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(177, 6);
            // 
            // 删除DToolStripMenuItem
            // 
            this.删除DToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("删除DToolStripMenuItem.Image")));
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            this.删除DToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.删除DToolStripMenuItem.Text = "删除(&D)";
            this.删除DToolStripMenuItem.Click += new System.EventHandler(this.删除DToolStripMenuItem_Click);
            // 
            // transferFile1
            // 
            this.transferFile1.AutoScroll = true;
            this.transferFile1.Location = new System.Drawing.Point(0, 0);
            this.transferFile1.Name = "transferFile1";
            this.transferFile1.Size = new System.Drawing.Size(378, 174);
            this.transferFile1.TabIndex = 0;
            // 
            // transferFile2
            // 
            this.transferFile2.AutoScroll = true;
            this.transferFile2.Location = new System.Drawing.Point(0, 0);
            this.transferFile2.Name = "transferFile2";
            this.transferFile2.Size = new System.Drawing.Size(378, 174);
            this.transferFile2.TabIndex = 0;
            // 
            // transferFile3
            // 
            this.transferFile3.AutoScroll = true;
            this.transferFile3.Location = new System.Drawing.Point(0, 0);
            this.transferFile3.Name = "transferFile3";
            this.transferFile3.Size = new System.Drawing.Size(378, 174);
            this.transferFile3.TabIndex = 0;
            // 
            // transferFile4
            // 
            this.transferFile4.AutoScroll = true;
            this.transferFile4.Location = new System.Drawing.Point(0, 0);
            this.transferFile4.Name = "transferFile4";
            this.transferFile4.Size = new System.Drawing.Size(378, 174);
            this.transferFile4.TabIndex = 0;
            // 
            // transferFile5
            // 
            this.transferFile5.AutoScroll = true;
            this.transferFile5.Location = new System.Drawing.Point(0, 0);
            this.transferFile5.Name = "transferFile5";
            this.transferFile5.Size = new System.Drawing.Size(378, 174);
            this.transferFile5.TabIndex = 0;
            // 
            // transferFile6
            // 
            this.transferFile6.AutoScroll = true;
            this.transferFile6.Location = new System.Drawing.Point(0, 0);
            this.transferFile6.Name = "transferFile6";
            this.transferFile6.Size = new System.Drawing.Size(378, 174);
            this.transferFile6.TabIndex = 0;
            // 
            // timerUpdateProgressBarValue
            // 
            this.timerUpdateProgressBarValue.Interval = 200;
            this.timerUpdateProgressBarValue.Tick += new System.EventHandler(this.timerUpdateProgressBarValue_Tick);
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
            this.Text = "Cloudreve v3.8 For Windows";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.panTop.ResumeLayout(false);
            this.panTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowLeftMenu)).EndInit();
            this.panLeftMenu.ResumeLayout(false);
            this.panStorageInfo.ResumeLayout(false);
            this.panStorageInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panMiddle.ResumeLayout(false);
            this.panMyShare.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyShare)).EndInit();
            this.panMyShareFileCount.ResumeLayout(false);
            this.panMyShareTop.ResumeLayout(false);
            this.panMyShareTop.PerformLayout();
            this.panMyShareToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panUpload.ResumeLayout(false);
            this.panUploadFileCount.ResumeLayout(false);
            this.panUploadTop.ResumeLayout(false);
            this.panUploadTop.PerformLayout();
            this.panUploadToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStartAllUploadTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUploadSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAllUploadTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPauseAllUploadTask)).EndInit();
            this.panDownload.ResumeLayout(false);
            this.panDownloadFileCount.ResumeLayout(false);
            this.panDownloadTop.ResumeLayout(false);
            this.panDownloadTop.PerformLayout();
            this.panDownloadToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnStartAllDownloadTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAllDownloadTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPauseAllDownloadTask)).EndInit();
            this.panFileList.ResumeLayout(false);
            this.panFileList_FileList.ResumeLayout(false);
            this.panFileList_FileList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).EndInit();
            this.panFileListFileCount.ResumeLayout(false);
            this.panFileListTop.ResumeLayout(false);
            this.panMiddleTopMiddle.ResumeLayout(false);
            this.panFileListToolBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSort)).EndInit();
            this.panFileListBackPath.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            this.menuSort.ResumeLayout(false);
            this.menuUpload.ResumeLayout(false);
            this.menuClickedFile.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panStorageInfo;
        private System.Windows.Forms.Panel panFileList_FileList;
        private System.Windows.Forms.Panel panFileListTop;
        private System.Windows.Forms.Panel panMiddleTopMiddle;
        private System.Windows.Forms.Panel panFileListToolBar;
        private System.Windows.Forms.Panel panFileListBackPath;
        private ComponentControls.Controls.NavigateMenu menuLeft;
        private System.Windows.Forms.ContextMenuStrip menuSort;
        private System.Windows.Forms.PictureBox btnSort;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridView dgvFileList;
        private System.Windows.Forms.Panel panFileListFileCount;
        private System.Windows.Forms.Label lblFileListFileCount;
        private System.Windows.Forms.PictureBox btnCreateDir;
        private System.Windows.Forms.PictureBox btnDownload;
        private System.Windows.Forms.ImageList imglstFileTypeIcon;
        private System.Windows.Forms.ToolStripMenuItem aZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最早上传ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最新上传ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最早修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最新修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最大ToolStripMenuItem;
        private ComponentControls.Controls.DirectoryPath directoryPath1;
        private System.Windows.Forms.PictureBox btnDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.ProgressBar prgStorage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnSettings;
        private System.Windows.Forms.PictureBox btnRefresh;
        private System.Windows.Forms.ContextMenuStrip menuUpload;
        private System.Windows.Forms.ToolStripMenuItem 创建目录DToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 上传文件UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 上传目录RToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkSelectAll;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTick;
        private System.Windows.Forms.DataGridViewImageColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModifyDate;
        private System.Windows.Forms.ContextMenuStrip menuClickedFile;
        private System.Windows.Forms.ToolStripMenuItem 打开OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 下载WToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 删除DToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 分享SToolStripMenuItem;
        private System.Windows.Forms.Panel panUpload;
        private System.Windows.Forms.Panel panDownload;
        private System.Windows.Forms.Panel panFileList;
        private System.Windows.Forms.Panel panDownloadFileCount;
        private System.Windows.Forms.Panel panDownloadTop;
        private System.Windows.Forms.Panel panDownloadToolBar;
        private System.Windows.Forms.PictureBox btnStartAllDownloadTask;
        private System.Windows.Forms.PictureBox btnDownloadSetting;
        private System.Windows.Forms.PictureBox btnDeleteAllDownloadTask;
        private System.Windows.Forms.PictureBox btnPauseAllDownloadTask;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.Label lblDownloadFileCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panUploadFileCount;
        private System.Windows.Forms.Label lblUploadFileCount;
        private System.Windows.Forms.Panel panUploadTop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panUploadToolBar;
        private System.Windows.Forms.PictureBox btnStartAllUploadTask;
        private System.Windows.Forms.PictureBox btnUploadSetting;
        private System.Windows.Forms.PictureBox btnDeleteAllUploadTask;
        private System.Windows.Forms.PictureBox btnPauseAllUploadTask;
        private System.Windows.Forms.Panel panMyShare;
        private System.Windows.Forms.DataGridView dgvMyShare;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn3;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn4;
        private System.Windows.Forms.Panel panMyShareFileCount;
        private System.Windows.Forms.Label lblMyShareFileCount;
        private System.Windows.Forms.Panel panMyShareTop;
        private System.Windows.Forms.Label 我的分享列表;
        private System.Windows.Forms.Panel panMyShareToolBar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private TransferFile transferFile1;
        private TransferFile transferFile2;
        private TransferFile transferFile3;
        private TransferFile transferFile4;
        private TransferFile transferFile5;
        private TransferFile transferFile6;
        private TransferFile tfUpload;
        private TransferFile tfDownload;
        private System.Windows.Forms.Timer timerUpdateProgressBarValue;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 重命名RToolStripMenuItem;
    }
}
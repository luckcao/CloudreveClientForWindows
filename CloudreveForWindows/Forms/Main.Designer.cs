﻿
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panLeftMenu = new System.Windows.Forms.Panel();
            this.panStorageInfo = new System.Windows.Forms.Panel();
            this.lblStorage = new System.Windows.Forms.Label();
            this.prgStorage = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panRightMenu = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDetail = new System.Windows.Forms.TabPage();
            this.panDetail_DirFileCount = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDetail_SubFileCount = new System.Windows.Forms.Label();
            this.lblDetail_SubDirCount = new System.Windows.Forms.Label();
            this.lblDetail_Size = new System.Windows.Forms.Label();
            this.lblDetail_Type = new System.Windows.Forms.Label();
            this.lblDetail_StoragePolicy = new System.Windows.Forms.Label();
            this.lblDetail_ModifyDate = new System.Windows.Forms.Label();
            this.lblDetail_CreateDate = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDetail_FileName = new System.Windows.Forms.Label();
            this.tabMy = new System.Windows.Forms.TabPage();
            this.panMiddle = new System.Windows.Forms.Panel();
            this.panMyShare = new System.Windows.Forms.Panel();
            this.panMyShareFileCount = new System.Windows.Forms.Panel();
            this.lblMyShareFileCount = new System.Windows.Forms.Label();
            this.panMyShareTop = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.我的分享列表 = new System.Windows.Forms.Label();
            this.panUpload = new System.Windows.Forms.Panel();
            this.panUploadFileCount = new System.Windows.Forms.Panel();
            this.lblUploadFileCount = new System.Windows.Forms.Label();
            this.panUploadTop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panUploadToolBar = new System.Windows.Forms.Panel();
            this.panDownload = new System.Windows.Forms.Panel();
            this.panDownloadFileCount = new System.Windows.Forms.Panel();
            this.lblDownloadFileCount = new System.Windows.Forms.Label();
            this.panDownloadTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panDownloadToolBar = new System.Windows.Forms.Panel();
            this.panFileList = new System.Windows.Forms.Panel();
            this.panFileList_FileList = new System.Windows.Forms.Panel();
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
            this.panFileListToolBar = new System.Windows.Forms.Panel();
            this.panFileListBackPath = new System.Windows.Forms.Panel();
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuClickedFile = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnRefreshShareFileList = new System.Windows.Forms.PictureBox();
            this.btnShareSetting = new System.Windows.Forms.PictureBox();
            this.btnDeleteAllShareFile = new System.Windows.Forms.PictureBox();
            this.btnStartAllUploadTask = new System.Windows.Forms.PictureBox();
            this.btnUploadSetting = new System.Windows.Forms.PictureBox();
            this.btnDeleteAllUploadTask = new System.Windows.Forms.PictureBox();
            this.btnPauseAllUploadTask = new System.Windows.Forms.PictureBox();
            this.btnStartAllDownloadTask = new System.Windows.Forms.PictureBox();
            this.btnDownloadSetting = new System.Windows.Forms.PictureBox();
            this.btnDeleteAllDownloadTask = new System.Windows.Forms.PictureBox();
            this.btnPauseAllDownloadTask = new System.Windows.Forms.PictureBox();
            this.lblWait = new System.Windows.Forms.Label();
            this.btnRefreshFileList = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnDownload = new System.Windows.Forms.PictureBox();
            this.btnCreateDir = new System.Windows.Forms.PictureBox();
            this.btnSort = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picDetail_FileTypeImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShowProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnShowLeftMenu = new System.Windows.Forms.PictureBox();
            this.创建目录DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传文件UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传目录RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.属性PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分享SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重命名RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sfList = new ComponentControls.Controls.ShareFile();
            this.tfUpload = new ComponentControls.Controls.TransferFile();
            this.tfDownload = new ComponentControls.Controls.TransferFile();
            this.directoryPath1 = new ComponentControls.Controls.DirectoryPath();
            this.menuLeft = new ComponentControls.Controls.NavigateMenu();
            this.panTop.SuspendLayout();
            this.panLeftMenu.SuspendLayout();
            this.panStorageInfo.SuspendLayout();
            this.panRightMenu.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabDetail.SuspendLayout();
            this.panDetail_DirFileCount.SuspendLayout();
            this.panMiddle.SuspendLayout();
            this.panMyShare.SuspendLayout();
            this.panMyShareFileCount.SuspendLayout();
            this.panMyShareTop.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panUpload.SuspendLayout();
            this.panUploadFileCount.SuspendLayout();
            this.panUploadTop.SuspendLayout();
            this.panUploadToolBar.SuspendLayout();
            this.panDownload.SuspendLayout();
            this.panDownloadFileCount.SuspendLayout();
            this.panDownloadTop.SuspendLayout();
            this.panDownloadToolBar.SuspendLayout();
            this.panFileList.SuspendLayout();
            this.panFileList_FileList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).BeginInit();
            this.panFileListFileCount.SuspendLayout();
            this.panFileListTop.SuspendLayout();
            this.panMiddleTopMiddle.SuspendLayout();
            this.panFileListToolBar.SuspendLayout();
            this.panFileListBackPath.SuspendLayout();
            this.menuSort.SuspendLayout();
            this.menuUpload.SuspendLayout();
            this.menuClickedFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshShareFileList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShareSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAllShareFile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartAllUploadTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUploadSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAllUploadTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPauseAllUploadTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartAllDownloadTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAllDownloadTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPauseAllDownloadTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshFileList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetail_FileTypeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowLeftMenu)).BeginInit();
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
            this.panLeftMenu.Controls.Add(this.panStorageInfo);
            this.panLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLeftMenu.Location = new System.Drawing.Point(0, 56);
            this.panLeftMenu.MaximumSize = new System.Drawing.Size(240, 0);
            this.panLeftMenu.MinimumSize = new System.Drawing.Size(240, 0);
            this.panLeftMenu.Name = "panLeftMenu";
            this.panLeftMenu.Size = new System.Drawing.Size(240, 699);
            this.panLeftMenu.TabIndex = 1;
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
            // panRightMenu
            // 
            this.panRightMenu.Controls.Add(this.pictureBox3);
            this.panRightMenu.Controls.Add(this.tabControl1);
            this.panRightMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.panRightMenu.Location = new System.Drawing.Point(1017, 56);
            this.panRightMenu.MaximumSize = new System.Drawing.Size(300, 0);
            this.panRightMenu.MinimumSize = new System.Drawing.Size(300, 0);
            this.panRightMenu.Name = "panRightMenu";
            this.panRightMenu.Size = new System.Drawing.Size(300, 699);
            this.panRightMenu.TabIndex = 2;
            this.panRightMenu.Visible = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDetail);
            this.tabControl1.Controls.Add(this.tabMy);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(300, 699);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabDetail
            // 
            this.tabDetail.Controls.Add(this.panDetail_DirFileCount);
            this.tabDetail.Controls.Add(this.lblDetail_Size);
            this.tabDetail.Controls.Add(this.lblDetail_Type);
            this.tabDetail.Controls.Add(this.lblDetail_StoragePolicy);
            this.tabDetail.Controls.Add(this.lblDetail_ModifyDate);
            this.tabDetail.Controls.Add(this.lblDetail_CreateDate);
            this.tabDetail.Controls.Add(this.label16);
            this.tabDetail.Controls.Add(this.label18);
            this.tabDetail.Controls.Add(this.label10);
            this.tabDetail.Controls.Add(this.label8);
            this.tabDetail.Controls.Add(this.label6);
            this.tabDetail.Controls.Add(this.lblDetail_FileName);
            this.tabDetail.Controls.Add(this.picDetail_FileTypeImage);
            this.tabDetail.Location = new System.Drawing.Point(4, 31);
            this.tabDetail.Name = "tabDetail";
            this.tabDetail.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetail.Size = new System.Drawing.Size(292, 664);
            this.tabDetail.TabIndex = 0;
            this.tabDetail.Text = "详情";
            this.tabDetail.UseVisualStyleBackColor = true;
            // 
            // panDetail_DirFileCount
            // 
            this.panDetail_DirFileCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panDetail_DirFileCount.Controls.Add(this.label12);
            this.panDetail_DirFileCount.Controls.Add(this.label13);
            this.panDetail_DirFileCount.Controls.Add(this.lblDetail_SubFileCount);
            this.panDetail_DirFileCount.Controls.Add(this.lblDetail_SubDirCount);
            this.panDetail_DirFileCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panDetail_DirFileCount.Location = new System.Drawing.Point(0, 455);
            this.panDetail_DirFileCount.Name = "panDetail_DirFileCount";
            this.panDetail_DirFileCount.Size = new System.Drawing.Size(292, 68);
            this.panDetail_DirFileCount.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "包含目录数：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 40);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "包含文件数：";
            // 
            // lblDetail_SubFileCount
            // 
            this.lblDetail_SubFileCount.AutoSize = true;
            this.lblDetail_SubFileCount.Location = new System.Drawing.Point(119, 40);
            this.lblDetail_SubFileCount.Name = "lblDetail_SubFileCount";
            this.lblDetail_SubFileCount.Size = new System.Drawing.Size(0, 20);
            this.lblDetail_SubFileCount.TabIndex = 3;
            // 
            // lblDetail_SubDirCount
            // 
            this.lblDetail_SubDirCount.AutoSize = true;
            this.lblDetail_SubDirCount.Location = new System.Drawing.Point(119, 4);
            this.lblDetail_SubDirCount.Name = "lblDetail_SubDirCount";
            this.lblDetail_SubDirCount.Size = new System.Drawing.Size(0, 20);
            this.lblDetail_SubDirCount.TabIndex = 3;
            // 
            // lblDetail_Size
            // 
            this.lblDetail_Size.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDetail_Size.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDetail_Size.Location = new System.Drawing.Point(89, 403);
            this.lblDetail_Size.Name = "lblDetail_Size";
            this.lblDetail_Size.Size = new System.Drawing.Size(193, 53);
            this.lblDetail_Size.TabIndex = 3;
            // 
            // lblDetail_Type
            // 
            this.lblDetail_Type.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDetail_Type.AutoSize = true;
            this.lblDetail_Type.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDetail_Type.Location = new System.Drawing.Point(90, 291);
            this.lblDetail_Type.Name = "lblDetail_Type";
            this.lblDetail_Type.Size = new System.Drawing.Size(0, 20);
            this.lblDetail_Type.TabIndex = 3;
            // 
            // lblDetail_StoragePolicy
            // 
            this.lblDetail_StoragePolicy.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDetail_StoragePolicy.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDetail_StoragePolicy.Location = new System.Drawing.Point(106, 463);
            this.lblDetail_StoragePolicy.Name = "lblDetail_StoragePolicy";
            this.lblDetail_StoragePolicy.Size = new System.Drawing.Size(179, 50);
            this.lblDetail_StoragePolicy.TabIndex = 3;
            // 
            // lblDetail_ModifyDate
            // 
            this.lblDetail_ModifyDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDetail_ModifyDate.AutoSize = true;
            this.lblDetail_ModifyDate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDetail_ModifyDate.Location = new System.Drawing.Point(90, 366);
            this.lblDetail_ModifyDate.Name = "lblDetail_ModifyDate";
            this.lblDetail_ModifyDate.Size = new System.Drawing.Size(0, 20);
            this.lblDetail_ModifyDate.TabIndex = 3;
            // 
            // lblDetail_CreateDate
            // 
            this.lblDetail_CreateDate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDetail_CreateDate.AutoSize = true;
            this.lblDetail_CreateDate.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDetail_CreateDate.Location = new System.Drawing.Point(90, 330);
            this.lblDetail_CreateDate.Name = "lblDetail_CreateDate";
            this.lblDetail_CreateDate.Size = new System.Drawing.Size(0, 20);
            this.lblDetail_CreateDate.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(10, 291);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 20);
            this.label16.TabIndex = 3;
            this.label16.Text = "类型：";
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(10, 463);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 20);
            this.label18.TabIndex = 3;
            this.label18.Text = "存储策略：";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(10, 366);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "修改于：";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(10, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "创建于：";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(10, 403);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "大小：";
            // 
            // lblDetail_FileName
            // 
            this.lblDetail_FileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDetail_FileName.ForeColor = System.Drawing.Color.Blue;
            this.lblDetail_FileName.Location = new System.Drawing.Point(6, 228);
            this.lblDetail_FileName.Name = "lblDetail_FileName";
            this.lblDetail_FileName.Size = new System.Drawing.Size(278, 45);
            this.lblDetail_FileName.TabIndex = 2;
            this.lblDetail_FileName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabMy
            // 
            this.tabMy.Location = new System.Drawing.Point(4, 22);
            this.tabMy.Name = "tabMy";
            this.tabMy.Padding = new System.Windows.Forms.Padding(3);
            this.tabMy.Size = new System.Drawing.Size(292, 673);
            this.tabMy.TabIndex = 1;
            this.tabMy.Text = "我的";
            this.tabMy.UseVisualStyleBackColor = true;
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
            this.panMiddle.Size = new System.Drawing.Size(777, 699);
            this.panMiddle.TabIndex = 3;
            // 
            // panMyShare
            // 
            this.panMyShare.Controls.Add(this.sfList);
            this.panMyShare.Controls.Add(this.panMyShareFileCount);
            this.panMyShare.Controls.Add(this.panMyShareTop);
            this.panMyShare.Location = new System.Drawing.Point(0, 180);
            this.panMyShare.Name = "panMyShare";
            this.panMyShare.Size = new System.Drawing.Size(726, 166);
            this.panMyShare.TabIndex = 3;
            this.panMyShare.Visible = false;
            // 
            // panMyShareFileCount
            // 
            this.panMyShareFileCount.Controls.Add(this.lblMyShareFileCount);
            this.panMyShareFileCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panMyShareFileCount.Location = new System.Drawing.Point(0, 126);
            this.panMyShareFileCount.Name = "panMyShareFileCount";
            this.panMyShareFileCount.Size = new System.Drawing.Size(726, 40);
            this.panMyShareFileCount.TabIndex = 11;
            // 
            // lblMyShareFileCount
            // 
            this.lblMyShareFileCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMyShareFileCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMyShareFileCount.Location = new System.Drawing.Point(0, 0);
            this.lblMyShareFileCount.Name = "lblMyShareFileCount";
            this.lblMyShareFileCount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblMyShareFileCount.Size = new System.Drawing.Size(726, 40);
            this.lblMyShareFileCount.TabIndex = 2;
            this.lblMyShareFileCount.Text = "本页共有 {0} 个分享（ {1} 个文件夹，{2} 个文件）";
            this.lblMyShareFileCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panMyShareTop
            // 
            this.panMyShareTop.Controls.Add(this.panel1);
            this.panMyShareTop.Controls.Add(this.我的分享列表);
            this.panMyShareTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMyShareTop.Location = new System.Drawing.Point(0, 0);
            this.panMyShareTop.Name = "panMyShareTop";
            this.panMyShareTop.Size = new System.Drawing.Size(726, 50);
            this.panMyShareTop.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnRefreshShareFileList);
            this.panel1.Controls.Add(this.btnShareSetting);
            this.panel1.Controls.Add(this.btnDeleteAllShareFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(606, 0);
            this.panel1.MaximumSize = new System.Drawing.Size(120, 0);
            this.panel1.MinimumSize = new System.Drawing.Size(120, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 50);
            this.panel1.TabIndex = 5;
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
            // panUpload
            // 
            this.panUpload.Controls.Add(this.tfUpload);
            this.panUpload.Controls.Add(this.panUploadFileCount);
            this.panUpload.Controls.Add(this.panUploadTop);
            this.panUpload.Location = new System.Drawing.Point(-1, 541);
            this.panUpload.Name = "panUpload";
            this.panUpload.Size = new System.Drawing.Size(726, 156);
            this.panUpload.TabIndex = 2;
            this.panUpload.Visible = false;
            // 
            // panUploadFileCount
            // 
            this.panUploadFileCount.Controls.Add(this.lblUploadFileCount);
            this.panUploadFileCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panUploadFileCount.Location = new System.Drawing.Point(0, 116);
            this.panUploadFileCount.Name = "panUploadFileCount";
            this.panUploadFileCount.Size = new System.Drawing.Size(726, 40);
            this.panUploadFileCount.TabIndex = 11;
            // 
            // lblUploadFileCount
            // 
            this.lblUploadFileCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUploadFileCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUploadFileCount.Location = new System.Drawing.Point(0, 0);
            this.lblUploadFileCount.Name = "lblUploadFileCount";
            this.lblUploadFileCount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblUploadFileCount.Size = new System.Drawing.Size(726, 40);
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
            this.panUploadTop.Size = new System.Drawing.Size(726, 50);
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
            this.panUploadToolBar.Location = new System.Drawing.Point(566, 0);
            this.panUploadToolBar.MaximumSize = new System.Drawing.Size(160, 0);
            this.panUploadToolBar.MinimumSize = new System.Drawing.Size(160, 0);
            this.panUploadToolBar.Name = "panUploadToolBar";
            this.panUploadToolBar.Size = new System.Drawing.Size(160, 50);
            this.panUploadToolBar.TabIndex = 2;
            // 
            // panDownload
            // 
            this.panDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panDownload.Controls.Add(this.tfDownload);
            this.panDownload.Controls.Add(this.panDownloadFileCount);
            this.panDownload.Controls.Add(this.panDownloadTop);
            this.panDownload.Location = new System.Drawing.Point(-1, 361);
            this.panDownload.Name = "panDownload";
            this.panDownload.Size = new System.Drawing.Size(726, 161);
            this.panDownload.TabIndex = 1;
            this.panDownload.Visible = false;
            // 
            // panDownloadFileCount
            // 
            this.panDownloadFileCount.Controls.Add(this.lblDownloadFileCount);
            this.panDownloadFileCount.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panDownloadFileCount.Location = new System.Drawing.Point(0, 121);
            this.panDownloadFileCount.Name = "panDownloadFileCount";
            this.panDownloadFileCount.Size = new System.Drawing.Size(726, 40);
            this.panDownloadFileCount.TabIndex = 10;
            // 
            // lblDownloadFileCount
            // 
            this.lblDownloadFileCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDownloadFileCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDownloadFileCount.Location = new System.Drawing.Point(0, 0);
            this.lblDownloadFileCount.Name = "lblDownloadFileCount";
            this.lblDownloadFileCount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblDownloadFileCount.Size = new System.Drawing.Size(726, 40);
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
            this.panDownloadTop.Size = new System.Drawing.Size(726, 50);
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
            this.panDownloadToolBar.Location = new System.Drawing.Point(566, 0);
            this.panDownloadToolBar.MaximumSize = new System.Drawing.Size(160, 0);
            this.panDownloadToolBar.MinimumSize = new System.Drawing.Size(160, 0);
            this.panDownloadToolBar.Name = "panDownloadToolBar";
            this.panDownloadToolBar.Size = new System.Drawing.Size(160, 50);
            this.panDownloadToolBar.TabIndex = 2;
            // 
            // panFileList
            // 
            this.panFileList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panFileList.Controls.Add(this.panFileList_FileList);
            this.panFileList.Controls.Add(this.panFileListTop);
            this.panFileList.Location = new System.Drawing.Point(0, 0);
            this.panFileList.Name = "panFileList";
            this.panFileList.Size = new System.Drawing.Size(726, 166);
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
            this.panFileList_FileList.Size = new System.Drawing.Size(726, 116);
            this.panFileList_FileList.TabIndex = 2;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFileList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvFileList.Size = new System.Drawing.Size(726, 76);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colFileName.DefaultCellStyle = dataGridViewCellStyle2;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colSize.DefaultCellStyle = dataGridViewCellStyle3;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colModifyDate.DefaultCellStyle = dataGridViewCellStyle4;
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
            this.panFileListFileCount.Size = new System.Drawing.Size(726, 40);
            this.panFileListFileCount.TabIndex = 3;
            // 
            // lblFileListFileCount
            // 
            this.lblFileListFileCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileListFileCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileListFileCount.Location = new System.Drawing.Point(0, 0);
            this.lblFileListFileCount.Name = "lblFileListFileCount";
            this.lblFileListFileCount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblFileListFileCount.Size = new System.Drawing.Size(726, 40);
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
            this.panFileListTop.Size = new System.Drawing.Size(726, 50);
            this.panFileListTop.TabIndex = 1;
            // 
            // panMiddleTopMiddle
            // 
            this.panMiddleTopMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panMiddleTopMiddle.Controls.Add(this.directoryPath1);
            this.panMiddleTopMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMiddleTopMiddle.Location = new System.Drawing.Point(40, 0);
            this.panMiddleTopMiddle.Name = "panMiddleTopMiddle";
            this.panMiddleTopMiddle.Size = new System.Drawing.Size(446, 50);
            this.panMiddleTopMiddle.TabIndex = 2;
            // 
            // panFileListToolBar
            // 
            this.panFileListToolBar.BackColor = System.Drawing.Color.White;
            this.panFileListToolBar.Controls.Add(this.btnRefreshFileList);
            this.panFileListToolBar.Controls.Add(this.btnSettings);
            this.panFileListToolBar.Controls.Add(this.btnDelete);
            this.panFileListToolBar.Controls.Add(this.btnDownload);
            this.panFileListToolBar.Controls.Add(this.btnCreateDir);
            this.panFileListToolBar.Controls.Add(this.btnSort);
            this.panFileListToolBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panFileListToolBar.Location = new System.Drawing.Point(486, 0);
            this.panFileListToolBar.MaximumSize = new System.Drawing.Size(240, 0);
            this.panFileListToolBar.MinimumSize = new System.Drawing.Size(240, 0);
            this.panFileListToolBar.Name = "panFileListToolBar";
            this.panFileListToolBar.Size = new System.Drawing.Size(240, 50);
            this.panFileListToolBar.TabIndex = 1;
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
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 6);
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
            this.删除DToolStripMenuItem,
            this.toolStripMenuItem6,
            this.属性PToolStripMenuItem});
            this.menuClickedFile.Name = "menuClickedFile";
            this.menuClickedFile.Size = new System.Drawing.Size(129, 166);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(125, 6);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(125, 6);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(125, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(125, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(125, 6);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "所有文件(*.*)|*.*";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnRefreshShareFileList
            // 
            this.btnRefreshShareFileList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRefreshShareFileList.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshShareFileList.Image")));
            this.btnRefreshShareFileList.Location = new System.Drawing.Point(10, 15);
            this.btnRefreshShareFileList.Name = "btnRefreshShareFileList";
            this.btnRefreshShareFileList.Size = new System.Drawing.Size(20, 20);
            this.btnRefreshShareFileList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefreshShareFileList.TabIndex = 15;
            this.btnRefreshShareFileList.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRefreshShareFileList, "刷新");
            this.btnRefreshShareFileList.Click += new System.EventHandler(this.btnRefreshShareFileList_Click);
            // 
            // btnShareSetting
            // 
            this.btnShareSetting.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnShareSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnShareSetting.Image")));
            this.btnShareSetting.Location = new System.Drawing.Point(91, 15);
            this.btnShareSetting.Name = "btnShareSetting";
            this.btnShareSetting.Size = new System.Drawing.Size(20, 20);
            this.btnShareSetting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShareSetting.TabIndex = 13;
            this.btnShareSetting.TabStop = false;
            this.toolTip1.SetToolTip(this.btnShareSetting, "设置");
            // 
            // btnDeleteAllShareFile
            // 
            this.btnDeleteAllShareFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnDeleteAllShareFile.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteAllShareFile.Image")));
            this.btnDeleteAllShareFile.Location = new System.Drawing.Point(53, 15);
            this.btnDeleteAllShareFile.Name = "btnDeleteAllShareFile";
            this.btnDeleteAllShareFile.Size = new System.Drawing.Size(20, 20);
            this.btnDeleteAllShareFile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDeleteAllShareFile.TabIndex = 12;
            this.btnDeleteAllShareFile.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDeleteAllShareFile, "取消所有分享");
            this.btnDeleteAllShareFile.Click += new System.EventHandler(this.btnDeleteAllShareFile_Click);
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
            this.btnStartAllUploadTask.Click += new System.EventHandler(this.btnStartAllUploadTask_Click);
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
            this.btnDeleteAllUploadTask.Click += new System.EventHandler(this.btnDeleteAllUploadTask_Click);
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
            this.btnPauseAllUploadTask.Click += new System.EventHandler(this.btnPauseAllUploadTask_Click);
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
            // lblWait
            // 
            this.lblWait.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWait.Image = ((System.Drawing.Image)(resources.GetObject("lblWait.Image")));
            this.lblWait.Location = new System.Drawing.Point(347, 37);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(32, 32);
            this.lblWait.TabIndex = 7;
            // 
            // btnRefreshFileList
            // 
            this.btnRefreshFileList.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRefreshFileList.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshFileList.Image")));
            this.btnRefreshFileList.Location = new System.Drawing.Point(10, 15);
            this.btnRefreshFileList.Name = "btnRefreshFileList";
            this.btnRefreshFileList.Size = new System.Drawing.Size(20, 20);
            this.btnRefreshFileList.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRefreshFileList.TabIndex = 14;
            this.btnRefreshFileList.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRefreshFileList, "刷新");
            this.btnRefreshFileList.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::CloudreveForWindows.Properties.Resources.close;
            this.pictureBox3.Location = new System.Drawing.Point(274, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "刷新");
            // 
            // picDetail_FileTypeImage
            // 
            this.picDetail_FileTypeImage.Location = new System.Drawing.Point(42, 55);
            this.picDetail_FileTypeImage.Name = "picDetail_FileTypeImage";
            this.picDetail_FileTypeImage.Size = new System.Drawing.Size(208, 172);
            this.picDetail_FileTypeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDetail_FileTypeImage.TabIndex = 1;
            this.picDetail_FileTypeImage.TabStop = false;
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
            // 创建目录DToolStripMenuItem
            // 
            this.创建目录DToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("创建目录DToolStripMenuItem.Image")));
            this.创建目录DToolStripMenuItem.Name = "创建目录DToolStripMenuItem";
            this.创建目录DToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.创建目录DToolStripMenuItem.Text = "创建目录(&D)";
            this.创建目录DToolStripMenuItem.Click += new System.EventHandler(this.创建目录DToolStripMenuItem_Click);
            // 
            // 上传文件UToolStripMenuItem
            // 
            this.上传文件UToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("上传文件UToolStripMenuItem.Image")));
            this.上传文件UToolStripMenuItem.Name = "上传文件UToolStripMenuItem";
            this.上传文件UToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.上传文件UToolStripMenuItem.Text = "文件上传(&U)";
            this.上传文件UToolStripMenuItem.Click += new System.EventHandler(this.上传文件UToolStripMenuItem_Click);
            // 
            // 上传目录RToolStripMenuItem
            // 
            this.上传目录RToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("上传目录RToolStripMenuItem.Image")));
            this.上传目录RToolStripMenuItem.Name = "上传目录RToolStripMenuItem";
            this.上传目录RToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.上传目录RToolStripMenuItem.Text = "目录上传(&R)";
            // 
            // 属性PToolStripMenuItem
            // 
            this.属性PToolStripMenuItem.Image = global::CloudreveForWindows.Properties.Resources.information_menu;
            this.属性PToolStripMenuItem.Name = "属性PToolStripMenuItem";
            this.属性PToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.属性PToolStripMenuItem.Text = "属性(&P)";
            this.属性PToolStripMenuItem.Click += new System.EventHandler(this.属性PToolStripMenuItem_Click);
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Image = global::CloudreveForWindows.Properties.Resources.open_folder;
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // 下载WToolStripMenuItem
            // 
            this.下载WToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("下载WToolStripMenuItem.Image")));
            this.下载WToolStripMenuItem.Name = "下载WToolStripMenuItem";
            this.下载WToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.下载WToolStripMenuItem.Text = "下载(&W)";
            this.下载WToolStripMenuItem.Click += new System.EventHandler(this.下载WToolStripMenuItem_Click);
            // 
            // 分享SToolStripMenuItem
            // 
            this.分享SToolStripMenuItem.Image = global::CloudreveForWindows.Properties.Resources.share;
            this.分享SToolStripMenuItem.Name = "分享SToolStripMenuItem";
            this.分享SToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.分享SToolStripMenuItem.Text = "分享(&S)";
            this.分享SToolStripMenuItem.Click += new System.EventHandler(this.分享SToolStripMenuItem_Click);
            // 
            // 重命名RToolStripMenuItem
            // 
            this.重命名RToolStripMenuItem.Image = global::CloudreveForWindows.Properties.Resources.edit;
            this.重命名RToolStripMenuItem.Name = "重命名RToolStripMenuItem";
            this.重命名RToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.重命名RToolStripMenuItem.Text = "重命名(&R)";
            this.重命名RToolStripMenuItem.Click += new System.EventHandler(this.重命名RToolStripMenuItem_Click);
            // 
            // 删除DToolStripMenuItem
            // 
            this.删除DToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("删除DToolStripMenuItem.Image")));
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            this.删除DToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.删除DToolStripMenuItem.Text = "删除(&D)";
            this.删除DToolStripMenuItem.Click += new System.EventHandler(this.删除DToolStripMenuItem_Click);
            // 
            // sfList
            // 
            this.sfList.AutoScroll = true;
            this.sfList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfList.Location = new System.Drawing.Point(0, 50);
            this.sfList.Name = "sfList";
            this.sfList.Size = new System.Drawing.Size(726, 76);
            this.sfList.TabIndex = 12;
            // 
            // tfUpload
            // 
            this.tfUpload.AutoScroll = true;
            this.tfUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tfUpload.Location = new System.Drawing.Point(0, 50);
            this.tfUpload.Name = "tfUpload";
            this.tfUpload.Size = new System.Drawing.Size(726, 66);
            this.tfUpload.TabIndex = 12;
            this.tfUpload.TransferItemDeleted += new ComponentControls.Controls.TransferFile.TransferItemDeletedEvent(this.tfUpload_TransferItemDeleted);
            this.tfUpload.TransferItemCompleted += new ComponentControls.Controls.TransferFile.TransferItemCompletedEvent(this.tfUpload_TransferItemCompleted);
            // 
            // tfDownload
            // 
            this.tfDownload.AutoScroll = true;
            this.tfDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tfDownload.Location = new System.Drawing.Point(0, 50);
            this.tfDownload.Name = "tfDownload";
            this.tfDownload.Size = new System.Drawing.Size(726, 71);
            this.tfDownload.TabIndex = 11;
            this.tfDownload.TransferItemDeleted += new ComponentControls.Controls.TransferFile.TransferItemDeletedEvent(this.tfDownload_TransferItemDeleted);
            this.tfDownload.TransferItemCompleted += new ComponentControls.Controls.TransferFile.TransferItemCompletedEvent(this.tfDownload_TransferItemCompleted);
            // 
            // directoryPath1
            // 
            this.directoryPath1.AutoScroll = true;
            this.directoryPath1.AutoScrollMinSize = new System.Drawing.Size(670, 50);
            this.directoryPath1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryPath1.Location = new System.Drawing.Point(0, 0);
            this.directoryPath1.Name = "directoryPath1";
            this.directoryPath1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.directoryPath1.Size = new System.Drawing.Size(446, 50);
            this.directoryPath1.TabIndex = 0;
            this.directoryPath1.PathItemClick += new ComponentControls.Controls.DirectoryPath.PathItemClickedEvent(this.directoryPath1_PathItemClick);
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
            this.panLeftMenu.ResumeLayout(false);
            this.panStorageInfo.ResumeLayout(false);
            this.panStorageInfo.PerformLayout();
            this.panRightMenu.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabDetail.ResumeLayout(false);
            this.tabDetail.PerformLayout();
            this.panDetail_DirFileCount.ResumeLayout(false);
            this.panDetail_DirFileCount.PerformLayout();
            this.panMiddle.ResumeLayout(false);
            this.panMyShare.ResumeLayout(false);
            this.panMyShareFileCount.ResumeLayout(false);
            this.panMyShareTop.ResumeLayout(false);
            this.panMyShareTop.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panUpload.ResumeLayout(false);
            this.panUploadFileCount.ResumeLayout(false);
            this.panUploadTop.ResumeLayout(false);
            this.panUploadTop.PerformLayout();
            this.panUploadToolBar.ResumeLayout(false);
            this.panDownload.ResumeLayout(false);
            this.panDownloadFileCount.ResumeLayout(false);
            this.panDownloadTop.ResumeLayout(false);
            this.panDownloadTop.PerformLayout();
            this.panDownloadToolBar.ResumeLayout(false);
            this.panFileList.ResumeLayout(false);
            this.panFileList_FileList.ResumeLayout(false);
            this.panFileList_FileList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).EndInit();
            this.panFileListFileCount.ResumeLayout(false);
            this.panFileListTop.ResumeLayout(false);
            this.panMiddleTopMiddle.ResumeLayout(false);
            this.panFileListToolBar.ResumeLayout(false);
            this.panFileListBackPath.ResumeLayout(false);
            this.menuSort.ResumeLayout(false);
            this.menuUpload.ResumeLayout(false);
            this.menuClickedFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshShareFileList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShareSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAllShareFile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartAllUploadTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUploadSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAllUploadTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPauseAllUploadTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnStartAllDownloadTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownloadSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDeleteAllDownloadTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPauseAllDownloadTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefreshFileList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDetail_FileTypeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowLeftMenu)).EndInit();
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
        private System.Windows.Forms.PictureBox btnRefreshFileList;
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
        private System.Windows.Forms.Panel panMyShareFileCount;
        private System.Windows.Forms.Label lblMyShareFileCount;
        private System.Windows.Forms.Panel panMyShareTop;
        private System.Windows.Forms.Label 我的分享列表;
        //private TransferFile transferFile1;
        //private TransferFile transferFile2;
        //private TransferFile transferFile3;
        //private TransferFile transferFile4;
        //private TransferFile transferFile5;
        //private TransferFile transferFile6;
        private TransferFile tfUpload;
        private TransferFile tfDownload;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem 重命名RToolStripMenuItem;
        private ShareFile sfList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnShareSetting;
        private System.Windows.Forms.PictureBox btnDeleteAllShareFile;
        private System.Windows.Forms.PictureBox btnRefreshShareFileList;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDetail;
        private System.Windows.Forms.Label lblDetail_Size;
        private System.Windows.Forms.Label lblDetail_ModifyDate;
        private System.Windows.Forms.Label lblDetail_CreateDate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDetail_FileName;
        private System.Windows.Forms.PictureBox picDetail_FileTypeImage;
        private System.Windows.Forms.TabPage tabMy;
        private System.Windows.Forms.Panel panDetail_DirFileCount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblDetail_SubFileCount;
        private System.Windows.Forms.Label lblDetail_SubDirCount;
        private System.Windows.Forms.Label lblDetail_Type;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblDetail_StoragePolicy;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStripMenuItem 属性PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
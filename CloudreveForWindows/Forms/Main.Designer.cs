
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panLeftMenu = new System.Windows.Forms.Panel();
            this.menuLeft = new ComponentControls.Controls.NavigateMenu();
            this.panLeftBottom = new System.Windows.Forms.Panel();
            this.lblStorage = new System.Windows.Forms.Label();
            this.prgStorage = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.panRightMenu = new System.Windows.Forms.Panel();
            this.panMiddle = new System.Windows.Forms.Panel();
            this.panMiddleBottom = new System.Windows.Forms.Panel();
            this.chkSelectAll = new System.Windows.Forms.CheckBox();
            this.dgvFileList = new System.Windows.Forms.DataGridView();
            this.colTick = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewImageColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModifyDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFileCount = new System.Windows.Forms.Label();
            this.panMiddleTop = new System.Windows.Forms.Panel();
            this.panMiddleTopMiddle = new System.Windows.Forms.Panel();
            this.directoryPath1 = new ComponentControls.Controls.DirectoryPath();
            this.panMiddleTopRight = new System.Windows.Forms.Panel();
            this.panMiddleTopLeft = new System.Windows.Forms.Panel();
            this.dgvDownload = new System.Windows.Forms.DataGridView();
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
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.colDownloadStatus = new System.Windows.Forms.DataGridViewImageColumn();
            this.colDownloadFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDownloadFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDownloadPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOpenFolderDesc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colDeleteDownload = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.lblWait = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.PictureBox();
            this.btnSettings = new System.Windows.Forms.PictureBox();
            this.btnDelete = new System.Windows.Forms.PictureBox();
            this.btnDownload = new System.Windows.Forms.PictureBox();
            this.btnCreateDir = new System.Windows.Forms.PictureBox();
            this.btnSort = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnShowProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnShowLeftMenu = new System.Windows.Forms.PictureBox();
            this.创建目录DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传文件UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.上传目录RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.下载WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分享SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panTop.SuspendLayout();
            this.panLeftMenu.SuspendLayout();
            this.panLeftBottom.SuspendLayout();
            this.panMiddle.SuspendLayout();
            this.panMiddleBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).BeginInit();
            this.panel1.SuspendLayout();
            this.panMiddleTop.SuspendLayout();
            this.panMiddleTopMiddle.SuspendLayout();
            this.panMiddleTopRight.SuspendLayout();
            this.panMiddleTopLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownload)).BeginInit();
            this.menuSort.SuspendLayout();
            this.menuUpload.SuspendLayout();
            this.menuClickedFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
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
            this.panLeftMenu.Controls.Add(this.panLeftBottom);
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
            // panLeftBottom
            // 
            this.panLeftBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panLeftBottom.Controls.Add(this.lblStorage);
            this.panLeftBottom.Controls.Add(this.prgStorage);
            this.panLeftBottom.Controls.Add(this.label2);
            this.panLeftBottom.Controls.Add(this.pictureBox1);
            this.panLeftBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panLeftBottom.Location = new System.Drawing.Point(0, 590);
            this.panLeftBottom.Name = "panLeftBottom";
            this.panLeftBottom.Size = new System.Drawing.Size(240, 109);
            this.panLeftBottom.TabIndex = 0;
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
            this.panMiddle.Controls.Add(this.dgvDownload);
            this.panMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMiddle.Location = new System.Drawing.Point(240, 56);
            this.panMiddle.Name = "panMiddle";
            this.panMiddle.Size = new System.Drawing.Size(837, 699);
            this.panMiddle.TabIndex = 3;
            // 
            // panMiddleBottom
            // 
            this.panMiddleBottom.BackColor = System.Drawing.Color.White;
            this.panMiddleBottom.Controls.Add(this.chkSelectAll);
            this.panMiddleBottom.Controls.Add(this.lblWait);
            this.panMiddleBottom.Controls.Add(this.dgvFileList);
            this.panMiddleBottom.Controls.Add(this.panel1);
            this.panMiddleBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMiddleBottom.Location = new System.Drawing.Point(0, 50);
            this.panMiddleBottom.Name = "panMiddleBottom";
            this.panMiddleBottom.Size = new System.Drawing.Size(835, 647);
            this.panMiddleBottom.TabIndex = 2;
            // 
            // chkSelectAll
            // 
            this.chkSelectAll.BackColor = System.Drawing.Color.Transparent;
            this.chkSelectAll.Location = new System.Drawing.Point(7, 8);
            this.chkSelectAll.Name = "chkSelectAll";
            this.chkSelectAll.Size = new System.Drawing.Size(14, 13);
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
            this.dgvFileList.Size = new System.Drawing.Size(835, 607);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFileCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 607);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 40);
            this.panel1.TabIndex = 3;
            // 
            // lblFileCount
            // 
            this.lblFileCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFileCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFileCount.Location = new System.Drawing.Point(0, 0);
            this.lblFileCount.Name = "lblFileCount";
            this.lblFileCount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblFileCount.Size = new System.Drawing.Size(835, 40);
            this.lblFileCount.TabIndex = 0;
            this.lblFileCount.Text = "共有 {0} 个项目（ {1} 个文件夹，{2} 个文件）";
            this.lblFileCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.panMiddleTop.Size = new System.Drawing.Size(835, 50);
            this.panMiddleTop.TabIndex = 1;
            // 
            // panMiddleTopMiddle
            // 
            this.panMiddleTopMiddle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panMiddleTopMiddle.Controls.Add(this.directoryPath1);
            this.panMiddleTopMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMiddleTopMiddle.Location = new System.Drawing.Point(40, 0);
            this.panMiddleTopMiddle.Name = "panMiddleTopMiddle";
            this.panMiddleTopMiddle.Size = new System.Drawing.Size(555, 50);
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
            this.directoryPath1.Size = new System.Drawing.Size(555, 50);
            this.directoryPath1.TabIndex = 0;
            this.directoryPath1.PathItemClick += new ComponentControls.Controls.DirectoryPath.PathItemClickedEvent(this.directoryPath1_PathItemClick);
            // 
            // panMiddleTopRight
            // 
            this.panMiddleTopRight.BackColor = System.Drawing.Color.White;
            this.panMiddleTopRight.Controls.Add(this.btnRefresh);
            this.panMiddleTopRight.Controls.Add(this.btnSettings);
            this.panMiddleTopRight.Controls.Add(this.btnDelete);
            this.panMiddleTopRight.Controls.Add(this.btnDownload);
            this.panMiddleTopRight.Controls.Add(this.btnCreateDir);
            this.panMiddleTopRight.Controls.Add(this.btnSort);
            this.panMiddleTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panMiddleTopRight.Location = new System.Drawing.Point(595, 0);
            this.panMiddleTopRight.MaximumSize = new System.Drawing.Size(240, 0);
            this.panMiddleTopRight.MinimumSize = new System.Drawing.Size(240, 0);
            this.panMiddleTopRight.Name = "panMiddleTopRight";
            this.panMiddleTopRight.Size = new System.Drawing.Size(240, 50);
            this.panMiddleTopRight.TabIndex = 1;
            // 
            // panMiddleTopLeft
            // 
            this.panMiddleTopLeft.BackColor = System.Drawing.Color.White;
            this.panMiddleTopLeft.Controls.Add(this.btnBack);
            this.panMiddleTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMiddleTopLeft.Location = new System.Drawing.Point(0, 0);
            this.panMiddleTopLeft.Name = "panMiddleTopLeft";
            this.panMiddleTopLeft.Size = new System.Drawing.Size(40, 50);
            this.panMiddleTopLeft.TabIndex = 0;
            // 
            // dgvDownload
            // 
            this.dgvDownload.AllowUserToAddRows = false;
            this.dgvDownload.AllowUserToDeleteRows = false;
            this.dgvDownload.AllowUserToResizeColumns = false;
            this.dgvDownload.AllowUserToResizeRows = false;
            this.dgvDownload.BackgroundColor = System.Drawing.Color.White;
            this.dgvDownload.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDownload.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDownload.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDownload.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDownloadStatus,
            this.colDownloadFileName,
            this.colDownloadFileSize,
            this.colDownloadPercent,
            this.colFileID,
            this.colOpenFolderDesc,
            this.colDeleteDownload});
            this.dgvDownload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDownload.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvDownload.Location = new System.Drawing.Point(0, 0);
            this.dgvDownload.MultiSelect = false;
            this.dgvDownload.Name = "dgvDownload";
            this.dgvDownload.RowHeadersVisible = false;
            this.dgvDownload.RowTemplate.Height = 50;
            this.dgvDownload.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDownload.Size = new System.Drawing.Size(835, 697);
            this.dgvDownload.TabIndex = 8;
            this.toolTip1.SetToolTip(this.dgvDownload, "下载");
            this.dgvDownload.Visible = false;
            this.dgvDownload.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDownload_CellContentClick);
            this.dgvDownload.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvDownload_DataError);
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
            this.toolStripMenuItem2,
            this.下载WToolStripMenuItem,
            this.toolStripMenuItem3,
            this.删除DToolStripMenuItem,
            this.toolStripMenuItem4,
            this.分享SToolStripMenuItem});
            this.menuClickedFile.Name = "menuClickedFile";
            this.menuClickedFile.Size = new System.Drawing.Size(121, 110);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(117, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(117, 6);
            // 
            // colDownloadStatus
            // 
            this.colDownloadStatus.DataPropertyName = "DownloadStatus";
            this.colDownloadStatus.HeaderText = "操作";
            this.colDownloadStatus.Name = "colDownloadStatus";
            this.colDownloadStatus.ReadOnly = true;
            this.colDownloadStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDownloadStatus.Width = 60;
            // 
            // colDownloadFileName
            // 
            this.colDownloadFileName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDownloadFileName.DataPropertyName = "FileName";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colDownloadFileName.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDownloadFileName.HeaderText = "文件名";
            this.colDownloadFileName.Name = "colDownloadFileName";
            this.colDownloadFileName.ReadOnly = true;
            this.colDownloadFileName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDownloadFileName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDownloadFileSize
            // 
            this.colDownloadFileSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDownloadFileSize.DataPropertyName = "FileSizeDesc";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDownloadFileSize.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDownloadFileSize.HeaderText = "大小";
            this.colDownloadFileSize.Name = "colDownloadFileSize";
            this.colDownloadFileSize.ReadOnly = true;
            this.colDownloadFileSize.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDownloadFileSize.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDownloadFileSize.Width = 48;
            // 
            // colDownloadPercent
            // 
            this.colDownloadPercent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDownloadPercent.DataPropertyName = "DownloadPercent";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colDownloadPercent.DefaultCellStyle = dataGridViewCellStyle8;
            this.colDownloadPercent.HeaderText = "下载进度(%)";
            this.colDownloadPercent.Name = "colDownloadPercent";
            this.colDownloadPercent.ReadOnly = true;
            this.colDownloadPercent.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDownloadPercent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDownloadPercent.Width = 107;
            // 
            // colFileID
            // 
            this.colFileID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colFileID.DataPropertyName = "FileID";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colFileID.DefaultCellStyle = dataGridViewCellStyle9;
            this.colFileID.HeaderText = "文件编号";
            this.colFileID.Name = "colFileID";
            this.colFileID.ReadOnly = true;
            this.colFileID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colFileID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFileID.Visible = false;
            this.colFileID.Width = 80;
            // 
            // colOpenFolderDesc
            // 
            this.colOpenFolderDesc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colOpenFolderDesc.DataPropertyName = "OpenFolderDesc";
            this.colOpenFolderDesc.HeaderText = "";
            this.colOpenFolderDesc.Name = "colOpenFolderDesc";
            this.colOpenFolderDesc.ReadOnly = true;
            this.colOpenFolderDesc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colOpenFolderDesc.Width = 5;
            // 
            // colDeleteDownload
            // 
            this.colDeleteDownload.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.colDeleteDownload.DataPropertyName = "DeleteDesc";
            this.colDeleteDownload.HeaderText = "";
            this.colDeleteDownload.Name = "colDeleteDownload";
            this.colDeleteDownload.ReadOnly = true;
            this.colDeleteDownload.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDeleteDownload.Width = 5;
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(117, 6);
            // 
            // lblWait
            // 
            this.lblWait.Image = ((System.Drawing.Image)(resources.GetObject("lblWait.Image")));
            this.lblWait.Location = new System.Drawing.Point(401, 312);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(32, 32);
            this.lblWait.TabIndex = 5;
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
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.Location = new System.Drawing.Point(10, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(20, 20);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 8;
            this.btnBack.TabStop = false;
            this.toolTip1.SetToolTip(this.btnBack, "返回上一层");
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // 
            // 上传目录RToolStripMenuItem
            // 
            this.上传目录RToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("上传目录RToolStripMenuItem.Image")));
            this.上传目录RToolStripMenuItem.Name = "上传目录RToolStripMenuItem";
            this.上传目录RToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.上传目录RToolStripMenuItem.Text = "目录上传(&R)";
            // 
            // 打开OToolStripMenuItem
            // 
            this.打开OToolStripMenuItem.Image = global::CloudreveForWindows.Properties.Resources.open_folder;
            this.打开OToolStripMenuItem.Name = "打开OToolStripMenuItem";
            this.打开OToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.打开OToolStripMenuItem.Text = "打开(&O)";
            this.打开OToolStripMenuItem.Click += new System.EventHandler(this.打开OToolStripMenuItem_Click);
            // 
            // 下载WToolStripMenuItem
            // 
            this.下载WToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("下载WToolStripMenuItem.Image")));
            this.下载WToolStripMenuItem.Name = "下载WToolStripMenuItem";
            this.下载WToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.下载WToolStripMenuItem.Text = "下载(&W)";
            this.下载WToolStripMenuItem.Click += new System.EventHandler(this.下载WToolStripMenuItem_Click);
            // 
            // 删除DToolStripMenuItem
            // 
            this.删除DToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("删除DToolStripMenuItem.Image")));
            this.删除DToolStripMenuItem.Name = "删除DToolStripMenuItem";
            this.删除DToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.删除DToolStripMenuItem.Text = "删除(&D)";
            this.删除DToolStripMenuItem.Click += new System.EventHandler(this.删除DToolStripMenuItem_Click);
            // 
            // 分享SToolStripMenuItem
            // 
            this.分享SToolStripMenuItem.Image = global::CloudreveForWindows.Properties.Resources.share;
            this.分享SToolStripMenuItem.Name = "分享SToolStripMenuItem";
            this.分享SToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.分享SToolStripMenuItem.Text = "分享(&S)";
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
            this.panLeftBottom.ResumeLayout(false);
            this.panLeftBottom.PerformLayout();
            this.panMiddle.ResumeLayout(false);
            this.panMiddleBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFileList)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panMiddleTop.ResumeLayout(false);
            this.panMiddleTopMiddle.ResumeLayout(false);
            this.panMiddleTopRight.ResumeLayout(false);
            this.panMiddleTopLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDownload)).EndInit();
            this.menuSort.ResumeLayout(false);
            this.menuUpload.ResumeLayout(false);
            this.menuClickedFile.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDownload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
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
        private System.Windows.Forms.Panel panLeftBottom;
        private System.Windows.Forms.Panel panMiddleBottom;
        private System.Windows.Forms.Panel panMiddleTop;
        private System.Windows.Forms.Panel panMiddleTopMiddle;
        private System.Windows.Forms.Panel panMiddleTopRight;
        private System.Windows.Forms.Panel panMiddleTopLeft;
        private ComponentControls.Controls.NavigateMenu menuLeft;
        private System.Windows.Forms.ContextMenuStrip menuSort;
        private System.Windows.Forms.PictureBox btnSort;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.DataGridView dgvFileList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFileCount;
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
        private System.Windows.Forms.DataGridView dgvDownload;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.DataGridViewImageColumn colDownloadStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDownloadFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDownloadFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDownloadPercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileID;
        private System.Windows.Forms.DataGridViewButtonColumn colOpenFolderDesc;
        private System.Windows.Forms.DataGridViewButtonColumn colDeleteDownload;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 分享SToolStripMenuItem;
    }
}
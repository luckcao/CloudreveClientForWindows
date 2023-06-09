
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
            this.panLeftBottom = new System.Windows.Forms.Panel();
            this.panRightMenu = new System.Windows.Forms.Panel();
            this.panMiddle = new System.Windows.Forms.Panel();
            this.panMiddleBottom = new System.Windows.Forms.Panel();
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
            this.panMiddleTopRight = new System.Windows.Forms.Panel();
            this.panMiddleTopLeft = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
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
            this.directoryPath1 = new ComponentControls.Controls.DirectoryPath();
            this.menuLeft = new ComponentControls.Controls.NavigateMenu();
            this.lblWait = new System.Windows.Forms.Label();
            this.btnShare = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnCreateDir = new System.Windows.Forms.PictureBox();
            this.btnSort = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.PictureBox();
            this.btnShowProfile = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnShowLeftMenu = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prgStorage = new System.Windows.Forms.ProgressBar();
            this.lblStorage = new System.Windows.Forms.Label();
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
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateDir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowLeftMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panMiddleBottom.Controls.Add(this.dgvFileList);
            this.panMiddleBottom.Controls.Add(this.panel1);
            this.panMiddleBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panMiddleBottom.Location = new System.Drawing.Point(0, 50);
            this.panMiddleBottom.Name = "panMiddleBottom";
            this.panMiddleBottom.Size = new System.Drawing.Size(835, 647);
            this.panMiddleBottom.TabIndex = 2;
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
            this.dgvFileList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFileList_CellDoubleClick);
            // 
            // colTick
            // 
            this.colTick.DataPropertyName = "Tick";
            this.colTick.HeaderText = "选择";
            this.colTick.Name = "colTick";
            this.colTick.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colTick.Width = 60;
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
            this.panMiddleTopMiddle.Size = new System.Drawing.Size(635, 50);
            this.panMiddleTopMiddle.TabIndex = 2;
            // 
            // panMiddleTopRight
            // 
            this.panMiddleTopRight.BackColor = System.Drawing.Color.White;
            this.panMiddleTopRight.Controls.Add(this.btnShare);
            this.panMiddleTopRight.Controls.Add(this.pictureBox5);
            this.panMiddleTopRight.Controls.Add(this.btnCreateDir);
            this.panMiddleTopRight.Controls.Add(this.btnSort);
            this.panMiddleTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panMiddleTopRight.Location = new System.Drawing.Point(675, 0);
            this.panMiddleTopRight.MaximumSize = new System.Drawing.Size(160, 0);
            this.panMiddleTopRight.MinimumSize = new System.Drawing.Size(160, 0);
            this.panMiddleTopRight.Name = "panMiddleTopRight";
            this.panMiddleTopRight.Size = new System.Drawing.Size(160, 50);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aZToolStripMenuItem,
            this.zAToolStripMenuItem,
            this.最早上传ToolStripMenuItem,
            this.最新上传ToolStripMenuItem,
            this.最早修改ToolStripMenuItem,
            this.最新修改ToolStripMenuItem,
            this.最小ToolStripMenuItem,
            this.最大ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 180);
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
            // directoryPath1
            // 
            this.directoryPath1.AutoScroll = true;
            this.directoryPath1.AutoScrollMinSize = new System.Drawing.Size(670, 50);
            this.directoryPath1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.directoryPath1.Location = new System.Drawing.Point(0, 0);
            this.directoryPath1.Name = "directoryPath1";
            this.directoryPath1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.directoryPath1.Size = new System.Drawing.Size(635, 50);
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
            // lblWait
            // 
            this.lblWait.Image = global::CloudreveForWindows.Properties.Resources.wait;
            this.lblWait.Location = new System.Drawing.Point(401, 312);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(32, 32);
            this.lblWait.TabIndex = 5;
            // 
            // btnShare
            // 
            this.btnShare.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnShare.Image = global::CloudreveForWindows.Properties.Resources.share;
            this.btnShare.Location = new System.Drawing.Point(50, 15);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(20, 20);
            this.btnShare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnShare.TabIndex = 12;
            this.btnShare.TabStop = false;
            this.toolTip1.SetToolTip(this.btnShare, "分享");
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox5.Image = global::CloudreveForWindows.Properties.Resources.upload;
            this.pictureBox5.Location = new System.Drawing.Point(90, 15);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(20, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox5, "上传");
            // 
            // btnCreateDir
            // 
            this.btnCreateDir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnCreateDir.Image = global::CloudreveForWindows.Properties.Resources.create_dir;
            this.btnCreateDir.Location = new System.Drawing.Point(8, 15);
            this.btnCreateDir.Name = "btnCreateDir";
            this.btnCreateDir.Size = new System.Drawing.Size(20, 20);
            this.btnCreateDir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCreateDir.TabIndex = 10;
            this.btnCreateDir.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCreateDir, "创建目录");
            this.btnCreateDir.Click += new System.EventHandler(this.btnCreateDir_Click);
            // 
            // btnSort
            // 
            this.btnSort.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSort.Image = global::CloudreveForWindows.Properties.Resources.sort;
            this.btnSort.Location = new System.Drawing.Point(129, 15);
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
            this.btnBack.Image = global::CloudreveForWindows.Properties.Resources.image_ic_undo_disable;
            this.btnBack.Location = new System.Drawing.Point(10, 15);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(20, 20);
            this.btnBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnBack.TabIndex = 8;
            this.btnBack.TabStop = false;
            this.toolTip1.SetToolTip(this.btnBack, "返回上一层");
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CloudreveForWindows.Properties.Resources.harddisk;
            this.pictureBox1.Location = new System.Drawing.Point(23, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // prgStorage
            // 
            this.prgStorage.BackColor = System.Drawing.Color.White;
            this.prgStorage.Location = new System.Drawing.Point(71, 48);
            this.prgStorage.Name = "prgStorage";
            this.prgStorage.Size = new System.Drawing.Size(158, 8);
            this.prgStorage.TabIndex = 2;
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
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCreateDir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnShowLeftMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox btnSort;
        private System.Windows.Forms.PictureBox btnBack;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblWait;
        private System.Windows.Forms.DataGridView dgvFileList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFileCount;
        private System.Windows.Forms.PictureBox btnCreateDir;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ImageList imglstFileTypeIcon;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colTick;
        private System.Windows.Forms.DataGridViewImageColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModifyDate;
        private System.Windows.Forms.ToolStripMenuItem aZToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最早上传ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最新上传ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最早修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最新修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最小ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 最大ToolStripMenuItem;
        private ComponentControls.Controls.DirectoryPath directoryPath1;
        private System.Windows.Forms.PictureBox btnShare;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStorage;
        private System.Windows.Forms.ProgressBar prgStorage;
        private System.Windows.Forms.Label label2;
    }
}
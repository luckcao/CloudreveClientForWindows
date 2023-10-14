using CloudreveMiddleLayer;
using CloudreveMiddleLayer.DataSet;
using CloudreveMiddleLayer.Entiry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentControls.Forms
{
    public partial class SelectPathDialog : Form
    {
        List<CloudreveMiddleLayer.JsonEntiryClass.GetFileListJson.ObjectsItem> tvList = null;
        bool isInFormLoading = true;

        private class TagInfo
        {
            string fileID = String.Empty;
            string fullPath = String.Empty;

            public string FileID
            {
                get { return fileID; }
            }

            public string FullPath
            {
                get { return fullPath; }
            }

            public TagInfo(string fileID, string fullPath)
            {
                this.fileID = fileID;
                this.fullPath = fullPath;
            }
        }

        public string SelectedPath
        {
            get
            {
                if(tvPath.SelectedNode == null)
                {
                    throw new Exception("没有选择任何路径！");
                }
                else
                {
                    return ((TagInfo)tvPath.SelectedNode.Tag).FullPath;
                }
            }
        }

        public string SelectedPathID
        {
            get
            {
                if (tvPath.SelectedNode == null)
                {
                    throw new Exception("没有选择任何路径！");
                }
                else
                {
                    return ((TagInfo)tvPath.SelectedNode.Tag).FileID;
                }
            }
        }

        public SelectPathDialog(string title = "请选择一个路径",
                                MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1)
        {
            InitializeComponent();
            imageList1.Images.Add(global::ComponentControls.Properties.Resources.dir);
            lblTitle.Text = title;
            btnOK.Text = "确定";
            btnCancel.Text = "取消";
            btnOK.Visible = true;
            btnCancel.Visible = true;
            switch (defaultButton)
            {
                case MessageBoxDefaultButton.Button1:
                    this.AcceptButton = btnOK;
                    this.CancelButton = btnCancel;
                    this.btnOK.Focus();
                    break;
                case MessageBoxDefaultButton.Button2:
                    btnOK.TabIndex = 2;
                    btnCancel.TabIndex = 1;
                    this.AcceptButton = btnCancel;
                    this.CancelButton = btnOK;
                    this.btnCancel.Focus();
                    break;
            }
            tvList = FileList.GetFileList(Util.CloudreveWebURL.GET_FILE_LIST_URL);
            BindPathSource(null);
        }

        #region TreeView

        private void BindPathSource(TreeNode parentNode)
        {
            if(tvList == null)
            {
                return;
            }

            for (int i = 0; i < tvList.Count; i++)
            {
                if(tvList[i].type.Trim().ToUpper().Equals("DIR"))
                {
                    TreeNode node = new TreeNode();
                    node.Text = tvList[i].name;
                    node.ImageIndex = 0;
                    if (parentNode == null)
                    {
                        node.Tag = new TagInfo(tvList[i].id, "/" + tvList[i].name);
                        tvPath.Nodes.Add(node);
                    }
                    else
                    {
                        node.Tag = new TagInfo(tvList[i].id, ((TagInfo)parentNode.Tag).FullPath + "/" + tvList[i].name);
                        parentNode.Nodes.Add(node);
                    }
                }
            }
            if(parentNode != null)
            {
                parentNode.Expand();
            }
        }

        /// <summary>
        /// 用于绘画treeview失去焦点时，选中的节点的背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvDepartment_DrawNode(object sender, DrawTreeNodeEventArgs e)
        {
            e.DrawDefault = true; //我这里用默认颜色即可，只需要在TreeView失去焦点时选中节点仍然突显
            return;
        }

        //用于取消默认选中
        private void tvDepartment_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (isInFormLoading)
            {
                e.Cancel = true;
                isInFormLoading = false;
            }
        }

        private void tvDepartment_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode lvi = tvPath.SelectedNode;

            btnOK.Enabled = lvi != null;
        }


        #endregion

        #region Button

        private void btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        #endregion

        private void tvPath_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if(e.Node.Nodes == null || e.Node.Nodes.Count == 0)
            {
                tvList = FileList.GetFileList(Util.CloudreveWebURL.GET_FILE_LIST_URL + ((TagInfo)e.Node.Tag).FullPath);
                if(tvList != null && tvList.Count > 0)
                {
                    BindPathSource(e.Node);
                }
            }
        }
    }
}

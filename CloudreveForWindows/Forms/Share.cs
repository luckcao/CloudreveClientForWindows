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

namespace CloudreveForWindows.Forms
{
    public partial class Share : Form
    {
        string fileID;
        bool isDir;

        public Share(string fileID, bool isDir)
        {
            InitializeComponent();
            this.fileID = fileID;
            this.isDir = isDir;
            for(int i=0; i< 999; i++)
            {
                dudDownloadTimes.Items.Add(i + 1);   // 允许1-999次下载
                dudExpireDayCount.Items.Add(i + 1);  // 允许1-999天有效
            }
        }

        public string Json
        {
            get { return FileList.GenerateShareJson(fileID, 
                                                    isDir, 
                                                    chkUsePassword.Checked ? txtPassword.Text : "",
                                                    chkAutoExpire.Checked ? Convert.ToInt32(dudDownloadTimes.Text) : -1,
                                                    chkAutoExpire.Checked ? Convert.ToInt32(dudExpireDayCount.Text) : 1,
                                                    chkAllowPreview.Checked); }
        }

        private void chkUsePassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.ReadOnly = !chkUsePassword.Checked;
            btnShowPassword.Enabled = chkUsePassword.Checked;
        }

        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            btnShowPassword.Image = txtPassword.PasswordChar != '\0' ? global::CloudreveForWindows.Properties.Resources.hide_password : global::CloudreveForWindows.Properties.Resources.show_password;
            txtPassword.PasswordChar = txtPassword.PasswordChar.Equals('\0') ? '*' : '\0';
        }

        private void chkAutoExpire_CheckedChanged(object sender, EventArgs e)
        {
            dudDownloadTimes.ReadOnly = dudExpireDayCount.ReadOnly = !chkAutoExpire.Checked;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

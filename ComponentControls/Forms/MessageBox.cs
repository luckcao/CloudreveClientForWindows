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
    public partial class MessageBox : Form
    {
        public MessageBox(string message = "", string title = "", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1, bool readOnly = true, bool multiLine = true)
        {
            InitializeComponent();
            this.txtMessage.Text = message;
            this.txtMessage.ReadOnly = readOnly;
            this.txtMessage.Multiline = multiLine;
            if(!multiLine)
            {
                this.txtMessage.BorderStyle = BorderStyle.FixedSingle;
                this.txtMessage.Focus();
            }
            this.lblTitle.Text = title;
            switch (buttons)
            {
                case MessageBoxButtons.OKCancel:
                    btnOK.Text = "确定";
                    btnCancel.Text = "取消";
                    btnOK.Visible = true;
                    btnCancel.Visible = true;
                    break;
                case MessageBoxButtons.YesNo:
                    btnOK.Text = "是";
                    btnCancel.Text = "否";
                    btnOK.Visible = true;
                    btnCancel.Visible = true;
                    break;
                case MessageBoxButtons.RetryCancel:
                    btnOK.Text = "重试";
                    btnCancel.Text = "取消";
                    btnOK.Visible = true;
                    btnCancel.Visible = true;
                    break;
                case MessageBoxButtons.OK:
                    btnOK.Dock = DockStyle.Fill;
                    btnOK.Text = "确定";
                    btnCancel.Text = "";
                    btnOK.Visible = true;
                    btnCancel.Visible = false;
                    break;
            }
            switch (icon)
            {
                case MessageBoxIcon.Hand:
                    picIcon.Image = global::ComponentControls.Properties.Resources.ErrorStopHand;
                    picIcon.Visible = true;
                    break;
                case MessageBoxIcon.None:
                    picIcon.Visible = false;
                    break;
                case MessageBoxIcon.Question:
                    picIcon.Image = global::ComponentControls.Properties.Resources.Question;
                    picIcon.Visible = true;
                    break;
                case MessageBoxIcon.Warning:
                    picIcon.Image = global::ComponentControls.Properties.Resources.Warning;
                    picIcon.Visible = true;
                    break;
                case MessageBoxIcon.Information:
                    picIcon.Image = global::ComponentControls.Properties.Resources.Information;
                    picIcon.Visible = true;
                    break;
            }
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
        }

        public string InputText
        {
            get { return txtMessage.Text.Trim(); }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            if(!txtMessage.ReadOnly && !requirementErrorProvider1.ValidateInput())
            {
                return;
            }
            else
            {
                requirementErrorProvider1.Clear();
            }
            Button btn = (Button)sender;
            switch (btn.Text.Trim())
            {
                case "确定":
                    this.DialogResult = DialogResult.OK;
                    break;
                case "取消":
                    this.DialogResult = DialogResult.Cancel;
                    break;
                case "是":
                    this.DialogResult = DialogResult.Yes;
                    break;
                case "否":
                    this.DialogResult = DialogResult.No;
                    break;
                case "重试":
                    this.DialogResult = DialogResult.Retry;
                    break;
            }
            this.Close();
        }

        private void MessageBox_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Text.Trim())
            {
                case "确定":
                    this.DialogResult = DialogResult.OK;
                    break;
                case "取消":
                    this.DialogResult = DialogResult.Cancel;
                    break;
                case "是":
                    this.DialogResult = DialogResult.Yes;
                    break;
                case "否":
                    this.DialogResult = DialogResult.No;
                    break;
                case "重试":
                    this.DialogResult = DialogResult.Retry;
                    break;
            }
            this.Close();

        }
    }
}

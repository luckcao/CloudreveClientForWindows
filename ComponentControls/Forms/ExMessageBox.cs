using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentControls.Forms
{
    public class ExMessageBox
    {
        public static DialogResult Show(string message = "", string title = "", MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.Information, MessageBoxDefaultButton defaultButton = MessageBoxDefaultButton.Button1, bool readOnly = true, bool multiLine = true, string checkBoxText = "")
        {
            return new MessageBox(message, title, buttons, icon, defaultButton, readOnly, multiLine, checkBoxText).ShowDialog();
        }
    }
}

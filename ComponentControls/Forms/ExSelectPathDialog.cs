using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentControls.Forms
{
    public class ExSelectPathDialog
    {
        public static DialogResult Show(string title, MessageBoxDefaultButton defaultButton)
        {
            return new SelectPathDialog(title, defaultButton).ShowDialog();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentControls.Components
{
    public partial class RequirementErrorProvider : ErrorProvider
    {
        Control control = null;
        string errorMessage = "不能为空";

        public RequirementErrorProvider()
        {
            InitializeComponent();
        }

        public RequirementErrorProvider(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

        }

        public Control BindControl
        {
            get { return control; }
            set { control = value; }
        }

        public string ErrorMessage
        {
            get { return errorMessage.Trim(); }
            set { errorMessage = value; }
        }

        public bool ValidateInput()
        {
            if (control == null)
            {
                return true;
            }
            if (control is PictureBox)
            {
                if (((PictureBox)control).Image == null)
                {
                    SetError(control, errorMessage);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (control is ListBox)
            {
                if (((ListBox)control).Items.Count == 0)
                {
                    SetError(control, errorMessage);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else if (control.Text.Trim().Equals(String.Empty))
            {
                SetError(control, errorMessage);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

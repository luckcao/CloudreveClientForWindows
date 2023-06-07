using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentControls.Components
{
    public partial class CheckFormatErrorProvider : ErrorProvider
    {
        Control control = null;
        string errorMessage = "格式不正确";

        string urlFormat = @"(http|https|ftp)://((((25[0-5])|(2[0-4]\d)|(1\d{2})|([1-9]?\d)\.){3}((25[0-5])|(2[0-4]\d)|(1\d{2})|([1-9]?\d)))|(([\w-]+\.)+(net|com|org|gov|edu|mil|info|travel|pro|museum|biz|[a-z]{2})))(/[\w\-~#]+)*(/[\w-]+\.[\w]{2,4})?([\?=&%_]?[\w-]+)*";
        string emailFormat = @"^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$";
        string integerFormat = @"^\d+$";
        string floatFormat = @"^\d+(\.\d+)?$";
        CheckTypeList checkType = CheckTypeList.Integer;

        public enum CheckTypeList
        {
            Integer = 0,
            Float = 1,
            WebURL = 10,
            EmailFormat = 11
        }

        public CheckTypeList CheckType
        {
            get { return checkType; }
            set { checkType = value; }
        }

        public CheckFormatErrorProvider()
        {
            InitializeComponent();
        }

        public CheckFormatErrorProvider(IContainer container)
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
            if (!IsValidFormat(control.Text.Trim()))
            {
                SetError(control, errorMessage);
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool IsValidFormat(string val)
        {
            if (!val.Equals(String.Empty))
            {
                //Regex r = new Regex(@"^\d+(\.)?\d*$");
                string format = String.Empty;
                switch(checkType)
                {
                    case CheckTypeList.Integer:
                        format = integerFormat;
                        break;
                    case CheckTypeList.Float:
                        format = floatFormat;
                        break;
                    case CheckTypeList.WebURL:
                        format = urlFormat;
                        break;
                    case CheckTypeList.EmailFormat:
                        format = emailFormat;
                        break;
                }
                Regex r = new Regex(format);
                return r.IsMatch(val);
            }
            return true;
        }
    }
}
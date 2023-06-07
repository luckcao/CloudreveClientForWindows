using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentControls.Controls
{
    public partial class HintTextBox : UserControl
    {
        public HintTextBox()
        {
            InitializeComponent();
        }

        public string HintText
        {
            get { return labelHint.Text.Trim(); }
            set { labelHint.Text = value; }
        }

        [Browsable(true)]
        public override string Text
        {
            get { return textBoxValue.Text.Trim(); }
            set { textBoxValue.Text = value; }
        }

        public char PWDChar
        {
            get { return textBoxValue.PasswordChar; }
            set { textBoxValue.PasswordChar = value; }
        }

        private void labelHint_Click(object sender, EventArgs e)
        {
            textBoxValue.Focus();
        }

        private void textBoxValue_TextChanged(object sender, EventArgs e)
        {
            labelHint.Visible = textBoxValue.Text.Trim().Equals(String.Empty);
        }
    }
}

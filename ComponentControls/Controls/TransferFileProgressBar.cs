using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentControls.Controls
{
    public partial class TransferFileProgressBar : ProgressBar
    {
        public delegate void SetValueEvent(object sender, int newValue, string fileID);
        public event SetValueEvent SetValue;

        public TransferFileProgressBar()
        {
            InitializeComponent();
        }

        public TransferFileProgressBar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void SetProgressBarValue(int value, string fileID)
        {
            if (SetValue != null)
            {
                SetValue(this, value, fileID);
            }
        }
    }
}

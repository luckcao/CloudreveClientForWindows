using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudreveMiddleLayer.Controls
{
    public partial class TransferFileProgressBar : ProgressBar
    {
        public delegate void ValueChangedEvent(object sender, int newValue);
        public event ValueChangedEvent ValueChanged;

        public TransferFileProgressBar()
        {
            InitializeComponent();
        }

        public TransferFileProgressBar(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void SetProgressBarValueInThread(int value)
        {
            Action t = () =>
            {
                if(value>=0)
                {
                    this.Value = value;
                }
            };

            //跨线程操作
            this.BeginInvoke(t);
        }
    }
}

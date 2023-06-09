using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentControls.Controls
{
    public partial class DirectoryPath : UserControl
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int ShowScrollBar(IntPtr hWnd, int bar, int show);

        List<EachPathControl> controlList = null;
        Point nextPosition = new Point();
        int controlSpace = 10;  //控件和控件之间的间隔
        public delegate void PathItemClickedEvent(object sender, DirecrotyPathItemClickedArgs e);
        public event PathItemClickedEvent PathItemClick;

        private class EachPathControl
        {
            private string pathName;
            private LinkLabel btn;
            private Label lbl;

            public EachPathControl(string pathName, LinkLabel btn, Label lbl)
            {
                this.pathName = pathName;
                this.btn = btn;
                this.lbl = lbl;
            }

            public LinkLabel Button { get { return btn; } }

            public Label Label { get { return lbl; } }

            public string PathName { get { return pathName; } }
        }

        public DirectoryPath()
        {
            InitializeComponent();
            controlList = new List<EachPathControl>();
            nextPosition.X = Padding.Left;
            nextPosition.Y = Padding.Top;
        }

        public string CurrentFullPath
        {
            get { return GetDirStringByList(); }
        }

        public void AddPath(string pathName)
        {
            LinkLabel btnPath = new LinkLabel();
            Label label = new Label();
            controlList.Add(new EachPathControl(pathName, btnPath, label));

            btnPath.AutoSize = true;
            btnPath.Font = this.Font;
            btnPath.Size = new System.Drawing.Size(74, 21);
            btnPath.Location = new System.Drawing.Point(nextPosition.X, (Height - btnPath.Height) / 2);
            btnPath.Name = "btnPath_" + pathName;
            btnPath.TabIndex = 0;
            btnPath.TabStop = false;
            btnPath.Tag = controlList.Count - 1;
            btnPath.Text = pathName;
            btnPath.LinkClicked += BtnPath_LinkClicked;
            this.Controls.Add(btnPath);

            nextPosition.X += btnPath.Width + controlSpace;

            if (!pathName.Equals("/"))
            {
                label.AutoSize = true;
                label.Font = this.Font;
                label.Size = new System.Drawing.Size(30, 21);
                label.Location = new System.Drawing.Point(nextPosition.X, (Height - btnPath.Height) / 2);
                label.Name = "label_" + pathName;
                label.TabIndex = 0;
                label.TabStop = false;
                label.Text = "/";
                this.Controls.Add(label);

                nextPosition.X += label.Width + controlSpace;
            }
            ShowScrollBar(this.Handle, 3, 0);
        }

        public void RemoveLastPath()
        {
            if (controlList[controlList.Count - 1].Label != null)
            {
                nextPosition.X = nextPosition.X - controlSpace - controlList[controlList.Count - 1].Label.Width;
                this.Controls.Remove(controlList[controlList.Count - 1].Label);
            }
            if (controlList[controlList.Count - 1].Button != null)
            {
                nextPosition.X = nextPosition.X - controlSpace - controlList[controlList.Count - 1].Button.Width;
                this.Controls.Remove(controlList[controlList.Count - 1].Button);
            }
            controlList.RemoveAt(controlList.Count - 1);
        }

        private String GetDirStringByList()
        {
            StringBuilder convertedPathString = new StringBuilder();
            for (int i = 0; i < controlList.Count; i++) // String dirName : currentFileTreePath)
            {
                if(controlList[i].PathName.Equals("/"))
                {
                    convertedPathString.Append(controlList[i].PathName);
                }
                else
                {
                    convertedPathString.Append(controlList[i].PathName);
                    if(i != controlList.Count - 1)
                    {
                        convertedPathString.Append("/");
                    }
                }
            }
            return convertedPathString.ToString();
        }

        private void BtnPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel btnPath = (LinkLabel)sender;
            int clickedIndex = Convert.ToInt32(btnPath.Tag);

            while(controlList.Count > clickedIndex + 1)
            {
                RemoveLastPath();
            }

            if (PathItemClick != null)
            {
                PathItemClick(this, new DirecrotyPathItemClickedArgs(clickedIndex, GetDirStringByList()));
            }
        }

        private void DirectoryPath_Resize(object sender, EventArgs e)
        {
            ShowScrollBar(this.Handle, 3, 0);
        }

        public void ClearAllPath()
        {
            while (controlList.Count > 0)
            {
                RemoveLastPath();
            }
            nextPosition.X = Padding.Left;
            nextPosition.Y = Padding.Top;

        }
    }
}

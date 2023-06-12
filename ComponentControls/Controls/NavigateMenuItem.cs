using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponentControls.Controls
{
    public partial class NavigateMenuItem : UserControl
    {
        int menuID, parentMenuID = int.MaxValue;
        internal Panel panCurrent = null;
        internal Panel panParent = null;
        internal Panel panChild = null;
        bool inControl = false;

        internal delegate void MenuItemMouseEnterEvent(object sender, EventArgs e);
        internal event MenuItemMouseEnterEvent MenuItemMouseEnter;
        internal delegate void MenuItemMouseLeaveEvent(object sender, EventArgs e);
        internal event MenuItemMouseLeaveEvent MenuItemMouseLeave;
        internal delegate void MenuItemClickEvent(object sender, NavigateMenuItemClickedArgs e);
        internal event MenuItemClickEvent MenuItemClick;

        public NavigateMenuItem(Image menuIcon, string menuText, int parentMenuID)
        {
            InitializeComponent();
            this.picMenuIcon.Image = menuIcon;
            this.lblMenuText.Text = menuText;
            this.parentMenuID = parentMenuID;
            this.picStatus.Visible = false;
            this.picMenuIcon.Left += 30;
            this.lblMenuText.Left += 30;

        }

        public NavigateMenuItem(Image menuIcon, string menuText)
        {
            InitializeComponent();
            this.picMenuIcon.Image = menuIcon;
            this.lblMenuText.Text = menuText;
            this.picStatus.Image = global::ComponentControls.Properties.Resources.js_assets_xiala;
        }


        public int MenuID 
        { 
            get { return menuID; } 
            set { menuID = value; }
        }

        public int ParentMenuID { get { return parentMenuID; } }

        public string MenuText { get { return this.lblMenuText.Text.Trim(); } }

        public Image MenuImage { get { return picMenuIcon.Image; } }

        internal Color MenuItemBackgroundColor
        {
            get { return this.BackColor; }
            set { this.BackColor = value; }
        }

        internal Color MenuItemForeColor
        {
            get { return this.lblMenuText.ForeColor; }
            set { this.lblMenuText.ForeColor = value; }
        }

        internal bool ShowStatusImage
        {
            get { return picStatus.Visible; }
            set { picStatus.Visible = value; }
        }

        internal Image StatusImage
        {
            get { return picStatus.Image; }
            set { picStatus.Image = value; }
        }

        internal Panel CurrentPanel
        {
            get { return panCurrent; }
            set { panCurrent = value; }
        }

        internal Panel ParentPanel
        {
            get { return panParent; }
            set { panParent = value; }
        }

        internal Panel ChildPanel
        {
            get { return panChild; }
            set { panChild = value; }
        }

        internal void NavigateMenuItem_MouseEnter(object sender, EventArgs e)
        {
            Console.WriteLine("InControl:" + inControl.ToString());
            inControl = true;
            Application.DoEvents();
            if (MenuItemMouseEnter != null)
            {
                MenuItemMouseEnter(this, e);
            }
        }

        internal void NavigateMenuItem_MouseLeave(object sender, EventArgs e)
        {
            //Thread.Sleep(50);
            Console.WriteLine("InControl:" + inControl.ToString() + "        MenuItemMouseLeave == null?  " + (MenuItemMouseLeave == null).ToString());
            if (MenuItemMouseLeave != null)  //!inControl && 
            {
                MenuItemMouseLeave(this, e);
            }
        }

        internal void NavigateMenuItem_Click(object sender, EventArgs e)
        {
            if(MenuItemClick != null)
            {
                MenuItemClick(this, new NavigateMenuItemClickedArgs(menuID, parentMenuID));
            }
        }
    }
}

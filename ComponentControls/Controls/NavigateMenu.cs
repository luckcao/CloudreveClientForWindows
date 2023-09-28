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
    public partial class NavigateMenu : UserControl
    {
        public const int ROOT_MENU_PARENT_ID = int.MaxValue;
        Color bgColor = Color.White;
        Color foreColor = Color.Black;
        Color mouseOnBGColor = Color.FromArgb(230, 230, 230);
        Color mouseOnForeColor = Color.Black;

        int menuItemHeight = 40;
        List<NavigateMenuItem> menuItems = null;

        public delegate void MenuItemClickEvent(object sender, NavigateMenuItemClickedArgs e);
        public event MenuItemClickEvent MenuItemClick;

        public NavigateMenu()
        {
            InitializeComponent();
        }

        public int MenuItemHeight
        {
            get { return menuItemHeight; }
            set { menuItemHeight = value; }
        }

        public Color MenuItemBackgroundColor
        {
            get { return bgColor; }
            set { bgColor = value; }
        }

        public Color MenuItemForeColor
        {
            get { return foreColor; }
            set { foreColor = value; }
        }

        public Color MenuItemMouseOnBackgroundColor
        {
            get { return mouseOnBGColor; }
            set { mouseOnBGColor = value; }
        }

        public Color MenuItemMouseOnForeColor
        {
            get { return mouseOnForeColor; }
            set { mouseOnForeColor = value; }
        }

        public List<NavigateMenuItem> DataSource
        {
            get { return menuItems; }
        }

        public void BindDataSource(List<NavigateMenuItem> value, bool sortByMenuID)
        {
            menuItems = value;
            while (this.Controls.Count > 0)
            {
                this.Controls.RemoveAt(0);
            }
            GC.Collect();

            for (int i = 0; i < menuItems.Count; i++)
            {
                menuItems[i].MenuID = i;
            }

            if (menuItems != null)
            {
                if (sortByMenuID)
                {
                    value.Sort(new MenuItemCompare());
                }

                GenerateMenuItem();
            }
        }

        private void GenerateMenuItem()
        {
            for (int i = 0; i < menuItems.Count; i++)
            {
                if (menuItems[i].ParentMenuID == ROOT_MENU_PARENT_ID)
                {
                    //表示是根菜单项
                    Panel pan = new Panel();
                    pan.Dock = System.Windows.Forms.DockStyle.Top;
                    pan.Height = menuItems[i].Height;
                    pan.Width = this.Width;
                    pan.Controls.Add(menuItems[i]);

                    menuItems[i].BackColor = MenuItemBackgroundColor;
                    menuItems[i].Width = this.Width;
                    menuItems[i].Height = menuItemHeight;
                    menuItems[i].MenuItemMouseEnter += NavigateMenu_MenuItemMouseEnter; ;
                    menuItems[i].MenuItemMouseLeave += NavigateMenu_MenuItemMouseLeave; ;
                    menuItems[i].MenuItemClick += NavigateMenu_MenuItemClick; ;

                    menuItems[i].panCurrent = pan;

                    //添加子菜单项
                    if(menuItems.Exists(t => t.ParentMenuID == menuItems[i].MenuID)) 
                    {
                        menuItems[i].ShowStatusImage = true;
                        Panel panSub = new Panel();
                        panSub.Dock = System.Windows.Forms.DockStyle.Top;
                        panSub.Width = this.Width;
                        int subCount = 0;
                        for (int j = 0; j < menuItems.Count; j++)
                        {
                            if (menuItems[j].ParentMenuID == menuItems[i].MenuID)
                            {
                                menuItems[j].BackColor = MenuItemBackgroundColor;
                                menuItems[j].Width = this.Width;
                                menuItems[j].Height = menuItemHeight;
                                menuItems[j].Dock = System.Windows.Forms.DockStyle.Top;
                                menuItems[j].MenuItemMouseEnter += NavigateMenu_MenuItemMouseEnter;
                                menuItems[j].MenuItemMouseLeave += NavigateMenu_MenuItemMouseLeave;
                                menuItems[j].MenuItemClick += NavigateMenu_MenuItemClick;
                                
                                subCount++;
                                panSub.Height = subCount * menuItems[j].Height;

                                menuItems[j].ParentPanel = pan;
                                panSub.Controls.Add(menuItems[j]);
                            }
                        }
                        menuItems[i].ChildPanel = panSub;
                        this.Controls.Add(panSub);
                    }
                    else
                    {
                        menuItems[i].ShowStatusImage = false;
                    }
                    this.Controls.Add(pan);
                }
            }
        }

        private void NavigateMenu_MenuItemClick(object sender, NavigateMenuItemClickedArgs e)
        {
            NavigateMenuItem m = (NavigateMenuItem)sender;
            
            if(m.panParent == null && m.ChildPanel != null)
            {
                //根菜单项，并且有子菜单项
                //有子菜单项
                m.ChildPanel.Visible = !m.ChildPanel.Visible;
                m.StatusImage = m.ChildPanel.Visible ?
                    global::ComponentControls.Properties.Resources.js_assets_xiala :
                    global::ComponentControls.Properties.Resources.js_assets_xiala2;
            }
            else
            {
                //子菜单项
                if(MenuItemClick != null)
                {
                    MenuItemClick(m, new NavigateMenuItemClickedArgs(m.MenuID, m.ParentMenuID));
                }
            }
        }

        private void NavigateMenu_MenuItemMouseLeave(object sender, EventArgs e)
        {
            NavigateMenuItem m = (NavigateMenuItem)sender;
            m.MenuItemBackgroundColor = MenuItemBackgroundColor;
            m.MenuItemForeColor = MenuItemForeColor;
        }

        private void NavigateMenu_MenuItemMouseEnter(object sender, EventArgs e)
        {
            NavigateMenuItem m = (NavigateMenuItem)sender;

            for (int i = 0; i < menuItems.Count; i++)
            {
                menuItems[i].MenuItemBackgroundColor = menuItems[i] == m ? MenuItemMouseOnBackgroundColor : MenuItemBackgroundColor;
                menuItems[i].MenuItemForeColor = menuItems[i] == m ? MenuItemMouseOnForeColor : MenuItemForeColor;
            }
        }

        class MenuItemCompare : IComparer<NavigateMenuItem>
        {
            //实现的是降序排列，你也可以改变返回值实现升序排列
            public int Compare(NavigateMenuItem x, NavigateMenuItem y)
            {
                if (x.ParentMenuID > y.ParentMenuID)
                {
                    return 1;
                }
                else if (x.ParentMenuID < y.ParentMenuID)
                {
                    return -1;
                }
                else//如果数字相同，则比较枚举值，枚举类型都对应一个数值默认从0开始。
                {
                    if (x.MenuID > y.MenuID)
                    {
                        return -1;
                    }
                    else if (x.MenuID < y.MenuID)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;//排面花色都相等
                    }
                }
            }
        }
    }
}
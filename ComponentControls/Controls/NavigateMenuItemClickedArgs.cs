using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentControls.Controls
{
    public class NavigateMenuItemClickedArgs : EventArgs
    {
        int menuID, parentMenuID;
        bool isParent = false;
        const int ROOT_MENU_PARENT_ID = int.MinValue;

        public NavigateMenuItemClickedArgs(int menuItemID, int parentMenuItemID)
        {
            this.menuID = menuItemID;
            this.parentMenuID = parentMenuItemID;
            if (parentMenuItemID == ROOT_MENU_PARENT_ID)
            {
                isParent = true;
            }
        }

        public int MenuItemID
        {
            get { return menuID; }
        }

        public int ParentMenuItemID
        {
            get { return parentMenuID; }
        }

        public bool IsParentMenuID
        {
            get { return isParent; }
        }
    }
}

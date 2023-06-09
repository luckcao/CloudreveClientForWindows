using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentControls.Controls
{
    public class DirecrotyPathItemClickedArgs : EventArgs
    {
        int clickedPathIndex;
        string pathString = "";

        public DirecrotyPathItemClickedArgs(int clickedPathIndex, string pathString)
        {
            this.clickedPathIndex = clickedPathIndex;
            this.pathString = pathString;
        }

        public int ClickedPathIndex
        {
            get { return ClickedPathIndex; }
        }

        public string ClickedFullPath
        {
            get { return pathString; }
        }
    }
}

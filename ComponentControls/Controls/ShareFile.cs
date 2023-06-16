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
    public partial class ShareFile : UserControl
    {
        List<ShareFileItem> items = new List<ShareFileItem>();
        int itemSpace = 12;

        public ShareFile()
        {
            InitializeComponent();
        }


        public void SetDataSource(List<ShareFileItem> items)
        {
            this.items = items;
        }

        public List<ShareFileItem> GetDataSource()
        {
            return this.items;
        }

        public void AddShareFile(ShareFileItem item)
        {
            item.Location = new Point(4, (item.Height + itemSpace) * items.Count);
            item.Width = this.Width - 28;
            item.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | AnchorStyles.Left;
            items.Add(item);
            this.Controls.Add(item);
        }

        public void AddShareFile(string fileID,
                             string fileName,
                             bool isDir,
                             string fileSize,
                             string createShareDate,
                             string expireDate,
                             string password,
                             int downloadCount,
                             int leftDownloadCount,
                             int viewCount,
                             bool allowPreview,
                             object tag)
        {
            ShareFileItem item = new ShareFileItem(fileID, fileName, isDir, fileSize, createShareDate, Convert.ToInt32(expireDate), password, downloadCount, leftDownloadCount, viewCount, allowPreview, tag);
            item.Location = new Point(4, (item.Height + itemSpace) * items.Count);
            item.Width = this.Width - 8;
            item.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | AnchorStyles.Left;
            items.Add(item);
            this.Controls.Add(item);
        }

        public void RemoveShareFileAt(int index)
        {
            for (int i = index + 1; i < items.Count; i++)
            {
                items[i].Location = new Point(4, items[i].Location.Y - items[i].Height - itemSpace);
            }
            this.Controls.Remove(items[index]);
            items.RemoveAt(index);
        }

        public void RemoveShareFile(string fileID)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].FileID.Equals(fileID))
                {
                    RemoveShareFileAt(i);
                    break;
                }
            }
        }

        public void Clear()
        {
            while (items.Count > 0)
            {
                this.Controls.Remove(items[0]);
                items.RemoveAt(0);
            }
            items.Clear();
        }

        public ShareFileItem GetItems(string fileID)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].FileID.Equals(fileID))
                {
                    return items[i];
                }
            }
            return null;
        }

    }
}

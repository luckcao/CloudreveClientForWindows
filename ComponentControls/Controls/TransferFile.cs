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
    [Serializable]
    public partial class TransferFile : UserControl
    {
        List<TransferFileItem> items = new List<TransferFileItem>();
        int itemSpace = 12;

        public TransferFile()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<TransferFileItem> items)
        {
            this.items = items;
        }

        public List<TransferFileItem> GetDataSource()
        {
            return this.items;
        }

        public void AddTransferFile(TransferFileItem item)
        {
            item.Location = new Point(4, (item.Height + itemSpace) * items.Count);
            item.Width = this.Width - 8;
            item.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | AnchorStyles.Left;
            items.Add(item);
            this.Controls.Add(item);
        }

        public void AddTransferFile(string fileID, string fileName, string filePath, string fileSize, int percent, object tag)
        {
            TransferFileItem item = new TransferFileItem(fileID, fileName, filePath, fileSize, 0, tag);
            item.Location = new Point(4, (item.Height + itemSpace) * items.Count);
            item.Width = this.Width - 8;
            item.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | AnchorStyles.Left;
            items.Add(item);
            this.Controls.Add(item);
        }

        public void RemoveTransferFileAt(int index)
        {
            for (int i = index + 1; i < items.Count; i++)
            {
                items[i].Location = new Point(4, items[i].Location.Y - items[i].Height - itemSpace);
            }
            this.Controls.Remove(items[index]);
            items.RemoveAt(index);
        }

        public void RemoveTransferFile(string fileID)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if(items[i].FileID.Equals(fileID))
                {
                    RemoveTransferFileAt(i);
                    break;
                }
            }
        }

        public void Clear()
        {
            while(items.Count > 0)
            {
                this.Controls.Remove(items[0]);
            }
            items.Clear();
        }

        public TransferFileItem GetItems(string fileID)
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
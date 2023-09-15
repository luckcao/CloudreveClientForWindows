using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ComponentControls.Controls
{
    public partial class TransferFile : UserControl
    {
        List<TransferFileItem> items = new List<TransferFileItem>();
        int itemSpace = 12;
        public delegate void TransferItemDeletedEvent(object sender, int index, bool removeLocalFile);
        public event TransferItemDeletedEvent TransferItemDeleted;
        public delegate void TransferItemCompletedEvent(object sender, string fileID);
        public event TransferItemCompletedEvent TransferItemCompleted;

        public TransferFile()
        {
            InitializeComponent();
        }

        public void SetDataSource(List<TransferFileItem> items)
        {
            this.items = items;
        }

        public int ItemCount(TransferFileItem.Status status = TransferFileItem.Status.所有状态)
        {
            if(status == TransferFileItem.Status.所有状态) 
            { 
                return this.items.Count; 
            }
            else
            {
                return items.Count(t => t.CurrentStatus == status);
            }
        }

        public TransferFileItem this[int index]
        {
            get { return this.items[index]; }
        }

        public TransferFileItem this[string fileID]
        {
            get { return items.Find(t => t.FileID == fileID); }
        }

        public void Add(string fileID, string fileName, string filePathFrom, string filePathTo, 
                        string fileSize, int percent, object tag, TransferFileItem.TransferType transType,
                        bool autoStart = false)
        {
            TransferFileItem item = new TransferFileItem(fileID, fileName, filePathFrom, filePathTo, fileSize, percent, tag, transType);
            item.Location = new Point(4, (item.Height + itemSpace) * items.Count);
            item.Width = this.Width - 8;
            item.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right | AnchorStyles.Left;
            item.TransferItemDeleteClicked += Item_TransferItemDeleteClicked;
            item.TransferItemCompleted += Item_TransferItemCompleted;
            items.Add(item);

            this.Controls.Add(item);

            if(autoStart)
            {
                item.CurrentStatus = TransferFileItem.Status.正在传输;
            }
        }

        private void Item_TransferItemCompleted(object sender, string fileID)
        {
            if(TransferItemCompleted!=null)
            {
                TransferItemCompleted(this, fileID);
            }
        }

        private void Item_TransferItemDeleteClicked(object sender, bool removeLocalFile)
        {
            Remove(items.IndexOf((TransferFileItem)sender), removeLocalFile);
        }

        public void Remove(int index, bool removeLocalFile)
        {
            for (int i = index + 1; i < items.Count; i++)
            {
                items[i].Location = new Point(4, items[i].Location.Y - items[i].Height - itemSpace);
            }
            if(TransferItemDeleted!=null)
            {
                TransferItemDeleted(this, index, removeLocalFile);
            }
            this.Controls.Remove(items[index]);
            items.RemoveAt(index);
        }

        public void Remove(string fileID)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if(items[i].FileID.Equals(fileID))
                {
                    Remove(i, true);
                    break;
                }
            }
        }

        public void Clear(bool removeLocalFile)
        {
            while(items.Count > 0)
            {
                Remove(0, removeLocalFile);
            }
        }
    }
}
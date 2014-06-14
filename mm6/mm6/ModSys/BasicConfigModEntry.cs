using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MM6.ModSys
{
    class BasicConfigModEntry : ModEntry
    {
        private string instance;
        private string filename;
        private string name;
        private string config;
        private ListViewItem listViewItem;

        public string InstanceId
        {
            get
            {
                return instance;
            }
            set
            {
                instance = value;
            }
        }

        public BasicConfigModEntry(string instance, string filename, string name, string config)
        {
            // TODO: Complete member initialization
            this.instance = instance;
            this.filename = filename;
            this.name = name;
            this.config = config;

            listViewItem = new ListViewItem(name);
        }

        public void SetGroup(ListViewGroup group)
        {
            listViewItem.Group = group;
        }

        public ListViewItem GetListViewItem()
        {
            return listViewItem;
        }
    }
}

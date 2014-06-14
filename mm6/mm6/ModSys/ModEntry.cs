using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MM6.ModSys
{
    public interface ModEntry
    {
        string InstanceId { get; set; }

        ListViewItem GetListViewItem();

        void SetGroup(ListViewGroup group);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MM6.ModSys;

namespace mm6_controls.Data
{
    public delegate void IDChanged(string oldId, string newId);
    public interface GameInstance
    {
        string ID { get; }
        string GetTitle();
        ListViewGroup GetListViewGroup();

        /*public Version Version { get; set; }
        public string Name { get; set; }*/

        /*public GameInstance()
        {
            Name = string.Format("{{0}}", Guid.NewGuid().ToString());
            Version = Version.Parse("0.0.0.0");
        }*/

        event IDChanged idChanged;

        ListViewItem[] GetListItems();

        void ChangeFilename(string newId);

        void AddModEntry(ModEntry tmpModEntry);
    }
}

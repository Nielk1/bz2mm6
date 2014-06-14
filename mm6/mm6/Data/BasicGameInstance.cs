using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MM6.ModSys;

namespace mm6_controls.Data
{
    public class BasicGameInstance : GameInstance
    {
        public event IDChanged idChanged;

        private string _Name;

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                Group.Header = _Name;
            }
        }
        public string ID { get { return _ID; } }
        private string _ID;
        private ListViewGroup Group;
        private List<ModEntry> ModEntries;

        public BasicGameInstance(string filename)
        {
            this._ID = Path.GetFileNameWithoutExtension(filename);
            this._Name = Guid.NewGuid().ToString();
            this.Group = new ListViewGroup(GetTitle());
            this.ModEntries = new List<ModEntry>();
        }

        public string GetTitle()
        {
            return Name;
        }

        public ListViewGroup GetListViewGroup()
        {
            return Group;
        }


        public ListViewItem[] GetListItems()
        {
            if (ModEntries.Count > 0)
            {
                return ModEntries.Select(dr => dr.GetListViewItem()).ToArray();
            }
            return (new List<string>() { "" }).Select(dr => new ListViewItem(dr, Group)).ToArray();
        }

        public void ChangeFilename(string newId)
        {
            _ID = newId;
            idChanged(ID, newId);
        }


        public void AddModEntry(ModEntry tmpModEntry)
        {
            tmpModEntry.GetListViewItem().Group = GetListViewGroup();
            ModEntries.Add(tmpModEntry);
        }
    }
}

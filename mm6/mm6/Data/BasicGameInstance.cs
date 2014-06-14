using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mm6_controls.Data
{
    public class BasicGameInstance : GameInstance
    {
        public event FilenameChanged filenameChanged;

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
        public string filename { get { return _filename; } }
        private string _filename;
        private ListViewGroup Group;

        public BasicGameInstance(string filename)
        {
            this._filename = filename;
            this._Name = Guid.NewGuid().ToString();
            this.Group = new ListViewGroup(GetTitle());
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
            return (new List<string>() { "", "Dummy2", "Dummy3" }).Select(dr => new ListViewItem(dr, Group)).ToArray();
        }

        public void ChangeFilename(string newFilename)
        {
            _filename = newFilename;
            filenameChanged(filename, newFilename);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace mm6_controls.Data
{
    public delegate void FilenameChanged(string oldFilename, string newFilename);
    public interface GameInstance
    {
        string filename { get; }
        string GetTitle();
        ListViewGroup GetListViewGroup();

        /*public Version Version { get; set; }
        public string Name { get; set; }*/

        /*public GameInstance()
        {
            Name = string.Format("{{0}}", Guid.NewGuid().ToString());
            Version = Version.Parse("0.0.0.0");
        }*/

        event FilenameChanged filenameChanged;

        ListViewItem[] GetListItems();

        void ChangeFilename(string newFilename);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;

namespace mm6.FileSys
{
    public class IconDescriptor
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public string Package { get; set; }

        public Dictionary<string, Dictionary<int, Icon>> IconSet { get; private set; }

        public IconDescriptor()
        {
            IconSet = new Dictionary<string, Dictionary<int, Icon>>();
        }

        public void LoadIcons()
        {
            foreach (string iconname in Directory.GetFiles(string.Format("./Icons/{0}/", Package)))
            {
                Dictionary<int, Icon> iconList = new Dictionary<int, Icon>();
                IconSet.Add(Path.GetFileName(iconname), iconList);
                if (Path.GetExtension(iconname).ToLowerInvariant() == ".ico")
                {
                    iconList.Add(48, new Icon(iconname, 48, 48));
                    iconList.Add(32, new Icon(iconname, 32, 32));
                    iconList.Add(16, new Icon(iconname, 16, 16));
                }
            }
        }
    }
}

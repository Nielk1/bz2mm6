using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using mm6_controls.Data;

namespace MM6.Controls
{
    public partial class GameLaunchListView : ListView
    {
        private GameLaunchListModel source;

        [Bindable(true)]
        [TypeConverter(typeof(GameLaunchListModel))]
        [Category("Data")]
        public GameLaunchListModel DataSource
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
            }
        }

        public GameLaunchListView()
        {
            InitializeComponent();
        }

        //private void bind()
        public void bind()
        {
            Items.Clear();
            Groups.Clear();

            if (source != null)
            {
                foreach (GameInstance instance in source.Instances)
                {
                    Groups.Add(instance.GetListViewGroup());

                    Items.AddRange(instance.GetListItems());
                }
                /*ListViewGroup[] groups = source.GetListGroups();
                Groups.AddRange(groups);

                foreach(ListViewGroup group in groups)
                {
                    Items.Add(new ListViewItem(
                }*/
            }
        }
    }
}

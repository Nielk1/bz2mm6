using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using mm6.FileSys;
using System.Reflection;
using mm6_controls.Controls;
using System.Threading;
using mm6_controls.Data;
using MM6.ModSys;

namespace mm6
{
    public partial class MainForm : Form
    {
        class IconCollection
        {
            public Dictionary<string, IconDescriptor> IconPacks { get; private set; }

            public ImageList LargeIcons { get; private set; }
            public ImageList SmallIcons { get; private set; }

            public IconCollection()
            {
                IconPacks = new Dictionary<string,IconDescriptor>();

                LargeIcons = new ImageList();
                SmallIcons = new ImageList();
                LargeIcons.ImageSize = new Size(48, 48);
                SmallIcons.ImageSize = new Size(16, 16);
            }

            public void AddPackFromJSON(string data)
            {
                IconDescriptor icons = JsonConvert.DeserializeObject<IconDescriptor>(data);
                icons.LoadIcons();
                icons.IconSet.ToList().ForEach(dr =>
                {
                    LargeIcons.Images.Add(icons.Package + @"/" + dr.Key, dr.Value[48]);
                    SmallIcons.Images.Add(icons.Package + @"/" + dr.Key, dr.Value[16]);
                });
                IconPacks.Add(icons.Package, icons);
            }
        }

        IconCollection iconCollection;


        QueuedBackgroundWorker BackgroundTaskWorker;
        GameLaunchListModel GameLaunchData;

        public MainForm()
        {
            InitializeComponent();
            splitContainerLaunchTab.Panel2Collapsed = true;

            iconCollection = new IconCollection();

            {
                var asmData = System.Reflection.Assembly.GetExecutingAssembly().GetName();
                this.Text = string.Format("Battlezone II - Mod Manager 6 [{0}.{1}.{2}.{3}]", asmData.Version.Major, asmData.Version.MajorRevision, asmData.Version.Minor, asmData.Version.MinorRevision);
            }

            GameLaunchData = new GameLaunchListModel();

            listViewLaunch.DataSource = GameLaunchData;

            BackgroundTaskWorker = new QueuedBackgroundWorker();
        }

        private void LoadData()
        {
            BackgroundTaskWorker.RunAsync(
                (obj, args) =>
                {
                    ((BackgroundWorker)obj).ReportProgress(0);
                    string[] files = Directory.GetFiles("./Icons/").Where(file => Path.GetExtension(file).ToLowerInvariant() == ".json").ToArray();
                    int count = files.Length;
                    for (int x = 0; x < count; x++)
                    {
                        ((BackgroundWorker)obj).ReportProgress(x * 100 / count);
                        iconCollection.AddPackFromJSON(File.ReadAllText(files[x]));
                        ((BackgroundWorker)obj).ReportProgress((x + 1) * 100 / count);
                    }
                    ((BackgroundWorker)obj).ReportProgress(100);
                },
                (obj, args) =>
                {
                    toolStripStatusLabel.Text = "OK";
                    toolStripProgressBar.Visible = false;
                    toolStripProgressBar.Value = 0;
                    //DoneLoading();
                },
                (obj, args) =>
                {
                    toolStripStatusLabel.Text = "Loading Icons";
                    toolStripProgressBar.Value = args.ProgressPercentage;
                    toolStripProgressBar.Visible = true;
                }
            );

            BackgroundTaskWorker.RunAsync(
                (obj, args) =>
                {
                    ((BackgroundWorker)obj).ReportProgress(0);
                    string[] files = Directory.GetFiles("./Data/Instances/").Where(file => Path.GetExtension(file).ToLowerInvariant() == ".json").ToArray();
                    int count = files.Length;
                    for (int x = 0; x < count; x++)
                    {
                        ((BackgroundWorker)obj).ReportProgress(x * 100 / count);
                        GameInstance tmpInstance = Factories.MakeGameInstance(files[x]);
                        if (tmpInstance != null)
                        {
                            GameLaunchData.AddGameInstance(tmpInstance);
                        }
                        ((BackgroundWorker)obj).ReportProgress((x + 1) * 100 / count);
                    }
                    ((BackgroundWorker)obj).ReportProgress(100);
                    Thread.Sleep(1000);
                },
                (obj, args) =>
                {
                    toolStripStatusLabel.Text = "OK";
                    toolStripProgressBar.Visible = false;
                    toolStripProgressBar.Value = 0;
                    DoneLoading();
                },
                (obj, args) =>
                {
                    toolStripStatusLabel.Text = "Loading Instances";
                    toolStripProgressBar.Value = args.ProgressPercentage;
                    toolStripProgressBar.Visible = true;
                }
            );
        }
        private void DoneLoading()
        {
            toolStripStatusLabel.Text = "OK";
            toolStripProgressBar.Value = 0;
            toolStripProgressBar.Visible = false;
            this.Enabled = true;

            LoadSettingsAndData();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadSettingsAndData()
        {
            /*GameInstance testInstance = BasicGameInstance.Make();
            GameInstance testInstance2 = BasicGameInstance.Make();
            GameLaunchData.AddGameInstance(testInstance);
            GameLaunchData.AddGameInstance(testInstance2);*/
            listViewLaunch.bind();

            //listViewIcons.Groups.AddRange(iconCollection.IconPacks.Values.Select(dr => new ListViewGroup(dr.Package, dr.Name)).ToArray());
            //iconCollection.IconPacks.ToList().ForEach(package =>
            //{
            //    listViewIcons.Items.AddRange(package.Value.IconSet.Select(dr => new ListViewItem(dr.Key, package.Value.Package + @"/" + dr.Key, listViewIcons.Groups[package.Value.Package])).ToArray());
            //});

            //listViewLaunch.LargeImageList = iconCollection.LargeIcons;
            //listViewIcons.LargeImageList = iconCollection.LargeIcons;

            /*ListViewGroup g1 = new ListViewGroup("bz2_1.3_private","Battlezone II 1.3 Private Beta");
            ListViewGroup g2 = new ListViewGroup("bz2_1.3.6.4","Battlezone II 1.3.6.4");
            ListViewGroup g3 = new ListViewGroup("bz2_mod_qf","Battlezone II - QF Mod");*/

            //images.Images.Add("bz2", System.Drawing.SystemIcons.Information);

            /*listViewLaunch.Items.Clear();
            listViewLaunch.Groups.Clear();
            //listViewLaunch.LargeImageList = images;

            listViewLaunch.Groups.Add(g1);
            listViewLaunch.Groups.Add(g2);
            listViewLaunch.Groups.Add(g3);

            listViewLaunch.Items.Add(new ListViewItem("Private Beta [Auto Updated]", "nielk1_pack_1/bzone.ico", g1));
            listViewLaunch.Items.Add(new ListViewItem("Battlezone II", "bz2", g2));
            listViewLaunch.Items.Add(new ListViewItem("Forgotten Enemies", "bz2", g2));
            listViewLaunch.Items.Add(new ListViewItem("QF", "bz2", g2));
            listViewLaunch.Items.Add(new ListViewItem("Uler", "bz2", g2));
            listViewLaunch.Items.Add(new ListViewItem("Legacy of Ashes", "bz2", g2));
            listViewLaunch.Items.Add(new ListViewItem("QF2", "bz2", g3));*/
        }


        private void tsbLaunch_Click(object sender, EventArgs e)
        {
            tsbOptions.Checked = false;
            tsbAction.Checked = false;
            if (!tsbLaunch.Checked)
            {
                splitContainerLaunchTab.Panel2Collapsed = true;
            } else {
                splitContainerLaunchTab.Panel2.Controls.Clear();
                splitContainerLaunchTab.Panel2Collapsed = false;
            }
        }

        private void tsbOptions_Click(object sender, EventArgs e)
        {
            tsbLaunch.Checked = false;
            tsbAction.Checked = false;
            if (!tsbOptions.Checked)
            {
                splitContainerLaunchTab.Panel2Collapsed = true;
            }
            else
            {
                splitContainerLaunchTab.Panel2.Controls.Clear();
                splitContainerLaunchTab.Panel2Collapsed = false;
            }
        }

        private void tsbAction_Click(object sender, EventArgs e)
        {
            tsbOptions.Checked = false;
            tsbLaunch.Checked = false;
            if (!tsbAction.Checked)
            {
                splitContainerLaunchTab.Panel2Collapsed = true;
            }
            else
            {
                splitContainerLaunchTab.Panel2.Controls.Clear();
                splitContainerLaunchTab.Panel2Collapsed = false;
            }
        }

        private void listViewLaunch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            //BackgroundTaskWorker.CancelAsync();
            //while (BackgroundTaskWorker.IsBusy()) {
            //    Thread.Sleep(1000);
            //}
        }
    }
}

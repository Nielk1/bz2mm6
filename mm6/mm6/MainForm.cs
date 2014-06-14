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
using Newtonsoft.Json.Linq;

namespace mm6
{
    public partial class MainForm : Form
    {
        QueuedBackgroundWorker BackgroundTaskWorker;
        GameLaunchListModel GameLaunchData;

        public MainForm()
        {
            InitializeComponent();
            splitContainerLaunchTab.Panel2Collapsed = true;

            //iconCollection = new IconCollection();

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
            /*BackgroundTaskWorker.RunAsync(
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
            );*/

            BackgroundTaskWorker.RunAsync(
                (obj, args) =>
                {
                    ((BackgroundWorker)obj).ReportProgress(0);
                    string[] files = Directory.GetFiles("./data/instances/").Where(file => Path.GetExtension(file).ToLowerInvariant() == ".json").ToArray();
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
                },
                (obj, args) =>
                {
                    toolStripStatusLabel.Text = "Loading Instances";
                    toolStripProgressBar.Value = args.ProgressPercentage;
                    toolStripProgressBar.Visible = true;
                }
            );

            BackgroundTaskWorker.RunAsync(
                (obj, args) =>
                {
                    ((BackgroundWorker)obj).ReportProgress(0);
                    string[] files = Directory.GetFiles("./data/modentrys/").Where(file => Path.GetExtension(file).ToLowerInvariant() == ".json").ToArray();
                    int count = files.Length;
                    for (int x = 0; x < count; x++)
                    {
                        ((BackgroundWorker)obj).ReportProgress(x * 100 / count);
                        ModEntry tmpModEntry = Factories.MakeModEntry(files[x]);
                        if (tmpModEntry != null)
                        {
                            GameInstance tmpInstance = GameLaunchData.GetInstanceByName(tmpModEntry.InstanceId);
                            if (tmpInstance != null)
                            {
                                tmpInstance.AddModEntry(tmpModEntry);
                            }
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
                    toolStripStatusLabel.Text = "Loading Mods";
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
            listViewLaunch.bind();
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

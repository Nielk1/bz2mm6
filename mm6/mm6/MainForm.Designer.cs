namespace mm6
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabLaunch = new System.Windows.Forms.TabPage();
            this.splitContainerLaunchTab = new System.Windows.Forms.SplitContainer();
            this.toolStripLaunch = new System.Windows.Forms.ToolStrip();
            this.tsbLaunch = new System.Windows.Forms.ToolStripButton();
            this.tsbOptions = new System.Windows.Forms.ToolStripButton();
            this.tsbAction = new System.Windows.Forms.ToolStripButton();
            this.tabAdd = new System.Windows.Forms.TabPage();
            this.toolStripAdd = new System.Windows.Forms.ToolStrip();
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.listViewLaunch = new MM6.Controls.GameLaunchListView();
            this.tabControlMain.SuspendLayout();
            this.tabLaunch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLaunchTab)).BeginInit();
            this.splitContainerLaunchTab.Panel1.SuspendLayout();
            this.splitContainerLaunchTab.SuspendLayout();
            this.toolStripLaunch.SuspendLayout();
            this.tabAdd.SuspendLayout();
            this.menuStripMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabLaunch);
            this.tabControlMain.Controls.Add(this.tabAdd);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(670, 299);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabLaunch
            // 
            this.tabLaunch.BackColor = System.Drawing.SystemColors.Control;
            this.tabLaunch.Controls.Add(this.splitContainerLaunchTab);
            this.tabLaunch.Location = new System.Drawing.Point(4, 22);
            this.tabLaunch.Name = "tabLaunch";
            this.tabLaunch.Padding = new System.Windows.Forms.Padding(3);
            this.tabLaunch.Size = new System.Drawing.Size(662, 273);
            this.tabLaunch.TabIndex = 0;
            this.tabLaunch.Text = "Launch";
            // 
            // splitContainerLaunchTab
            // 
            this.splitContainerLaunchTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerLaunchTab.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainerLaunchTab.Location = new System.Drawing.Point(3, 3);
            this.splitContainerLaunchTab.Name = "splitContainerLaunchTab";
            // 
            // splitContainerLaunchTab.Panel1
            // 
            this.splitContainerLaunchTab.Panel1.Controls.Add(this.listViewLaunch);
            this.splitContainerLaunchTab.Panel1.Controls.Add(this.toolStripLaunch);
            this.splitContainerLaunchTab.Size = new System.Drawing.Size(656, 267);
            this.splitContainerLaunchTab.SplitterDistance = 467;
            this.splitContainerLaunchTab.TabIndex = 2;
            // 
            // toolStripLaunch
            // 
            this.toolStripLaunch.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStripLaunch.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripLaunch.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLaunch,
            this.tsbOptions,
            this.tsbAction});
            this.toolStripLaunch.Location = new System.Drawing.Point(444, 0);
            this.toolStripLaunch.Name = "toolStripLaunch";
            this.toolStripLaunch.Padding = new System.Windows.Forms.Padding(0);
            this.toolStripLaunch.Size = new System.Drawing.Size(23, 267);
            this.toolStripLaunch.TabIndex = 0;
            this.toolStripLaunch.Text = "toolStrip1";
            this.toolStripLaunch.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // tsbLaunch
            // 
            this.tsbLaunch.CheckOnClick = true;
            this.tsbLaunch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLaunch.Image = ((System.Drawing.Image)(resources.GetObject("tsbLaunch.Image")));
            this.tsbLaunch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLaunch.Name = "tsbLaunch";
            this.tsbLaunch.Size = new System.Drawing.Size(22, 20);
            this.tsbLaunch.Text = "Launch";
            this.tsbLaunch.Click += new System.EventHandler(this.tsbLaunch_Click);
            // 
            // tsbOptions
            // 
            this.tsbOptions.CheckOnClick = true;
            this.tsbOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOptions.Image = ((System.Drawing.Image)(resources.GetObject("tsbOptions.Image")));
            this.tsbOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOptions.Name = "tsbOptions";
            this.tsbOptions.Size = new System.Drawing.Size(22, 20);
            this.tsbOptions.Text = "Options";
            this.tsbOptions.Click += new System.EventHandler(this.tsbOptions_Click);
            // 
            // tsbAction
            // 
            this.tsbAction.CheckOnClick = true;
            this.tsbAction.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAction.Image = ((System.Drawing.Image)(resources.GetObject("tsbAction.Image")));
            this.tsbAction.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAction.Name = "tsbAction";
            this.tsbAction.Size = new System.Drawing.Size(22, 20);
            this.tsbAction.Text = "Actions";
            this.tsbAction.Click += new System.EventHandler(this.tsbAction_Click);
            // 
            // tabAdd
            // 
            this.tabAdd.BackColor = System.Drawing.SystemColors.Control;
            this.tabAdd.Controls.Add(this.toolStripAdd);
            this.tabAdd.Location = new System.Drawing.Point(4, 22);
            this.tabAdd.Name = "tabAdd";
            this.tabAdd.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdd.Size = new System.Drawing.Size(662, 273);
            this.tabAdd.TabIndex = 1;
            this.tabAdd.Text = "Add Mod/Patch";
            // 
            // toolStripAdd
            // 
            this.toolStripAdd.Location = new System.Drawing.Point(3, 3);
            this.toolStripAdd.Name = "toolStripAdd";
            this.toolStripAdd.Size = new System.Drawing.Size(656, 25);
            this.toolStripAdd.TabIndex = 0;
            this.toolStripAdd.Text = "toolStrip1";
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(670, 24);
            this.menuStripMain.TabIndex = 1;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(211, 186);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 100);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.Location = new System.Drawing.Point(105, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 100);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 100);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // statusStripMain
            // 
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
            this.statusStripMain.Location = new System.Drawing.Point(0, 323);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(670, 22);
            this.statusStripMain.TabIndex = 2;
            this.statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(23, 17);
            this.toolStripStatusLabel.Text = "OK";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            // 
            // listViewLaunch
            // 
            this.listViewLaunch.DataSource = null;
            this.listViewLaunch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLaunch.HideSelection = false;
            this.listViewLaunch.Location = new System.Drawing.Point(0, 0);
            this.listViewLaunch.MultiSelect = false;
            this.listViewLaunch.Name = "listViewLaunch";
            this.listViewLaunch.Size = new System.Drawing.Size(444, 267);
            this.listViewLaunch.TabIndex = 1;
            this.listViewLaunch.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 345);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.Controls.Add(this.statusStripMain);
            this.Enabled = false;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "MainForm";
            this.Text = "MM6";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabLaunch.ResumeLayout(false);
            this.splitContainerLaunchTab.Panel1.ResumeLayout(false);
            this.splitContainerLaunchTab.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerLaunchTab)).EndInit();
            this.splitContainerLaunchTab.ResumeLayout(false);
            this.toolStripLaunch.ResumeLayout(false);
            this.toolStripLaunch.PerformLayout();
            this.tabAdd.ResumeLayout(false);
            this.tabAdd.PerformLayout();
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabLaunch;
        private System.Windows.Forms.TabPage tabAdd;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripAdd;
        private System.Windows.Forms.SplitContainer splitContainerLaunchTab;
        private System.Windows.Forms.ToolStrip toolStripLaunch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private MM6.Controls.GameLaunchListView listViewLaunch;
        private System.Windows.Forms.ToolStripButton tsbAction;
        private System.Windows.Forms.ToolStripButton tsbOptions;
        private System.Windows.Forms.ToolStripButton tsbLaunch;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
    }
}


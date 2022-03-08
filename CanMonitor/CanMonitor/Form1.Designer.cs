﻿namespace CanMonitor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.checkBox_showEMCY = new System.Windows.Forms.CheckBox();
            this.checkBox_showNMTEC = new System.Windows.Forms.CheckBox();
            this.checkBox_showNMT = new System.Windows.Forms.CheckBox();
            this.checkBox_showSDO = new System.Windows.Forms.CheckBox();
            this.checkBox_showPDO = new System.Windows.Forms.CheckBox();
            this.button_refresh = new System.Windows.Forms.Button();
            this.checkBox_heartbeats = new System.Windows.Forms.CheckBox();
            this.button_open = new System.Windows.Forms.Button();
            this.comboBox_rate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_port = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkbox_autoscroll = new System.Windows.Forms.CheckBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listView_nmt = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listView_emcy = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.textBox_info = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecentlyUsed = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPluginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_showEMCY);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_showNMTEC);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_showNMT);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_showSDO);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_showPDO);
            this.splitContainer1.Panel1.Controls.Add(this.button_refresh);
            this.splitContainer1.Panel1.Controls.Add(this.checkBox_heartbeats);
            this.splitContainer1.Panel1.Controls.Add(this.button_open);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_rate);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_port);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.checkbox_autoscroll);
            this.splitContainer1.Panel1.Controls.Add(this.button_clear);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1464, 829);
            this.splitContainer1.SplitterDistance = 82;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // checkBox_showEMCY
            // 
            this.checkBox_showEMCY.AutoSize = true;
            this.checkBox_showEMCY.Location = new System.Drawing.Point(1067, 59);
            this.checkBox_showEMCY.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_showEMCY.Name = "checkBox_showEMCY";
            this.checkBox_showEMCY.Size = new System.Drawing.Size(68, 21);
            this.checkBox_showEMCY.TabIndex = 10;
            this.checkBox_showEMCY.Text = "EMCY";
            this.checkBox_showEMCY.UseVisualStyleBackColor = true;
            this.checkBox_showEMCY.CheckedChanged += new System.EventHandler(this.checkBox_emcy_CheckedChanged);
            // 
            // checkBox_showNMTEC
            // 
            this.checkBox_showNMTEC.AutoSize = true;
            this.checkBox_showNMTEC.Location = new System.Drawing.Point(1067, 33);
            this.checkBox_showNMTEC.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_showNMTEC.Name = "checkBox_showNMTEC";
            this.checkBox_showNMTEC.Size = new System.Drawing.Size(78, 21);
            this.checkBox_showNMTEC.TabIndex = 9;
            this.checkBox_showNMTEC.Text = "NMTEC";
            this.checkBox_showNMTEC.UseVisualStyleBackColor = true;
            this.checkBox_showNMTEC.CheckedChanged += new System.EventHandler(this.checkBox_NMTEC_CheckedChanged);
            // 
            // checkBox_showNMT
            // 
            this.checkBox_showNMT.AutoSize = true;
            this.checkBox_showNMT.Location = new System.Drawing.Point(1067, 7);
            this.checkBox_showNMT.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_showNMT.Name = "checkBox_showNMT";
            this.checkBox_showNMT.Size = new System.Drawing.Size(60, 21);
            this.checkBox_showNMT.TabIndex = 8;
            this.checkBox_showNMT.Text = "NMT";
            this.checkBox_showNMT.UseVisualStyleBackColor = true;
            this.checkBox_showNMT.CheckedChanged += new System.EventHandler(this.checkBox_nmt_CheckedChanged);
            // 
            // checkBox_showSDO
            // 
            this.checkBox_showSDO.AutoSize = true;
            this.checkBox_showSDO.Location = new System.Drawing.Point(943, 57);
            this.checkBox_showSDO.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_showSDO.Name = "checkBox_showSDO";
            this.checkBox_showSDO.Size = new System.Drawing.Size(60, 21);
            this.checkBox_showSDO.TabIndex = 7;
            this.checkBox_showSDO.Text = "SDO";
            this.checkBox_showSDO.UseVisualStyleBackColor = true;
            this.checkBox_showSDO.CheckedChanged += new System.EventHandler(this.checkBox_showSDO_CheckedChanged);
            // 
            // checkBox_showPDO
            // 
            this.checkBox_showPDO.AutoSize = true;
            this.checkBox_showPDO.Location = new System.Drawing.Point(943, 32);
            this.checkBox_showPDO.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_showPDO.Name = "checkBox_showPDO";
            this.checkBox_showPDO.Size = new System.Drawing.Size(60, 21);
            this.checkBox_showPDO.TabIndex = 6;
            this.checkBox_showPDO.Text = "PDO";
            this.checkBox_showPDO.UseVisualStyleBackColor = true;
            this.checkBox_showPDO.CheckedChanged += new System.EventHandler(this.checkBox_showPDO_CheckedChanged);
            // 
            // button_refresh
            // 
            this.button_refresh.Image = ((System.Drawing.Image)(resources.GetObject("button_refresh.Image")));
            this.button_refresh.Location = new System.Drawing.Point(198, 14);
            this.button_refresh.Name = "button_refresh";
            this.button_refresh.Size = new System.Drawing.Size(32, 30);
            this.button_refresh.TabIndex = 5;
            this.button_refresh.Text = "R";
            this.button_refresh.UseVisualStyleBackColor = true;
            this.button_refresh.Click += new System.EventHandler(this.button_refresh_Click);
            // 
            // checkBox_heartbeats
            // 
            this.checkBox_heartbeats.AutoSize = true;
            this.checkBox_heartbeats.Location = new System.Drawing.Point(943, 7);
            this.checkBox_heartbeats.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_heartbeats.Name = "checkBox_heartbeats";
            this.checkBox_heartbeats.Size = new System.Drawing.Size(100, 21);
            this.checkBox_heartbeats.TabIndex = 4;
            this.checkBox_heartbeats.Text = "Heartbeats";
            this.checkBox_heartbeats.UseVisualStyleBackColor = true;
            this.checkBox_heartbeats.CheckedChanged += new System.EventHandler(this.checkBox_heartbeats_CheckedChanged);
            // 
            // button_open
            // 
            this.button_open.Location = new System.Drawing.Point(469, 16);
            this.button_open.Margin = new System.Windows.Forms.Padding(4);
            this.button_open.Name = "button_open";
            this.button_open.Size = new System.Drawing.Size(141, 28);
            this.button_open.TabIndex = 3;
            this.button_open.Text = "Open";
            this.button_open.UseVisualStyleBackColor = true;
            this.button_open.Click += new System.EventHandler(this.button_open_Click);
            // 
            // comboBox_rate
            // 
            this.comboBox_rate.FormattingEnabled = true;
            this.comboBox_rate.Items.AddRange(new object[] {
            "10Kbit",
            "20Kbit",
            "50Kbit",
            "100Kbit",
            "125Kbit",
            "250Kbit",
            "500Kbit",
            "800Kbit",
            "1Mbit"});
            this.comboBox_rate.Location = new System.Drawing.Point(299, 18);
            this.comboBox_rate.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_rate.Name = "comboBox_rate";
            this.comboBox_rate.Size = new System.Drawing.Size(144, 24);
            this.comboBox_rate.TabIndex = 2;
            this.comboBox_rate.SelectedIndexChanged += new System.EventHandler(this.comboBox_rate_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bitrate";
            // 
            // comboBox_port
            // 
            this.comboBox_port.FormattingEnabled = true;
            this.comboBox_port.Location = new System.Drawing.Point(47, 18);
            this.comboBox_port.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_port.Name = "comboBox_port";
            this.comboBox_port.Size = new System.Drawing.Size(144, 24);
            this.comboBox_port.TabIndex = 0;
            this.comboBox_port.SelectedIndexChanged += new System.EventHandler(this.comboBox_port_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port";
            // 
            // checkbox_autoscroll
            // 
            this.checkbox_autoscroll.AutoSize = true;
            this.checkbox_autoscroll.Checked = true;
            this.checkbox_autoscroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkbox_autoscroll.Location = new System.Drawing.Point(619, 23);
            this.checkbox_autoscroll.Margin = new System.Windows.Forms.Padding(4);
            this.checkbox_autoscroll.Name = "checkbox_autoscroll";
            this.checkbox_autoscroll.Size = new System.Drawing.Size(92, 21);
            this.checkbox_autoscroll.TabIndex = 0;
            this.checkbox_autoscroll.Text = "Autoscroll";
            this.checkbox_autoscroll.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(723, 16);
            this.button_clear.Margin = new System.Windows.Forms.Padding(4);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(100, 28);
            this.button_clear.TabIndex = 1;
            this.button_clear.Text = "Clear all";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1464, 742);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1456, 713);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitor";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 4);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1448, 705);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Timestamp";
            this.columnHeader13.Width = 176;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Type";
            this.columnHeader1.Width = 103;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "COB";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Node";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Payload";
            this.columnHeader4.Width = 192;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Info";
            this.columnHeader5.Width = 559;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listView_nmt);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1456, 714);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "NMT";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listView_nmt
            // 
            this.listView_nmt.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader6,
            this.columnHeader7});
            this.listView_nmt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_nmt.HideSelection = false;
            this.listView_nmt.Location = new System.Drawing.Point(4, 4);
            this.listView_nmt.Margin = new System.Windows.Forms.Padding(4);
            this.listView_nmt.Name = "listView_nmt";
            this.listView_nmt.Size = new System.Drawing.Size(1448, 706);
            this.listView_nmt.TabIndex = 0;
            this.listView_nmt.UseCompatibleStateImageBehavior = false;
            this.listView_nmt.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Time";
            this.columnHeader12.Width = 188;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Node";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "State";
            this.columnHeader7.Width = 280;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listView_emcy);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1456, 714);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Emergency";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listView_emcy
            // 
            this.listView_emcy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.listView_emcy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView_emcy.HideSelection = false;
            this.listView_emcy.Location = new System.Drawing.Point(0, 0);
            this.listView_emcy.Margin = new System.Windows.Forms.Padding(4);
            this.listView_emcy.Name = "listView_emcy";
            this.listView_emcy.Size = new System.Drawing.Size(1456, 714);
            this.listView_emcy.TabIndex = 0;
            this.listView_emcy.UseCompatibleStateImageBehavior = false;
            this.listView_emcy.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Time";
            this.columnHeader8.Width = 87;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Node";
            this.columnHeader9.Width = 78;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Payload";
            this.columnHeader10.Width = 129;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Info";
            this.columnHeader11.Width = 729;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.textBox_info);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(1456, 714);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Info";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // textBox_info
            // 
            this.textBox_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_info.Location = new System.Drawing.Point(4, 4);
            this.textBox_info.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_info.Multiline = true;
            this.textBox_info.Name = "textBox_info";
            this.textBox_info.ReadOnly = true;
            this.textBox_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_info.Size = new System.Drawing.Size(1448, 706);
            this.textBox_info.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1464, 30);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecentlyUsed,
            this.loadPluginToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveDataToolStripMenuItem,
            this.loadDataToolStripMenuItem,
            this.toolStripSeparator2,
            this.preferencesToolStripMenuItem,
            this.toolStripSeparator3,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuRecentlyUsed
            // 
            this.mnuRecentlyUsed.Name = "mnuRecentlyUsed";
            this.mnuRecentlyUsed.Size = new System.Drawing.Size(188, 26);
            this.mnuRecentlyUsed.Text = "Recent Plugins";
            // 
            // loadPluginToolStripMenuItem
            // 
            this.loadPluginToolStripMenuItem.Name = "loadPluginToolStripMenuItem";
            this.loadPluginToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.loadPluginToolStripMenuItem.Text = "Load Plugin";
            this.loadPluginToolStripMenuItem.Click += new System.EventHandler(this.loadPluginToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(185, 6);
            // 
            // saveDataToolStripMenuItem
            // 
            this.saveDataToolStripMenuItem.Name = "saveDataToolStripMenuItem";
            this.saveDataToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.saveDataToolStripMenuItem.Text = "Save Data";
            this.saveDataToolStripMenuItem.Click += new System.EventHandler(this.saveDataToolStripMenuItem_Click);
            // 
            // loadDataToolStripMenuItem
            // 
            this.loadDataToolStripMenuItem.Name = "loadDataToolStripMenuItem";
            this.loadDataToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.loadDataToolStripMenuItem.Text = "Load Data";
            this.loadDataToolStripMenuItem.Click += new System.EventHandler(this.loadDataToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // preferencesToolStripMenuItem
            // 
            this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
            this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.preferencesToolStripMenuItem.Text = "Preferences";
            this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipTitle = "CanOpen Monitor";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "CanOpen Monitor";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1464, 859);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CanOpen monitor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_open;
        private System.Windows.Forms.ComboBox comboBox_rate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.CheckBox checkbox_autoscroll;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox checkBox_heartbeats;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listView_nmt;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListView listView_emcy;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ToolStripMenuItem loadPluginToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox_info;
        private System.Windows.Forms.ToolStripMenuItem mnuRecentlyUsed;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadDataToolStripMenuItem;
        private System.Windows.Forms.Button button_refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem preferencesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.CheckBox checkBox_showSDO;
        private System.Windows.Forms.CheckBox checkBox_showPDO;
        private System.Windows.Forms.CheckBox checkBox_showEMCY;
        private System.Windows.Forms.CheckBox checkBox_showNMTEC;
        private System.Windows.Forms.CheckBox checkBox_showNMT;
    }
}


namespace QuestHome.UI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lst_homes = new System.Windows.Forms.CheckedListBox();
            this.menu_main = new System.Windows.Forms.MenuStrip();
            this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeDeviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootRecoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootFastbootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootBootloaderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shutdownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_apply = new System.Windows.Forms.GroupBox();
            this.tabs_main = new System.Windows.Forms.TabControl();
            this.tab_overview = new System.Windows.Forms.TabPage();
            this.txt_debug = new System.Windows.Forms.TextBox();
            this.tab_news = new System.Windows.Forms.TabPage();
            this.tab_homes = new System.Windows.Forms.TabPage();
            this.tab_firmware = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.box_fw_mirror = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_fw_changelog = new System.Windows.Forms.RichTextBox();
            this.ctx_fw_changelog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openInBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_fw_release = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_fw_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_fw_apply = new System.Windows.Forms.Button();
            this.lst_fw = new System.Windows.Forms.ListBox();
            this.tab_apps = new System.Windows.Forms.TabPage();
            this.status = new System.Windows.Forms.StatusStrip();
            this.status_bar = new System.Windows.Forms.ToolStripProgressBar();
            this.status_battery_lc = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_battery_rc = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_battery_hmd = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_connection_mode = new System.Windows.Forms.ToolStripStatusLabel();
            this.status_text = new System.Windows.Forms.ToolStripStatusLabel();
            this.shellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_main.SuspendLayout();
            this.tabs_main.SuspendLayout();
            this.tab_overview.SuspendLayout();
            this.tab_homes.SuspendLayout();
            this.tab_firmware.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.ctx_fw_changelog.SuspendLayout();
            this.status.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_homes
            // 
            this.lst_homes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lst_homes.FormattingEnabled = true;
            this.lst_homes.Items.AddRange(new object[] {
            "Default Home"});
            this.lst_homes.Location = new System.Drawing.Point(6, 6);
            this.lst_homes.Name = "lst_homes";
            this.lst_homes.Size = new System.Drawing.Size(196, 394);
            this.lst_homes.TabIndex = 0;
            // 
            // menu_main
            // 
            this.menu_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reloadToolStripMenuItem,
            this.aDBToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu_main.Location = new System.Drawing.Point(0, 0);
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(744, 25);
            this.menu_main.TabIndex = 1;
            this.menu_main.Text = "menuStrip1";
            // 
            // reloadToolStripMenuItem
            // 
            this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
            this.reloadToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.reloadToolStripMenuItem.Text = "Reload";
            this.reloadToolStripMenuItem.Click += new System.EventHandler(this.reloadToolStripMenuItem_Click);
            // 
            // aDBToolStripMenuItem
            // 
            this.aDBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeDeviceToolStripMenuItem,
            this.rebootToolStripMenuItem,
            this.shutdownToolStripMenuItem,
            this.shellToolStripMenuItem});
            this.aDBToolStripMenuItem.Name = "aDBToolStripMenuItem";
            this.aDBToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.aDBToolStripMenuItem.Text = "ADB";
            // 
            // changeDeviceToolStripMenuItem
            // 
            this.changeDeviceToolStripMenuItem.Name = "changeDeviceToolStripMenuItem";
            this.changeDeviceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.changeDeviceToolStripMenuItem.Text = "Change Device";
            this.changeDeviceToolStripMenuItem.Click += new System.EventHandler(this.changeDeviceToolStripMenuItem_Click);
            // 
            // rebootToolStripMenuItem
            // 
            this.rebootToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rebootSystemToolStripMenuItem,
            this.rebootRecoveryToolStripMenuItem,
            this.rebootFastbootToolStripMenuItem,
            this.rebootBootloaderToolStripMenuItem});
            this.rebootToolStripMenuItem.Name = "rebootToolStripMenuItem";
            this.rebootToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rebootToolStripMenuItem.Text = "Reboot";
            // 
            // rebootSystemToolStripMenuItem
            // 
            this.rebootSystemToolStripMenuItem.Name = "rebootSystemToolStripMenuItem";
            this.rebootSystemToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.rebootSystemToolStripMenuItem.Text = "System";
            this.rebootSystemToolStripMenuItem.Click += new System.EventHandler(this.rebootSystemToolStripMenuItem_Click);
            // 
            // rebootRecoveryToolStripMenuItem
            // 
            this.rebootRecoveryToolStripMenuItem.Name = "rebootRecoveryToolStripMenuItem";
            this.rebootRecoveryToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.rebootRecoveryToolStripMenuItem.Text = "Recovery";
            this.rebootRecoveryToolStripMenuItem.Click += new System.EventHandler(this.rebootRecoveryToolStripMenuItem_Click);
            // 
            // rebootFastbootToolStripMenuItem
            // 
            this.rebootFastbootToolStripMenuItem.Name = "rebootFastbootToolStripMenuItem";
            this.rebootFastbootToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.rebootFastbootToolStripMenuItem.Text = "Fastboot";
            this.rebootFastbootToolStripMenuItem.Click += new System.EventHandler(this.rebootFastbootToolStripMenuItem_Click);
            // 
            // rebootBootloaderToolStripMenuItem
            // 
            this.rebootBootloaderToolStripMenuItem.Name = "rebootBootloaderToolStripMenuItem";
            this.rebootBootloaderToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.rebootBootloaderToolStripMenuItem.Text = "Bootloader";
            this.rebootBootloaderToolStripMenuItem.Click += new System.EventHandler(this.rebootBootloaderToolStripMenuItem_Click);
            // 
            // shutdownToolStripMenuItem
            // 
            this.shutdownToolStripMenuItem.Name = "shutdownToolStripMenuItem";
            this.shutdownToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shutdownToolStripMenuItem.Text = "Shutdown";
            this.shutdownToolStripMenuItem.Click += new System.EventHandler(this.shutdownToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // grp_apply
            // 
            this.grp_apply.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grp_apply.Location = new System.Drawing.Point(208, 361);
            this.grp_apply.Name = "grp_apply";
            this.grp_apply.Size = new System.Drawing.Size(522, 42);
            this.grp_apply.TabIndex = 3;
            this.grp_apply.TabStop = false;
            this.grp_apply.Text = "Apply";
            // 
            // tabs_main
            // 
            this.tabs_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs_main.Controls.Add(this.tab_overview);
            this.tabs_main.Controls.Add(this.tab_news);
            this.tabs_main.Controls.Add(this.tab_homes);
            this.tabs_main.Controls.Add(this.tab_firmware);
            this.tabs_main.Controls.Add(this.tab_apps);
            this.tabs_main.Location = new System.Drawing.Point(0, 28);
            this.tabs_main.Name = "tabs_main";
            this.tabs_main.SelectedIndex = 0;
            this.tabs_main.Size = new System.Drawing.Size(744, 439);
            this.tabs_main.TabIndex = 4;
            this.tabs_main.SelectedIndexChanged += new System.EventHandler(this.tabs_main_SelectedIndexChanged);
            this.tabs_main.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabs_main_Selecting);
            this.tabs_main.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabs_main_Selected);
            this.tabs_main.TabIndexChanged += new System.EventHandler(this.tabs_main_TabIndexChanged);
            // 
            // tab_overview
            // 
            this.tab_overview.Controls.Add(this.txt_debug);
            this.tab_overview.Location = new System.Drawing.Point(4, 22);
            this.tab_overview.Name = "tab_overview";
            this.tab_overview.Padding = new System.Windows.Forms.Padding(3);
            this.tab_overview.Size = new System.Drawing.Size(736, 413);
            this.tab_overview.TabIndex = 0;
            this.tab_overview.Text = "Overview";
            this.tab_overview.UseVisualStyleBackColor = true;
            // 
            // txt_debug
            // 
            this.txt_debug.Dock = System.Windows.Forms.DockStyle.Left;
            this.txt_debug.Location = new System.Drawing.Point(3, 3);
            this.txt_debug.Multiline = true;
            this.txt_debug.Name = "txt_debug";
            this.txt_debug.ReadOnly = true;
            this.txt_debug.Size = new System.Drawing.Size(370, 407);
            this.txt_debug.TabIndex = 0;
            // 
            // tab_news
            // 
            this.tab_news.Location = new System.Drawing.Point(4, 22);
            this.tab_news.Name = "tab_news";
            this.tab_news.Padding = new System.Windows.Forms.Padding(3);
            this.tab_news.Size = new System.Drawing.Size(736, 413);
            this.tab_news.TabIndex = 1;
            this.tab_news.Text = "News";
            this.tab_news.UseVisualStyleBackColor = true;
            // 
            // tab_homes
            // 
            this.tab_homes.Controls.Add(this.lst_homes);
            this.tab_homes.Controls.Add(this.grp_apply);
            this.tab_homes.Location = new System.Drawing.Point(4, 22);
            this.tab_homes.Name = "tab_homes";
            this.tab_homes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_homes.Size = new System.Drawing.Size(736, 413);
            this.tab_homes.TabIndex = 2;
            this.tab_homes.Text = "Homes";
            this.tab_homes.UseVisualStyleBackColor = true;
            // 
            // tab_firmware
            // 
            this.tab_firmware.Controls.Add(this.label2);
            this.tab_firmware.Controls.Add(this.box_fw_mirror);
            this.tab_firmware.Controls.Add(this.groupBox1);
            this.tab_firmware.Controls.Add(this.txt_fw_release);
            this.tab_firmware.Controls.Add(this.label3);
            this.tab_firmware.Controls.Add(this.txt_fw_id);
            this.tab_firmware.Controls.Add(this.label1);
            this.tab_firmware.Controls.Add(this.btn_fw_apply);
            this.tab_firmware.Controls.Add(this.lst_fw);
            this.tab_firmware.Location = new System.Drawing.Point(4, 22);
            this.tab_firmware.Name = "tab_firmware";
            this.tab_firmware.Size = new System.Drawing.Size(736, 413);
            this.tab_firmware.TabIndex = 3;
            this.tab_firmware.Text = "Firmware";
            this.tab_firmware.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mirror:";
            // 
            // box_fw_mirror
            // 
            this.box_fw_mirror.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_fw_mirror.FormattingEnabled = true;
            this.box_fw_mirror.Location = new System.Drawing.Point(232, 387);
            this.box_fw_mirror.Name = "box_fw_mirror";
            this.box_fw_mirror.Size = new System.Drawing.Size(420, 21);
            this.box_fw_mirror.TabIndex = 10;
            this.box_fw_mirror.SelectionChangeCommitted += new System.EventHandler(this.box_fw_mirror_SelectionChangeCommitted);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_fw_changelog);
            this.groupBox1.Location = new System.Drawing.Point(191, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 314);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Changelog";
            // 
            // txt_fw_changelog
            // 
            this.txt_fw_changelog.ContextMenuStrip = this.ctx_fw_changelog;
            this.txt_fw_changelog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_fw_changelog.Location = new System.Drawing.Point(3, 16);
            this.txt_fw_changelog.Name = "txt_fw_changelog";
            this.txt_fw_changelog.ReadOnly = true;
            this.txt_fw_changelog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txt_fw_changelog.Size = new System.Drawing.Size(531, 295);
            this.txt_fw_changelog.TabIndex = 3;
            this.txt_fw_changelog.Text = "";
            // 
            // ctx_fw_changelog
            // 
            this.ctx_fw_changelog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInBrowserToolStripMenuItem});
            this.ctx_fw_changelog.Name = "ctx_fw_changelog";
            this.ctx_fw_changelog.Size = new System.Drawing.Size(170, 26);
            // 
            // openInBrowserToolStripMenuItem
            // 
            this.openInBrowserToolStripMenuItem.Name = "openInBrowserToolStripMenuItem";
            this.openInBrowserToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.openInBrowserToolStripMenuItem.Text = "Open in Browser";
            this.openInBrowserToolStripMenuItem.Click += new System.EventHandler(this.openInBrowserToolStripMenuItem_Click);
            // 
            // txt_fw_release
            // 
            this.txt_fw_release.Location = new System.Drawing.Point(249, 41);
            this.txt_fw_release.Name = "txt_fw_release";
            this.txt_fw_release.ReadOnly = true;
            this.txt_fw_release.Size = new System.Drawing.Size(479, 20);
            this.txt_fw_release.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Released:";
            // 
            // txt_fw_id
            // 
            this.txt_fw_id.Location = new System.Drawing.Point(215, 15);
            this.txt_fw_id.Name = "txt_fw_id";
            this.txt_fw_id.ReadOnly = true;
            this.txt_fw_id.Size = new System.Drawing.Size(513, 20);
            this.txt_fw_id.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // btn_fw_apply
            // 
            this.btn_fw_apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_fw_apply.Location = new System.Drawing.Point(658, 385);
            this.btn_fw_apply.Name = "btn_fw_apply";
            this.btn_fw_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_fw_apply.TabIndex = 1;
            this.btn_fw_apply.Text = "Start Update";
            this.btn_fw_apply.UseVisualStyleBackColor = true;
            this.btn_fw_apply.Click += new System.EventHandler(this.btn_fw_apply_Click);
            // 
            // lst_fw
            // 
            this.lst_fw.FormattingEnabled = true;
            this.lst_fw.Location = new System.Drawing.Point(3, 3);
            this.lst_fw.Name = "lst_fw";
            this.lst_fw.Size = new System.Drawing.Size(169, 407);
            this.lst_fw.TabIndex = 0;
            this.lst_fw.SelectedIndexChanged += new System.EventHandler(this.lst_fw_SelectedIndexChanged);
            // 
            // tab_apps
            // 
            this.tab_apps.Location = new System.Drawing.Point(4, 22);
            this.tab_apps.Name = "tab_apps";
            this.tab_apps.Size = new System.Drawing.Size(736, 413);
            this.tab_apps.TabIndex = 4;
            this.tab_apps.Text = "Apps";
            this.tab_apps.UseVisualStyleBackColor = true;
            // 
            // status
            // 
            this.status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_bar,
            this.status_battery_lc,
            this.status_battery_rc,
            this.status_battery_hmd,
            this.status_connection_mode,
            this.status_text});
            this.status.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.status.Location = new System.Drawing.Point(0, 470);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(744, 22);
            this.status.TabIndex = 5;
            this.status.Text = "statusStrip1";
            // 
            // status_bar
            // 
            this.status_bar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.status_bar.Name = "status_bar";
            this.status_bar.Size = new System.Drawing.Size(100, 16);
            this.status_bar.Visible = false;
            // 
            // status_battery_lc
            // 
            this.status_battery_lc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.status_battery_lc.Name = "status_battery_lc";
            this.status_battery_lc.Size = new System.Drawing.Size(23, 17);
            this.status_battery_lc.Text = "?%";
            // 
            // status_battery_rc
            // 
            this.status_battery_rc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.status_battery_rc.Name = "status_battery_rc";
            this.status_battery_rc.Size = new System.Drawing.Size(26, 17);
            this.status_battery_rc.Text = "? %";
            // 
            // status_battery_hmd
            // 
            this.status_battery_hmd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.status_battery_hmd.Name = "status_battery_hmd";
            this.status_battery_hmd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.status_battery_hmd.Size = new System.Drawing.Size(26, 17);
            this.status_battery_hmd.Text = "? %";
            // 
            // status_connection_mode
            // 
            this.status_connection_mode.Name = "status_connection_mode";
            this.status_connection_mode.Size = new System.Drawing.Size(13, 17);
            this.status_connection_mode.Text = "?";
            // 
            // status_text
            // 
            this.status_text.Name = "status_text";
            this.status_text.Size = new System.Drawing.Size(64, 17);
            this.status_text.Text = "Loading ...";
            // 
            // shellToolStripMenuItem
            // 
            this.shellToolStripMenuItem.Name = "shellToolStripMenuItem";
            this.shellToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shellToolStripMenuItem.Text = "Shell";
            this.shellToolStripMenuItem.Click += new System.EventHandler(this.shellToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 492);
            this.Controls.Add(this.status);
            this.Controls.Add(this.tabs_main);
            this.Controls.Add(this.menu_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_main;
            this.Name = "MainForm";
            this.Text = "Quest Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menu_main.ResumeLayout(false);
            this.menu_main.PerformLayout();
            this.tabs_main.ResumeLayout(false);
            this.tab_overview.ResumeLayout(false);
            this.tab_overview.PerformLayout();
            this.tab_homes.ResumeLayout(false);
            this.tab_firmware.ResumeLayout(false);
            this.tab_firmware.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ctx_fw_changelog.ResumeLayout(false);
            this.status.ResumeLayout(false);
            this.status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lst_homes;
        private System.Windows.Forms.MenuStrip menu_main;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
        private System.Windows.Forms.GroupBox grp_apply;
        private System.Windows.Forms.TabControl tabs_main;
        private System.Windows.Forms.TabPage tab_overview;
        private System.Windows.Forms.TabPage tab_news;
        private System.Windows.Forms.TabPage tab_homes;
        private System.Windows.Forms.TabPage tab_firmware;
        private System.Windows.Forms.TabPage tab_apps;
        private System.Windows.Forms.StatusStrip status;
        private System.Windows.Forms.ToolStripProgressBar status_bar;
        private System.Windows.Forms.ToolStripStatusLabel status_text;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txt_fw_changelog;
        private System.Windows.Forms.TextBox txt_fw_release;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_fw_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_fw_apply;
        private System.Windows.Forms.ListBox lst_fw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox box_fw_mirror;
        private System.Windows.Forms.ContextMenuStrip ctx_fw_changelog;
        private System.Windows.Forms.ToolStripMenuItem openInBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel status_battery_hmd;
        private System.Windows.Forms.TextBox txt_debug;
        private System.Windows.Forms.ToolStripMenuItem aDBToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel status_battery_lc;
        private System.Windows.Forms.ToolStripStatusLabel status_battery_rc;
        private System.Windows.Forms.ToolStripStatusLabel status_connection_mode;
        private System.Windows.Forms.ToolStripMenuItem changeDeviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebootSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebootRecoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebootFastbootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shutdownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rebootBootloaderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shellToolStripMenuItem;
    }
}


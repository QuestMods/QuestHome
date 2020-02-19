namespace QuestHome.UI.Popups
{
    partial class DeviceSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeviceSettings));
            this.grp_recording = new System.Windows.Forms.GroupBox();
            this.grp_foveation = new System.Windows.Forms.GroupBox();
            this.box_resolution = new System.Windows.Forms.ComboBox();
            this.int_bitrate = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.box_foveation = new System.Windows.Forms.ComboBox();
            this.grp_textures = new System.Windows.Forms.GroupBox();
            this.int_texture_height = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.int_texture_width = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.grp_metrics = new System.Windows.Forms.GroupBox();
            this.chk_omms_graph = new System.Windows.Forms.CheckBox();
            this.chk_omms_graph2 = new System.Windows.Forms.CheckBox();
            this.chk_omms_stats = new System.Windows.Forms.CheckBox();
            this.int_omms_scale = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_omms_headlock = new System.Windows.Forms.CheckBox();
            this.chk_omms_enable = new System.Windows.Forms.CheckBox();
            this.btn_omms_start = new System.Windows.Forms.Button();
            this.chk_omms_logging = new System.Windows.Forms.CheckBox();
            this.chk_omms_remote = new System.Windows.Forms.CheckBox();
            this.grp_recording.SuspendLayout();
            this.grp_foveation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.int_bitrate)).BeginInit();
            this.grp_textures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.int_texture_height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_texture_width)).BeginInit();
            this.grp_metrics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.int_omms_scale)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_recording
            // 
            this.grp_recording.Controls.Add(this.label2);
            this.grp_recording.Controls.Add(this.label1);
            this.grp_recording.Controls.Add(this.int_bitrate);
            this.grp_recording.Controls.Add(this.box_resolution);
            this.grp_recording.Location = new System.Drawing.Point(12, 65);
            this.grp_recording.Name = "grp_recording";
            this.grp_recording.Size = new System.Drawing.Size(290, 75);
            this.grp_recording.TabIndex = 0;
            this.grp_recording.TabStop = false;
            this.grp_recording.Text = "Recording";
            // 
            // grp_foveation
            // 
            this.grp_foveation.Controls.Add(this.box_foveation);
            this.grp_foveation.Location = new System.Drawing.Point(12, 12);
            this.grp_foveation.Name = "grp_foveation";
            this.grp_foveation.Size = new System.Drawing.Size(290, 47);
            this.grp_foveation.TabIndex = 1;
            this.grp_foveation.TabStop = false;
            this.grp_foveation.Text = "Foveation";
            // 
            // box_resolution
            // 
            this.box_resolution.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_resolution.FormattingEnabled = true;
            this.box_resolution.Items.AddRange(new object[] {
            "1920 x 1080",
            "1280 x 720 (recommended)",
            "1024 x 1024 (default)"});
            this.box_resolution.Location = new System.Drawing.Point(73, 19);
            this.box_resolution.Name = "box_resolution";
            this.box_resolution.Size = new System.Drawing.Size(128, 21);
            this.box_resolution.TabIndex = 0;
            this.box_resolution.Text = "1024 x 1024 (default)";
            this.box_resolution.SelectionChangeCommitted += new System.EventHandler(this.box_resolution_SelectionChangeCommitted);
            // 
            // int_bitrate
            // 
            this.int_bitrate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.int_bitrate.Increment = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.int_bitrate.Location = new System.Drawing.Point(73, 46);
            this.int_bitrate.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.int_bitrate.Name = "int_bitrate";
            this.int_bitrate.Size = new System.Drawing.Size(85, 20);
            this.int_bitrate.TabIndex = 2;
            this.int_bitrate.Value = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resolution:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitrate:";
            // 
            // box_foveation
            // 
            this.box_foveation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.box_foveation.FormattingEnabled = true;
            this.box_foveation.Items.AddRange(new object[] {
            "0 (Off/Auto, Default)",
            "1 (Low)",
            "2 (Medium)",
            "3 (High)"});
            this.box_foveation.Location = new System.Drawing.Point(3, 16);
            this.box_foveation.Name = "box_foveation";
            this.box_foveation.Size = new System.Drawing.Size(284, 21);
            this.box_foveation.TabIndex = 1;
            this.box_foveation.Text = "0 (Off, Default)";
            this.box_foveation.TextUpdate += new System.EventHandler(this.box_foveation_TextUpdate);
            // 
            // grp_textures
            // 
            this.grp_textures.Controls.Add(this.label4);
            this.grp_textures.Controls.Add(this.int_texture_width);
            this.grp_textures.Controls.Add(this.label3);
            this.grp_textures.Controls.Add(this.int_texture_height);
            this.grp_textures.Location = new System.Drawing.Point(12, 146);
            this.grp_textures.Name = "grp_textures";
            this.grp_textures.Size = new System.Drawing.Size(290, 46);
            this.grp_textures.TabIndex = 2;
            this.grp_textures.TabStop = false;
            this.grp_textures.Text = "Texture Multiplier";
            // 
            // int_texture_height
            // 
            this.int_texture_height.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.int_texture_height.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.int_texture_height.Location = new System.Drawing.Point(53, 16);
            this.int_texture_height.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.int_texture_height.Name = "int_texture_height";
            this.int_texture_height.Size = new System.Drawing.Size(58, 20);
            this.int_texture_height.TabIndex = 5;
            this.int_texture_height.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Height:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Width:";
            // 
            // int_texture_width
            // 
            this.int_texture_width.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.int_texture_width.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.int_texture_width.Location = new System.Drawing.Point(164, 16);
            this.int_texture_width.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.int_texture_width.Name = "int_texture_width";
            this.int_texture_width.Size = new System.Drawing.Size(58, 20);
            this.int_texture_width.TabIndex = 7;
            this.int_texture_width.Value = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 319);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(220, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Apply these settings on every connection";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // grp_metrics
            // 
            this.grp_metrics.Controls.Add(this.chk_omms_remote);
            this.grp_metrics.Controls.Add(this.chk_omms_logging);
            this.grp_metrics.Controls.Add(this.btn_omms_start);
            this.grp_metrics.Controls.Add(this.chk_omms_enable);
            this.grp_metrics.Controls.Add(this.chk_omms_headlock);
            this.grp_metrics.Controls.Add(this.label5);
            this.grp_metrics.Controls.Add(this.int_omms_scale);
            this.grp_metrics.Controls.Add(this.chk_omms_stats);
            this.grp_metrics.Controls.Add(this.chk_omms_graph2);
            this.grp_metrics.Controls.Add(this.chk_omms_graph);
            this.grp_metrics.Location = new System.Drawing.Point(12, 198);
            this.grp_metrics.Name = "grp_metrics";
            this.grp_metrics.Size = new System.Drawing.Size(290, 115);
            this.grp_metrics.TabIndex = 5;
            this.grp_metrics.TabStop = false;
            this.grp_metrics.Text = "OVR Metrics Tool";
            // 
            // chk_omms_graph
            // 
            this.chk_omms_graph.AutoSize = true;
            this.chk_omms_graph.Location = new System.Drawing.Point(10, 45);
            this.chk_omms_graph.Name = "chk_omms_graph";
            this.chk_omms_graph.Size = new System.Drawing.Size(85, 17);
            this.chk_omms_graph.TabIndex = 6;
            this.chk_omms_graph.Text = "Show Graph";
            this.chk_omms_graph.UseVisualStyleBackColor = true;
            this.chk_omms_graph.CheckedChanged += new System.EventHandler(this.chk_omms_graph_CheckedChanged);
            // 
            // chk_omms_graph2
            // 
            this.chk_omms_graph2.AutoSize = true;
            this.chk_omms_graph2.Location = new System.Drawing.Point(101, 45);
            this.chk_omms_graph2.Name = "chk_omms_graph2";
            this.chk_omms_graph2.Size = new System.Drawing.Size(100, 17);
            this.chk_omms_graph2.TabIndex = 7;
            this.chk_omms_graph2.Text = "Alternate Graph";
            this.chk_omms_graph2.UseVisualStyleBackColor = true;
            this.chk_omms_graph2.CheckedChanged += new System.EventHandler(this.chk_omms_graph2_CheckedChanged);
            // 
            // chk_omms_stats
            // 
            this.chk_omms_stats.AutoSize = true;
            this.chk_omms_stats.Location = new System.Drawing.Point(207, 45);
            this.chk_omms_stats.Name = "chk_omms_stats";
            this.chk_omms_stats.Size = new System.Drawing.Size(80, 17);
            this.chk_omms_stats.TabIndex = 8;
            this.chk_omms_stats.Text = "Show Stats";
            this.chk_omms_stats.UseVisualStyleBackColor = true;
            this.chk_omms_stats.CheckedChanged += new System.EventHandler(this.chk_omms_stats_CheckedChanged);
            // 
            // int_omms_scale
            // 
            this.int_omms_scale.Location = new System.Drawing.Point(113, 19);
            this.int_omms_scale.Name = "int_omms_scale";
            this.int_omms_scale.Size = new System.Drawing.Size(56, 20);
            this.int_omms_scale.TabIndex = 9;
            this.int_omms_scale.ValueChanged += new System.EventHandler(this.int_omms_scale_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Scale:";
            // 
            // chk_omms_headlock
            // 
            this.chk_omms_headlock.AutoSize = true;
            this.chk_omms_headlock.Location = new System.Drawing.Point(9, 68);
            this.chk_omms_headlock.Name = "chk_omms_headlock";
            this.chk_omms_headlock.Size = new System.Drawing.Size(89, 17);
            this.chk_omms_headlock.TabIndex = 11;
            this.chk_omms_headlock.Text = "Lock to head";
            this.chk_omms_headlock.UseVisualStyleBackColor = true;
            this.chk_omms_headlock.CheckedChanged += new System.EventHandler(this.chk_omms_headlock_CheckedChanged);
            // 
            // chk_omms_enable
            // 
            this.chk_omms_enable.AutoSize = true;
            this.chk_omms_enable.Location = new System.Drawing.Point(10, 20);
            this.chk_omms_enable.Name = "chk_omms_enable";
            this.chk_omms_enable.Size = new System.Drawing.Size(59, 17);
            this.chk_omms_enable.TabIndex = 12;
            this.chk_omms_enable.Text = "Enable";
            this.chk_omms_enable.UseVisualStyleBackColor = true;
            this.chk_omms_enable.CheckedChanged += new System.EventHandler(this.chk_omms_enable_CheckedChanged);
            // 
            // btn_omms_start
            // 
            this.btn_omms_start.Location = new System.Drawing.Point(215, 12);
            this.btn_omms_start.Name = "btn_omms_start";
            this.btn_omms_start.Size = new System.Drawing.Size(72, 25);
            this.btn_omms_start.TabIndex = 13;
            this.btn_omms_start.Text = "Start";
            this.btn_omms_start.UseVisualStyleBackColor = true;
            this.btn_omms_start.Click += new System.EventHandler(this.btn_omms_start_Click);
            // 
            // chk_omms_logging
            // 
            this.chk_omms_logging.AutoSize = true;
            this.chk_omms_logging.Location = new System.Drawing.Point(180, 89);
            this.chk_omms_logging.Name = "chk_omms_logging";
            this.chk_omms_logging.Size = new System.Drawing.Size(64, 17);
            this.chk_omms_logging.TabIndex = 14;
            this.chk_omms_logging.Text = "Logging";
            this.chk_omms_logging.UseVisualStyleBackColor = true;
            this.chk_omms_logging.CheckedChanged += new System.EventHandler(this.chk_omms_logging_CheckedChanged);
            // 
            // chk_omms_remote
            // 
            this.chk_omms_remote.AutoSize = true;
            this.chk_omms_remote.Location = new System.Drawing.Point(9, 89);
            this.chk_omms_remote.Name = "chk_omms_remote";
            this.chk_omms_remote.Size = new System.Drawing.Size(165, 17);
            this.chk_omms_remote.TabIndex = 15;
            this.chk_omms_remote.Text = "Remote Device Management";
            this.chk_omms_remote.UseVisualStyleBackColor = true;
            this.chk_omms_remote.CheckedChanged += new System.EventHandler(this.chk_omms_remote_CheckedChanged);
            // 
            // DeviceSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 343);
            this.Controls.Add(this.grp_metrics);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.grp_textures);
            this.Controls.Add(this.grp_foveation);
            this.Controls.Add(this.grp_recording);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeviceSettings";
            this.Text = "Device Settings";
            this.Load += new System.EventHandler(this.DeviceSettings_Load);
            this.grp_recording.ResumeLayout(false);
            this.grp_recording.PerformLayout();
            this.grp_foveation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.int_bitrate)).EndInit();
            this.grp_textures.ResumeLayout(false);
            this.grp_textures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.int_texture_height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.int_texture_width)).EndInit();
            this.grp_metrics.ResumeLayout(false);
            this.grp_metrics.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.int_omms_scale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_recording;
        private System.Windows.Forms.GroupBox grp_foveation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown int_bitrate;
        private System.Windows.Forms.ComboBox box_resolution;
        private System.Windows.Forms.ComboBox box_foveation;
        private System.Windows.Forms.GroupBox grp_textures;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown int_texture_width;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown int_texture_height;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grp_metrics;
        private System.Windows.Forms.CheckBox chk_omms_headlock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown int_omms_scale;
        private System.Windows.Forms.CheckBox chk_omms_stats;
        private System.Windows.Forms.CheckBox chk_omms_graph2;
        private System.Windows.Forms.CheckBox chk_omms_graph;
        private System.Windows.Forms.Button btn_omms_start;
        private System.Windows.Forms.CheckBox chk_omms_enable;
        private System.Windows.Forms.CheckBox chk_omms_logging;
        private System.Windows.Forms.CheckBox chk_omms_remote;
    }
}
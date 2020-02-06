namespace QuestHome.UI.Popups
{
    partial class ADBDevicePicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ADBDevicePicker));
            this.lst_devices = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lst_devices
            // 
            this.lst_devices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lst_devices.FormattingEnabled = true;
            this.lst_devices.Location = new System.Drawing.Point(0, 0);
            this.lst_devices.Name = "lst_devices";
            this.lst_devices.Size = new System.Drawing.Size(410, 305);
            this.lst_devices.TabIndex = 0;
            this.lst_devices.SelectedIndexChanged += new System.EventHandler(this.lst_devices_SelectedIndexChanged);
            // 
            // ADBDevicePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 305);
            this.Controls.Add(this.lst_devices);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ADBDevicePicker";
            this.Text = "Pick a device...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_devices;
    }
}
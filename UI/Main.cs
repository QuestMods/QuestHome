using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpAdbClient;
using System.IO;
using IniParser.Model;

namespace QuestHome.UI
{
    public partial class MainForm : Form
    {
        private WebClient webClient;
        private ADB adb;

        private void InvokeUI(Action a)
        {
            BeginInvoke(new MethodInvoker(a));
        }

        public MainForm()
        {
            Logger.Trace("START");
            if (Program.Arguments.IgnoreSSLErrors)
            {
                Logger.Warn("\"--ignoresslerrors\" is set, ignoring SSL Errors!");
                ServicePointManager.ServerCertificateValidationCallback = (a, b, c, d) => true;
            }
            webClient = new WebClient();
            if (Program.FirstRun || !Program.config.Sections.ContainsSection("ADB"))
            {
                new UI.Popups.Welcome().ShowDialog();
                var adbPicker = new UI.ADBPicker();
                adbPicker.ShowDialog();
            }
            adb = new ADB();
            Task.Factory.StartNew(() => adb.Initialize());
            // AdbClient.Instance.Install(adb.currentDevice.Data, );
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Program.config.Sections.ContainsSection("Window"))
            {
                var state = Program.config["Window"]["State"]; var loc = Program.config["Window"]["Location"].Split(':'); var size = Program.config["Window"]["Size"].Split(':');
                Logger.Debug("Was {} Location: {} Size: {}", Program.config["Window"]["State"], loc.ToJson(false), size.ToJson(false));
                switch (state)
                {
                    case "Maximized":
                        WindowState = FormWindowState.Maximized;
                        break;

                    default:
                        Location = new Point(int.Parse(loc[0]), int.Parse(loc[1]));
                        Size = new Size(int.Parse(size[1]), int.Parse(size[0]));
                        break;
                }
            }
            var devList = adb.GetDevices();
            if (devList.Count > 0) adb.currentDevice = devList.First();
            adb.currentDeviceChanged += Adb_currentDeviceChanged;
            Logger.Trace("MainForm fully loaded");
        }

        private void Adb_currentDeviceChanged(object sender, EventArgs e)
        {
            if (adb.currentDevice is null) return;
            UpdateBatteryPercentages();
        }

        private void UpdateBatteryPercentages()
        {
            var level = int.Parse(adb.SendCommand("dumpsys battery | grep level").Replace("level: ", ""));
            InvokeUI(() =>
            {
                txt_debug.Text = adb.currentDevice.ToJson();
                status_battery_hmd.Text = $"{level} %";
                if (level >= 99) status_battery_hmd.ForeColor = Color.Green;
                else if (level <= 75) status_battery_hmd.ForeColor = Color.Blue;
                else if (level <= 50) status_battery_hmd.ForeColor = Color.Yellow;
                else if (level <= 25) status_battery_hmd.ForeColor = Color.Orange;
                else if (level <= 10) status_battery_hmd.ForeColor = Color.Red;
                // status_battery_hmd.ToolTipText = status_battery_hmd.Text + "(not charging)";
            });
        }

        private void reloadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(adb.currentDevice is null)) UpdateBatteryPercentages();
            if (tabs_main.SelectedTab == tab_homes)
            {
                LoadAvailableHomes();
                FillHomes();
            }
            else if (tabs_main.SelectedTab == tab_firmware)
            {
                PreloadFirmwares();
                FillFirmwares();
            }
        }

        private void tabs_main_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tabs_main_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPage == tab_firmware)
            {
                FillFirmwares();
            }
        }

        private void tabs_main_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPage == tab_news)
            {
                e.Cancel = true;
            }
            else if (e.TabPage == tab_homes)
            {
                InitializeHomes();
            }
            else if (e.TabPage == tab_firmware)
            {
                PreloadFirmwares();
            }
        }

        private void tabs_main_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Debug("called");
            if (WindowState == FormWindowState.Normal)
            {
                Program.config["Window"]["Location"] = Location.X.ToString() + ":" + Location.Y.ToString();
                Program.config["Window"]["Size"] = Height.ToString() + ":" + Width.ToString();
            }
            Program.config["Window"]["State"] = WindowState.ToString();
            // Config.Save(Program.config);
            Application.Exit();
        }

        private void changeDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Popups.ADBDevicePicker(adb).Show();
        }

        private void shutdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Are you sure you want to shut down {adb.currentDevice.Serial}?", "Shutdown device?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) adb.SendCommand("reboot -s");
        }

        private void rebootSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Are you sure you want to reboot {adb.currentDevice.Serial}?", "Reboot device?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) adb.SendCommand("reboot");
        }

        private void rebootBootloaderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Are you sure you want to reboot {adb.currentDevice.Serial} into bootloader?", "Reboot bootloader device?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) adb.SendCommand("reboot bootloader");
        }

        private void rebootRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Are you sure you want to reboot {adb.currentDevice.Serial} into recovery?", "Reboot recovery device?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) adb.SendCommand("reboot recovery");
        }

        private void rebootFastbootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"Are you sure you want to reboot {adb.currentDevice.Serial} into fastboot?", "Fastboot device?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes) adb.SendCommand("reboot fastboot");
        }

        private void shellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Popups.ADBShell(adb).Show();
        }

        private void recordSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Popups.DeviceSettings(adb).Show();
        }
    }
}
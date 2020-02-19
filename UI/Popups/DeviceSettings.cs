using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuestHome.UI.Popups
{
    public partial class DeviceSettings : Form
    {
        private ADB adb;

        public DeviceSettings(ADB adb)
        {
            this.adb = adb;
            InitializeComponent();
            Text = $"Settings for {adb.currentDevice.Serial}";
        }

        private void box_resolution_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void DeviceSettings_Load(object sender, EventArgs e)
        {
        }

        private void box_foveation_TextUpdate(object sender, EventArgs e)
        {
        }

        private void btn_omms_start_Click(object sender, EventArgs e)
        {
            // var pm = PackageManager();
            adb.currentDevice.SendCommand("am start omms://app");
        }

        private void chk_omms_logging_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_omms_logging.Checked) MessageBox.Show("Recordings will be saved under /OVRMonitorMetricsService/CapturedMetrics/");
            adb.currentDevice.SetProp("debug.oculus.omms.enableCSV", chk_omms_logging.Checked.ToString().ToLower());
        }

        private void chk_omms_enable_CheckedChanged(object sender, EventArgs e)
        {
            adb.currentDevice.SetProp("debug.oculus.omms.enableOverlay", chk_omms_enable.Checked.ToString().ToLower());
        }

        private void chk_omms_graph_CheckedChanged(object sender, EventArgs e)
        {
            adb.currentDevice.SetProp("debug.oculus.omms.enableGraph", chk_omms_graph.Checked.ToString().ToLower());
        }

        private void chk_omms_graph2_CheckedChanged(object sender, EventArgs e)
        {
            adb.currentDevice.SetProp("debug.oculus.omms.enableGraph2", chk_omms_graph2.Checked.ToString().ToLower());
        }

        private void chk_omms_stats_CheckedChanged(object sender, EventArgs e)
        {
            adb.currentDevice.SetProp("debug.oculus.omms.enableStats", chk_omms_stats.Checked.ToString().ToLower());
        }

        private void chk_omms_headlock_CheckedChanged(object sender, EventArgs e)
        {
            adb.currentDevice.SetProp("debug.oculus.omms.headLocked", chk_omms_headlock.Checked.ToString().ToLower());
        }
        private void chk_omms_remote_CheckedChanged(object sender, EventArgs e)
        {
            adb.currentDevice.SetProp("debug.oculus.omms.enableBT", chk_omms_remote.Checked.ToString().ToLower());
        }

        private void int_omms_scale_ValueChanged(object sender, EventArgs e)
        {
        }

    }
}
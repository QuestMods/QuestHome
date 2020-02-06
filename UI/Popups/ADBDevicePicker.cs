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
    public partial class ADBDevicePicker : Form
    {
        private ADB adb;

        public ADBDevicePicker(ADB adb)
        {
            this.adb = adb;
            InitializeComponent();
            FillList();
        }

        private void FillList(bool clear = true)
        {
            var devs = adb.GetDevices();
            if (clear) lst_devices.Items.Clear();
            foreach (var dev in devs)
            {
                // if(dev.IsQuest)
                lst_devices.Items.Add(dev);
                if (dev == adb.currentDevice) lst_devices.SelectedItem = dev;
            }
        }

        private void lst_devices_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dev = lst_devices.SelectedItem as Classes.Device;
            if (dev == adb.currentDevice) return;
            adb.currentDevice = dev;
        }
    }
}
using QuestHome.Classes;
using SharpAdbClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace QuestHome
{
    public class ADB
    {
        public readonly static Regex SerialRegex = new Regex(@"^[A-Z0-9]{14}$");

        public static List<FileInfo> DefaultSearchPaths = new List<FileInfo> {
            System.Environment.SpecialFolder.ApplicationData.CombineFile(@"SideQuest\platform-tools\adb.exe"),
            System.Environment.SpecialFolder.ProgramFilesX86.CombineFile(@"android-sdk\platform-tools\adb.exe")
        };

        public AdbServer server;
        private ConsoleOutputReceiver receiver = new ConsoleOutputReceiver() { };

        public event EventHandler currentDeviceChanged;

        private Device _currentDevice;
        private const string s = "ADB";

        protected virtual void OnCurrentDeviceChanged()
        {
            currentDeviceChanged?.Invoke(this, EventArgs.Empty);
        }

        public Device currentDevice {
            get { return _currentDevice; }
            set {
                _currentDevice = value;
                OnCurrentDeviceChanged();
            }
        }

        public StartServerResult Initialize()
        {
            var config = Program.config;
            if (config[s].ContainsKey("path")) return StartServerResult.AlreadyRunning;
            server = new AdbServer();
            var result = server.StartServer(config[s]["path"], restartServerIfNewer: false);
            // Logger.Trace("ADB Connected Devices: {}", AdbClient.Instance.GetDevices().ToJson());
            var monitor = new DeviceMonitor(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)));
            monitor.DeviceConnected += OnDeviceConnected;
            monitor.DeviceChanged += DeviceChanged;
            monitor.DeviceDisconnected += DeviceDisconnected;
            Task.Factory.StartNew(() => monitor.Start());
            return result;
        }

        private void DeviceDisconnected(object sender, DeviceDataEventArgs e)
        {
            var device = new Device(e.Device);
            Logger.Debug("ADB Device disconnected: {}", device.Serial);
            if (device.Serial == currentDevice.Serial) SwitchFallback();
        }

        private void DeviceChanged(object sender, DeviceDataEventArgs e)
        {
            var device = new Device(e.Device);
            Logger.Debug("ADB Device changed: {}", device.Serial);
            OnDeviceConnected(sender, e);
        }

        private void OnDeviceConnected(object sender, DeviceDataEventArgs e)
        {
            var device = new Device(e.Device);
            var devs = AdbClient.Instance.GetDevices().Where(m => m.Serial == device.Data.Serial);
            if (devs.Count() < 1) return;
            device = new Device(devs.First());
            Logger.Debug("ADB Device connected: {}", device.Serial);
            if (device.IsQuest && (currentDevice is null || !currentDevice.IsConnected || (currentDevice.IsWifi && !device.IsWifi)))
            {
                Logger.Info("Quest {} found, switching...", device.Serial);
                UseDevice(device);
            }
        }

        public string SendCommand(string command, bool newReceiver = true)
        {
            if (currentDevice is null) return string.Empty;
            if (newReceiver) receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand(command, currentDevice.Data, receiver);
            return receiver.ToString().Trim();
        }

        private void UseDevice(Device device)
        {
            currentDevice = device;
        }

        private void SwitchFallback()
        {
            var devs = GetDevices().Where(m => m.Serial == currentDevice.Serial);
            if (devs.Count() > 0) currentDevice = devs.First();
        }

        public List<Device> GetDevices()
        {
            var lst = new List<Device>();
            foreach (var dev in AdbClient.Instance.GetDevices())
            {
                lst.Add(new Device(dev));
            }
            return lst;
        }
    }
}
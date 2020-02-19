using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using SharpAdbClient;

namespace QuestHome.Classes
{
    public class Device
    {
        public DeviceData Data { get; set; }
        public bool IsQuest { get { return Data.Model == "Quest"; } }
        public bool IsWifi { get { return !(EndPoint is null); } }
        public bool IsConnected { get { return AdbClient.Instance.GetDevices().Any(m => m.TransportId == Data.TransportId); } }
        public EndPoint EndPoint { get; set; }
        public string Serial { get; set; }

        public Device(DeviceData deviceData)
        {
            Data = deviceData;
            EndPoint = Utils.ParseIPEndPoint(Data.Serial);
            Serial = GetSerial();
        }

        public override string ToString()
        {
            return $"{Serial} {(IsWifi ? $" ({Data.Serial})" : $"")} [{Data.Model}]";
        }

        private string GetSerial()
        {
            var serial = Data.Serial.Trim();
            if (ADB.SerialRegex.IsMatch(serial)) return serial;
            try
            {
                return SendCommand("getprop ro.serialno");
            }
            catch
            {
                try
                {
                    return SendCommand("getprop ro.boot.serialno");
                }
                catch { Logger.Error("Unable to get serial no of {}", Data.Serial); }
            }
            return null;
        }

        public string SendCommand(string command, ConsoleOutputReceiver receiver = null)
        {
            if (receiver is null) receiver = new ConsoleOutputReceiver();
            Logger.Debug("ADB -> {}: {}", Serial, command);
            AdbClient.Instance.ExecuteRemoteCommand(command, Data, receiver);
            return receiver.ToString().Trim();
        }
        public void SetProp(string prop, string value) => SendCommand($"setprop {prop} {value}");
        public string GetProp(string prop) => SendCommand($"getprop {prop}");
    }
}
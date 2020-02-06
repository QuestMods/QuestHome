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

        public string SendCommand(string command)
        {
            var receiver = new ConsoleOutputReceiver();
            AdbClient.Instance.ExecuteRemoteCommand(command, Data, receiver);
            return receiver.ToString().Trim();
        }
    }
}
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace QuestHome.Classes
{
    public class Mirror
    {
        public Uri URL { get; set; }
        public PingReply Reply { get; set; }

        public Mirror(string url)
        {
            URL = new Uri(url);
            Reply = new Ping().Send(URL.Host);
        }

        public override string ToString()
        {
            var ping = Reply.Status == IPStatus.Success ? $"{Reply.RoundtripTime} ms" : Reply.Status.ToString().Split(".").Last();
            return $"[{ping}] {URL.AbsoluteUri}";
        }
    }

    public class Firmware
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Added { get; set; }
        public DateTime Released { get; set; }
        public List<string> Mirrors { get; set; }
        public string Crc32 { get; set; }
        public string Md5 { get; set; }
        public string Sha512 { get; set; }

        [JsonProperty(PropertyName = "changelog-url")]
        public string ChangelogURL { get; set; }

        public string Changelog { get; set; }

        public override string ToString()
        {
            return $"{Name} {(Released == DateTime.MinValue ? "" : $" ({Released.Date:d})")}";
        }
    }
}
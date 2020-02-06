using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestHome.Classes
{
    public class Environment
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public uint Build { get; set; }

        [JsonProperty(PropertyName = "support-url")]
        public string SupportURL { get; set; }

        public List<string> Tags { get; set; }

        [JsonProperty(PropertyName = "replaces-package")]
        public string ReplacesPackage { get; set; }

        [JsonProperty(PropertyName = "download-url")]
        public string DownloadURL { get; set; }

        [JsonProperty(PropertyName = "preview-video")]
        public string PreviewVideo { get; set; }

        public string Thumbnail { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public class EnvironmentsResponse
    {
        [JsonProperty(PropertyName = "last-updated")]
        public string LastUpdated { get; set; }

        public List<Environment> Environments { get; set; }
    }
}
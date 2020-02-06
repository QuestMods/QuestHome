using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;

namespace QuestHome
{
    public class Config
    {
        public static IniData DefaultConfig = new IniData();
        public static string DefaultConfigFile = Path.Combine(Utils.getOwnPath().DirectoryName, System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".ini");

        public static IniData Load(string file = null, FileIniDataParser parser = null)
        {
            if (file == null) file = DefaultConfigFile;
            if (parser == null) parser = new FileIniDataParser();
            if (!File.Exists(file))
            {
                Logger.Warn("Config did not exist, creating default...");
                Save(DefaultConfig, parser: parser);
                Program.FirstRun = true;
                return DefaultConfig;
            }
            Logger.Debug("Loading config from {}", file);
            return parser.ReadFile(file);
        }

        public static void Save(IniData config, string file = null, FileIniDataParser parser = null)
        {
            if (file == null) file = DefaultConfigFile;
            if (parser == null) parser = new FileIniDataParser();
            if (config.Sections.Count < 1) return;
            Logger.Debug("Writing config to {}", file);
            parser.WriteFile(file, config);
        }
    }
}
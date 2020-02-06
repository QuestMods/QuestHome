using CommandLine;
using IniParser.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QuestHome
{
    internal static class Program
    {
        public static Options Arguments = new Options();
        public static UI.MainForm mainWindow;
        public static bool FirstRun = false;
        public static IniData config = Config.Load();

        public class Options
        {
            [Option('c', "console", Required = false, HelpText = "Enable console")]
            public bool ConsoleEnabled { get; set; }

            [Option("ignoresslerrors", Required = false, HelpText = "Ignore SSL Errors")]
            public bool IgnoreSSLErrors { get; set; }

            [Option("device", Required = false, HelpText = "Connects to the device with the provided serial no")]
            public string Serial { get; set; }

            [Option("ip", Required = false, HelpText = "Connects to the provided ip")]
            public string IP { get; set; }

            [Option("port", Required = false, HelpText = "Connects to the provided port")]
            public short Port { get; set; } = 5555;
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(OnProcessExit);
            var assembly = System.Reflection.Assembly.GetEntryAssembly().GetName();
            Logger.Debug("{0} v{1} ({2}) with args: {3}", assembly.Name, assembly.Version, assembly.ProcessorArchitecture, string.Join(" ", args));
            Logger.Debug("Current Date and Time: {0} (UTC: {1})", DateTime.Now, DateTime.UtcNow);
            Parser.Default.ParseArguments<Options>(args).WithParsed(o => Arguments = o).WithNotParsed(o => Logger.Error("Unable to parse arguments: {0}", o.First().Tag));
            if (Arguments.ConsoleEnabled) ExternalConsole.InitConsole();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            mainWindow = new UI.MainForm();
            Application.Run(mainWindow);
            Logger.Debug("Ended");
            OnProcessExit(false, new EventArgs());
        }

        private static void OnProcessExit(object sender, EventArgs e)
        {
            Logger.Log("Exiting...");
            Logger.Trace(config.ToJson());
            Config.Save(config);
            // LogReader.Dispose();
            // IPC.Launcher.Dispose();
            ExternalConsole.Dispose();
            Application.Exit();
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }
    }
}
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Security.Principal;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using System.Net;
using System.Globalization;

namespace QuestHome
{
    public static partial class Utils
    {
        public static FileInfo getOwnPath()
        {
            return new FileInfo(Path.GetFullPath(Application.ExecutablePath));
        }
        /*[DllImport("User32.dll")]
        public static extern Int32 SetForegroundWindow(int hWnd);*/
        /*public static void BringSelfToFront()
        {
            var window = Program.mainWindow;
            if (window.WindowState == FormWindowState.Minimized)
                window.WindowState = FormWindowState.Normal;
            else
            {
                window.TopMost = true;
                window.Focus();
                window.BringToFront();
                window.TopMost = false;
            }
            /*Program.mainWindow.Activate();
            Program.mainWindow.Focus();
            // SetForegroundWindow(SafeHandle.ToInt32());
        }*/

        public static bool IsAlreadyRunning(string appName)
        {
            System.Threading.Mutex m = new System.Threading.Mutex(false, appName);
            if (m.WaitOne(1, false) == false)
            {
                return true;
            }
            return false;
        }

        internal static void Exit()
        {
            Application.Exit();
            var currentP = Process.GetCurrentProcess();
            currentP.Kill();
        }

        public static void RestartAsAdmin(string[] arguments)
        {
            if (IsAdmin()) return;
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.UseShellExecute = true;
            proc.WorkingDirectory = Environment.CurrentDirectory;
            proc.FileName = Assembly.GetEntryAssembly().CodeBase;
            proc.Arguments += arguments.ToString();
            proc.Verb = "runas";
            try
            {
                /*new Thread(() =>
                {
                    Thread.CurrentThread.IsBackground = true;
                    Process.Start(proc);
                }).Start();*/
                Process.Start(proc);
                Exit();
            }
            catch (Exception)
            {
                // Logger.Error("Unable to restart as admin!", ex.Message);
                MessageBox.Show("Unable to restart as admin for you. Please do this manually now!", "Can't restart as admin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Exit();
            }
        }

        internal static bool IsAdmin()
        {
            bool isAdmin;
            try
            {
                WindowsIdentity user = WindowsIdentity.GetCurrent();
                WindowsPrincipal principal = new WindowsPrincipal(user);
                isAdmin = principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
            catch (UnauthorizedAccessException)
            {
                isAdmin = false;
            }
            catch (Exception)
            {
                isAdmin = false;
            }
            return isAdmin;
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            return Convert.ToBase64String(plainTextBytes);
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
            return Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static FileInfo DownloadFile(string url, DirectoryInfo destinationPath, string fileName = null)
        {
            if (fileName == null) fileName = url.Split('/').Last();
            // Main.webClient.DownloadFile(url, Path.Combine(destinationPath.FullName, fileName));
            return new FileInfo(Path.Combine(destinationPath.FullName, fileName));
        }

        public static void ShowFileInExplorer(FileInfo file)
        {
            StartProcess("explorer.exe", null, "/select, " + file.FullName.Quote());
        }

        public static void OpenFolderInExplorer(DirectoryInfo dir)
        {
            StartProcess("explorer.exe", null, dir.FullName.Quote());
        }

        public static FileInfo pickFile(string title = null, string initialDirectory = null, string filter = null)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                if (initialDirectory != null) fileDialog.Title = title;
                if (initialDirectory != null)
                {
                    fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
                }
                else
                {
                    fileDialog.InitialDirectory = initialDirectory;
                }
                if (filter != null) fileDialog.Filter = filter;
                fileDialog.Multiselect = false;
                var result = fileDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    var file = new FileInfo(fileDialog.FileName);
                    if (file.Exists) return file;
                }
                return null;
            }
        }

        public static Process StartProcess(FileInfo file, params string[] args) => StartProcess(file.FullName, file.DirectoryName, args);

        public static Process StartProcess(string file, string workDir = null, params string[] args)
        {
            ProcessStartInfo proc = new ProcessStartInfo();
            proc.FileName = file;
            proc.Arguments = string.Join(" ", args);
            Logger.Debug("Starting Process: {0} {1}", proc.FileName, proc.Arguments);
            if (workDir != null)
            {
                proc.WorkingDirectory = workDir;
                Logger.Debug("Working Directory: {0}", proc.WorkingDirectory);
            }
            return Process.Start(proc);
        }

        public static IPEndPoint ParseIPEndPoint(string endPoint)
        {
            string[] ep = endPoint.Split(':');
            if (ep.Length < 2) return null;
            IPAddress ip;
            if (ep.Length > 2)
            {
                if (!IPAddress.TryParse(string.Join(":", ep, 0, ep.Length - 1), out ip))
                {
                    return null;
                }
            }
            else
            {
                if (!IPAddress.TryParse(ep[0], out ip))
                {
                    return null;
                }
            }
            int port;
            if (!int.TryParse(ep[ep.Length - 1], NumberStyles.None, NumberFormatInfo.CurrentInfo, out port))
            {
                return null;
            }
            return new IPEndPoint(ip, port);
        }
    }
}
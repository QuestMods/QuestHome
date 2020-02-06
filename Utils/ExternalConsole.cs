using Microsoft.Win32.SafeHandles;
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

namespace QuestHome
{
    public class ExternalConsole
    {
        private const int STD_OUTPUT_HANDLE = -11;
        private const int STD_INPUT_HANDLE = -10;
        private const int STD_ERROR_HANDLE = -12;
        private const int MY_CODE_PAGE = 437;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern IntPtr CreateFile([MarshalAs(UnmanagedType.LPTStr)] string filename, [MarshalAs(UnmanagedType.U4)] uint access, [MarshalAs(UnmanagedType.U4)] FileShare share, IntPtr securityAttributes, [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition, [MarshalAs(UnmanagedType.U4)] FileAttributes flagsAndAttributes, IntPtr templateFile);

        [DllImport("kernel32.dll", EntryPoint = "GetStdHandle", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll", EntryPoint = "SetStdHandle", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern bool SetStdHandle(int nStdHandle, IntPtr hHandle);

        [DllImport("kernel32.dll", EntryPoint = "AllocConsole", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int AllocConsole();

        [DllImport("kernel32.dll", EntryPoint = "FreeConsole", SetLastError = true, CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        private static extern int FreeConsole();

        public static void InitConsole()
        {
            AllocConsole();
            IntPtr stdHandle = GetStdHandle(STD_OUTPUT_HANDLE);
            SafeFileHandle safeFileHandle = new SafeFileHandle(stdHandle, true);
            FileStream fileStream = new FileStream(safeFileHandle, FileAccess.Write);
            // Encoding encoding = Encoding.GetEncoding(MY_CODE_PAGE);
            // StreamWriter standardOutput = new StreamWriter(fileStream, encoding);
            StreamWriter standardOutput = new StreamWriter(fileStream, Encoding.UTF8);
            standardOutput.AutoFlush = true;
            Console.SetOut(standardOutput);
            if (Debugger.IsAttached) OverrideRedirection();
#if DEBUG
            Test();
#endif
            Logger.Debug("Console Initialized");
            Console.WriteLine();
        }

        private static void Test()
        {
            Logger.Info("Debug build detected, Testing console...");
            Logger.Trace("Logger.Trace");
            Logger.Debug("Logger.Debug");
            Logger.Info("Logger.Info");
            Logger.Warn("Logger.Warn");
            Logger.Error("Logger.Error");
            Logger.Fatal("Logger.Fatal");
            Console.WriteLine("Console.WriteLine");
            Debug.WriteLine("System.Diagnostics.Debug.WriteLine");
        }

        private static void OverrideRedirection()
        {
            Logger.Warn("Debugger is attached, force redirecting console output!");
            var hOut = GetStdHandle(STD_OUTPUT_HANDLE);
            var hRealOut = CreateFile("CONOUT$", 0x80000000 | 0x40000000, FileShare.Write, IntPtr.Zero, FileMode.OpenOrCreate, 0, IntPtr.Zero);
            if (hRealOut != hOut)
            {
                SetStdHandle(STD_OUTPUT_HANDLE, hRealOut);
                Console.SetOut(new StreamWriter(Console.OpenStandardOutput(), Console.OutputEncoding) { AutoFlush = true });
            }
        }

        public static void Dispose()
        {
            FreeConsole();
        }
    }
}
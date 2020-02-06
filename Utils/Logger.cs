using System.Diagnostics;
using System.Globalization;
using NLog;

namespace QuestHome
{
    public static class Logger
    {
        private static readonly NLog.Logger NLogger = LogManager.GetCurrentClassLogger();

        // private enum LogLevel { Trace, Debug, Info, Warn, Error, Fatal }
        public static void Trace(string msg, params object[] format) => log(LogLevel.Trace, msg: msg, format: format);

        public static void Debug(string msg, params object[] format) => log(LogLevel.Debug, msg: msg, format: format);

        public static void Log(string msg, params object[] format) => log(LogLevel.Info, msg: msg, format: format);

        public static void Info(string msg, params object[] format) => log(LogLevel.Info, msg: msg, format: format);

        public static void Warn(string msg, params object[] format) => log(LogLevel.Warn, msg: msg, format: format);

        public static void Error(string msg, params object[] format) => log(LogLevel.Error, msg: msg, format: format);

        public static void Fatal(string msg, params object[] format) => log(LogLevel.Fatal, msg: msg, format: format);

        private static void log(LogLevel logLevel, string msg, params object[] format)
        {
            LogEventInfo logEvent = new LogEventInfo(level: logLevel, loggerName: NLogger.Name, formatProvider: CultureInfo.InvariantCulture, message: msg, parameters: format);
            NLogger.Log(typeof(Logger), logEvent);
        }
    }
}
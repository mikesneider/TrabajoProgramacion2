using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace WindowsFormsApp2
{
    class cs_Logger
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public enum LogLevel
        {
            FATAL,
            ERROR,
            WARN,
            INFO,
            DEBUG,
        }

        public static void Log(string msg, LogLevel level = LogLevel.DEBUG)
        {
            StackFrame frame = new StackFrame(1);
            string callerMethodName = frame.GetMethod().Name;
            string callerClassName = frame.GetMethod().DeclaringType.FullName;
            msg = string.Format("{0}:{1}:{2}", callerClassName, callerMethodName, msg);

            switch (level)
            {
                case LogLevel.FATAL:
                    log.Fatal(msg);
                    break;
                case LogLevel.ERROR:
                    log.Error(msg);
                    break;
                case LogLevel.WARN:
                    log.Warn(msg);
                    break;
                case LogLevel.INFO:
                    log.Info(msg);
                    break;
                default:
                    log.Debug(msg);
                    break;
            }
        }
    }
}

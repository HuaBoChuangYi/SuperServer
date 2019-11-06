using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperServer
{
    public class Logger
    {
        public static ILog LogForm;
        public static void Error(string message)
        {
            if (LogForm != null)
            {
                LogForm.Error(message);
            }
        }

        public static void Log(LogMessage message)
        {
            if (LogForm != null)
            {
                LogForm.Log(message);
            }
        }
    }

    public interface ILog
    {
        void Error(string message);

        void Log(LogMessage message);
    }

    public class LogMessage
    {
        public LogMessage()
        {
            this.Time = DateTime.Now.ToLongTimeString();
        }
        public string Time { get; set; }
        public string FromDeviceId { get; set; }
        public string ToDeviceId { get; set; }
        public string Key { get; set; }
        public string Content { get; set; }
    }
}

using Logging.Entities;

namespace Logging.Model
{
    public class LogEntry
    {
        public string LogDateTime { get; set; }
        public LogLevel LogType { get; set; }
        public string LogMessage { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Logging.Entities;
using Logging.Model;
using Newtonsoft.Json;

namespace Logging.ConcreteLoggers
{
    public class JsonLogger
    {

        public void Error(string message)
        {
            Log(message, LogLevel.ERROR);
        }

        public void Info(string message)
        {
            Log(message, LogLevel.INFORMATION);
        }

        private void Log(string message, LogLevel logLevel)
        {
            string fullPattern = DateTimeFormatInfo.CurrentInfo.FullDateTimePattern;
            LogEntry logEntry = new LogEntry
            {
                LogDateTime = DateTime.UtcNow.ToString(fullPattern),
                LogType = LogLevel.INFORMATION,
                LogMessage = message
            };
            string json = File.ReadAllText("log.json");
            var logs = JsonConvert.DeserializeObject<List<LogEntry>>(json);
            (logs ??= new List<LogEntry>()).Add(logEntry);
            File.WriteAllText("log.json", JsonConvert.SerializeObject(logs));
        }
    }
}
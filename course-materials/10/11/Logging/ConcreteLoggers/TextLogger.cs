using System;
using System.Globalization;
using System.IO;
using System.Text;
using Logging.Entities;
using Logging.Interfaces;

namespace Logging.ConcreteLoggers
{
    public class TextLogger : ILogger
    {
        public string Separator { get; private set; }

        public TextLogger()
        {
            Separator = "--------------------";
        }

        public void Error(string message)
        {
            Log(message, LogLevel.ERROR);
        }

        public void Info(string message)
        {
            Log(message, LogLevel.INFORMATION);
        }

        public void Log(string message, LogLevel logLevel)
        {
            string messageToLog = string.Empty;
            var stringBuilder = new StringBuilder();
            string fullPattern = DateTimeFormatInfo.CurrentInfo.FullDateTimePattern;
            stringBuilder.AppendLine(DateTime.UtcNow.ToString(fullPattern));
            stringBuilder.AppendLine(logLevel.ToString());
            stringBuilder.AppendLine(message);
            stringBuilder.AppendLine(Separator);
            AppendLogToTextFile(stringBuilder.ToString());
        }

        private void AppendLogToTextFile(string logMessage)
        {
            File.AppendAllText("log.txt", logMessage);
        }
    }
}
using Logging.Entities;
using Logging.Interfaces;

namespace Logging.AbstractLogger
{
    public abstract class AbstractLogger : ILogger
    {
        public void Error(string message)
        {
            Log(message, LogLevel.ERROR);
        }

        public void Info(string message)        
        {
            Log(message, LogLevel.INFORMATION);
        }

        public abstract void Log(string message, LogLevel logLevel);
    }
}
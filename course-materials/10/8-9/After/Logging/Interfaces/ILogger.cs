using Logging.Entities;

namespace Logging.Interfaces
{
    public interface ILogger
    {

        void Error(string message)
        {
            Log(message, LogLevel.ERROR);
        }

        void Info(string message)
        {
            Log(message, LogLevel.INFORMATION);
        }
        
        void Log(string message, LogLevel logLevel);
    }
}
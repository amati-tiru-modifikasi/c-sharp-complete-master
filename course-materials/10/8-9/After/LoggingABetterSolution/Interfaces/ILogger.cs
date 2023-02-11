using Logging.Entities;

namespace Logging.Interfaces
{
    public interface ILogger
    {
        void Error(string message);
        void Info(string message);
        void Log(string message, LogLevel logLevel);
    }
}
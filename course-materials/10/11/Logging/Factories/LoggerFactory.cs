using Logging.ConcreteLoggers;
using Logging.Entities;
using Logging.Interfaces;

namespace Logging.Factories
{
    public class LoggerFactory
    {
        public ILogger Create(FileType fileType)
        {
            ILogger logger = fileType == FileType.TXT ? new TextLogger() : new JsonLogger();
            return logger;
        }
    }
}
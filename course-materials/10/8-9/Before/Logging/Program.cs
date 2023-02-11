using System;
using Logging.ConcreteLoggers;

namespace Logging
{
    class Program
    {
        private static TextLogger textLogger = new TextLogger();
        private static JsonLogger jsonLogger = new JsonLogger();
        static void Main(string[] args)
        {

            Console.WriteLine("Please provide a message to log...");
            var message = Console.ReadLine();
            PromptForLogType(out int logTypeValue);
            PromptForLogFileType(out int logFileTypeValue);
            if (logFileTypeValue == 1 && logTypeValue == 1)
            {
                textLogger.Info(message);
            }
            if (logFileTypeValue == 1 && logTypeValue == 2)
            {
                textLogger.Error(message);
            }
            if (logFileTypeValue == 2 && logTypeValue == 1)
            {
                jsonLogger.Info(message);
            }
            if (logFileTypeValue == 2 && logTypeValue == 2)
            {
                jsonLogger.Error(message);
            }
            Console.WriteLine("Log added");
        }

        private static void PromptForLogType(out int logType)
        {
            Console.WriteLine("Do you want to log an information (1) or error (2)...");
            string logTypeInput = Console.ReadLine();
            if (!int.TryParse(logTypeInput, out logType) || !IsValidInput(logType))
            {
                Console.WriteLine("Invalid choice");
                PromptForLogType(out logType);
            }
        }

        private static void PromptForLogFileType(out int logFileType)
        {
            Console.WriteLine("Do you want to log to a text file (1) or to a json file (2)...");
            string logTypeInput = Console.ReadLine();
            if (!int.TryParse(logTypeInput, out logFileType) || !IsValidInput(logFileType))
            {
                Console.WriteLine("Invalid choice");
                PromptForLogFileType(out logFileType);
            }
        }

        private static bool IsValidInput(int input)
        {
            return input == 1 || input == 2;
        }
    }
}

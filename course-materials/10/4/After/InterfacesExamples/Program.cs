using System;
using System.Collections.Generic;

namespace InterfacesExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ILogger> loggers = new List<ILogger>
            {
                new TextLogger
                {
                    IsEnabled = true
                },
                new JsonLogger
                {
                    IsEnabled = true
                }
            };

            foreach (var logger in loggers)
            {
                logger.Log();
            }
        }
    }
}

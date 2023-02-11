using System;

namespace InterfacesExamples
{
    class JsonLogger : ILogger
    {
        private bool _isEnabled;
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set { _isEnabled = value; }
        }

        public void Log()
        {
            if (IsEnabled)
            {
                Console.WriteLine("Log from json file");
            }
        }
    }
}
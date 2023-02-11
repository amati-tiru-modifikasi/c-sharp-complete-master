using System;

namespace InterfacesExamples
{
    class TextLogger : ILogger
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
                Console.WriteLine("Log from text file");
            }
        }
    }
}
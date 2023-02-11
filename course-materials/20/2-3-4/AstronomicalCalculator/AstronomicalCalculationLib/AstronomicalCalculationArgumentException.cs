using System;

namespace AstronomicalCalculationLib
{
    public class AstronomicalCalculationArgumentException : AstronomicalCalculationException
    {
        public string Argument { get; set; }
        
        public string Parameter { get; set; }
        
        public AstronomicalCalculationArgumentException() : base()
        {
            
        }

        public AstronomicalCalculationArgumentException(string argument, string parameter) : this()
        {
            Argument = argument;
            Parameter = parameter;
        }

        public AstronomicalCalculationArgumentException(string message, string argument, string parameter) : base(message)
        {
            Argument = argument;
            Parameter = parameter;
        }

        public AstronomicalCalculationArgumentException(string argument, string parameter, Exception innerException) : base(innerException)
        {
            Argument = argument;
            Parameter = parameter;
        }

        public AstronomicalCalculationArgumentException(string message, string argument, string parameter, Exception innerException) : base(message, innerException)
        {
            Argument = argument;
            Parameter = parameter;
        }

        public override string Message
        {
            get
            {
                return base.Message + Environment.NewLine + 
                (!string.IsNullOrEmpty(Argument) ? "Invalid Argument " + Argument : string.Empty);
            }
        }
    }
}

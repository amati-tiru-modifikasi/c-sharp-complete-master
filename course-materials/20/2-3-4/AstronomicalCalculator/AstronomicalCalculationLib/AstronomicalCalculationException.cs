using System;

namespace AstronomicalCalculationLib
{
    public class AstronomicalCalculationException : Exception
    {
        private static readonly string _defaultMessage = "An error occured during the calculation. ";

        public AstronomicalCalculationException() : base(_defaultMessage)
        {
            
        }

        public AstronomicalCalculationException(string message) : base(_defaultMessage + message)
        {
            
        }

        public AstronomicalCalculationException(Exception innerException) : base(_defaultMessage, innerException)
        {
            
        }

        public AstronomicalCalculationException(string message, Exception innerException) : base(_defaultMessage + message, innerException)
        {
            
        }

    }
}

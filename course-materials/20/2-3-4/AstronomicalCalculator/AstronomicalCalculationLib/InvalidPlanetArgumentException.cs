using System;

namespace AstronomicalCalculationLib
{
    public class InvalidPlanetArgumentException : AstronomicalCalculationException
    {
        public string Argument { get; }

        public InvalidPlanetArgumentException() : base()
        {

        }

        public InvalidPlanetArgumentException(string argument) : this()
        {
            Argument = argument;
        }

        public InvalidPlanetArgumentException(string message, string argument) : base(message)
        {
            Argument = argument;
        }

        public InvalidPlanetArgumentException(string argument, Exception innerException) : base(innerException)
        {
            Argument = argument;
        }

        public InvalidPlanetArgumentException(string message, string argument, Exception innerException) : base(message, innerException)
        {
            Argument = argument;
        }

        public override string Message
        {
            get
            {
                return 
                base.Message + Environment.NewLine +
                "Invalid planet name Argument " + (!string.IsNullOrEmpty(Argument) ? Argument : string.Empty) + Environment.NewLine +
                "Valid planet names : Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune";
            }
        }
    }
}

using System;
using System.Text;

namespace AstronomicalCalculationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine();
            RunMassConversionExamples();
            RunCalculationExamples();
        }

        private static void RunMassConversionExamples()
        {
            MassConversionExamples.MassConversions();
            MassConversionExamples.ConvertInConsole();
        }
        private static void RunCalculationExamples()
        {
            GravityCalculationExamples.GravityCalculations();
            GravityCalculationExamples.CalculateInConsole();
        }
    }
}

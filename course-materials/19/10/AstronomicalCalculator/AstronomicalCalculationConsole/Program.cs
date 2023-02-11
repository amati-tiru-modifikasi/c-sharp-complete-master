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
            Console.WriteLine();
            MassConversionExamples.ConvertInConsole();
            Console.WriteLine();
        }
        private static void RunCalculationExamples()
        {
            GravityCalculationExamples.GravityCalculations();
            Console.WriteLine();
            GravityCalculationExamples.CalculateInConsole();
            Console.WriteLine();
        }
    }
}

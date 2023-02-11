using System;
using System.Text;

namespace AstronomicalCalculationConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.WriteLine();
                RunMassConversionExamples();
                RunCalculationExamples();
            }
            catch (Exception ex)
            {
                 // TODO
            }
        }

        private static void RunCalculationExamples()
        {
            // GravityCalculationExamples.GravityCalculations();
            GravityCalculationExamples.CalculateInConsole();
        }

        private static void RunMassConversionExamples()
        {
            // MassConversionExamples.MassConversions();
            MassConversionExamples.ConvertInConsole();
        }
    }
}

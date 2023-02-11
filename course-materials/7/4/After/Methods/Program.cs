using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"5 squared = {CalculationHelper.Square(5)}");
            Console.WriteLine($"5.00001 squared = {CalculationHelper.Square(5.00001f)}");
        }
    }
}

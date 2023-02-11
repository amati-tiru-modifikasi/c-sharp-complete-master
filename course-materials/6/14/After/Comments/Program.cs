using System;

namespace Comments
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hover to see the method documentation
            float multiplication = Calculator.Multiply(3f, 6.25f);
            float division = Calculator.Divide(18, 2);
            /*--------------------------------------------------------
                This is a multiple line comment
                Print out the values to the console
            --------------------------------------------------------*/
            Console.WriteLine($"{nameof(multiplication)} = {multiplication}");
            Console.WriteLine($"{nameof(division)} = {division}");

        }
    }
}

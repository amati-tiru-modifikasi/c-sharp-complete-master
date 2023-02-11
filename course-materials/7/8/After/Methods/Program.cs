using System;

namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            RunPassingValueParameterByValueExample();
            Console.WriteLine();
            RunPassingValueParameterByReferenceExample();
            
        }


        private static void RunPassingValueParameterByReferenceExample()
        {
            Console.WriteLine("--- Passing reference parameter by reference ---");
            Console.WriteLine();
            // When passing reference parameter by reference, Any changes inside of the method 
            // has an effect on the original value of the variable
            int integer = 7;
            Console.WriteLine($"Before calling the method SquareByReference, the integer value is: {integer}");
            Console.WriteLine();
            CalculationHelper.SquareByReference(ref integer);
            Console.WriteLine($"After calling the method SquareByReference, the integer value is: {integer}");
            Console.WriteLine();
        }

        private static void RunPassingValueParameterByValueExample()
        {
            Console.WriteLine("--- Passing reference parameter by value ---");
            Console.WriteLine();
            // When passing reference parameter by value, Any changes inside of the method 
            // have no effect on the original value of the variable
            int integer = 7;
            Console.WriteLine($"Before calling the method SquareByValue, the integer value is: {integer}");
            Console.WriteLine();
            CalculationHelper.SquareByValue(integer);
            Console.WriteLine($"After calling the method SquareByValue, the integer value is: {integer}");
            Console.WriteLine();
        }
    }
}

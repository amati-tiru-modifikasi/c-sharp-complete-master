using System;

namespace Methods
{
    public static class CalculationHelper
    {
        public static void SquareByValue(int integer)
        {
            integer *= integer;
            Console.WriteLine($"Integer value inside SquareByValue method:");
            Console.WriteLine($"{integer}");
            Console.WriteLine();
        }

        public static void SquareByReference(ref int integer)
        {
            integer *= integer;
            Console.WriteLine($"Integer value inside SquareByReference method:");
            Console.WriteLine($"{integer}");
            Console.WriteLine();
        }

        public static int Square(int integer)
        {
            return integer * integer;
        }

        public static float Square(float floatValue)
        {
            return floatValue * floatValue;
        }
    }
}

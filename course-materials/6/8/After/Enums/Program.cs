using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            EnumInstantiation();
            TryParseStringValue();
            IntegerValueToObject();
            CheckValuesBeforeCasting();
            GetConstants();
        }

        private static void EnumInstantiation()
        {
            Console.WriteLine("> EnumInstantiation");
            Console.WriteLine("----------------------------------------");
            // instantiation
            // use enum constants
            Planet neptune = Planet.Neptune;
            // Cast an integer value
            Planet earth = (Planet)3;
            // use a parameter-less ctor
            SuperpowerLevel noneLevel = new SuperpowerLevel(); // !!! It's not a valid constant in the enum if no constant with value equal to 0
            Planet mercury = new Planet(); // !!! It's not a valid constant in the enum if no constant with value equal to 0
            Console.WriteLine($"{nameof(neptune)} enum constant: {neptune}");
            Console.WriteLine($"{nameof(earth)} enum constant: {earth}");
            Console.WriteLine($"{nameof(mercury)} enum constant: {mercury}");
            Console.WriteLine($"{nameof(noneLevel)} enum constant: {noneLevel}");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
        }

        private static void IntegerValueToObject()
        {
            // Use Enum.ToObject
            Planet jupiter = (Planet)Enum.ToObject(typeof(Planet), 4); // A cast is needed
        }

        private static void TryParseStringValue()
        {
            // use Parse or TryParse
            var parseSucceeded = Enum.TryParse(typeof(Planet), "Mars", out var planet);
            if (parseSucceeded)
            {
                Planet mars = (Planet)planet; // A cast is needed
                Console.WriteLine($"Parse succeeded : {mars}");
            }
            else
            {
                Console.WriteLine("Parse failed");

            }
        }

        static void CheckValuesBeforeCasting()
        {
            Console.WriteLine("> CheckValuesBeforeCasting");
            Console.WriteLine("----------------------------------------");

            int[] valuesToCheck = { -100, -1, 0, 1, 3, 8, 200 };
            foreach (var value in valuesToCheck)
            {
                Planet planet;
                if (Enum.IsDefined(typeof(Planet), value))
                {
                    planet = (Planet)value;
                    Console.WriteLine($"{value} exists in {typeof(Planet).Name} enum : {planet}");
                }
                else
                    Console.WriteLine($"{value} does not exist in {typeof(Planet).Name} enum");
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
        }

        static void GetConstants()
        {
            Console.WriteLine("> GetConstants");
            Console.WriteLine("----------------------------------------");

            var values = Enum.GetValues(typeof(SuperpowerLevel));
            Console.WriteLine($"{typeof(SuperpowerLevel).Name} enum constants");
            foreach (SuperpowerLevel level in values)
            {
                Console.WriteLine(level);
            }

            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
        }
    }
}

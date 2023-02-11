using System;

namespace AstronomicalCalculationConsole
{
    public static class ConsoleInputHelper
    {
        public static void PromptForMass(out long massParsed)
        {
            var mass = Console.ReadLine();
            if (long.TryParse(mass, out massParsed)) return;
            Console.WriteLine("The entered mass is not valid. Try again");
            Console.WriteLine("What is mass in kg of the object ?");
            PromptForMass(out massParsed);
        }
        public static void PromptForMass(out double massParsed)
        {
            var mass = Console.ReadLine();
            if (double.TryParse(mass, out massParsed)) return;
            Console.WriteLine("The entered mass is not valid. Try again");
            Console.WriteLine("What is mass in kg of the object ?");
            PromptForMass(out massParsed);
        }
        public static void PromptForRadius(out double radiusParsed)
        {
            var radius = Console.ReadLine();
            if (double.TryParse(radius, out radiusParsed)) return;
            Console.WriteLine("The entered radius is not valid. Try again");
            Console.WriteLine("What is radius in meters of the object ?");
            PromptForRadius(out radiusParsed);
        }
    }
}

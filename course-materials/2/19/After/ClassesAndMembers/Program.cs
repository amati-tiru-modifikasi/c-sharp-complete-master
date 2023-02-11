using System;

namespace ClassesAndMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            var planet1 = new Planet(1);
            planet1.Name = "Exoplanet";
            planet1.Radius = 10000;
            planet1.PrintInfos();
            Console.WriteLine();
            Console.WriteLine($"Temperature : {planet1.GetTemperature()}°C");
            Console.WriteLine();
            planet1.AddSatellite("Exosatellite");
            Console.WriteLine();
            planet1.PrintInfos();
        }
    }
}

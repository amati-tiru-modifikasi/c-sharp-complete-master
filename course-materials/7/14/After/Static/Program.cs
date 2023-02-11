using System;
using System.Collections.Generic;
using Helpers;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            var planet1 = new Planet("Planet1",new List<string>{"Sat1"});
            PrintPlanetInfo(planet1);
            Console.WriteLine();
            var planet2 = new Planet("Planet2",new List<string>{"Sat1", "Sat2", "Sat3", "Sat4", "Sat5", "Sat6"});
            PrintPlanetInfo(planet2);
            Console.WriteLine();
            Console.WriteLine($"First planet : {Planet.GetAllPlanets()[0]}");
        }

        private static void PrintPlanetInfo(Planet planet)
        {
            Console.WriteLine(planet.Name);
            Console.WriteLine(Planet.Shape);
            Console.WriteLine(Planet.Orbit);
            foreach (var satellite in planet.GetSatellites())
            {
                Console.WriteLine($"Satellite : {satellite.Name}");
            }
        }
    }
}

using System;
using System.Globalization;
using AstronomicalCalculationLibrary;

namespace AstronomicalCalculationConsole
{
    public static class GravityCalculationExamples
    {
        private static readonly string _separator = "-------------------";
        public static void GravityCalculations()
        {
            CalculateGravityAndPrint("Moon", Constants.Satellites.Moon.MASS, Constants.Satellites.Moon.RADIUS);
            Console.WriteLine(_separator);
            CalculateGravityAndPrint("Black hole", 10 * Constants.Stars.Sun.MASS, 10);
            Console.WriteLine(_separator);
            CalculateGravityAndPrint("Impossible", 10 * Constants.Stars.Sun.MASS, -1);
            CalculatePlanetsGravity();
        }

        private static void CalculatePlanetsGravity()
        {
            string[] planetNames = { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };
            foreach (var name in planetNames)
            {
                CalculateGravityAndPrint(name);
                Console.WriteLine("---");
            }
        }

        private static void CalculateGravityAndPrint(string name, double mass, double radius)
        {
            var gravity = AstronomicalCalculator.CalculateGravity(mass, radius);
            var escapeVelocity = AstronomicalCalculator.CalculateEscapeVelocity(mass, radius);
            WriteGravityCalculationResultsToConsole(name, gravity, escapeVelocity);
        }
        private static void CalculateGravityAndPrint(string name)
        {
            try
            {
                var gravity = AstronomicalCalculator.CalculatePlanetGravity(name);
                var escapeVelocity = AstronomicalCalculator.CalculatePlanetEscapeVelocity(name);
                WriteGravityCalculationResultsToConsole(name, gravity, escapeVelocity);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }
        static void WriteGravityCalculationResultsToConsole(string objectName, double gravity, double escapeVelocity)
        {
            Console.WriteLine($"--- {objectName} ----");
            Console.WriteLine($"Object Gravity : {Math.Round(gravity, 1)} m/s²");
            Console.WriteLine($"Escape Velocity : {Math.Round(escapeVelocity, 1)} m/s, {Math.Round(escapeVelocity * Constants.MS_TO_KMH_CONVERSION_FACTOR, 1)} km/h");
        }

        public static void CalculateInConsole()
        {
            Console.WriteLine("What is the object name ?");
            var name = Console.ReadLine();
            Console.WriteLine("What is the mass in kg of the object ?");
            ConsoleInputHelper.PromptForMass(out double massInKg);
            Console.WriteLine("What is the radius in meters of the object ?");
            ConsoleInputHelper.PromptForRadius(out double radiusInMeters);
            var gravity = AstronomicalCalculator.CalculateGravity(massInKg, radiusInMeters);
            var velocity = AstronomicalCalculator.CalculateEscapeVelocity(massInKg, radiusInMeters);
            WriteGravityCalculationResultsToConsole(name, gravity, velocity);
        }
    }
}


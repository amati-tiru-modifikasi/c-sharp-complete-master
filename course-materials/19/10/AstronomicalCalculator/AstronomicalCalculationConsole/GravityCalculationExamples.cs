using System;
using System.Globalization;
using AstronomicalCalculationLibrary;

namespace AstronomicalCalculationConsole
{
    public static class GravityCalculationExamples
    {
        public static void GravityCalculations()
        {
            Console.WriteLine("--- Start --- GravityCalculationExamples --- GravityCalculations ---");
            CalculateGravityAndPrint(Satellites.Moon.ToString(), Constants.Satellites.Moon.MASS, Constants.Satellites.Moon.RADIUS);
            CalculateGravityAndPrint("Black hole", 10 * Constants.Stars.Sun.MASS, 10);
            CalculateGravityAndPrint("Impossible", 10 * Constants.Stars.Sun.MASS, -1);
            CalculatePlanetsGravity();
            Console.WriteLine("--- End --- GravityCalculationExamples --- GravityCalculations ---");
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
            try
            {
                var gravity = AstronomicalCalculator.CalculateGravity(mass, radius);
                var escapeVelocity = AstronomicalCalculator.CalculateEscapeVelocity(mass, radius);
                WriteGravityCalculationResultsToConsole(name, gravity, escapeVelocity);
            }
            catch (Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ResetColor();
            }
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
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ResetColor();
            }
        }

        static void WriteGravityCalculationResultsToConsole(string name, double gravity, double escapeVelocity)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"--- {name} ----");
            Console.WriteLine($"Object Gravity : {Math.Round(gravity, 1)} m/s²");
            Console.WriteLine($"Escape Velocity : {Math.Round(escapeVelocity, 1)} m/s, {Math.Round(escapeVelocity * Constants.MS_TO_KMH_CONVERSION_FACTOR, 1)} km/h");
        }

        public static void CalculateInConsole()
        {
            Console.WriteLine("--- Start --- GravityCalculationExamples --- CalculateInConsole ---");
            Console.WriteLine("What is the object name ?");
            var name = Console.ReadLine();
            Console.WriteLine("What is the mass in kg of the object ?");
            ConsoleInputHelper.PromptForMass(out double massInKg);
            Console.WriteLine("What is the radius in meters of the object ?");
            ConsoleInputHelper.PromptForRadius(out double radiusInMeters);
            try
            {
                var gravity = AstronomicalCalculator.CalculateGravity(massInKg, radiusInMeters);
                var velocity = AstronomicalCalculator.CalculateEscapeVelocity(massInKg, radiusInMeters);
                WriteGravityCalculationResultsToConsole(name, gravity, velocity);
            }
            catch (System.Exception ex)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(ex);
            }
            finally
            {
                Console.ResetColor();
                Console.WriteLine("--- End --- GravityCalculationExamples --- CalculateInConsole ---");
            }
        }
    }
}

using System;
using System.Collections.Generic;

namespace AstronomicalCalculationLibrary
{
    public static class AstronomicalCalculator
    {
        private static readonly List<Planet> _planets = new()
        {
            new() { Name = Planets.Mercury.ToString(), Mass = Constants.Planets.Mercury.MASS , Radius = Constants.Planets.Mercury.RADIUS },
            new() { Name = Planets.Venus.ToString(), Mass = Constants.Planets.Venus.MASS , Radius = Constants.Planets.Venus.RADIUS },
            new() { Name = Planets.Earth.ToString(), Mass = Constants.Planets.Earth.MASS , Radius = Constants.Planets.Earth.RADIUS },
            new() { Name = Planets.Mars.ToString(), Mass = Constants.Planets.Mars.MASS , Radius = Constants.Planets.Mars.RADIUS },
            new() { Name = Planets.Jupiter.ToString(), Mass = Constants.Planets.Jupiter.MASS , Radius = Constants.Planets.Jupiter.RADIUS },
            new() { Name = Planets.Saturn.ToString(), Mass = Constants.Planets.Saturn.MASS , Radius = Constants.Planets.Saturn.RADIUS },
            new() { Name = Planets.Uranus.ToString(), Mass = Constants.Planets.Uranus.MASS , Radius = Constants.Planets.Uranus.RADIUS },
            new() { Name = Planets.Neptune.ToString(), Mass = Constants.Planets.Neptune.MASS , Radius = Constants.Planets.Neptune.RADIUS },
        };
        public static double CalculateGravity(double mass, double radius)
        {
            if (mass <= 0)
            {
                throw new ArgumentException("Mass parameter must be a positive value");
            }
            if (radius <= 0)
            {
                throw new ArgumentException("Radius parameter must be a positive value");
            }
            return Constants.GRAVITATIONAL_CONSTANT * mass / Math.Pow(radius, 2);
        }

        public static double CalculateEscapeVelocity(double mass, double radius)
        {
            if (mass <= 0)
            {
                throw new ArgumentException("Mass parameter must be a positive value");
            }
            if (radius <= 0)
            {
                throw new ArgumentException("Radius parameter must be a positive value");
            }
            return Math.Sqrt(2 * Constants.GRAVITATIONAL_CONSTANT * mass / radius);
        }
        public static double CalculatePlanetGravity(string planetName)
        {
            if (planetName == null)
            {
                throw new ArgumentNullException("The planet name is null");
            }
            if (planetName == string.Empty)
            {
                throw new ArgumentException("The planet name is an empty string");
            }
            if (!Enum.TryParse<Planets>(planetName, out Planets planetEnum))
            {
                throw new ArgumentException("The planet name is not valid. Valid planet names : Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune");
            }
            Planet planet = GetPlanet(planetEnum);
            return Constants.GRAVITATIONAL_CONSTANT * planet.Mass / Math.Pow(planet.Radius, 2);
        }

        public static double CalculatePlanetEscapeVelocity(string planetName)
        {
            if (planetName == null)
            {
                throw new ArgumentNullException("The planet name is null");
            }
            if (planetName == string.Empty)
            {
                throw new ArgumentException("The planet name is an empty string");
            }
            if (!Enum.TryParse<Planets>(planetName, out Planets planetEnum))
            {
                throw new ArgumentException("The planet name is not valid. Valid planet names : Mercury, Venus, Earth, Mars, Jupiter, Saturn, Uranus, Neptune");
            }
            Planet planet = GetPlanet(planetEnum);
            return Math.Sqrt(2 * Constants.GRAVITATIONAL_CONSTANT * planet.Mass / planet.Radius);
        }

        private static Planet GetPlanet(Planets planetEnum)
        {
            var planet = _planets[(int)planetEnum];
            return planet;
        }
    }
}

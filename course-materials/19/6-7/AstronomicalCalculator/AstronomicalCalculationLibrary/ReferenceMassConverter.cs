using System;

namespace AstronomicalCalculationLibrary
{
    public static class ReferenceMassConverter
    {
        public static double ToSolarMasses(double mass)
        {
            if (mass <= 0)
            {
                throw new ArgumentException("Mass must be positive");
            }
            return ToReferenceMasses(mass, Constants.Stars.Sun.MASS);
        }

        public static double ToEarthMasses(double mass)
        {
            if (mass <= 0)
            {
                throw new ArgumentException("Mass must be positive");
            }
            return ToReferenceMasses(mass, Constants.Planets.Earth.MASS);
        }

        public static double ToReferenceMasses(double mass, double referenceMass)
        {
            if (mass <= 0)
            {
                throw new ArgumentException("Mass parameter must be a positive value");
            }
            if (referenceMass <= 0)
            {
                throw new ArgumentException("Reference Mass parameter must be a positive value");
            }
            return mass / referenceMass;
        }

        public static long ToReferenceMasses(long mass, long referenceMass)
        {
            if (mass <= 0)
            {
                throw new ArgumentException("Mass parameter must be a positive value");
            }
            if (referenceMass <= 0)
            {
                throw new ArgumentException("Reference Mass parameter must be a positive value");
            }
            return mass / referenceMass;
        }
    }
}

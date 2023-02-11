using System;

namespace AstronomicalCalculationLib
{
    public static class ReferenceMassConverter
    {
        public static double ToSolarMasses(double mass)
        {
            if (mass <= 0)
            {
                throw new AstronomicalCalculationArgumentException("Mass parameter must be a positive value", mass.ToString(), nameof(mass));
            }
            return ToReferenceMasses(mass, Constants.Stars.Sun.MASS);
        }

        public static double ToEarthMasses(double mass)
        {
            if (mass <= 0)
            {
                throw new AstronomicalCalculationArgumentException("Mass parameter must be a positive value", mass.ToString(), nameof(mass));
            }
            return ToReferenceMasses(mass, Constants.Planets.Earth.MASS);
        }

        public static double ToReferenceMasses(double mass, double referenceMass)
        {
            if (mass <= 0)
            {
                throw new AstronomicalCalculationArgumentException("Mass parameter must be a positive value", mass.ToString(), nameof(mass));
            }
            if (referenceMass <= 0)
            {
                throw new AstronomicalCalculationArgumentException("Reference mass parameter must be a positive value", referenceMass.ToString(), nameof(referenceMass));
            }
            return mass/referenceMass;
        }

        public static long ToReferenceMasses(long mass, long referenceMass)
        {
            if (mass <= 0)
            {
                throw new AstronomicalCalculationArgumentException("Mass parameter must be a positive value", mass.ToString(), nameof(mass));
            }
            if (referenceMass <= 0)
            {
                throw new AstronomicalCalculationArgumentException("Reference mass parameter must be a positive value", referenceMass.ToString(), nameof(referenceMass));
            }
            return mass/referenceMass;
        }
    }
}

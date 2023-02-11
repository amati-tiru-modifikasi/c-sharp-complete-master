using System;

namespace AstronomicalCalculationLibrary
{
    public static class ReferenceMassConverter
    {
        public static double ToSolarMasses(double mass)
        {
            return ToReferenceMasses(mass, Constants.Stars.Sun.MASS);
        }

        public static double ToEarthMasses(double mass)
        {
            return ToReferenceMasses(mass, Constants.Planets.Earth.MASS);
        }

        public static double ToReferenceMasses(double mass, double referenceMass)
        {
            return mass/referenceMass;
        }

        public static long ToReferenceMasses(long mass, long referenceMass)
        {
            return mass/referenceMass;
        }
    }
}

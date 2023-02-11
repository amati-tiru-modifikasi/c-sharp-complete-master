using System;

namespace AstronomicalCalculationLibrary
{
    public static class Constants
    {
        public const float MS_TO_KMH_CONVERSION_FACTOR = 3.6f;
        public const double GRAVITATIONAL_CONSTANT = 6.6e-11;

        public static class Satellites
        {
            public static class Moon
            {
                public const double MASS = 7.3e22;
                public const double RADIUS = 1.7e6;
            }
            public static class Europa
            {
                public const double MASS = 4.7e22;
                public const double RADIUS = 1.5e6;
            }
        }

        public static class Stars
        {
            public static class Sun
            {
                public const double MASS = 1.9e30;
                public const double RADIUS = 6.9e8;
            }
            public static class R136A1
            {
                public const double MASS = 4.1e32;
                public const double RADIUS = 2.7e10;
            }
        }
        public static class Planets
        {
            public static class Mercury
            {
                public const double MASS = 3.3e23;
                public const double RADIUS = 2.4e6;
            }
            public static class Venus
            {
                public const double MASS = 4.8e24;
                public const double RADIUS = 6e6;
            }
            public static class Earth
            {
                public const double MASS = 5.9e24;
                public const double RADIUS = 6.3e6;
            }
            public static class Mars
            {
                public const double MASS = 6.4e23;
                public const double RADIUS = 3.3e6;
            }
            public static class Jupiter
            {
                public const double MASS = 1.9e27;
                public const double RADIUS = 7.1e7;
            }
            public static class Saturn
            {
                public const double MASS = 5.6e26;
                public const double RADIUS = 6e7;
            }
            public static class Uranus
            {
                public const double MASS = 8.6e25;
                public const double RADIUS = 2.5e7;
            }
            public static class Neptune
            {
                public const double MASS = 1e26;
                public const double RADIUS = 2.4e7;
            }
        }
    }
}

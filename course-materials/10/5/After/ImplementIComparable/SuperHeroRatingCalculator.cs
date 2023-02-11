using System;

namespace ImplementIComparable
{
    public static class SuperHeroRatingCalculator
    {
        public static int CalculateRating(
            int numberOfSuperpowers,
            HealthLevel health,
            SuperpowerLevel superPowerLevel,
            StrengthLevel strength
        )
        {
            return Math.Abs((numberOfSuperpowers * 10 + (int)health + (int)superPowerLevel + (int)strength) / 4);
        }
    }
}
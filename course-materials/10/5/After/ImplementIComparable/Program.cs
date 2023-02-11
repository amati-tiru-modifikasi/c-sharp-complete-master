using System;

namespace ImplementIComparable
{
    class Program
    {
        static void Main(string[] args)
        {
            var superHero1 = new SuperHero
            {
                NumberOfSuperpowers = 3,
                Health = HealthLevel.Four,
                Strength = StrengthLevel.Three,
                SuperpowerLevel = SuperpowerLevel.Three
            };

            var superHero2 = new SuperHero
            {
                NumberOfSuperpowers = 5,
                Health = HealthLevel.Five,
                Strength = StrengthLevel.Four,
                SuperpowerLevel = SuperpowerLevel.Three
            };

            var isSuperHero1BetterThanSuperHero2 = superHero1.CompareTo(superHero2);
            var response = isSuperHero1BetterThanSuperHero2 > 0 ? "Yes" : "No";
            Console.WriteLine($"Is {nameof(superHero1)} better than {nameof(superHero2)} ? {response}");
        }
    }
}

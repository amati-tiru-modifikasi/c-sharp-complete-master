using System;

namespace ImplementIComparable
{
    public class SuperHero : IComparable
    {
        public string Name { get; set; }
        public int NumberOfSuperpowers { get; set; }
        public StrengthLevel Strength { get; set; }
        public HealthLevel Health { get; set; }
        public SuperpowerLevel SuperpowerLevel { get; set; }
        public int CompareTo(object obj)
        {
            var rating = SuperHeroRatingCalculator.CalculateRating(
                this.NumberOfSuperpowers,
                this.Health,
                this.SuperpowerLevel,
                this.Strength
            );

            var superHero = obj as SuperHero;
            var ratingToCompare = SuperHeroRatingCalculator.CalculateRating(
                superHero.NumberOfSuperpowers,
                superHero.Health,
                superHero.SuperpowerLevel,
                superHero.Strength
            );
            
            return rating.CompareTo(ratingToCompare);
        }
    }

    public enum StrengthLevel
    {
        One = 10,
        Two = 20,
        Three = 40,
        Four = 60,
        Five = 100
    }

    public enum HealthLevel
    {
        One = 10,
        Two = 20,
        Three = 40,
        Four = 60,
        Five = 100
    }
    public enum SuperpowerLevel
    {
        One = 10,
        Two = 20,
        Three = 40,
        Four = 60,
        Five = 100
    }

}
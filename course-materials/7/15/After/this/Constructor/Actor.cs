using System;
using System.Collections.Generic;

namespace Constructor
{
    public class Actor
    {
        private string firstname;
        public string Firstname
        {
            get { return firstname; }
            set { firstname = value; }
        }

        private string lastname;
        public string Lastname
        {
            get { return lastname; }
            set { lastname = value; }
        }

        private int popularity;
        public int Popularity
        {
            get { return popularity; }
        }

        public Actor()
        {

        }

        public Actor(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            popularity = PopularityCalculator.CalculatePopularity(this);
        }

    }

    public static class PopularityCalculator
    {
        public static int CalculatePopularity(Actor actor)
        {
            return new Random().Next(0, 100);
        }
    }
}

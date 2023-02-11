using System;

namespace Methods
{
    public class Movie
    {
        public int Id { get; internal set; }
        public string Title { get; set; }
        public string Overview { get; set; }

        // method override Object.ToString()
        public override string ToString()
        {
            return $"Movie : Id = {Id} - Title : {Title} - Overview : {Overview}";
        }
    }
}

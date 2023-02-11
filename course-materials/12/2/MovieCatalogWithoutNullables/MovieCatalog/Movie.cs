using System;

namespace MovieCatalog
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Overview { get; set; }
        public int Revenue { get; set; }
        public double VoteAverage { get; set; }
        public bool HasAward { get; set; }

        public Movie() : this(0)
        {
            
        }

        public Movie(int id)
        {
            Id = id;
        }
    }
}

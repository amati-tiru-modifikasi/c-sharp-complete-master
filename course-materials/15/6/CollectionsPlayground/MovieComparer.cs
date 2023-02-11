using System.Collections.Generic;

namespace CoolectionsPlaygrouund
{
    internal class MovieComparer : IComparer<Movie>
    {
        public int Compare(Movie movie1, Movie movie2)
        {
            return movie1.Id.CompareTo(movie2.Id);
        }
    }
}
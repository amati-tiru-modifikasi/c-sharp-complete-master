using System.Collections.Generic;

namespace CoolectionsPlaygrouund
{
    internal class MovieEqualityComparer : IEqualityComparer<Movie>
    {
        public bool Equals(Movie movie1, Movie movie2)
        {
            return movie1.Id.Equals(movie2.Id);
        }

        public int GetHashCode(Movie obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
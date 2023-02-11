using System.Collections.Generic;
using LinqPlayground.Entities;

namespace LinqPlayground
{
    public class MovieIdentifierEqualityComparer : IEqualityComparer<Movie>
    {
        public bool Equals(Movie movie1, Movie movie2) => movie1.Id.Equals(movie2.Id);

        public int GetHashCode(Movie movie) => movie.Id.GetHashCode();
    }
}
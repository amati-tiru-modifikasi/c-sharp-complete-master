using System.Collections.Generic;
using LinqPlayground.Entities;

namespace LinqPlayground
{
    public class MovieEqualityComparer : IEqualityComparer<Movie>
    {
        public bool Equals(Movie movie1, Movie movie2) =>  movie1.Id.Equals(movie2.Id) &&
            movie1.ReleaseDate.Equals(movie2.ReleaseDate) &&
            movie1.Budget.Equals(movie2.Budget) &&
            movie1.Revenue.Equals(movie2.Revenue) &&
            movie1.Runtime.Equals(movie2.Runtime) &&
            movie1.Title.Equals(movie2.Title) &&
            movie1.Overview.Equals(movie2.Overview) &&
            movie1.Popularity.Equals(movie2.Popularity) &&
            movie1.Tagline.Equals(movie2.Tagline) &&
            movie1.VoteAverage.Equals(movie2.VoteAverage) &&
            movie1.VoteCount.Equals(movie2.VoteCount);

        public int GetHashCode(Movie movie) => movie.Id.GetHashCode();
    }
}
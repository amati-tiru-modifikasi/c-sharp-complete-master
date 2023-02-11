using System;
using System.Collections.Generic;
using Entities;

namespace DataAccess
{
    public class MovieData
    {
        internal List<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie{Id = 1, Title = "Title 1", Overview = "Overview 1", ReleaseDate = new DateTime(2010,1,1)},
                // new MovieDescription{Id = 1, Title = "Title 1", ReleaseDate = new DateTime(), Category = string.Empty} // error
                new Movie{Id = 2, Title = "Title 2", Overview = "Overview 2", ReleaseDate = new DateTime(2017,2,15)}
            };
        }
    }
}
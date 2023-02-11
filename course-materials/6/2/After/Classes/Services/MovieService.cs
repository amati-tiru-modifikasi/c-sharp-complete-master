using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Services
{
    public class MovieService
    {
        // Field used internally (private)
        private readonly List<Movie> _movieList;

        // Constructor
        public MovieService()
        {
            _movieList = new List<Movie>{
                new Movie{Id = 1 , Title = "Title 1", Overview = "Overview 1"},
                new Movie{Id = 2 , Title = "Title 2", Overview = "Overview 2"},
                new Movie{Id = 3 , Title = "Title 3", Overview = "Overview 3"},
                new Movie{Id = 4 , Title = "Title 4", Overview = "Overview 4"},
                new Movie{Id = 5 , Title = "Title 5", Overview = "Overview 5"},
            };
        }

        // Method
        public List<Movie> GetMovies()
        {
            return _movieList;
        }
    }
    
}
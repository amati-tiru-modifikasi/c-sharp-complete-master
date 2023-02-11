using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess;
using Models;

namespace Services
{
    class MovieService
    {
        // making this field private prevents from using this
        // member outside of this service class
        private MovieData _movieData = new MovieData();

        public List<MovieDescription> GetMovies()
        {
            return _movieData.GetMovies().Select(entity => new MovieDescription{
                Description = new StringBuilder().Append(entity.Title)
                .Append("\n").Append(entity.ReleaseDate.Year.ToString())
                .Append("\n").Append(entity.Overview)
                .ToString()
            }).ToList();
        }
    } 
}
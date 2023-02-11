using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Movie
    {
        public string Title { get; set; }
        public string Overview { get; set; }
        public List<Actor> Actors { get; set; }

        private readonly string _language = "English";

        public Movie()
        {
            Actors = new List<Actor>(); // Uncomment to fix System.NullReferenceException
        }
        
        public Movie(string title, string overview) : this()
        {
            Title = title;
            Overview = overview;
        }

        public Movie(string title, string overview, string language) : this(title, overview)
        {
            _language = language;
        }

        public Movie(string title, string overview, List<Actor> actors) : this(title, overview)
        {
            Actors = actors;
        }

        public Movie(string title, string overview, string language, List<Actor> actors) : this(title, overview)
        {
            _language = language;
            Actors = actors;
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Movie Title : {Title} - Overview : {Overview} - Language : {_language}");
            if (Actors.Count > 0)
            {
                foreach (var actor in Actors)
                {
                    stringBuilder.AppendLine($"Actor : {actor.Firstname} , {actor.Lastname}, Popularity : {actor.Popularity}");
                }
            }
            return stringBuilder.ToString();
        }
    }
}

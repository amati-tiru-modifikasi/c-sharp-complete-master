using System;

namespace MovieCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie = new Movie()
            {
                Id = 1,
                Title = "Interstellar",
                // ReleaseDate = null,
                ReleaseDate = new DateTime(2014, 11, 5),
                Overview = "The adventures of a group of explorers who make use of a newly discovered wormhole to surpass the limitations on human space travel and conquer the vast distances involved in an interstellar voyage.",
                // Overview = null,
                Revenue = null,
                // Revenue = 675120017,
                VoteAverage = 8.3,
                HasAward = true
                // HasAward = null
            };

            PrintMovieInfos(movie);
        }

        private static void PrintMovieInfos(Movie movie)
        {
            PrintTitleAndOverview(movie.Title, movie.Overview);
            PrintMovieReleaseDate(movie.ReleaseDate);
            PrintRevenueAndVoteInfos(movie.Revenue, movie.VoteAverage);
            PrintMovieAward(movie.HasAward);
        }

        private static void PrintTitleAndOverview(string title, string overview)
        {
            if (!string.IsNullOrEmpty(title))
            {
                Console.WriteLine($"Movie title : {title}");
            }
            else
            {
                Console.WriteLine("No title provided");
            }

            if (!string.IsNullOrEmpty(overview))
            {
                Console.WriteLine($"Movie overview : {overview}");
            }
            else
            {
                Console.WriteLine("No overview provided");
            }
        }

        private static void PrintMovieReleaseDate(DateTime? releaseDate)
        {
            if (releaseDate.HasValue)
            {
                Console.WriteLine($"Movie release Date : {releaseDate:t}");
            }
            else
            {
                Console.WriteLine("Unknown release date");
            }
        }

        private static void PrintRevenueAndVoteInfos(int? revenue, double? voteAverage)
        {
            if (revenue.HasValue)
            {
                Console.WriteLine($"Movie Revenue : {revenue}");
            }
            else
            {
                Console.WriteLine("Unknown revenue");
            }

            if (voteAverage.HasValue)
            {
                int numberOfStars = (int)Math.Abs(voteAverage.Value / 2);
                Console.WriteLine($"Movie rating : {new string('*', numberOfStars)}");
            }
            else
            {
                Console.WriteLine("No rating");
            }
        }
        private static void PrintMovieAward(bool? hasAward)
        {
            if (hasAward.HasValue)
            {
                Console.WriteLine("Awarded movie");
            }
            else
            {
                Console.WriteLine("No award obtained");
            }
        }

    }
}

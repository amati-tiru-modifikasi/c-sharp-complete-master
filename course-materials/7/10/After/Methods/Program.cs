using System;

namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            RunPassingReferenceParameterByValueExample();
            Console.WriteLine();
            RunPassingReferenceParameterByReferenceExample();
            Console.WriteLine();
            RunPassingReferenceParameterByReferenceWithOutExample();
        }

        private static void RunPassingReferenceParameterByReferenceExample()
        {
            Console.WriteLine("--- Passing reference parameter by reference ---");
            Console.WriteLine();
            // Any changes that take place in the method affect the original object
            var movie1 = new Movie { Title = "Movie title 1", Overview = "Movie overview 1" };
            Console.WriteLine($"Before calling the method ChangeMovieOverviewByReference, movie instance is:");
            Console.WriteLine($"{movie1}");
            Console.WriteLine();
            ChangeMovieOverviewByReference(ref movie1);
            Console.WriteLine($"After calling the method ChangeMovieOverviewByReference, movie is:");
            Console.WriteLine($"{movie1}");
            Console.WriteLine();

            var movie2 = new Movie { Title = "Movie title 2", Overview = "Movie overview 2" };
            Console.WriteLine($"Before calling the method AllocateNewMovieByReference, movie is:");
            Console.WriteLine($"{movie2}");
            Console.WriteLine();
            AllocateNewMovieByReference(ref movie2);
            Console.WriteLine($"After calling the method AllocateNewMovieByReference, movie is:");
            Console.WriteLine($"{movie2}");
            Console.WriteLine();
        }

        private static void RunPassingReferenceParameterByReferenceWithOutExample()
        {
            Console.WriteLine("--- Passing reference parameter by reference ---");
            Console.WriteLine();
            // Any changes that take place in the method affect the original object
            var movie1 = new Movie { Title = "Movie title 1", Overview = "Movie overview 1" };
            Console.WriteLine($"Before calling the method ChangeMovieOverviewByReference, movie instance is:");
            Console.WriteLine($"{movie1}");
            Console.WriteLine();
            ChangeMovieOverviewByReferenceWithOut(out movie1);
            Console.WriteLine($"After calling the method ChangeMovieOverviewByReference, movie is:");
            Console.WriteLine($"{movie1}");
            Console.WriteLine();
        }

        private static void RunPassingReferenceParameterByValueExample()
        {
            Console.WriteLine("--- Passing reference parameter by value ---");
            Console.WriteLine();
            // When passing reference parameter by value any changes on the parameters members 
            // inside of the called method has an effect on the original object
            var movieFactory = new MovieFactory();
            var movie1 = movieFactory.CreateMovie(1, "Movie title 1", "Movie overview 1");
            Console.WriteLine($"Before calling the method ChangeMovieOverviewByValue, movie instance is:");
            Console.WriteLine($"{movie1}");
            Console.WriteLine();
            ChangeMovieOverviewByValue(movie1);
            Console.WriteLine($"After calling the method ChangeMovieOverviewByValue, movie is:");
            Console.WriteLine($"{movie1}");
            Console.WriteLine();

            // When passing reference parameter creating a new object in memory inside of the
            // called method has no effect on the original object
            var movie2 = movieFactory.CreateMovie(2, "Movie title 2", "Movie overview 2");
            Console.WriteLine($"Before calling the method AllocateNewMovieByValue, movie is:");
            Console.WriteLine($"{movie2}");
            Console.WriteLine();
            AllocateNewMovieByValue(movie2);
            Console.WriteLine($"After calling the method AllocateNewMovieByValue, movie is:");
            Console.WriteLine($"{movie2}");
            Console.WriteLine();
        }
        static void ChangeMovieOverviewByValue(Movie movie)
        {
            movie.Overview = "MODIFIED!";
            Console.WriteLine($"Inside ChangeMovieOverviewByValue method, movie is:");
            Console.WriteLine($"{movie}");
            Console.WriteLine();
        }
        static void AllocateNewMovieByValue(Movie movie)
        {
            movie = new Movie
            {
                Title = "NEW MOVIE TITLE!",
                Overview = "NEW MOVIE OVERVIEW!"
            };
            Console.WriteLine($"Inside AllocateNewMovieByValue method, movie is:");
            Console.WriteLine($"{movie}");
            Console.WriteLine();
        }
        static void ChangeMovieOverviewByReference(ref Movie movie)
        {
            movie.Overview = "MODIFIED!";
            Console.WriteLine($"Inside ChangeMovieOverviewByReference method, movie is:");
            Console.WriteLine($"{movie}");
            Console.WriteLine();
        }
        static void AllocateNewMovieByReference(ref Movie movie)
        {
            movie = new Movie
            { 
                Title = "NEW MOVIE TITLE!",
                Overview = "NEW MOVIE OVERVIEW!"
            };
            Console.WriteLine($"Inside AllocateNewMovieByReference method, movie is:");
            Console.WriteLine($"{movie}");
            Console.WriteLine();
        }

        static void ChangeMovieOverviewByReferenceWithOut(out Movie movie)
        {
            // The only difference between ref and out is that a parameter defined
            // with out must be initialized inside of the method
            movie = new MovieFactory().CreateMovie(); // Error if this line is commented out
        }
    }
}

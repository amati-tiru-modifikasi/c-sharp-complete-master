using System;

namespace Methods
{
    class Program
    {

        static void Main(string[] args)
        {
            var movieFactory = new MovieFactory();
            var myMovie = movieFactory.CreateMovie(1, "My title", "My overview");
            // var myMovie = movieFactory.CreateMovie(1, overview : "My overview", title: "My title");
            // var myMovie = movieFactory.CreateMovie( title: "My title", overview: "My overview", id: 1);

            var defaultMovie = movieFactory.CreateMovie();
            // var defaultMovie = movieFactory.CreateMovie(0, overview: "Another Overview");
            // var defaultMovie = movieFactory.CreateMovie(0, title: "Another Title");
            Console.WriteLine($"Default Movie created :");
            Console.WriteLine($"{defaultMovie}");
            Console.WriteLine();
            Console.WriteLine($"Movie created :");
            Console.WriteLine($"{myMovie}");
        }     
    }
}

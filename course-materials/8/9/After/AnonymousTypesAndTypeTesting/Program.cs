using System;
using System.Collections.Generic;

namespace AnonymousTypesAndTypeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new(1, "Title 1", "Overview 1");
            Console.WriteLine(movie1);
            var movie2 = new { Id = 1, Title = "Title 1", Overview = "Overview 1" };
            Console.WriteLine(movie2);
            Console.WriteLine();
            // types are not equal
            Type movie1Type = movie1.GetType();
            Type movie2Type = movie2.GetType();
            Console.WriteLine($"{nameof(movie1Type)} ReferenceEquals {nameof(movie2Type)} ? {Object.ReferenceEquals(movie1Type, movie2Type)}");
            Console.WriteLine($"{nameof(movie1Type)} ReferenceEquals {typeof(Movie)} ? {Object.ReferenceEquals(movie1Type, typeof(Movie))}");
            Console.WriteLine();

            // print out the type and the FullName property
            Console.WriteLine($"{nameof(movie1)} type : {movie1Type}");
            Console.WriteLine($"{nameof(movie1)} type full name : {movie1Type.FullName}");
            Console.WriteLine();
            Console.WriteLine($"{nameof(movie2)} type : {movie2Type}");
            Console.WriteLine($"{nameof(movie2)} type full name: {movie2Type.FullName}");

            movie2 = new { Id = 1, Title = "Title 2", Overview = "Overview 2" }; // OK
            // movie2 = new { Id = 1, Title = "Title 2" }; // KO compiling error
        }
    }

    public class BaseClass { }

    public class DerivedClass : BaseClass { }

    delegate void PrintHandler(string message);
}

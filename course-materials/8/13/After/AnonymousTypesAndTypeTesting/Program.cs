using System;
using System.Collections.Generic;

namespace AnonymousTypesAndTypeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintTypeInfo("int type", typeof(int));
            PrintTypeInfo("List<Movie> type", typeof(List<Movie>));
            Movie movie = new(1, "Title 1", "Overview 1");
            if (movie.GetType() == typeof(Movie))
            {
                Console.WriteLine($"{nameof(movie)} is a {movie.GetType()}");
            }
        }

        private static void PrintTypeInfo(string name, Type objectType)
        {
            Console.WriteLine($"{name} type : {objectType}");
            Console.WriteLine($"{name} type name : {objectType.Name}");
            Console.WriteLine($"{name} type full name : {objectType.FullName}");
            Console.WriteLine($"{name} is a class ? {objectType.IsClass}");
            Console.WriteLine($"{name} base type {objectType.BaseType}");
            Console.WriteLine();
        }
    }

    public class BaseClass { }

    public class DerivedClass : BaseClass { }

    delegate void PrintHandler(string message);
}

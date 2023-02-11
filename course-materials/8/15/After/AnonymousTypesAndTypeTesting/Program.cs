using System;
using System.Collections.Generic;

namespace AnonymousTypesAndTypeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            // variable is T is returns true when a boxing or unboxing conversion 
            // exists from the run-time type of the variable to type T
            int i = 1;
            Console.WriteLine($"{nameof(i)} is {typeof(int).Name} ? {i is int}");
            Console.WriteLine($"{nameof(i)} is {typeof(object).Name} ? {i is object}");
            Console.WriteLine();

            object obj = i;
            Console.WriteLine($"{nameof(obj)} is {typeof(int).Name} ? {obj is int}");
            Console.WriteLine($"{nameof(obj)} is {typeof(object).Name} ? {obj is object}");
            Console.WriteLine();

            // variable is T is returns true when the run-time type of the
            // variable is T or derives from type T or implements interface T
            Movie movie = new(1, "Title 1", "Overview 1");
            Console.WriteLine($"{nameof(movie)} is {typeof(Movie).Name} ? {movie is Movie}");
            Console.WriteLine($"{nameof(movie)} is {typeof(object).Name} ? {movie is object}");
            Console.WriteLine($"{nameof(movie)} is {typeof(BaseClass).Name} ? {movie is BaseClass}");
            Console.WriteLine($"{nameof(movie)} is {typeof(IPlayable).Name} ? {movie is IPlayable}");
            Console.WriteLine();

            var baseInstance = new BaseClass();
            Console.WriteLine($"{nameof(baseInstance)} is {typeof(BaseClass).Name} ? {baseInstance is BaseClass}");
            Console.WriteLine($"{nameof(baseInstance)} is {typeof(DerivedClass).Name} ? {baseInstance is DerivedClass}");
            var derivedInstance = new DerivedClass();
            Console.WriteLine($"{nameof(derivedInstance)} is {typeof(BaseClass).Name} ? {derivedInstance is BaseClass}");
            Console.WriteLine($"{nameof(derivedInstance)} is {typeof(DerivedClass).Name} ? {derivedInstance is DerivedClass}");
            Console.WriteLine();

            // variable is T is returns true when the run-time type of the variable
            // is a nullable of T
            int? iNullable = 1;
            Console.WriteLine($"{nameof(i)} is {typeof(int).Name} ? {i is int}");
            Console.WriteLine($"{nameof(i)} is {typeof(int?).Name} ? {i is int?}");
            Console.WriteLine($"{nameof(iNullable)} is {typeof(int?).Name} ? {iNullable is int?}");
            Console.WriteLine($"{nameof(iNullable)} is {typeof(int).Name} ? {iNullable is int}");

            int? iNullable1 = null;
            Movie movie1 = null;
            Console.WriteLine($"{nameof(iNullable1)} is null ? {iNullable1 is null}");
            Console.WriteLine($"{nameof(movie1)} is null ? {movie1 is null}");
            Console.WriteLine($"{nameof(iNullable1)} is not null ? {iNullable1 is not null}");
            Console.WriteLine($"{nameof(movie1)} is not null ? {movie1 is not null}");

            iNullable1 = 1;
            movie1 = new Movie(1, "title", "overview");
            Console.WriteLine($"{nameof(iNullable1)} is null ? {iNullable1 is null}");
            Console.WriteLine($"{nameof(movie1)} is null ? {movie1 is null}");
            Console.WriteLine($"{nameof(iNullable1)} is not null ? {iNullable1 is not null}");
            Console.WriteLine($"{nameof(movie1)} is not null ? {movie1 is not null}");
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

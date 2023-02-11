using System;
using System.Collections.Generic;

namespace AnonymousTypesAndTypeTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            // for value type
            int int1 = 1;
            var int1Type = int1.GetType();
            PrintTypeInfo(nameof(int1), int1Type);

            // for an array
            int[] intArray = { 1, 2, 3, 4, 5 };
            Type intArrayType = intArray.GetType();
            PrintTypeInfo(nameof(intArray), intArrayType);

            // for a datetime
            DateTime dt = DateTime.Now;
            Type dtType = dt.GetType();
            PrintTypeInfo(nameof(dt), dtType);

            // for a ref type
            Movie movie = new(1, "Title 1", "Overview 1");
            Type movieType = movie.GetType();
            PrintTypeInfo(nameof(movie), movieType);

            // for a list
            List<Movie> movieList = new() { movie };
            Type movieListType = movieList.GetType();
            PrintTypeInfo(nameof(movieList), movieListType);

            // for an interface
            IPlayable playable = movie;
            Type playableType = playable.GetType();
            PrintTypeInfo(nameof(playable), playableType);

            // for an enum
            Planet planet = 0;
            Type planetType = planet.GetType();
            PrintTypeInfo(nameof(planet), planetType);

            // for a delegate
            PrintHandler printHandler = Console.WriteLine;
            Type printHandlerType = printHandler.GetType();
            PrintTypeInfo(nameof(printHandler), printHandlerType);

            // Inheritance
            BaseClass baseInstance = new BaseClass();
            PrintTypeInfo(nameof(baseInstance), baseInstance.GetType());
            DerivedClass derivedInstance = new DerivedClass();
            PrintTypeInfo(nameof(derivedInstance), derivedInstance.GetType());
            object derivedIntanceAsObject = derivedInstance;
            PrintTypeInfo(nameof(derivedIntanceAsObject), derivedIntanceAsObject.GetType());
            BaseClass derivedInstanceAsBase = derivedInstance;
            PrintTypeInfo(nameof(derivedInstanceAsBase), derivedInstanceAsBase.GetType());
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

using System;

namespace Records
{
    class Program
    {
        static void Main(string[] args)
        {
            InheritanceSample();
        }

        private static void InheritanceSample()
        {
            Console.WriteLine("> Inheritance");
            Console.WriteLine("--------------------------------------");
            OrderItem inStoreOrderItem1 = new InStoreOrderItem(1, "Product1", 1, "Store1");
            var inStoreOrderItem2 = (InStoreOrderItem)inStoreOrderItem1;
            var (id, product, quantity, store) = inStoreOrderItem2;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
        }

        public static void ClassSample()
        {
            Console.WriteLine("> ClassSample");
            Console.WriteLine("--------------------------------------");
            var movie = new Classes.Movie(1, "Movie Title", "Movie Description");
            Console.WriteLine($"{nameof(movie)} : {movie}");
            var (id, title, description) = movie;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
        }

        private static void RecordSample()
        {
            Console.WriteLine("> RecordSample");
            Console.WriteLine("--------------------------------------");
            var movie = new Movie(1, "Movie Title", "Movie Description")
            {
                NumberOfStars = 4
            };
            Console.WriteLine($"{nameof(movie)} : {movie}");
            var newMovie = movie with
            {
                Description = "Another description",
                NumberOfStars = 3,

            };
            Console.WriteLine($"{nameof(newMovie)} : {newMovie}");
            var (id, title, description, nbStars) = movie;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
        }

        private static void Equality()
        {
            Console.WriteLine("> Equality");
            Console.WriteLine("--------------------------------------");
            var movie1 = new Records.Movie(1, "Movie Title", "Movie Description");
            var movie2 = new Records.Movie(2, "Movie Title", "Movie Description");
            Console.WriteLine($"{nameof(movie1)} == {nameof(movie2)} ? {movie1 == movie2}");
            Console.WriteLine($"Equals({nameof(movie1)},{nameof(movie2)}) ? {Equals(movie1, movie2)}");
            Console.WriteLine($"{nameof(movie1)}.ReferenceEquals({nameof(movie2)}) ? {ReferenceEquals(movie1, movie2)}");
            Console.WriteLine($"{nameof(movie1)}.GetHashCode() = {movie1.GetHashCode()}");
            Console.WriteLine($"{nameof(movie2)}.GetHashCode() = {movie2.GetHashCode()}");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine();
        }

    }
}

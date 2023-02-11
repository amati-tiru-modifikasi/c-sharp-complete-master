using System;
using Entities;
using Services;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var global = new Global();
            global.DoSomething();
            new Local().DoSomething();
            // Class instance
            var service = new MovieService();
            Console.WriteLine($"Get movie from service : {service.GetMovies()[0].Title}"); 
        }
    }

    // Bad practice for large projects
    // This class is defined in the same file
    class Local
    {
        public void DoSomething(){}
    }
}

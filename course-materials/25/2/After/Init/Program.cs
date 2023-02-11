using System;
using Init;

InitPropertiesSample();

void InitPropertiesSample()
{
    Console.WriteLine("> InitPropertiesSample");
    Console.WriteLine("--------------------------------------");
    // var immutableMovie = new Movie(1, "Movie title", "Movie description");
    var immutableMovie = new Movie()
    {
        Id = 1,
        Title = "Movie title",
        Description = "Movie description"
    };
    Console.WriteLine($"Before reassignement {immutableMovie}");
    immutableMovie = new Movie
    {
        Id = 2,
        Title = "Modified title",
        Description = "Modified decription"
    };
    Console.WriteLine($"After reassignement {immutableMovie}");
    Console.WriteLine("--------------------------------------");
}



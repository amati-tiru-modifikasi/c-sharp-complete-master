using System;
using System.Collections.Generic;

namespace ExpressionBodyDefinition
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>
            {
                new Movie
                {
                    Id =2093,
                    ReleaseDate = DateTime.Parse("1983-05-25 00:00:00.0000000"),
                    Budget = 32350000,
                    Revenue = 572700000,
                    Runtime = 135,
                    Title = "Return of the Jedi",
                    Overview = "Luke Skywalker leads a mission to rescue his friend Han Solo from the clutches of Jabba the Hutt, while the Emperor seeks to destroy the Rebellion once and for all with a second dreaded Death Star.",
                    Popularity = 25,
                    Tagline = "The Empire Falls...",
                    VoteAverage = 7,
                    VoteCount = 10992
                },
                new Movie
                {
                    Id =2109,
                    ReleaseDate = DateTime.Parse("1993-06-11 00:00:00.0000000"),
                    Budget = 63000000,
                    Revenue = 920100000,
                    Runtime = 127,
                    Title = "Jurassic Park",
                    Overview = "A wealthy entrepreneur secretly creates a theme park featuring living dinosaurs drawn from prehistoric DNA. Before opening day, he invites a team of experts and his two eager grandchildren to experience the park and help calm anxious investors. However, the park is anything but amusing as the security systems go off-line and the dinosaurs escape.",
                    Popularity = 24,
                    Tagline = "An adventure 65 million years in the making.",
                    VoteAverage = 7,
                    VoteCount = 11856
                },
                new Movie
                {
                    Id =2257,
                    ReleaseDate = DateTime.Parse("2013-11-15 00:00:00.0000000"),
                    Budget = 130000000,
                    Revenue = 847423452,
                    Runtime = 146,
                    Title = "The Hunger Games: Catching Fire",
                    Overview = "Katniss Everdeen has returned home safe after winning the 74th Annual Hunger Games along with fellow tribute Peeta Mellark. Winning means that they must turn around and leave their family and close friends, embarking on a \"Victor's Tour\" of the districts. Along the way Katniss senses that a rebellion is simmering, but the Capitol is still very much in control as President Snow prepares the 75th Annual Hunger Games (The Quarter Quell) - a competition that could change Panem forever.",
                    Popularity = 35,
                    Tagline = "Every revolution begins with a spark.",
                    VoteAverage = 7,
                    VoteCount = 13611
                }
            };
            foreach (var movie in movies)
            {
                movie.DisplayData();
            }
            
        }
    }
}

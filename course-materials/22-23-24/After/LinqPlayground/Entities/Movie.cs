using System;
using System.Collections.Generic;
using System.Text;

namespace LinqPlayground.Entities
{
    public class Movie
    {
        public int Id { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int? Budget { get; set; }
        public long? Revenue { get; set; }
        public int? Runtime { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public int Popularity { get; set; }
        public string Tagline { get; set; }
        public int VoteAverage { get; set; }
        public int VoteCount { get; set; }
        public List<Cast> Casts { get; set; }
        public int NumberOfStars => (int)Math.Abs(VoteAverage / 2);

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"------ {Title} ------");
            stringBuilder.AppendLine($"Number of stars : {new string('*', NumberOfStars)}");
            stringBuilder.AppendLine($"Released on {ReleaseDate:Y}");
            stringBuilder.AppendLine($"Budget : {Budget:c}");
            stringBuilder.AppendLine($"Revenue : {Revenue:c}");
            stringBuilder.AppendLine($"Runtime : {Runtime}");
            stringBuilder.AppendLine($"Popularity : {Popularity}");
            stringBuilder.AppendLine($"Vote rating : {VoteAverage}/10");
            stringBuilder.AppendLine($"Number of voters : {VoteCount}");
            stringBuilder.AppendLine($"{Overview}");
            stringBuilder.AppendLine();
            return stringBuilder.ToString();
        }
    }
}
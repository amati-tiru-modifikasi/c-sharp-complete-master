using System;
using System.Text;

namespace LinqPlayground.Models
{
    public class Movie
    {
        public DateTime ReleaseDate { get; set; }
        public string Title { get; set; }
        public string Overview { get; set; }
        public double VoteAverage { get; set; }
        public int VoteCount { get; set; }
        
        public int NumberOfStars => (int)Math.Abs(VoteAverage / 2);

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"------ {Title} ------");
            stringBuilder.AppendLine($"Number of stars : {new string('*', NumberOfStars)}");
            stringBuilder.AppendLine($"Released on {ReleaseDate:Y}");
            string shortOverview = Overview.Length <= 250 ? Overview : string.Concat(Overview.Substring(0, 250), " ...");
            stringBuilder.AppendLine($"{shortOverview}");
            stringBuilder.AppendLine();
            return stringBuilder.ToString();
        }
    }
}
using System;
using System.Text;

namespace ExpressionBodyDefinition
{
    public class Movie
    {
        private int _id;
        // public int Id
        // {
        //     get { return _id; }
        //     set { _id = value; }
        // }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

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
        // public int NumberOfStars
        // {
        //     get { return Math.Abs(VoteAverage / 2); }
        // }
        public int NumberOfStars => Math.Abs(VoteAverage / 2);

        public Movie()
        {

        }
        // public Movie(int id)
        // {
        //     _id = id;
        // }
        public Movie(int id) => _id = id;

        // public override string ToString()
        // {
        //     return $"{Title} - {ReleaseDate} - {new string('*', NumberOfStars)}";
        // }
        public override string ToString() => $"{Title} - {ReleaseDate} - {new string('*', NumberOfStars)}";

        // public void DisplayData()
        // {
        //     Console.WriteLine(GetMovieInfos());
        // }
        public void DisplayData() => Console.WriteLine(GetMovieInfos());

        private string GetMovieInfos()
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
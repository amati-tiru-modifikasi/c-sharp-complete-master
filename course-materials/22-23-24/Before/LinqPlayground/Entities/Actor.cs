using System;
using System.Text;

namespace LinqPlayground.Entities
{
    public class Actor
    {
        public int Id { get; set; }
        public string Biography { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
        public string Name { get; set; }
        public double Popularity { get; set; }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"------ {Name} ------");
            stringBuilder.AppendLine($"Born in {BirthDate:Y}");
            stringBuilder.AppendLine($"Popularity : {Popularity}");
            stringBuilder.AppendLine($"{Biography}");
            stringBuilder.AppendLine();
            return stringBuilder.ToString();
        }
    }
}
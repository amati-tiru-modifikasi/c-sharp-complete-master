using System.Collections.Generic;
using System.Text;

namespace Immutability
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Award> Awards { get; }
        public Movie(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
            Awards = new List<Award>();
        }

        public Movie(int id, string title, string description, List<Award> awards) : this(id, title, description)
        {
            Awards = awards;
        }

        public void AddAward(Award award)
        {
            Awards.Add(award);
        }

        public override string ToString()
        {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Id : {Id} - Title : {Title} - Description : {Description}");
            foreach (var award in Awards)
            {
                stringBuilder.AppendLine($"Award : {award.Title}");
            }
            return stringBuilder.ToString();
        }
    }

    public class Award
    {
        public string Title { get; set; }

        public Award(string title)
        {
            Title = title;
        }
    }
}



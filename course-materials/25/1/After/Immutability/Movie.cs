using System.Collections.Generic;
using System.Text;

namespace Immutability
{
    public class Movie
    {
        private readonly int _id;
        public int Id => _id;

        private readonly string _title;
        public string Title => _title;

        private readonly string _description;
        public string Description => _description;

        private readonly List<Award> _awards;
        public List<Award> Awards => _awards;
        public Movie(int id, string title, string description)
        {
            _id = id;
            _title = title;
            _description = description;
            _awards = new List<Award>();
        }

        public Movie(int id, string title, string description, List<Award> awards) : this(id, title, description) =>
            _awards = awards;

        public Movie AddAward(Award award)
        {
            var newAwards = new List<Award>(_awards);
            newAwards.Add(award);
            return new(_id, _title, _description, newAwards);
        }

        public Movie ChangeDescription(string description) => new(_id, _title, description, _awards);

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
        private readonly string _title;
        public string Title => _title;

        public Award(string title) => _title = title;
    }
}
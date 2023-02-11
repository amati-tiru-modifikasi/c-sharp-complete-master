using System.Collections.Generic;

namespace Records
{
    public record Movie(int Id, string Title)
    {
        public string Description { get; init; }
        public int NumberOfStars { get; init; }

        public Movie(int id, string title, string description) : this(id, title)
        {
            Description = description;
        }

        public void Deconstruct(out int id, out string title, out string description, out int numberOfStars)
        {
            id = Id;
            title = Title;
            description = Description;
            numberOfStars = NumberOfStars;
        }

        public List<string> GetComments() => new()
        {
            "Comment1",
            "Comment2",
            "Comment3"
        };
    }
}
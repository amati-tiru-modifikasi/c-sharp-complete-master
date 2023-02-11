namespace Classes
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public Movie(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }
    }
}
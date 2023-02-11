namespace Init
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Movie()
        {
            
        }

        public Movie(int id, string title, string description)
        {
            Id = id;
            Title = title;
            Description = description;
        }

        public override string ToString() => $"Id : {Id} - Title : {Title} - Description : {Description}";
    }
}
namespace Init
{
    public class Movie
    {
        public int Id { get; init; }
        // public string Title { get; set; }
        private string _title;
        public string Title
        {
            get => _title;
            init => _title = value;
        }
        
        // public string Description { get; set; }
        private string _description;
        public string Description
        {
            get { return _description; }
            init { _description = value; }
        }
        
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
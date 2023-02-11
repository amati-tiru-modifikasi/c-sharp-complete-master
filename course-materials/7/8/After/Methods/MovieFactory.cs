namespace Methods
{
    // Instantiable class
    public class MovieFactory
    {
        // instance method
        // default parameters
        public Movie CreateMovie(int id = 0, string title = "Default Title", string overview = "Default Overview")
        {
            return new Movie { Id = id, Title = title, Overview = overview };
        }
    }
}
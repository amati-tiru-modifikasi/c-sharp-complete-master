using System;

namespace AnonymousTypesAndTypeTesting
{
    public class Movie : IPlayable
    {
        public int Id { get; private set; }
        public string Title { get; private set; }
        public string Overview { get; private set; }

        public Movie(int id, string title, string overview)
        {
            Id = id;
            Title = title;
            Overview = overview;
        }

        public override string ToString()
        {
            return $"Movie, Title : {Title} - Overview : {Overview}";
        }

        public void Play()
        {
            throw new NotImplementedException();
        }
    }
}

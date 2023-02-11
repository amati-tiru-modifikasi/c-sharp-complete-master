using System;

namespace Entities
{
    internal class Movie
    {
        // fields
        private string _title;
        private string _overview;

        // bad practice, use a property
        public string GetTitle()
        {
            return _title;
        }

        // read-write property
        public string Title
        {
            get
            {
                return _title;
            }

            set
            {
                _title = value;
            }
            // Possible to make this setter private
            // private set
            // {
            //     _title = value;
            // }
        }

        // readonly property
        public string Overview
        {
            get
            {
                return _overview;
            }
            set
            {
                _overview = value;
            }

        }

        // very usefull shorthand
        // Auto implemented read write property
        public int Id { get; set; }

        
        public DateTime ReleaseDate { get; set; }

        // Possible to make it read only property
        // public DateTime ReleaseDate { get; }
        
        // Possible to define the setter visibility
        public string Category { get; private set; }
    }
}
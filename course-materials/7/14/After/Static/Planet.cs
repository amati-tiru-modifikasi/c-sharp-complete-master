using System.Collections.Generic;
using System.Linq;

namespace Helpers
{
    public class Planet
    {
        private List<Satellite> _satellites;
        
        
        public string Name { get; set; }
        public static string Shape { get; set; }

        public static string Orbit 
        {
            get 
            {
                return "Elliptical";
            }
        }        

        static Planet()
        {
            Shape = "Spheroid";
        }

        public Planet(string name, List<string> satellites)
        {
            Name = name; 
            _satellites = new List<Satellite>();
            var counter = 1;
            foreach (var satellite in satellites)
            {
                _satellites.Add(new Satellite{Id = counter, Name = satellite});
                counter = counter++;
            }
        }

        public static string[] GetAllPlanets()
        {
            return new string[8]{"Mercury","Venus","Earth","Mars","Jupiter","Saturn","Uranus","Neptune"};
        }
        public Satellite[] GetSatellites()
        {
            return _satellites.ToArray();
        }
        
    }
    
}
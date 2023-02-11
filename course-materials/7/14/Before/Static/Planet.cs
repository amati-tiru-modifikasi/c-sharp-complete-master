using System.Collections.Generic;

namespace Helpers
{
    public class Planet
    {
        private List<Satellite> _satellites;
        
        public string Name { get; set; }
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
    
    }
    
}
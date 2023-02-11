using System;
using System.Collections.Generic;

namespace ClassesAndMembers
{
    public class Planet
    {
        private int _id;
        public string Name { get; set; }

        private int _radius;

        public int Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }
        private List<string> _satellites = new();

        public Planet(int id)
        {
            _id = id;
        }

        public int GetTemperature()
        {
            return new Random().Next(-200, 200);
        }

        public void PrintInfos()
        {
            Console.Write(this);
        }

        public void AddSatellite(string name)
        {
            _satellites.Add(name);
        }

        public override string ToString()
        {
            string planetInfos = $"Planet id : {_id}" + Environment.NewLine;
            planetInfos += $"Name : {Name}" + Environment.NewLine;
            planetInfos += $"Radius : {_radius} km" + Environment.NewLine;
            planetInfos += $"{Name} has {_satellites.Count} satellite(s)" + Environment.NewLine;
            return planetInfos;
        }

    }
}
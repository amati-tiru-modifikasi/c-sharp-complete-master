namespace Shapes
{
    public abstract class Shape
    {
        public string Name { get; set; }
        
        public Shape(string name)
        {
            Name = name;
        }

        public abstract double CalculateArea();
    }
}
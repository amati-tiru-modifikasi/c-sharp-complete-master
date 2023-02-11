namespace Shapes.Polygons
{
    class Triangle : Polygon
    {
        public double Height { get; set; }
        public double Base { get; set; }

        public Triangle(double height, double @base) : base("Triangle")
        {
            Height = height;
            Base = @base;
        }

        public Triangle(string name, double height, double @base) : base(name)
        {
            Height = height;
            Base = @base;
        }

        public override double CalculateArea()
        {
            return Height * Base / 2;
        }
    }
}
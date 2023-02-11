namespace Shapes.Curves
{
    public class Circle : Ellipsis
    {
        public Circle(double radius) : base("Circle", radius, radius)
        {
        }

        public sealed override double CalculateArea()
        {
            return base.CalculateArea();
        }
    }
}
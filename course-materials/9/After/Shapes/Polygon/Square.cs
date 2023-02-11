namespace Shapes.Polygons
{
    class Square : Rectangle
    {
        public Square(double length) : base("Square", length, length)
        {
            
        }

        public override double CalculateArea()
        {
            return base.CalculateArea();
        }
    }

    class MoreSpecializedSquare : Square
    {
        public MoreSpecializedSquare(double length) : base(length)
        {
        }

        public sealed override double CalculateArea()
        {
            return base.CalculateArea();
        }
    }
}
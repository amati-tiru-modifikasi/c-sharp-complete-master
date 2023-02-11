using System;

namespace Shapes.Curves
{
    public class Ellipsis : Curve
    {
        public double MinorRadius { get; set; }

        public double MajorRadius { get; set; }

        public Ellipsis(double minorRadius, double majorRadius) : base("Ellispis")
        {
            MinorRadius = minorRadius;
            MajorRadius = majorRadius;
        }

        public Ellipsis(string name, double minorRadius, double majorRadius) : base(name)
        {
            MinorRadius = minorRadius;
            MajorRadius = majorRadius;
        }

        public override double CalculateArea()
        {
            return Math.PI * MinorRadius * MajorRadius;
        }
    }
}
namespace Structures
{
    // can't inherit form class or struct
    // supports interfaces implementation
    public struct Point
    {
        // Impossible to initialize an instance field or prop at declaration
        // public int X { get; set; } = 1;
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        // you can initialize static or const fields at declaration
        private static readonly Point _origin = new Point(0, 0, 0);
        public static Point Origin
        {
            get
            {
                return _origin;
            }
        }

        // // You can't declare a parameterless constructor
        // // Every structure already provides an implicit one
        // public Point()
        // {
        // }

        public Point(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
            // A ctor must initialize all the fields/poperties
        }

        public override string ToString()
        {
            return $"(X = {X}, Y = {Y}, Z = {Z})";
        }

        public void SetToOrigin()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
    }
}
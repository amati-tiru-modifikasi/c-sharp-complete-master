using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new();
            car.MoveForward();
            Boat boat = new();
            boat.MoveForward();
        }
    }
}

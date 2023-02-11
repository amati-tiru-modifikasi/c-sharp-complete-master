using System;

namespace Vehicles
{
    public class Car : ILandVehicle
    {
        public void MoveForward()
        {
            Console.WriteLine("Move like a car");
        }
    }
}
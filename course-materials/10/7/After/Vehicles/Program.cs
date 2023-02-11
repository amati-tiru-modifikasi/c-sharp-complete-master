using System;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            // Regular implementation
            var car = new Car();
            // Car car1 = new();
            // ILandVehicle car1 = new Car();
            car.MoveForward();
            IWatercraft boat = new Boat();
            boat.MoveForward();
            // Explicit implementation
            // Compiling error, because interface implemented explicitly
            // var boat = new Boat();
            // boat.MoveForward();

            var amphibousVehicle = new AmphibiousVehicle();
            amphibousVehicle.MoveForward();
            ((IWatercraft)amphibousVehicle).MoveForward();
            ((ILandVehicle)amphibousVehicle).MoveForward();
        }
    }
}

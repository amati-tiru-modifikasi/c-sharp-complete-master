using System;

namespace Vehicles
{
    public class AmphibiousVehicle : ILandVehicle, IWatercraft
    {
        public void MoveForward()
        {
            Console.WriteLine("Move like a land vehicle or watercraft ?");
        }
        void ILandVehicle.MoveForward()
        {
            Console.WriteLine("Move like a land vehicle !");
        }

        void IWatercraft.MoveForward()
        {
            Console.WriteLine("Move like a watercraft !");
        }
    }
}
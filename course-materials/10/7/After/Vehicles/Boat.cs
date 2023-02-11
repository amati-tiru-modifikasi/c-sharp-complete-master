using System;

namespace Vehicles
{
    public class Boat : IWatercraft
    {
        void IWatercraft.MoveForward()
        {
            Console.WriteLine("Move like a boat");
        }
    }
}
using System;

namespace Vehicles
{
    public class Boat : IWatercraft
    {
        public void MoveForward()
        {
            Console.WriteLine("Move like a boat");
        }
    }
}
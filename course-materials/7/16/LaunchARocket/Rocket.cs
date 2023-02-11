using System;

namespace LaunchARocket
{
    public class Rocket
    {
        // here you must create 4 private fields
        // _fuelLevel : reamining fuel level in the rocket 
        // _power : the propulsion power of the rocket 
        // (the rocket is propelled at each impulsion)
        // _fuelPerImpulsion : fuel consumed for each impulsion
        // _numberOfImpulsions : number of impulsions performed
        
        // here you must create 2 auto-implemented properties
        // Name and CoveredDistance

        // here you must create 2 computed properties
        // CanPropel (if enough fuel)
        // DistanceCoveredInOneImpulsion (calculation : 100 * _power)

        // this class has a constructor
        // Initialize the fields and properties that must be initialized

        public void PropelRocketAndNotifyWhenOutOfFuel()
        {
            // insert the name of the rocket in this interpolated string
            Console.WriteLine($"Rocket is starting off ...");
            Console.WriteLine($"Distance before refuel {GetDistanceBeforeRefuel():N0} kms");
            PropelWhileEnoughFuel();
            NotifyRocketOutOfFuel();
        }

        public void PropelWhileEnoughFuel()
        {
            // implement this method
            // while the rocket can propel call the CheckFuelAndPropel method
            throw new NotImplementedException();
        }

        public void CheckFuelAndPropel()
        {
            // implement this method
            // if the rocket can propel 
            // update the fuel level, the covered distance and the number of impulsions
            throw new NotImplementedException();
        }

        private void NotifyRocketOutOfFuel()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            // insert the name of the rocket in this interpolated string
            Console.WriteLine($"!!! Out of fuel !!!");
            Console.ResetColor();
        }

        public void RefuelRocket(int fuelReload)
        {
            // update the fuel level
            Console.ForegroundColor = ConsoleColor.Blue;
            // insert the name of the rocket in this interpolated string
            Console.WriteLine($"Refueled");
            Console.ResetColor();
        }

        private float GetDistanceBeforeRefuel()
        {
            // Implement this method
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            // Implement this method
            // Display the name, the remaining fuel level, the distance covered in one impulsion
            // the number of impulsions and the covered distance
            throw new NotImplementedException();
        }
    }
}
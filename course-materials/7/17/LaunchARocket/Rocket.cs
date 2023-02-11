using System;

namespace LaunchARocket
{
    public class Rocket
    {
        private int _fuelLevel;
        private int _power;
        private int _fuelPerImpulsion;
        private int _numberOfImpulsions;
        public string Name { get; set; }
        public float CoveredDistance { get; set; }
        public bool CanPropel
        {
            get
            {
                if (_fuelLevel >= _fuelPerImpulsion)
                {
                    return true;
                }
                return false;
            }
        }

        public int DistanceCoveredInOneImpulsion
        {
            get
            {
                return 100 * _power;
            }
        }

        public Rocket(string name, int fuelLevel, int power, int fuelPerImpulsion)
        {
            Name = name;
            _fuelLevel = fuelLevel;
            _power = power;
            _fuelPerImpulsion = fuelPerImpulsion;
            _numberOfImpulsions = 0;
        }

        public void PropelRocketAndNotifyWhenOutOfFuel()
        {
            Console.WriteLine($"Rocket {Name} is starting off ...");
            Console.WriteLine($"Distance before refuel {GetDistanceBeforeRefuel():N0} kms");
            PropelWhileEnoughFuel();
            NotifyRocketOutOfFuel();
        }

        public void PropelWhileEnoughFuel()
        {
            while (CanPropel)
            {
                CheckFuelAndPropel();
            }
        }

        public void CheckFuelAndPropel()
        {
            if (CanPropel)
            {
                _fuelLevel -= _fuelPerImpulsion;
                CoveredDistance += DistanceCoveredInOneImpulsion;
                _numberOfImpulsions++;
            }
        }

        private void NotifyRocketOutOfFuel()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"!!! {Name} out of fuel !!!");
            Console.ResetColor();
        }

        public void RefuelRocket(int fuelReload)
        {
            _fuelLevel += fuelReload;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{Name} Refueled");
            Console.ResetColor();
        }

        private float GetDistanceBeforeRefuel()
        {
            return _fuelLevel / _fuelPerImpulsion * DistanceCoveredInOneImpulsion;
        }

        public override string ToString()
        {
            string rocketInfo = $"Rocket {Name}" + Environment.NewLine;
            rocketInfo += $"Remaining fuel {_fuelLevel} unit(s)" + Environment.NewLine;
            rocketInfo += $"Distance covered in one impulsion {DistanceCoveredInOneImpulsion} km" + Environment.NewLine;
            rocketInfo += $"Number of impulsions {_numberOfImpulsions}" + Environment.NewLine;
            rocketInfo += $"Rocket {Name} covered distance {CoveredDistance:N0} kms {new string('-', (int)CoveredDistance / 10000)} O|====|>" + Environment.NewLine;
            return rocketInfo;
        }
    }
}
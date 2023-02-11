using System;

namespace LaunchARocket
{
    class Program
    {
        static void Main(string[] args)
        {
            var rocket1 = new Rocket("Falcon Heavy", 1000, 87, 11);
            Console.WriteLine("**************************");
            Travel(rocket1);
            Console.WriteLine("**************************");
            var rocket2 = new Rocket("Saturn V", 1000, 59, 14);
            Travel(rocket2);
            Console.WriteLine("**************************");
            DisplayWinnerAndRocketsInfos(rocket1, rocket2);
        }

        private static void Travel(Rocket rocket)
        {
            for (var i = 0; i < 2; i++)
            {
                rocket.PropelRocketAndNotifyWhenOutOfFuel();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Refuel {i + 1}");
                Console.ResetColor();
                rocket.RefuelRocket(200);
            }
            rocket.PropelRocketAndNotifyWhenOutOfFuel();
        }

        private static void DisplayWinnerAndRocketsInfos(Rocket rocket1, Rocket rocket2)
        {
            Console.WriteLine();
            DisplayWinner(rocket1, rocket2);
            Console.WriteLine();
            Console.WriteLine(rocket1);
            Console.WriteLine();
            Console.WriteLine(rocket2);
        }

        private static void DisplayWinner(Rocket rocket1, Rocket rocket2)
        {
            string message = string.Empty;
            if (rocket1.CoveredDistance > rocket2.CoveredDistance)
            {
                message = $"{rocket1.Name} covered a greater distance";
            }
            else if (rocket1.CoveredDistance < rocket2.CoveredDistance)
            {
                message = $"{rocket2.Name} covered a greater distance";
            }
            else
            {
                message = $"{rocket1.Name} and {rocket2.Name} covered the same distance";
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}

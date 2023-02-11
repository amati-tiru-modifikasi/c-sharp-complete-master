using System;

namespace SubscriptionAmountCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseAmount = 100;
            CalculateAndDisplayForSeniors(baseAmount);
            CalculateAndDisplayForAdults(baseAmount);
            CalculateAndDisplayForYouth(baseAmount);
        }

        private static void CalculateAndDisplayForYouth(int baseAmount)
        {
            var amountForYouthOver5y = SubscriptionRateCalculator.CalculateRate(
                new RateCalculationParameters
                {
                    ClientBirthDate = new DateTime(2010, 1, 1),
                    Seniority = 6,
                    IsStudent = false
                }
            );
            var amountForYouthUnder5y = SubscriptionRateCalculator.CalculateRate(
                new RateCalculationParameters
                {
                    ClientBirthDate = new DateTime(2010, 1, 1),
                    Seniority = 4,
                    IsStudent = false
                }
            );
            var amountForYouthStudent = SubscriptionRateCalculator.CalculateRate(
                new RateCalculationParameters
                {
                    ClientBirthDate = new DateTime(2010, 1, 1),
                    Seniority = 4,
                    IsStudent = true
                }
            );
            DisplaySubscriptionAmountForCategory("Youth", baseAmount, amountForYouthOver5y, amountForYouthUnder5y, amountForYouthStudent);
        }

        private static void CalculateAndDisplayForAdults(int baseAmount)
        {
            var amountForAdultOver5y = SubscriptionRateCalculator.CalculateRate(
                new RateCalculationParameters
                {
                    ClientBirthDate = new DateTime(1980, 1, 1),
                    Seniority = 6,
                    IsStudent = false
                }
            );
            var amountForAdultUnder5y = SubscriptionRateCalculator.CalculateRate(
                new RateCalculationParameters
                {
                    ClientBirthDate = new DateTime(1980, 1, 1),
                    Seniority = 4,
                    IsStudent = false
                }
            );
            var amountForAdultStudent = SubscriptionRateCalculator.CalculateRate(
                new RateCalculationParameters
                {
                    ClientBirthDate = new DateTime(1980, 1, 1),
                    Seniority = 4,
                    IsStudent = true
                }
            );
            DisplaySubscriptionAmountForCategory("Adults", baseAmount, amountForAdultOver5y, amountForAdultUnder5y, amountForAdultStudent);
        }

        private static void CalculateAndDisplayForSeniors(int baseAmount)
        {
            var amountForSeniorOver5y = SubscriptionRateCalculator.CalculateRate(
                new RateCalculationParameters
                {
                    ClientBirthDate = new DateTime(1948, 1, 1),
                    Seniority = 6,
                    IsStudent = false
                }
            );
            var amountForSeniorUnder5y = SubscriptionRateCalculator.CalculateRate(
                new RateCalculationParameters
                {
                    ClientBirthDate = new DateTime(1948, 1, 1),
                    Seniority = 4,
                    IsStudent = false
                }
            );
            DisplaySubscriptionAmountForCategory("Seniors", baseAmount, amountForSeniorOver5y, amountForSeniorUnder5y);
        }

        private static void DisplaySubscriptionAmountForCategory(string categoryName, int baseAmount, decimal amountOver5y, decimal amountUnder5y, decimal? amountForStudent = null)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"For {categoryName}");
            if (amountForStudent != null)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("     For students");
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"        Subsciption amount = {baseAmount * amountForStudent}");
                Console.ResetColor();
            }
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("     For more than 5y seniority");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"            Subsciption amount = {baseAmount * amountOver5y}");
            Console.ResetColor();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("     For less than 5y seniority");
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"            Subsciption amount = {baseAmount * amountUnder5y}");
            Console.ResetColor();
        }
    }
}

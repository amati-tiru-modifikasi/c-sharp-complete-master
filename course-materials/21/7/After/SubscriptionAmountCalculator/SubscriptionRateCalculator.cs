using System;
namespace SubscriptionAmountCalculator
{
    static class SubscriptionRateCalculator
    {
        private delegate decimal RateCalculationHandler(int seniority, bool isStudent);

        public static decimal CalculateRate(RateCalculationParameters parameters)
        {
            RateCalculationHandler handler;
            if (parameters.ClientBirthDate.Date > DateTime.Today)
            {
                throw new ArgumentException("Invalid birth date");
            }
            if (parameters.Seniority < 0)
            {
                throw new ArgumentException("Invalid seniority");
            }
            var age = DateTime.Today.Year - parameters.ClientBirthDate.Year;
            if (age > 65)
            {
                handler = CalculateRateForSenior;
            }
            else if (age > 18 && age <= 65)
            {
                handler = CalculateRateForAdult;
            }
            else
            {
                handler = CalculateRateForYouth;
            }
            return handler(parameters.Seniority, parameters.IsStudent);
        }

        private static decimal CalculateRateForSenior(int seniority, bool isStudent)
        {
            decimal rate = 0.95m;
            if (seniority > 5)
            {
                rate = 0.9m;
            }
            return rate;
        }

        private static decimal CalculateRateForAdult(int seniority, bool isStudent)
        {
            decimal rate = 1;
            if (isStudent)
            {
                rate = 0.75m;
            }
            else
            {
                if (seniority > 5)
                {
                    rate = 0.95m;
                }
            }
            return rate;
        }


        private static decimal CalculateRateForYouth(int seniority, bool isStudent)
        {
            decimal rate = 0.9m;
            if (isStudent)
            {
                rate = 0.75m;
            }
            else
            {
                if (seniority > 5)
                {
                    rate = 0.8m;
                }
            }
            return rate;
        }
    }
}
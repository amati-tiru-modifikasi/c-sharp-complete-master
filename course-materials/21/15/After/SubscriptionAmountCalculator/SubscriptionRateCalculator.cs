using System;

namespace SubscriptionAmountCalculator
{
    static class SubscriptionRateCalculator
    {
        public static decimal CalculateRate(RateCalculationParameters parameters)
        {
            if (parameters.ClientBirthDate.Date > DateTime.Today)
            {
                throw new ArgumentException("Invalid birth date");
            }
            if (parameters.Seniority < 0)
            {
                throw new ArgumentException("Invalid seniority");
            }
            var age = DateTime.Today.Year - parameters.ClientBirthDate.Year;
            var handler = GetCalculationDelegate(age);
            return handler(parameters.Seniority, parameters.IsStudent);
        }

        private static Func<int, bool, decimal> GetCalculationDelegate(int age)
        {
            Func<int, bool, decimal> handler;
            if (age > 65)
            {
                handler = SeniorRateCalculation.CalculateRate;
            }
            else if (age > 18 && age <= 65)
            {
                handler = SeniorRateCalculation.CalculateRate;
            }
            else
            {
                handler = SeniorRateCalculation.CalculateRate;
            }

            return handler;
        }
    }
}
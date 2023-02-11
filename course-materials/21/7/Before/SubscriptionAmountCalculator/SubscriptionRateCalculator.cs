using System;
namespace SubscriptionAmountCalculator
{
    static class SubscriptionRateCalculator
    {
        public static decimal CalculateRate()
        {
            throw new NotImplementedException();
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
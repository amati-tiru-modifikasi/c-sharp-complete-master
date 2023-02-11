namespace SubscriptionAmountCalculator
{
    public class SeniorRateCalculation
    {
        public static decimal CalculateRate(int seniority, bool isStudent)
        {
            decimal rate = 0.95m;
            if (seniority > 5)
            {
                rate = 0.9m;
            }
            return rate;
        }
    }
}
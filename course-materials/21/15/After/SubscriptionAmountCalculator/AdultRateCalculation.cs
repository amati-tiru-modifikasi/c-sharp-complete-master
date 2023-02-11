namespace SubscriptionAmountCalculator
{
    public class AdultRateCalculation
    {
        public static decimal CalculateRate(int seniority, bool isStudent)
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
    }
}
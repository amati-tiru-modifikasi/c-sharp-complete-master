namespace SubscriptionAmountCalculator
{
    public class YouthRateCalculation
    {
        public static decimal CalculateRate(int seniority, bool isStudent)
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
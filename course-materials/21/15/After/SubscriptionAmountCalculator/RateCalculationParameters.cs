using System;

namespace SubscriptionAmountCalculator
{
    public class RateCalculationParameters
    {
        public DateTime ClientBirthDate { get; set; }
        public int Seniority { get; set; }
        public bool IsStudent { get; set; }
    }
}
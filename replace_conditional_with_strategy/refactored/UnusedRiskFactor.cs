namespace replace_conditional_with_strategy.refactored
{
    internal class UnusedRiskFactor
    {
        public static UnusedRiskFactor GetFactors()
        {
            return new UnusedRiskFactor();
        }

        public double ForRating(double riskRating)
        {
            return 4;
        }
    }
}

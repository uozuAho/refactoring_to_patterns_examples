namespace replace_conditional_with_strategy.refactored_with_composition
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

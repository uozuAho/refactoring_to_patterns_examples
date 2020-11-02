namespace replace_conditional_with_strategy.initial_state
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

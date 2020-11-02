namespace replace_conditional_with_strategy.refactored
{
    internal class RiskFactor
    {
        public static RiskFactor GetFactors()
        {
            return new RiskFactor();
        }

        public double ForRating(double riskRating)
        {
            return 4;
        }
    }
}

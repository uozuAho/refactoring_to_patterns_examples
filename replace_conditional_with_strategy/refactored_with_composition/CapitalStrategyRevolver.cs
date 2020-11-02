namespace replace_conditional_with_strategy.refactored_with_composition
{
    public class CapitalStrategyRevolver
    {
        public double Capital(Loan loan)
        {
            return loan.Commitment
                   * loan.GetUnusedPercentage()
                   * loan.Duration()
                   * loan.RiskFactor();
        }
    }
}

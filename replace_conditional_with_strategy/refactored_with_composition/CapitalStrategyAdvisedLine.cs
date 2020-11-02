namespace replace_conditional_with_strategy.refactored_with_composition
{
    public class CapitalStrategyAdvisedLine
    {
        public double Capital(Loan loan)
        {
            return loan.OutstandingRiskAmount()
                   * loan.Duration()
                   * loan.RiskFactor()
                   + loan.UnusedRiskAmount()
                   * loan.Duration()
                   * loan.UnusedRiskFactor();
        }
    }
}

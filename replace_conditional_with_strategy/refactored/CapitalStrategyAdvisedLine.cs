namespace replace_conditional_with_strategy.refactored
{
    internal class CapitalStrategyAdvisedLine : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return loan.OutstandingRiskAmount()
                   * Duration(loan)
                   * RiskFactor(loan.RiskRating)
                   + loan.UnusedRiskAmount()
                   * Duration(loan)
                   * UnusedRiskFactor(loan.RiskRating);
        }
    }
}

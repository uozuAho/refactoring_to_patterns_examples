namespace replace_conditional_with_strategy.refactored
{
    internal class CapitalStrategyRevolver : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return loan.Commitment
                   * loan.GetUnusedPercentage()
                   * Duration(loan)
                   * RiskFactor(loan.RiskRating);
        }
    }
}

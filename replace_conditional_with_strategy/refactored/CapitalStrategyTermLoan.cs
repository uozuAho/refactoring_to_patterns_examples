namespace replace_conditional_with_strategy.refactored
{
    internal class CapitalStrategyTermLoan : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return loan.Commitment * Duration(loan) * RiskFactor(loan.RiskRating);
        }
    }
}

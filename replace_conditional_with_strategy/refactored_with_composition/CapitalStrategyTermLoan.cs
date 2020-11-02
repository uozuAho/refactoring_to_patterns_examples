namespace replace_conditional_with_strategy.refactored_with_composition
{
    public class CapitalStrategyTermLoan
    {
        public double Capital(Loan loan)
        {
            return loan.Commitment * loan.Duration() * loan.RiskFactor();
        }
    }
}

namespace replace_conditional_with_strategy.refactored_with_composition
{
    public class CapitalStrategyTermLoan : ICapitalStrategy
    {
        private readonly LoanCalcs _loanCalcs = new LoanCalcs();

        public double Capital(Loan loan)
        {
            return loan.Commitment
                   * loan.Duration()
                   * _loanCalcs.RiskFactor(loan.RiskRating);
        }
    }
}

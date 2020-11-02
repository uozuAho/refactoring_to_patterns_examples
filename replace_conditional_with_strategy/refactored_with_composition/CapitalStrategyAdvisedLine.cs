namespace replace_conditional_with_strategy.refactored_with_composition
{
    public class CapitalStrategyAdvisedLine : ICapitalStrategy
    {
        private readonly LoanCalcs _loanCalcs = new LoanCalcs();

        public double Capital(Loan loan)
        {
            return loan.OutstandingRiskAmount()
                   * loan.Duration()
                   * _loanCalcs.RiskFactor(loan.RiskRating)
                   + loan.UnusedRiskAmount()
                   * loan.Duration()
                   * _loanCalcs.UnusedRiskFactor(loan.RiskRating);
        }
    }
}

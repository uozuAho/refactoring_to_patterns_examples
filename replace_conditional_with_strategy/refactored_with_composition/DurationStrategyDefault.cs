namespace replace_conditional_with_strategy.refactored_with_composition
{
    public class DurationStrategyDefault : IDurationStrategy
    {
        private readonly LoanCalcs _loanCalcs = new LoanCalcs();

        public double Duration(Loan loan)
        {
            return _loanCalcs.YearsTo(loan.Expiry.Value);
        }
    }
}

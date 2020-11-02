namespace replace_conditional_with_strategy.refactored_with_composition
{
    public class DurationStrategyDefault : IDurationStrategy
    {
        public double Duration(Loan loan)
        {
            return loan.YearsTo(loan._expiry.Value);
        }
    }
}

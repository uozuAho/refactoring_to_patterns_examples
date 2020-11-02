namespace replace_conditional_with_strategy.refactored_with_composition
{
    public interface IDurationStrategy
    {
        double Duration(Loan loan);
    }
}

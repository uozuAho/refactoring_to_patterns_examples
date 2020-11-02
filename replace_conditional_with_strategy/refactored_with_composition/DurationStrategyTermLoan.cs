namespace replace_conditional_with_strategy.refactored_with_composition
{
    public class DurationStrategyTermLoan : IDurationStrategy
    {
        public double Duration(Loan loan)
        {
            return WeightedAverageDuration(loan);
        }

        private double WeightedAverageDuration(Loan loan)
        {
            var duration = 0.0;
            var weightedAverage = 0.0;
            var sumOfPayments = 0.0;
            foreach (var payment in loan.Payments)
            {
                sumOfPayments += payment.Amount();
                weightedAverage += loan.YearsTo(payment.Date()) * payment.Amount();
            }

            if (loan.Commitment != 0.0) duration = weightedAverage / sumOfPayments;
            return duration;
        }
    }
}

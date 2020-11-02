namespace replace_conditional_with_strategy.refactored
{
    internal class CapitalStrategyTermLoan : CapitalStrategy
    {
        public override double Capital(Loan loan)
        {
            return loan.Commitment * Duration(loan) * RiskFactor(loan.RiskRating);
        }

        public override double Duration(Loan loan)
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
                weightedAverage += YearsTo(payment.Date()) * payment.Amount();
            }

            if (loan.Commitment != 0.0) duration = weightedAverage / sumOfPayments;
            return duration;
        }
    }
}

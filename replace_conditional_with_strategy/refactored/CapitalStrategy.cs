namespace replace_conditional_with_strategy.refactored
{
    public class CapitalStrategy
    {
        public double Capital(Loan loan)
        {
            if (loan.Expiry == null && loan.Maturity != null)
                return loan.Commitment * loan.Duration() * RiskFactor(loan.RiskRating);
            if (loan.Expiry != null && loan.Maturity == null)
            {
                if (loan.GetUnusedPercentage() != 1.0)
                    return loan.Commitment
                           * loan.GetUnusedPercentage()
                           * loan.Duration()
                           * RiskFactor(loan.RiskRating);
                else
                    return loan.OutstandingRiskAmount()
                           * loan.Duration()
                           * RiskFactor(loan.RiskRating)
                           + loan.UnusedRiskAmount()
                           * loan.Duration()
                           * UnusedRiskFactor(loan.RiskRating);
            }

            return 0.0;
        }

        private double RiskFactor(double riskRating)
        {
            return refactored.RiskFactor.GetFactors().ForRating(riskRating);
        }

        private double UnusedRiskFactor(double riskRating)
        {
            return refactored.UnusedRiskFactor.GetFactors().ForRating(riskRating);
        }
    }
}

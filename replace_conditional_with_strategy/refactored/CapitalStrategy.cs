using System;

namespace replace_conditional_with_strategy.refactored
{
    public class CapitalStrategy
    {
        private const int MillisPerDay = 3600 * 24 * 1000;
        private const int DaysPerYear = 360;

        public virtual double Capital(Loan loan)
        {
            if (loan.Expiry == null && loan.Maturity != null)
                return new CapitalStrategyTermLoan().Capital(loan);
            if (loan.Expiry != null && loan.Maturity == null)
            {
                if (loan.GetUnusedPercentage() != 1.0)
                    return new CapitalStrategyRevolver().Capital(loan);
                else
                    return loan.OutstandingRiskAmount()
                           * Duration(loan)
                           * RiskFactor(loan.RiskRating)
                           + loan.UnusedRiskAmount()
                           * Duration(loan)
                           * UnusedRiskFactor(loan.RiskRating);
            }

            return 0.0;
        }

        public double Duration(Loan loan)
        {
            if (loan.Expiry == null && loan.Maturity != null) return WeightedAverageDuration(loan);
            else if (loan.Expiry != null && loan.Maturity == null) return YearsTo(loan.Expiry.Value);
            return 0.0;
        }

        protected double RiskFactor(double riskRating)
        {
            return refactored.RiskFactor.GetFactors().ForRating(riskRating);
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

        private double YearsTo(DateTime endDate)
        {
            var beginDate = DateTime.Now;
            return ((endDate - beginDate).Milliseconds / MillisPerDay) / DaysPerYear;
        }

        private double UnusedRiskFactor(double riskRating)
        {
            return refactored.UnusedRiskFactor.GetFactors().ForRating(riskRating);
        }
    }
}

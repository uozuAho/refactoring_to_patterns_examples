using System;

namespace replace_conditional_with_strategy.refactored
{
    public abstract class CapitalStrategy
    {
        private const int MillisPerDay = 3600 * 24 * 1000;
        private const int DaysPerYear = 360;

        public abstract double Capital(Loan loan);

        public virtual double Duration(Loan loan)
        {
            return YearsTo(loan.Expiry.Value);
        }

        protected double RiskFactor(double riskRating)
        {
            return refactored.RiskFactor.GetFactors().ForRating(riskRating);
        }

        protected double UnusedRiskFactor(double riskRating)
        {
            return refactored.UnusedRiskFactor.GetFactors().ForRating(riskRating);
        }

        protected double YearsTo(DateTime endDate)
        {
            var beginDate = DateTime.Now;
            return ((endDate - beginDate).Milliseconds / MillisPerDay) / DaysPerYear;
        }
    }
}

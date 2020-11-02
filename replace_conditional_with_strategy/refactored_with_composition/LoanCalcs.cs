using System;

namespace replace_conditional_with_strategy.refactored_with_composition
{
    public class LoanCalcs
    {
        private const int MillisPerDay = 3600 * 24 * 1000;
        private const int DaysPerYear = 360;

        public double YearsTo(DateTime endDate)
        {
            var beginDate = DateTime.Now;
            return ((endDate - beginDate).Milliseconds / MillisPerDay) / DaysPerYear;
        }

        public double RiskFactor(double riskRating)
        {
            return refactored.RiskFactor.GetFactors().ForRating(riskRating);
        }

        public double UnusedRiskFactor(double riskRating)
        {
            return refactored.UnusedRiskFactor.GetFactors().ForRating(riskRating);
        }
    }
}

using System;
using System.Collections.Generic;

namespace replace_conditional_with_strategy.refactored
{
    public class Loan
    {
        public DateTime? Expiry;
        public DateTime? Maturity;
        public double Commitment;
        public double RiskRating;

        private const int MillisPerDay = 3600 * 24 * 1000;
        private const int DaysPerYear = 360;

        private double _outstanding;
        private List<Payment> _payments;

        public double Capital()
        {
            return new CapitalStrategy().Capital(this);
        }

        public double GetUnusedPercentage()
        {
            return 23;
        }

        public double OutstandingRiskAmount()
        {
            return _outstanding;
        }

        public double UnusedRiskAmount()
        {
            return (Commitment - _outstanding);
        }

        public double Duration()
        {
            if (Expiry == null && Maturity != null) return WeightedAverageDuration();
            else if (Expiry != null && Maturity == null) return YearsTo(Expiry.Value);
            return 0.0;
        }

        private double WeightedAverageDuration()
        {
            var duration = 0.0;
            var weightedAverage = 0.0;
            var sumOfPayments = 0.0;
            foreach (var payment in _payments)
            {
                sumOfPayments += payment.Amount();
                weightedAverage += YearsTo(payment.Date()) * payment.Amount();
            }

            if (Commitment != 0.0) duration = weightedAverage / sumOfPayments;
            return duration;
        }

        private double YearsTo(DateTime endDate)
        {
            var beginDate = DateTime.Now;
            return ((endDate - beginDate).Milliseconds / MillisPerDay) / DaysPerYear;
        }
    }
}

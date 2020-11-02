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
        public List<Payment> Payments;

        private double _outstanding;

        public double Capital()
        {
            return new CapitalStrategy().Capital(this);
        }

        public double Duration(Loan loan)
        {
            return new CapitalStrategy().Duration(this);
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
            return Commitment - _outstanding;
        }
    }
}

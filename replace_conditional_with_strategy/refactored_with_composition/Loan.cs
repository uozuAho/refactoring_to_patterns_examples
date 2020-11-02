using System;
using System.Collections.Generic;

namespace replace_conditional_with_strategy.refactored_with_composition
{
    public class Loan
    {
        public double Commitment;
        public List<Payment> Payments;

        private const int MillisPerDay = 3600 * 24 * 1000;
        private const int DaysPerYear = 360;

        private DateTime? _expiry;
        private DateTime? _maturity;
        private double _outstanding;
        private double _riskRating;
        private readonly ICapitalStrategy _capitalStrategy;

        private Loan(
            double commitment,
            DateTime? maturity,
            double riskRating,
            ICapitalStrategy capitalStrategy)
        {
            Commitment = commitment;
            _maturity = maturity;
            _riskRating = riskRating;
            _capitalStrategy = capitalStrategy;
        }

        public static Loan NewTermLoan(double commitment, DateTime maturity, double riskRating)
        {
            return new Loan(commitment, maturity, riskRating, new CapitalStrategyTermLoan());
        }

        public static Loan NewRevolver(double commitment, DateTime maturity, double riskRating)
        {
            return new Loan(commitment, maturity, riskRating, new CapitalStrategyRevolver());
        }

        public static Loan NewAdvisedLine(double commitment, DateTime? maturity, double riskRating)
        {
            return new Loan(commitment, maturity, riskRating, new CapitalStrategyAdvisedLine());
        }

        public double Capital()
        {
            return _capitalStrategy.Capital(this);
        }

        public double Duration()
        {
            if (_expiry == null && _maturity != null)
                return new DurationStrategyTermLoan().Duration(this);
            else if (_expiry != null && _maturity == null)
                return YearsTo(_expiry.Value);
            return 0.0;
        }

        public double RiskFactor()
        {
            return initial_state.RiskFactor.GetFactors().ForRating(_riskRating);
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

        public double YearsTo(DateTime endDate)
        {
            var beginDate = DateTime.Now;
            return ((endDate - beginDate).Milliseconds / MillisPerDay) / DaysPerYear;
        }

        public double UnusedRiskFactor()
        {
            return initial_state.UnusedRiskFactor.GetFactors().ForRating(_riskRating);
        }
    }
}

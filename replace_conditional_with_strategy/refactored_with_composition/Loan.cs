using System;
using System.Collections.Generic;

namespace replace_conditional_with_strategy.refactored_with_composition
{
    public class Loan
    {
        public double Commitment;
        public DateTime? Expiry;
        public List<Payment> Payments;

        private const int MillisPerDay = 3600 * 24 * 1000;
        private const int DaysPerYear = 360;

        private DateTime? _maturity;
        private double _outstanding;
        private double _riskRating;
        private readonly ICapitalStrategy _capitalStrategy;
        private readonly IDurationStrategy _durationStrategy;

        private Loan(double commitment,
            DateTime? maturity,
            double riskRating,
            ICapitalStrategy capitalStrategy,
            IDurationStrategy durationStrategy)
        {
            Commitment = commitment;
            _maturity = maturity;
            _riskRating = riskRating;
            _capitalStrategy = capitalStrategy;
            _durationStrategy = durationStrategy;
        }

        public static Loan NewTermLoan(double commitment, DateTime maturity, double riskRating)
        {
            return new Loan(
                commitment,
                maturity,
                riskRating,
                new CapitalStrategyTermLoan(),
                new DurationStrategyTermLoan()
            );
        }

        public static Loan NewRevolver(double commitment, DateTime maturity, double riskRating)
        {
            return new Loan(
                commitment,
                maturity,
                riskRating,
                new CapitalStrategyRevolver(),
                new DurationStrategyDefault()
            );
        }

        public static Loan NewAdvisedLine(double commitment, DateTime? maturity, double riskRating)
        {
            return new Loan(
                commitment,
                maturity,
                riskRating,
                new CapitalStrategyAdvisedLine(),
                new DurationStrategyDefault()
            );
        }

        public double Capital()
        {
            return _capitalStrategy.Capital(this);
        }

        public double Duration()
        {
            return _durationStrategy.Duration(this);
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

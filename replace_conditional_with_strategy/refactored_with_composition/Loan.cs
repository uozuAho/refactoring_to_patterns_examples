using System;
using System.Collections.Generic;

namespace replace_conditional_with_strategy.refactored_with_composition
{
    public class Loan
    {
        private DateTime? _expiry;
        private DateTime? _maturity;
        private double _commitment;
        private double _outstanding;
        private List<Payment> _payments;
        private const int MillisPerDay = 3600 * 24 * 1000;
        private const int DaysPerYear = 360;
        private double _riskRating;

        private Loan(double commitment, DateTime? maturity, double riskRating)
        {
            _commitment = commitment;
            _maturity = maturity;
            _riskRating = riskRating;
        }

        public static Loan NewTermLoan(double commitment, DateTime maturity, double riskRating)
        {
            return new Loan(commitment, maturity, riskRating);
        }

        public static Loan NewRevolver(double commitment, DateTime maturity, double riskRating)
        {
            return new Loan(commitment, maturity, riskRating);
        }

        public static Loan NewAdvisedLine(double commitment, DateTime? maturity, double riskRating)
        {
            return new Loan(commitment, maturity, riskRating);
        }

        public double Capital()
        {
            if (_expiry == null && _maturity != null)
                return _commitment * Duration() * RiskFactor();
            if (_expiry != null && _maturity == null)
            {
                if (GetUnusedPercentage() != 1.0)
                    return _commitment * GetUnusedPercentage() * Duration() * RiskFactor();
                else
                    return (OutstandingRiskAmount() * Duration() * RiskFactor())
                           + (UnusedRiskAmount() * Duration() * UnusedRiskFactor());
            }

            return 0.0;
        }

        private double GetUnusedPercentage()
        {
            return 23;
        }

        private double OutstandingRiskAmount()
        {
            return _outstanding;
        }

        private double UnusedRiskAmount()
        {
            return (_commitment - _outstanding);
        }

        public double Duration()
        {
            if (_expiry == null && _maturity != null) return WeightedAverageDuration();
            else if (_expiry != null && _maturity == null) return YearsTo(_expiry.Value);
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

            if (_commitment != 0.0) duration = weightedAverage / sumOfPayments;
            return duration;
        }

        private double YearsTo(DateTime endDate)
        {
            var beginDate = DateTime.Now;
            return ((endDate - beginDate).Milliseconds / MillisPerDay) / DaysPerYear;
        }

        private double RiskFactor()
        {
            return initial_state.RiskFactor.GetFactors().ForRating(_riskRating);
        }

        private double UnusedRiskFactor()
        {
            return initial_state.UnusedRiskFactor.GetFactors().ForRating(_riskRating);
        }
    }
}

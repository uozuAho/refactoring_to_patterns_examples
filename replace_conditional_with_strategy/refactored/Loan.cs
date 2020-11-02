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

        private double _outstanding = 0.0;
        private readonly CapitalStrategy _capitalStrategy;

        private Loan(
            double commitment,
            DateTime? maturity,
            double riskRating,
            CapitalStrategy capitalStrategy)
        {
            Commitment = commitment;
            Maturity = maturity;
            RiskRating = riskRating;
            _capitalStrategy = capitalStrategy;
        }

        public static Loan NewTermLoan(double commitment, DateTime maturity, double riskRating)
        {
            return new Loan(commitment, maturity, riskRating, new CapitalStrategyTermLoan());
        }

        public static Loan NewRevolver(double commitment, DateTime maturity, double riskRating)
        {
            return new Loan(commitment, maturity, riskRating, new CapitalStrategy());
        }

        public static Loan NewAdvisedLine(double commitment, DateTime? maturity, double riskRating)
        {
            return new Loan(commitment, maturity, riskRating, new CapitalStrategy());
        }

        public double Capital()
        {
            return _capitalStrategy.Capital(this);
        }

        public double Duration(Loan loan)
        {
            return _capitalStrategy.Duration(this);
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

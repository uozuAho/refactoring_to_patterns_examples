using System;
using replace_conditional_with_strategy.initial_state;
using Xunit;

namespace replace_conditional_with_strategy.test.initial_state
{
    public class LoanTests
    {
        [Fact]
        public void TermLoan()
        {
            var commitment = 100;
            var riskRating = 10;
            var maturity = DateTime.Today.AddDays(7);
            var loan = Loan.NewTermLoan(commitment, maturity, riskRating);
            //return loan.Commitment * Duration(loan) * RiskFactor(loan.RiskRating);
            Assert.Equal(1, loan.Capital());
        }
    }
}

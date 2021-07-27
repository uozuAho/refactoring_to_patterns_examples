using System;
using replace_conditional_with_strategy.initial_state;
using Xunit;

namespace replace_conditional_with_strategy.test.initial_state
{
    public class LoanTests
    {
        [Fact]
        public void TermLoan_WithNoPayments_Capital_isNan()
        {
            var commitment = 100;
            var riskRating = 10;
            var maturity = DateTime.Today.AddDays(7);
            var loan = Loan.NewTermLoan(commitment, maturity, riskRating);

            Assert.Equal(double.NaN, loan.Capital());
        }

        [Fact]
        public void TermLoan_WithNoPayments_Capital_isZero()
        {
            var commitment = 100;
            var riskRating = 10;
            var maturity = DateTime.Today.AddDays(7);
            var loan = Loan.NewTermLoan(commitment, maturity, riskRating);
            loan.AddPayment(10);

            Assert.Equal(0, loan.Capital());
        }
    }
}

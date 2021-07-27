using System;
using replace_conditional_with_strategy.initial_state;
using Xunit;

namespace replace_conditional_with_strategy.test.initial_state
{
    public class TermLoan_Capital
    {
        const int AssertToDecimalPlaces = 2;

        [Fact]
        public void With_no_payments_is_NaN()
        {
            var commitment = 100;
            var riskRating = 10;
            var maturity = DateTime.Today.AddDays(7);
            var loan = Loan.NewTermLoan(commitment, maturity, riskRating);

            // warning: I have no idea what loan capital is
            Assert.Equal(double.NaN, loan.Capital());
        }

        [Fact]
        public void With_one_payment_is_810_14()
        {
            var commitment = 100;
            var riskRating = 10;
            var maturity = DateTime.Today.AddDays(7);
            var loan = Loan.NewTermLoan(commitment, maturity, riskRating);
            loan.AddPayment(10, DateTime.Today.AddYears(2));

            Assert.Equal(810.14, loan.Capital(), AssertToDecimalPlaces);
        }
    }

    public class TermLoan_Duration
    {
        [Fact]
        public void With_one_payment_in_two_years_is_2()
        {
            var commitment = 100;
            var riskRating = 10;
            var maturity = DateTime.Today.AddDays(7);
            var loan = Loan.NewTermLoan(commitment, maturity, riskRating);
            loan.AddPayment(10, DateTime.Today.AddYears(2));

            // warning: I have no idea what loan duration is
            Assert.Equal(2, loan.Duration(), 0);
        }
    }
}

using System;
using replace_conditional_with_strategy.initial_state;
using Xunit;

namespace replace_conditional_with_strategy.test.initial_state
{
    public class RevolverLoan_Capital
    {
        const int AssertToDecimalPlaces = 0;

        [Fact]
        public void With_no_payments_is_NaN()
        {
            var currentDate = DateTime.Today;
            var commitment = 100;
            var riskRating = 10;
            var maturity = currentDate.AddDays(7);
            var loan = Loan.NewRevolver(commitment, maturity, riskRating);

            Assert.Equal(double.NaN, loan.Capital());
        }

        [Fact]
        public void With_one_payment_is_810_14()
        {
            var currentDate = DateTime.Today;
            var commitment = 100;
            var riskRating = 10;
            var maturity = currentDate.AddDays(7);
            var loan = Loan.NewTermLoan(commitment, maturity, riskRating);
            loan.AddPayment(10, currentDate.AddYears(2));

            Assert.Equal(810.14, loan.Capital(), AssertToDecimalPlaces);
        }
    }

    public class RevolverLoan_Duration
    {
        const int AssertToDecimalPlaces = 0;

        [Fact]
        public void With_one_payment_in_two_years_is_2()
        {
            var currentDate = DateTime.Today;
            var commitment = 100;
            var riskRating = 10;
            var maturity = currentDate.AddDays(7);
            var loan = Loan.NewTermLoan(commitment, maturity, riskRating);
            loan.AddPayment(10, currentDate.AddYears(2));

            // warning: I have no idea what loan duration is
            Assert.Equal(2, loan.Duration(), AssertToDecimalPlaces);
        }

        [Fact]
        public void With_one_payment_in_three_years_is_3()
        {
            var currentDate = DateTime.Today;
            var commitment = 100;
            var riskRating = 10;
            var maturity = currentDate.AddDays(7);
            var loan = Loan.NewTermLoan(commitment, maturity, riskRating);
            loan.AddPayment(10, currentDate.AddYears(3));

            // warning: I have no idea what loan duration is
            Assert.Equal(3, loan.Duration(), AssertToDecimalPlaces);
        }
    }
}

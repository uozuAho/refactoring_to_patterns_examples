using System;
using replace_conditional_with_strategy.initial_state;
using Xunit;

namespace replace_conditional_with_strategy.test.initial_state
{
    public class RevolverLoan_Capital
    {
        const int AssertToDecimalPlaces = 0;

        [Fact]
        public void With_1_year_expiry_is_9312()
        {
            var currentDate = DateTime.Today;
            var commitment = 100;
            var riskRating = 10;
            var expiry = currentDate.AddYears(1);
            var loan = Loan.NewRevolver(commitment, expiry, riskRating);

            Assert.Equal(9312, loan.Capital(), AssertToDecimalPlaces);
        }

        [Fact]
        public void With_one_payment_is_still_9312()
        {
            var currentDate = DateTime.Today;
            var commitment = 100;
            var riskRating = 10;
            var expiry = currentDate.AddYears(1);
            var loan = Loan.NewRevolver(commitment, expiry, riskRating);
            loan.AddPayment(10, currentDate.AddYears(2));

            Assert.Equal(9312, loan.Capital(), AssertToDecimalPlaces);
        }
    }

    public class RevolverLoan_Duration
    {
        const int AssertToDecimalPlaces = 0;

        [Fact]
        public void With_1_year_expiry_is_1()
        {
            var currentDate = DateTime.Today;
            var commitment = 100;
            var riskRating = 10;
            var expiry = currentDate.AddYears(1);
            var loan = Loan.NewRevolver(commitment, expiry, riskRating);

            // warning: I have no idea what loan duration is
            Assert.Equal(1, loan.Duration(), AssertToDecimalPlaces);
        }

        [Fact]
        public void Is_not_affected_by_payments()
        {
            var currentDate = DateTime.Today;
            var commitment = 100;
            var riskRating = 10;
            var expiry = currentDate.AddYears(1);
            var loan = Loan.NewRevolver(commitment, expiry, riskRating);
            loan.AddPayment(10, currentDate.AddYears(1));
            loan.AddPayment(10, currentDate.AddYears(2));
            loan.AddPayment(10, currentDate.AddYears(3));

            // warning: I have no idea what loan duration is
            Assert.Equal(1, loan.Duration(), AssertToDecimalPlaces);
        }
    }
}

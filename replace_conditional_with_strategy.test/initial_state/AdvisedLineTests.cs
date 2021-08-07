using System;
using replace_conditional_with_strategy.initial_state;
using Xunit;

namespace replace_conditional_with_strategy.test.initial_state
{
    public class AdvisedLine_Capital
    {
        const int AssertToDecimalPlaces = 0;

        [Fact]
        public void With_no_payments_and_expiry_in_1_year_is_9312()
        {
            var currentDate = DateTime.Today;
            var commitment = 100;
            var riskRating = 10;
            var expiry = currentDate.AddYears(1);
            var loan = Loan.NewAdvisedLine(commitment, expiry, riskRating);

            Assert.Equal(9312, loan.Capital(), AssertToDecimalPlaces);
        }

        [Fact]
        public void With_one_payment_of_1000_is_9312()
        {
            var currentDate = DateTime.Today;
            var commitment = 100;
            var riskRating = 10;
            var expiry = currentDate.AddYears(1);
            var loan = Loan.NewAdvisedLine(commitment, expiry, riskRating);
            loan.AddPayment(1000, currentDate.AddYears(2));

            Assert.Equal(9312, loan.Capital(), AssertToDecimalPlaces);
        }
    }

    public class AdvisedLine_Duration
    {
        const int AssertToDecimalPlaces = 0;

        [Fact]
        public void With_1_year_expiry_is_1()
        {
            var currentDate = DateTime.Today;
            var commitment = 100;
            var riskRating = 10;
            var expiry = currentDate.AddYears(1);
            var loan = Loan.NewAdvisedLine(commitment, expiry, riskRating);

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
            var loan = Loan.NewAdvisedLine(commitment, expiry, riskRating);
            loan.AddPayment(10, currentDate.AddYears(1));
            loan.AddPayment(10, currentDate.AddYears(2));
            loan.AddPayment(10, currentDate.AddYears(3));

            // warning: I have no idea what loan duration is
            Assert.Equal(1, loan.Duration(), AssertToDecimalPlaces);
        }
    }
}

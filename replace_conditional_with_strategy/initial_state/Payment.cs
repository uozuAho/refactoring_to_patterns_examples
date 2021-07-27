using System;

namespace replace_conditional_with_strategy.initial_state
{
    internal class Payment
    {
        private readonly double _amount;
        private readonly DateTime _date;

        public Payment(double amount, DateTime date)
        {
            _amount = amount;
            _date = date;
        }

        public double Amount()
        {
            return _amount;
        }

        public DateTime Date()
        {
            return _date;
        }
    }
}

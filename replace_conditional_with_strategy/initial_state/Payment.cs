using System;

namespace replace_conditional_with_strategy.initial_state
{
    internal class Payment
    {
        private readonly double _amount;

        public Payment(double amount)
        {
            _amount = amount;
        }

        public double Amount()
        {
            return _amount;
        }

        public DateTime Date()
        {
            return DateTime.Now;
        }
    }
}

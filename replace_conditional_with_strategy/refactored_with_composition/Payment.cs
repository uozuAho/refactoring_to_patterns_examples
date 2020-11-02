using System;

namespace replace_conditional_with_strategy.refactored_with_composition
{
    internal class Payment
    {
        public double Amount()
        {
            return 0.0;
        }

        public DateTime Date()
        {
            return DateTime.Now;
        }
    }
}

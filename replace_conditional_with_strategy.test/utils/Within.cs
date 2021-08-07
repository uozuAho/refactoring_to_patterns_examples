using System;
using System.Collections.Generic;

namespace replace_conditional_with_strategy.test.utils
{
    public class Within : IEqualityComparer<double>
    {
        private readonly double _limit;

        public Within(double limit)
        {
            _limit = limit;
        }

        public bool Equals(double x, double y)
        {
            return Math.Abs(x - y) <= _limit;
        }

        public int GetHashCode(double obj)
        {
            return obj.GetHashCode();
        }
    }
}

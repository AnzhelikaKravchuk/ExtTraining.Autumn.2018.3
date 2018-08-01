using No3.Solution;
using System;
using System.Collections.Generic;

namespace No3
{
    public class Calculator
    {
        public double CalculateAverage(IEnumerable<double> values, Func<IEnumerable<double>, double> averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (averagingMethod == null)
            {
                throw new ArgumentNullException(nameof(averagingMethod));
            }

            return CalculateAverage(values, new Nested(averagingMethod));
        }

        public double CalculateAverage(IEnumerable<double> values, IAvarageCalculateStrategy averagingMethod)
        {
            if (values == null)
            {
                throw  new ArgumentNullException(nameof(values));
            }

            if (averagingMethod == null)
            {
                throw new ArgumentNullException(nameof(averagingMethod));
            }

            return averagingMethod.Calculate(values);
        }

        private class Nested : IAvarageCalculateStrategy
        {
            private readonly Func<IEnumerable<double>, double> _callBack;

            public Nested(Func<IEnumerable<double>, double> callBack)
            {
                _callBack = callBack ?? throw new ArgumentNullException(nameof(callBack));
            }

            public double Calculate(IEnumerable<double> values)
            {
                return _callBack(values);
            }
        }
    }
}

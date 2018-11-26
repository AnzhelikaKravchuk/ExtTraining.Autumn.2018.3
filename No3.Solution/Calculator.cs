using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, IAveragingMethod averagingMethod)
        {
            if (values == null)
            {
                throw  new ArgumentNullException(nameof(values));
            }

            if (averagingMethod == null)
            {
                throw  new ArgumentNullException(nameof(averagingMethod));
            }

            return averagingMethod.Calculate(values);
        }

        public double CalculateAverage(List<double> values, Func<List<double>,double> method)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (method == null)
            {
                throw new ArgumentNullException(nameof(method));
            }

            return method(values);
        }
    }
}

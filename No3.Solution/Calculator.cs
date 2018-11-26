using System;
using System.Collections.Generic;

namespace No3.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, IAverageCalculator averageCalculator)
        {
            if (values == null)
            {
                throw  new ArgumentNullException(nameof(values));
            }

            if (averageCalculator == null)
            {
                throw new ArgumentNullException(nameof(averageCalculator));
            }

            return averageCalculator.Average(values);
        }

        public double CalculateAverage(List<double> values, Func<IEnumerable<double>, double> averageCalculator)
        {
            if (values == null || averageCalculator == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (averageCalculator == null)
            {
                throw new ArgumentNullException(nameof(averageCalculator));
            }

            return averageCalculator(values);
        }
    }
}

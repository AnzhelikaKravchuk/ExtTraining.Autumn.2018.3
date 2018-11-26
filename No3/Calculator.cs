using System;
using System.Collections.Generic;
using System.Linq;

namespace No3
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, AveragingMethod averagingMethod)
        {
            if (values == null)
            {
                throw  new ArgumentNullException(nameof(values));
            }

            switch (averagingMethod)
            {
                case AveragingMethod.Mean:
                    return values.Sum() / values.Count;

                case AveragingMethod.Median:
                    var sortedValues = values.OrderBy(x => x).ToList();

                    int n = sortedValues.Count;

                    if (n % 2 == 1)
                    {
                        return sortedValues[(n - 1) / 2];
                    }

                    return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;

                default:
                    throw new ArgumentException("Invalid averagingMethod value");
            }
        }
    }
}

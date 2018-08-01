using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution.Tests.FirstMethod
{
    public class Median : IAveragingMethod
    {
        public double FindAverage(ICollection<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (values.Count == 0)
            {
                throw new ArgumentException("Can not calculate mean of empty collection.");
            }
            
            var sortedValues = values.OrderBy(x => x).ToList();

            int n = sortedValues.Count;

            if (n % 2 == 1)
            {
                return sortedValues[(n - 1) / 2];
            }

            return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.Tests
{
    class FindAverageMedianMethod : IAverage
    {
        public double GetAverage(List<double> values)
        {
            if(values == null)
            {
                throw new ArgumentNullException();
            }

            if(values.Count == 0)
            {
                throw new ArgumentException();
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

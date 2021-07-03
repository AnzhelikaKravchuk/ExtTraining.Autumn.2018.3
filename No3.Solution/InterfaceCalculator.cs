using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public class InterfaceCalculator : ICountAverage
    {
        public double MethodMean(List<double> values) => ICount(FindMean, values);

        public double MethodMedian(List<double> values) => ICount(FindMedian, values);

        public double ICount(Delegate.FindAverage average, List<double> values)
        {
            return average(values);
        }

        private static double FindMean(List<double> values)
        {
            return values.Sum() / values.Count;
        }

        private static double FindMedian(List<double> values)
        {
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

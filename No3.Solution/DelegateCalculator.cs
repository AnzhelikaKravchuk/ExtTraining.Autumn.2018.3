using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public static class DelegateCalculator
    {
        public static double MethodMean(List<double> values) => CountAverage(FindMean,values);

        public static double MethodMedian(List<double> values) => CountAverage(FindMedian, values);

        #region Private
        private static double CountAverage(Delegate.FindAverage average, List<double> values)
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
        #endregion
    }
}

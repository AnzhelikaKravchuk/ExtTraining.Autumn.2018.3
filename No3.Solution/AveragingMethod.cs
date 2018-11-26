using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public static class AveragingMethod
    {
        public static double Mean(IEnumerable<double> values)
        {
            var array = values as double[] ?? values.ToArray();

            return array.Sum() / array.Length;
        }

        public static double Median(IEnumerable<double> values)
        {
            var sortedValues = values.OrderBy(x => x).ToArray();
            int n = sortedValues.Length;
            if (n % 2 == 1)
            {
                return sortedValues[(n - 1) / 2];
            }

            return (sortedValues[sortedValues.Length / 2 - 1] + sortedValues[n / 2]) / 2;
        }
    }
}
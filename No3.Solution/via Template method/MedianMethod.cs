using System.Collections.Generic;
using System.Linq;

namespace No3.Solution.via_Template_method
{
    public class MedianMethod : AverageAlgorithm
    {
        public override double Calculate(double[] values)
        {
            List<double> sortedValues = values.OrderBy(x => x).ToList();

            int n = sortedValues.Count;

            if (n % 2 == 1)
            {
                return sortedValues[(n - 1) / 2];
            }

            return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
        }
    }
}

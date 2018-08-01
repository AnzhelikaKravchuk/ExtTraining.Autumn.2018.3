using System.Collections.Generic;
using System.Linq;
using No3.Solution.SecondMethod;

namespace No3.Solution.Tests.SecondMethod
{
    public class Median : AbstractAveragingMethod
    {
        public override double FindAverage(ICollection<double> values)
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
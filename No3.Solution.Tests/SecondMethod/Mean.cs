using System.Collections.Generic;
using System.Linq;
using No3.Solution.SecondMethod;

namespace No3.Solution.Tests.SecondMethod
{
    public class Mean : AbstractAveragingMethod
    {
        public override double FindAverage(ICollection<double> values) => values.Sum() / values.Count;
    }
}
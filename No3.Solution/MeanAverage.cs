using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public class MeanAverage : IAverage
    {
        public double Average(IEnumerable<double> numbers)
        {
            List<double> values = new List<double>();
            values.AddRange(numbers);
            return values.Sum() / values.Count;
        }
    }
}

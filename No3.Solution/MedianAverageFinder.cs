using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public class MedianAlgorithmSolver : IComputer
    {
        public double Find(IEnumerable<double> values)
        {
            var sorted = values.OrderBy(x => x).ToList();

            int n = sorted.Count;

            if (n % 2 == 1)
            {
                return sorted[(n - 1) / 2];
            }

            return (sorted[sorted.Count / 2 - 1] + sorted[n / 2]) / 2;
        }
    }
}

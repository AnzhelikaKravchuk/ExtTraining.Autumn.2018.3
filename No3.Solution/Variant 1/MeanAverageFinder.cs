using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.Variant_1
{
    public class MeanAlgorithmSolver : IAlgorithmSolver
    {
        public double Find(IEnumerable<double> values)
        {
            return values.Sum() / values.Count();
        }
    }
}

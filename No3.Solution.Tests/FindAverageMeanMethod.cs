using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution.Tests
{
    class FindAverageMeanMethod : IAverage
    {
        public double GetAverage(List<double> values)
        {
            if(values == null)
            {
                throw new ArgumentNullException();
            }

            return values.Sum() / values.Count;
        }
    }
}

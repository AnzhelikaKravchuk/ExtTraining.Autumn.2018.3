using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3
{
    public class Mean : IAveragingMethod
    {
        public double Perform(List<double> values)
        {
            return values.Sum() / values.Count;
        }
    }
}

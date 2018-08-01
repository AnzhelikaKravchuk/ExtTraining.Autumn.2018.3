using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public static class CalculateAverageDelegate
    {
        public static double Calculate(List<double> values, Func<List<double>, double> calculate = null)
        {
            if (calculate == null)
            {
                calculate = new Mean().CalculateAverage;
            }

            return calculate(values);
        }
    }
}

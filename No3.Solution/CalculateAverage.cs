using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public static class CalculateAverage
    {
        public static double Calculate(List<double> values, ICalculateAvarage calculate = null)
        {
            if (calculate == null)
            {
                calculate = new Mean();
            }

            return calculate.CalculateAverage(values);
        }
    }
}

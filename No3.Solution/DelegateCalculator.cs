using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public static class DelegateCalculator
    {
        public static double Calculate(this IEnumerable<double> agregate, Func<List<double>, double> Delegate)
        {
            if (Delegate == null)
            {
                throw new ArgumentNullException();
            }

            return Delegate(agregate.ToList());
        }
    }
}

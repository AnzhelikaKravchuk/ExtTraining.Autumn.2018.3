using System;
using System.Collections.Generic;
using System.Linq;

namespace No3
{
    public static class Calculator
    {
        public static double Calculate(List<double> values, IAveragingMethod method)
        {
            return method.Perform(values);
        }
        public static double Calculate(this IEnumerable<double> agregate, Func<List<double>, double> func)
        {
            if (func == null)
            {
                throw new ArgumentNullException();
            }

            return func(agregate.ToList());
        }
        private static void Validate(List<double> values, IAveragingMethod method)
        {
            if (values == null)
            {
                throw new ArgumentNullException();
            }

            if (method == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}

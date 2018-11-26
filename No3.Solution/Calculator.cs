using System;
using System.Collections.Generic;

namespace No3.Solution
{
    public static class Calculator
    {
        public static double CalculateAverage(IEnumerable<double> values, IAveragingCalculator<double> calculator)
        {
            if (values == null) throw  new ArgumentNullException(nameof(values));
            if (calculator == null) throw new ArgumentNullException(nameof(calculator));

            return CalculateAverage(values, calculator.Calculate);
        }

        public static double CalculateAverage(IEnumerable<double> values, Func<IEnumerable<double>, double> calculator)
        {
            if (values == null) throw new ArgumentNullException(nameof(values));
            if (calculator == null) throw new ArgumentNullException(nameof(calculator));

            return calculator(values);
        }
    }
}

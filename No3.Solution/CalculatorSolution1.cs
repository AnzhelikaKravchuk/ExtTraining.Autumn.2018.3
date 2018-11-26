using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public class CalculatorSolution1
    {
        public double CalculateAverage(List<double> values, IAverageCaculator calculator)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (calculator == null)
            {
                throw new ArgumentNullException(nameof(calculator));
            }

            return calculator.Calculate(values);         
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace No3
{
    public class CalculatorSolution2
    {
        public delegate double Calculation(List<double> values);

        public double CalculateAverage(List<double> values, Calculation calculation)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            if (calculation == null)
            {
                throw new ArgumentNullException(nameof(calculation));
            }

            return calculation(values);
        }
    }
}

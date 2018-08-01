using System;
using System.Collections.Generic;

namespace No3.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, ICalculate average)
        {
            ValidateParameters(values, average);

            return average.CalculateAverage(values);
        }

        private void ValidateParameters(List<double> values, ICalculate average)
        {
            if (values == null)
            {
                throw new ArgumentNullException(
                    $"Parameter {nameof(values)} can't be null");
            }

            if (average == null)
            {
                throw new ArgumentNullException(
                    $"Parameter {nameof(average)} can't be null");
            }
        }
    }
}

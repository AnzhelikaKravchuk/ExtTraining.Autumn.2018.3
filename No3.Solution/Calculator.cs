using System;
using System.Collections.Generic;

namespace No3.Solution
{
    public class Calculator
    {
        private readonly IAlgorithm _algorithm;

        public Calculator(IAlgorithm algorithm)
        {
            _algorithm = algorithm;
        }

        public double CalculateAverage(IList<double> values)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            return _algorithm.Calculate(values);
        }
    }
}

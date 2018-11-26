using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public class Calculator
    {
        private readonly IAverageAlgorithm algorithm;
        public Calculator(IAverageAlgorithm averageAlgorithm)
        {
            algorithm = averageAlgorithm;
        }

        public double CalculateAverage(List<double> values)
        {
            if (values == null)
            {
                throw  new ArgumentNullException(nameof(values));
            }

            return algorithm.Calculate(values);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public class Calculator
    {
        ICalculate averagingMethod = null;

        public Calculator(ICalculate averagingMethod)
        {
            this.averagingMethod = averagingMethod ?? throw new ArgumentNullException(nameof(averagingMethod));
        }

        public double CalculateAverage(List<double> values)
        {
            if (values == null)
            {
                throw  new ArgumentNullException(nameof(values));
            }

            return averagingMethod.Calculate(values);
            
        }
    }
}

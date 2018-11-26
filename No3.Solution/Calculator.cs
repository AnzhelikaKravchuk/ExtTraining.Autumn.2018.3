using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No3.Solution.CalculateMethods;

namespace No3.Solution
{
    public class Calculator
    {
        public double CalculateAverage(IEnumerable<double> values, AveragingMethod averagingMethod)
        {
            if (values == null)
            {
                throw new ArgumentNullException(nameof(values));
            }

            ICalculater<double> methodCalculater = Factory.CreateFactory(averagingMethod);

            return methodCalculater.Calculate(values);

        }
    }
}

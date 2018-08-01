using System;
using System.Collections.Generic;
using System.Linq;

namespace No3
{
    public class Calculator
    {
        public double Calculate(List<double> values, IAveragingMethod method)
        {
            return method.Perform(values);
        }
        private void Validate(List<double> values, IAveragingMethod method)
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

using System;
using System.Collections.Generic;
using System.Linq;

namespace No3.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, IAveraging averagingMethod)
        {
            return CalculateAverage(values, averagingMethod.Calculate);
        }

        public double CalculateAverage(List<double> values, Func<List<double>,double> averagingMethod)
        {
            if (values == null)
            {
                throw  new ArgumentNullException(nameof(values));
            }

            return averagingMethod.Invoke(values);
            }
        }
    }


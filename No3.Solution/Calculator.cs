using System;
using System.Collections.Generic;

namespace No3.Solution
{
    public class Calculator
    {
        public double CalculateAverage(List<double> values, CalculateAvarage calcAvarage)
        {          
            CheckNull(values);
            CheckNull(calcAvarage);
            return calcAvarage.GetAvarage(values);
        }

        public double CalculateAverage(List<double> values, IAvarageCalculator calcAvarage)
        {
            CheckNull(values);
            CheckNull(calcAvarage);
            return calcAvarage.GetAvarage(values);
        }

        private void CheckNull(object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public class Calculator
    {
        private ICalculate<double> calc;

        public Calculator(ICalculate<double> calc)
        {
            this.calc = calc;
        }

        public double AveragingCalculation(List<double> values)
        {
            if (values.Equals(null))
            {
                throw new ArgumentNullException();
            }

            return calc.Calculate(values);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No3.Solution
{
    public class MeanCalculation : ICalculate<double>
    {
        public double Calculate(List<double> values)
        {
            return values.Sum() / values.Count();
        }
    }
}

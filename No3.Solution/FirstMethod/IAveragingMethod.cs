using System;
using System.Collections.Generic;

namespace No3.Solution
{
    public interface IAveragingMethod
    {
        double FindAverage(ICollection<double> values);
    }
}
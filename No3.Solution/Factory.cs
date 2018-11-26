using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No3.Solution.CalculateMethods;

namespace No3.Solution
{
    public static class Factory
    {
        public static ICalculater<double> CreateFactory(AveragingMethod method)
        {
            switch (method)
            {
                case AveragingMethod.Mean:
                    return new MeanCalculater();
                case AveragingMethod.Median:
                    return new MedianCalculater();
                default:
                    throw new ArgumentException("Invalid averagingMethod value");
            }
        } 
    }
}

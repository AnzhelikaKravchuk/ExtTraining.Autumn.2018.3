using System.Collections.Generic;

namespace No3.Solution.State_Pattern
{
    public class Calculator
    {
        public Calculator(IAveragingMethod averagingMethod = null)
        {
            if (averagingMethod == null)
            {
                averagingMethod = new MeanMethod();
            }

            this.AveragingMethod = averagingMethod;
        }

        public IAveragingMethod AveragingMethod { get; set; }

        public double CalculateAverage(List<double> values)
        {
            return this.AveragingMethod.Calculate(values);
        }
    }
}

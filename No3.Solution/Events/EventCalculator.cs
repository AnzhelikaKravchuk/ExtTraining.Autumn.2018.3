using System;
using System.Collections.Generic;

namespace No3.Solution.Events
{
    public class EventCalculator
    {
        public event EventHandler<DoubleListEventArgs> AveragingMethod = delegate { };

        public double CalculateAverage(List<double> values)
        {
            var temp = new DoubleListEventArgs(values);

            this.OnState(this, temp);

            return temp.Result;
        }

        protected virtual void OnState(object sender, DoubleListEventArgs e)
        {
            this.AveragingMethod?.Invoke(sender, e);
        }
    }
}
using System;
using System.Collections.Generic;

namespace No3.Solution.Events
{
    public class DoubleListEventArgs : EventArgs
    {
        public DoubleListEventArgs(List<double> values)
        {
            this.Values = values;
        }

        public double Result { get; set; }

        public List<double> Values { get; set; }
    }
}
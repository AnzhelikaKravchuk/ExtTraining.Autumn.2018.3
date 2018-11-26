using System;
using System.Collections.Generic;

namespace No3.Solution.InterfaceSolution
{
    public class DelegateToInterfaceAdapter : IAveragingMethod
    {
        /// <summary>
        /// Delegate which has to be adapted
        /// </summary>
        private Func<List<double>, double> parent;

        public DelegateToInterfaceAdapter(Func<List<double>, double> parent)
        {
            this.parent = parent;
        }

        /// <summary>
        /// Interface method implementation using delegate
        /// </summary>
        /// <param name="values">Values</param>
        /// <returns>Average</returns>
        public double Average(List<double> values)
        {
            return parent(values);
        }
    }
}

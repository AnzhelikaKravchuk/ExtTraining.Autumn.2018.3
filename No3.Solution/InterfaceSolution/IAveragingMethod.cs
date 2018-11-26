using System;
using System.Collections.Generic;

namespace No3.Solution.InterfaceSolution
{
    public interface IAveragingMethod
    {
        /// <summary>
        /// Calculates average for values
        /// </summary>
        /// <param name="values">Values</param>
        /// <returns>Average for value</returns>
        double Average(List<double> values);
    }
}

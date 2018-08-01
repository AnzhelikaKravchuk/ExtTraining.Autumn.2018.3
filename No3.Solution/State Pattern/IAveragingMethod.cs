using System.Collections.Generic;

namespace No3.Solution.State_Pattern
{
    public interface IAveragingMethod
    {
        double Calculate(List<double> values);
    }
}

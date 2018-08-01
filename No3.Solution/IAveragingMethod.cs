using System.Collections.Generic;

namespace No3
{
    public interface IAveragingMethod
    {
        double Perform(List<double> values);
    }
}
using System.Collections.Generic;

namespace No3.Solution
{
    public interface IAverageFunc<T>
    {
        T Avegage(IEnumerable<T> values);
    }
}

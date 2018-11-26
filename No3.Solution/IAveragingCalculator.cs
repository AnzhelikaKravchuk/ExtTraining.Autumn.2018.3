using System.Collections.Generic;

namespace No3.Solution
{
    public interface IAveragingCalculator<T>
    {
        T Calculate(IEnumerable<T> numbers);
    }
}
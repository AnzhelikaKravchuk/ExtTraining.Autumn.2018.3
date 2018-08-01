using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public interface IGenarator<T>
    {
        IEnumerable<T> Generate(int sequenceLength);
    }
}

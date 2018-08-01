using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class NumericGenerator<T>
    {

        public static IEnumerable<T> Generate(IGenarator<T> generator, int sequenceLength)
        {
            return generator.Generate(sequenceLength);
        }

    }
}

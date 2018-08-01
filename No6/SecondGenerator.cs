using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public class SecondGenerator : IGenarator<int>
    {
        // Squence: x(n + 1) = 6 * x(n) - 8 * x(n - 1),
        // Result:  1, 2, 4, 8, 16, 32, 64, 128, 256, 512 

        public IEnumerable<int> Generate(int sequenceLength)
        {
            yield return 1;
            yield return 2;

            int prev = 1;
            int current = 2;
            int next;

            for (int i = 0; i < sequenceLength - 2; i++)
            {
                yield return next = 6 * current - 8 * prev;
                prev = current;
                current = next;
            }

        }
    }
}

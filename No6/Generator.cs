using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class Generator
    {
        public static IEnumerable<T> Generate<T> (Func<T, T, T> function, T previousNumber, T currentNumber, int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                yield return previousNumber;
                T newNumber = function(previousNumber, currentNumber);
                previousNumber = currentNumber;
                currentNumber = newNumber;
            }          
        }
    }
}

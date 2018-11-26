using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public class SequenceGenerator<T> where T : struct
    {
        public T[] Generate(int length, T firstElem, T secondElem, Func<T, T, T> func)
        {
            if(func == null)
            {
                throw new ArgumentNullException();
            }

            if(length < 3)
            {
                throw new ArgumentException();
            }

            T[] sequence = new T[length];
            sequence[0] = firstElem;
            sequence[1] = secondElem;

            for(int i = 2; i < length; i++)
            {
                sequence[i] = func(sequence[i - 2], sequence[i - 1]);
            }

            return sequence;
        }
    }
}

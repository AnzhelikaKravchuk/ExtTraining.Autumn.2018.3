using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class SequenceGenerator
    {
        public static IEnumerable<T> Generate<T>(T firstElement, T secondElement, int count, Func<T, T, T> func)
        {
            T value = func(firstElement, secondElement);

            T oldValue = secondElement;

            while (count > 0)
            {
                yield return value;

                oldValue = value;
                value = func(oldValue, secondElement);
            }
        }
    }
}

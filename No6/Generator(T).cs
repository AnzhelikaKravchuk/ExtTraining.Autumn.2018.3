using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public class Generator<T>
    {
        private Func<T, T, T> generatorFunc;

        public Generator(Func<T, T, T> generatorFunc)
        {
            this.generatorFunc = generatorFunc;
        }

        public IEnumerable<T> Generate(int count, T first, T second)
        {
            T curr = second;
            T prev = first;
            for (int i = 0; i < count; i++)
            {
                switch (i)
                {
                    case 0:
                        yield return prev;
                        break;
                    case 1:
                        yield return curr;
                        break;
                    default:
                        {
                            T temp = generatorFunc(curr, prev);
                            prev = curr;
                            curr = temp;
                            yield return curr;
                            break;
                        }
                }
            }
        }
    }
}

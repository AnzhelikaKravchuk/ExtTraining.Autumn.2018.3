using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public class GenerateNumbers<T>
    {
        private Func<T, T, T> func;
        private int count;

        public GenerateNumbers(int count, Func<T, T, T> func)
        {
            if(func == null)
            {
                throw new ArgumentNullException(nameof(func));
            }
            this.func = func;
            this.count = count;
        }

        public T[] StartGenerate(T firstNumber, T secondNumber)
        {
            T[] array = new T[count];
            array[0] = firstNumber;
            array[1] = secondNumber;

            for(int i = 2; i < count; i++)
            {
                T thirdNumber = func.Invoke(firstNumber, secondNumber);
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
                array[i] = thirdNumber;
            }

            return array;
        }
    }
}

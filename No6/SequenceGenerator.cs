using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace No6
{
    public static class SequenceGenerator
    {


        /// <summary>
        /// static method that generates the next sequance value.
        /// </summary>
        /// <typeparam name="T"> value type. </typeparam>
        /// <param name="array"> array of sequence. </param>
        /// <param name="position"> current position in array. </param>
        /// <param name="generator"> recursive call of this method. </param>
        private static void Generate<T>(T[] array, int position, Func<T, T, T> generator)
        {
            if(position > array.Length - 1) { return;}
            array[position] = generator(array[position - 2], array[position - 1]);
            Generate<T>(array, position + 1, generator);
        }

        /// <summary>
        /// Public method that preparing data for private recursive call.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <param name="size"></param>
        /// <param name="generator"></param>
        /// <returns></returns>
        public static T[] GetGeneration<T>(T first, T second, int size, Func<T,T,T> generator)
        {
            if(generator == null) { throw new ArgumentNullException(nameof(generator)); }

            var sequence = new T[size];
            sequence[0] = first;
            sequence[1] = second;

            Generate(sequence, 2, generator);

            return sequence;
        }

    }
}

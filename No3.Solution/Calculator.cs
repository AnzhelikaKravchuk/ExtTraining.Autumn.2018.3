using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using No3.Solution.Variant_1;

namespace No3.Solution
{
    public static class Calculator
    {
        /// <summary>
        /// Версия с делегатом
        /// </summary>
        /// <param name="values">The values.</param>
        /// <param name="convert">The convert.</param>
        /// <returns></returns>
        public static double CalculateAverage(IEnumerable<double> values,
            Converter<IEnumerable<double>, double> convert)
        {
            ValidateOnNull(convert);
            ConverterAdapter ca = new ConverterAdapter(convert);
            return CalculateAverage(values, ca);
        }

        /// <summary>
        /// Версия с интерфейсом
        /// </summary>
        /// <param name="values">The values.</param>
        /// <param name="finder">The finder.</param>
        /// <returns></returns>
        public static double CalculateAverage(IEnumerable<double> values, IAlgorithmSolver finder)
        {
            ValidateOnNull(values);
            ValidateOnNull(finder);

            return finder.Find(values);
        }

        private static void ValidateOnNull<T>(T obj) where T : class
        {
            if (obj is null)
            {
                throw new ArgumentNullException();
            }
        }

        /// <summary>
        /// Адаптер делегата
        /// </summary>
        /// <seealso cref="No3.Solution.Variant_1.IAlgorithmSolver" />
        private class ConverterAdapter : IAlgorithmSolver
        {
            private readonly Converter<IEnumerable<double>, double> find;

            public ConverterAdapter(Converter<IEnumerable<double>, double> convert)
            {
                this.find = convert;
            }

            public double Find(IEnumerable<double> values)
            {
                return this.find(values);
            }
        }
    }
}

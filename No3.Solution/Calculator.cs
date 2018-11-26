using System;
using System.Collections.Generic;

namespace No3.Solution
{
    public class Calculator
    {
        /// <summary>
        /// Delegate variant
        /// </summary>
        /// <param name="values">values to process.</param>
        /// <param name="convert">method of convertion.</param>
        /// <returns></returns>
        public double CalculateAverage(IEnumerable<double> values,
            Converter<IEnumerable<double>, double> convert)
        {
            CheckParams(convert);
            ConverterAdapter adapter = new ConverterAdapter(convert);
            return CalculateAverage(values, adapter);
        }

        /// <summary>
        /// Interface variant
        /// </summary>
        /// <param name="values">values to process.</param>
        /// <param name="converter">The converter.</param>
        /// <returns></returns>
        public double CalculateAverage(IEnumerable<double> values, IComputer converter)
        {
            CheckParams(values);
            CheckParams(converter);

            return converter.Find(values);
        }

        private void CheckParams<T>(T obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException();
            }
        }

        private class ConverterAdapter : IComputer
        {
            private readonly Converter<IEnumerable<double>, double> converter;

            public ConverterAdapter(Converter<IEnumerable<double>, double> convert)
            {
                this.converter = convert;
            }

            public double Find(IEnumerable<double> values)
            {
                return this.converter(values);
            }
        }
    }
}

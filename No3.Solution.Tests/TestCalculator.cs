using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {
            double expected = 8.3636363;

            double actual = Calculator.CalculateAverage(values, values => values.Sum() / values.Count());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            double expected = 8.0;

            double actual = Calculator.CalculateAverage(values, new AverageCalculator());

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }

    public class AverageCalculator : IAveragingCalculator<double>
    {
        public double Calculate(IEnumerable<double> numbers)
        {
            if (numbers == null) throw new ArgumentNullException(nameof(numbers));

            var sortedValues = numbers.OrderBy(x => x).ToList();

            int n = sortedValues.Count;

            if (n % 2 == 1)
            {
                return sortedValues[(n - 1) / 2];
            }

            return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
        }
    }
}
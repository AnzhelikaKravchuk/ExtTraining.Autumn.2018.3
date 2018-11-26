using System.Collections.Generic;
using NUnit.Framework;
using No3.Solution.Calculators;
using System.Linq;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean_InterfaceMethod()
        {
            Calculator calculator = new Calculator();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, new MeanCalculator());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian_InterfaceMethod()
        {
            Calculator calculator = new Calculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, new MedianCalculator());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMean_DelegateMethod()
        {
            Calculator calculator = new Calculator();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, (values) => values.Sum() / values.Count());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian_DelegateMethod()
        {
            Calculator calculator = new Calculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, (values) =>
            {
                var sortedValues = values.OrderBy(x => x).ToList();

                int n = sortedValues.Count;

                if (n % 2 == 1)
                {
                    return sortedValues[(n - 1) / 2];
                }

                return (sortedValues[sortedValues.Count / 2 - 1] + sortedValues[n / 2]) / 2;
            });

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}
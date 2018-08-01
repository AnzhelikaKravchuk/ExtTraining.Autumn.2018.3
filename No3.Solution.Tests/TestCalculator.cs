using System.Collections.Generic;
using NUnit.Framework;
using No3.Solution;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {
            Calculator calculator = new Calculator();

            double expected = 8.3636363;         

            Assert.AreEqual(expected, calculator.CalculateAverage(values, new AvarageMean()), 0.000001);
            Assert.AreEqual(expected, calculator.CalculateAverage(values, new AvarageMeanStrategy()), 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            Calculator calculator = new Calculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, new MedianMean());

            Assert.AreEqual(expected, calculator.CalculateAverage(values, new MedianMean()), 0.000001);
            Assert.AreEqual(expected, calculator.CalculateAverage(values, new MedianMeanStrategy()), 0.000001);
        }
    }
}
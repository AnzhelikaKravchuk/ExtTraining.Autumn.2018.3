using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private DoubleCalculator _calculator;
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [SetUp]
        public void Initialization()
        {
            _calculator = new DoubleCalculator();
        }

        [Test]
        public void Test_AverageByMean()
        {           
            double expected = 8.3636363;

            double actual = _calculator.CalculateAverage(values, new MedianCalculator());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {            
            double expected = 8.0;

            double actual = _calculator.CalculateAverage(values, (doubles) => (doubles.Sum() / doubles.Count));

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}
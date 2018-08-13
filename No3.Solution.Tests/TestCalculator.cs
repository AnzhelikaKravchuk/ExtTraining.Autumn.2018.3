using System.Collections.Generic;
using NUnit.Framework;
using No3.Solution;
using System;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {
            IAvaragingMethod method = new MeanAvaragingMethod();

            double expected = 8.3636363;

            double actual = method.CalculateAvarage(values);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            IAvaragingMethod method = new MedianAvaragingMethod();

            double expected = 8.0;

            double actual = method.CalculateAvarage(values);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMean_Exception()
        {
            IAvaragingMethod method = new MeanAvaragingMethod();
            Assert.Throws<ArgumentNullException>(() => method.CalculateAvarage(null));
        }

        [Test]
        public void Test_AverageByMedian_Exception()
        {
            IAvaragingMethod method = new MedianAvaragingMethod();
            Assert.Throws<ArgumentNullException>(() => method.CalculateAvarage(null));
        }
    }
}
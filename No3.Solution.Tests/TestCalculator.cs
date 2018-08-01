using System;
using System.Collections.Generic;
using No3.Solution;
using NUnit.Framework;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {
            Calculator calc = new Calculator();
            double expected = 8.3636363;

            double actual = calc.Calculate(values, new Mean());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            Calculator calc = new Calculator();

            double expected = 8.0;

            double actual = calc.Calculate(values, new Median());

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
    [TestFixture]
    public class DelegateCalculatorTests
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMeanDelegate()
        {
            var result = values.Calculate(new Mean().Perform);
            double expected = 8.3636363;
            Assert.AreEqual(expected, result, 0.000001);
        }

        [Test]
        public void Test_AverageByMedianDelegate()
        {
            var result = values.Calculate(new Median().Perform);
            double expected = 8.0;
            Assert.AreEqual(expected, result, 0.000001);
        }
        [Test]
        public void CalculatorViaDelegate_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => values.Calculate(null));
        }
    }
}
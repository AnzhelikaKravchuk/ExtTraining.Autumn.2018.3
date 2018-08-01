using System.Collections.Generic;
using NUnit.Framework;
using No3.Solution;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly double[] values = new double[] { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        #region Via strategy
        [Test]
        public void Test_Strategy_AverageByMean()
        {
            via_Strategy.Calculator calculator = new via_Strategy.Calculator();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, new via_Strategy.MeanAverage());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_Strategy_AverageByMedian()
        {
            via_Strategy.Calculator calculator = new via_Strategy.Calculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, new via_Strategy.MedianAverage());

            Assert.AreEqual(expected, actual, 0.000001);
        }
        #endregion

        #region Via Template method
        [Test]
        public void Test_Template_AverageByMean()
        {
            via_Template_method.Calculator calculator = new via_Template_method.Calculator();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, new via_Template_method.MeanMethod());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_Template_AverageByMedian()
        {
            via_Template_method.Calculator calculator = new via_Template_method.Calculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, new via_Template_method.MedianMethod());

            Assert.AreEqual(expected, actual, 0.000001);
        }
        #endregion
    }
}
using System.Collections.Generic;
using NUnit.Framework;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMeanInterface()
        {
            Calculator calculator = new Calculator();
            IAveragingMethod method = new MeanMethod();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, method);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMeanDelegate()
        {
            Calculator calculator = new Calculator();
            IAveragingMethod method = new MeanMethod();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, method.Calculate);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedianInterface()
        {
            Calculator calculator = new Calculator();
            IAveragingMethod method = new MedianMethod();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, method);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedianDelegate()
        {
            Calculator calculator = new Calculator();
            IAveragingMethod method = new MedianMethod();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, method.Calculate);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}
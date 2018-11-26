using System.Collections.Generic;
using NUnit.Framework;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean_Interface()
        {
            Calculator calculator = new Calculator();

            AverageMean average = new AverageMean();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, average);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMean_Delegate()
        {
            Calculator calculator = new Calculator();

            AverageMean average = new AverageMean();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, average.Calculate);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian_Interface()
        {
            Calculator calculator = new Calculator();

            AverageMedian average = new AverageMedian();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, average);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian_Delegate()
        {
            Calculator calculator = new Calculator();

            AverageMedian average = new AverageMedian();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, average.Calculate);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}
using System.Collections.Generic;
using NUnit.Framework;
using Moq;

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

            var mean = new CalculateMean();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, mean);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            Calculator calculator = new Calculator();

            double expected = 8.0;

            var median = new CalculateMedian();

            double actual = calculator.CalculateAverage(values, median);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_Moq_Object()
        {
            Calculator calculator = new Calculator();

            double expected = 8.0;

            var medianMoq = new Mock<ICalculate>();
            medianMoq.Setup(x => x.CalculateAverage(values))
                .Returns(8.0);

            double actual = calculator.CalculateAverage(values, medianMoq.Object);

            medianMoq.Verify(x => x.CalculateAverage(values),
                Times.Exactly(1));

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}
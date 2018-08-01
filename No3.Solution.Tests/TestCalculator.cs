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
        public void MoqTest()
        {
            // Проверяется, что метод класса Calculator внутри себя вызывает метод Calculate
            // интерфейса IAveragingMethod
            var mocker = new Mock<IAveragingMethod>();
            var calculator = new Calculator();
            calculator.CalculateAverage(values, mocker.Object);

            mocker.Verify(method => method.Calculate(values));
        }

        [Test]
        public void Test_AverageByMean()
        {
            Calculator calculator = new Calculator();

            double expected = 8.3636363;
            Mean mean = new Mean();

            double actual = calculator.CalculateAverage(values, mean);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            Calculator calculator = new Calculator();

            double expected = 8.0;
            Median median = new Median();
            double actual = calculator.CalculateAverage(values, median);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}
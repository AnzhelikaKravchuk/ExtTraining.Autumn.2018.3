using System.Collections.Generic;
using No3.Solution.State_Pattern;
using NUnit.Framework;

namespace No3.Solution.Tests
{
    using No3.Solution.Events;

    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {
            Calculator calculator = new Calculator(new MeanMethod());

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            Calculator calculator = new Calculator(new MedianMethod());

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_Event_AverageByMean()
        {
            EventCalculator calculator = new EventCalculator();

            MeanEvent temp = new MeanEvent();

            temp.Subscribe(calculator);

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_Event_AverageByMedian()
        {
            EventCalculator calculator = new EventCalculator();

            MedianEvent temp = new MedianEvent();

            temp.Subscribe(calculator);

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}
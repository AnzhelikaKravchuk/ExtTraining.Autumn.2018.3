using System.Collections.Generic;
using NUnit.Framework;
using No3.Solution;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private IAverageCaculator _calculator;

        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void TestSolution1_AverageByMean()
        {
            CalculatorSolution1 calculator = new CalculatorSolution1();
            _calculator = new MeanCalculator();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, _calculator);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void TestSolution1_AverageByMedian()
        {
            CalculatorSolution1 calculator = new CalculatorSolution1();
            _calculator = new MedianCalculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, _calculator);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void TestSolution2_AverageByMean()
        {
            CalculatorSolution2 calculator = new CalculatorSolution2();
            _calculator = new MeanCalculator();

            double expected = 8.3636363;

            double actual = calculator.CalculateAverage(values, _calculator.Calculate);

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void TestSolution2_AverageByMedian()
        {
            CalculatorSolution2 calculator = new CalculatorSolution2();
            _calculator = new MedianCalculator();

            double expected = 8.0;

            double actual = calculator.CalculateAverage(values, _calculator.Calculate);

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}
using System.Collections.Generic;
using NUnit.Framework;
using No3.Solution;
using No3.Solution.Variant_1;

namespace No3.Solution.Tests
{
    [TestFixture]
    public class TestCalculator
    {
        private readonly List<double> values = new List<double> { 10, 5, 7, 15, 13, 12, 8, 7, 4, 2, 9 };

        [Test]
        public void Test_AverageByMean()
        {
            double expected = 8.3636363;

            double actual = Calculator.CalculateAverage(values, vs => new MeanAlgorithmSolver().Find(vs));

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMean_Via_Interface()
        {
            double expected = 8.3636363;

            double actual = Calculator.CalculateAverage(values, new MeanAlgorithmSolver());

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian()
        {
            double expected = 8.0;

            double actual = Calculator.CalculateAverage(values, vs => new MedianAlgorithmSolver().Find(vs));

            Assert.AreEqual(expected, actual, 0.000001);
        }

        [Test]
        public void Test_AverageByMedian_Via_Interface()
        {
            double expected = 8.0;

            double actual = Calculator.CalculateAverage(values, new MedianAlgorithmSolver());

            Assert.AreEqual(expected, actual, 0.000001);
        }
    }
}
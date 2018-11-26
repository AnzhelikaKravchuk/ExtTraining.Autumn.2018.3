using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace No6.Solution.Tests
{
    [TestFixture]
    public class CustomEnumerableTests
    {
        [Test]
        public void Generator_ForSequence1()
        {
            int[] expected = {1, 1, 2, 3, 5, 8, 13, 21, 34, 55};

            int Generate(int index, int number1, int number2)
            {
                switch (index)
                {
                    case 1:
                        return number1;
                    case 2:
                        return number2;
                    default:
                        return Generate(index - 1, number1, number2) + Generate(index - 2, number1, number2);
                }
            }

            CollectionAssert.AreEqual(Generator.Generate(expected[0], expected[1], Generate, expected.Length), expected);
        }
        
        [Test]
        public void Generator_ForSequence2()
        {
            int[] expected = { 1, 2, 4, 8, 16, 32, 64, 128, 256, 512 };

            int Generate(int index, int number1, int number2)
            {
                switch (index)
                {
                    case 1:
                        return number1;
                    case 2:
                        return number2;
                    default:
                        return 6 * Generate(index - 1, number1, number2) - 8 * Generate(index - 2, number1, number2);
                }
            }

            CollectionAssert.AreEqual(Generator.Generate(expected[0], expected[1], Generate, expected.Length), expected);
        }

        [Test]
        public void Generator_ForSequence3()
        {
            double[] expected = { 1, 2, 2.5, 3.3, 4.05757575757576, 4.87086926018965, 5.70389834408211, 6.55785277425587, 7.42763417076325, 8.31053343902137 };

            double Generate(int index, double number1, double number2)
            {
                switch (index)
                {
                    case 1:
                        return number1;
                    case 2:
                        return number2;
                    default:
                        return Generate(index - 1, number1, number2) + Generate(index - 2, number1, number2) / Generate(index - 1, number1, number2);
                }
            }

            CollectionAssert.AreEqual(Generator.Generate(expected[0], expected[1], Generate, expected.Length), expected, Comparer<double>.Create((num1, num2) => Math.Abs(num1 - num2) < 0.0001 ? 0 : num1 - num2 > 0.0001 ? 1 : -1));
        }
    }
}

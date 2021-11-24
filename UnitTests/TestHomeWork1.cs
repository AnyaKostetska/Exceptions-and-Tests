using NUnit.Framework;
using ExceptionsTestLibrary;
using System;


namespace UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2, 5, 25, 10)]
        [TestCase(2, -8, 8, 8)]
        [TestCase(-2, -5, -25,-15)]
        public void GetSolutionToLinearEquationWhenParamsIsNotEqualZero
                    (double a, double b, double c, double expected)
        {
            double actual = HomeWork1.GetSolutionToLinearEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void GetSolutionToLinearEquationWhenParamAIsEqualZero_ShouldThrowDivideByZeroException
            (double n)
        {
            try
            {
                HomeWork1.GetSolutionToLinearEquation(n, n, n);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("a,b,c == 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

    }
}
using NUnit.Framework;
using ExceptionsTestsLibrary;
using System;


namespace UnitTests
{
    public class TestHomeWork1_Basic
    {

        [TestCase(2, 5, 25, 10)]
        [TestCase(2, -8, 8, 8)]
        [TestCase(-2, -5, -25,10)]
        public void GetSolutionToLinearEquationWhenParamsIsNotEqualZero
                    (double a, double b, double c, double expected)
        {
            double actual = HomeWork1_Basic.GetSolutionToLinearEquation(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 1, 2)]
        [TestCase(1, 0, 2)]
        [TestCase(1, 2, 0)]
        public void GetSolutionToLinearEquationWhenParamAIsEqualZero_ShouldThrowDivideByZeroException
            (double a, double b, double c)
        {
            try
            {
                HomeWork1_Basic.GetSolutionToLinearEquation(a, b, c);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("a or b or c == 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

    }
}
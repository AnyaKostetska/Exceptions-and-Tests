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

        [TestCase(5, 4, -41)]
        [TestCase(4, 5, 45)]
        [TestCase(7, 0, -5)]
        [TestCase(0, 3, 3)]
        public void GetSolutionToEquationWhenParamsIsNotEqualZero
                   (double a, double b, double expected)
        {
            double actual = HomeWork1_Basic.GetSolutionToEquation(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        public void GetSolutionToEquationWhenParamAandBIsEqualZero_ShouldThrowDivideByZeroException
            (double a, double b)
        {
            try
            {
                HomeWork1_Basic.GetSolutionToEquation(a, b);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("a or b == 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        //[TestCase(5, 4, 4, 7, -41, 48)]
        //[TestCase(5, 4, 4, 7, -41, 48)]
        //[TestCase(5, 4, 4, 7, -41, 48)]
        //[TestCase(5, 4, 4, 7, -41, 48)]
        //public void FindTwoValuesAandBifcoordinatesX1X2AndY1Y2_PositiveScenario
        //   (double x1, double x2, double y1, double y2, double expectedA, double expectedB)
        //{
        //    double actualA = HomeWork1_Basic.FindAandBbyCoordinates( x1 , x2, y1, y2);
        //    double 

        //    Assert.AreEqual(expectedA, actualA, expectedB, actualB);
        //}

        //[TestCase(0, 0)]
        //[TestCase(10, 10)]
        //[TestCase(-1, -1)]
        //public void FindTwoValuesAandBifcoordinatesX1X2AndY1Y2_NegativeScenario
        //    (double x1, double x2)
        //{
        //    try
        //    {
        //        HomeWork1_Basic.GetSolutionToEquation(x1, x2);
        //    }
        //    catch (DivideByZeroException ex)
        //    {
        //        Assert.AreEqual("x1 - x2 == 0", ex.Message);
        //        Assert.Pass();
        //    }

        //    Assert.Fail();
        //}
    }
}
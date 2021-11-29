using NUnit.Framework;
using ExceptionsTestsLibrary;
using System;

namespace UnitTests
{
    public class TestHomeWork2_Cycles
    {
        [TestCase(9, 1)]
        [TestCase(-9, 1)]
        [TestCase(10, 1)]
        [TestCase(285, 0)]
        public void GetCountOfNumbersFromZeroToTenDevidedByA
            (double a, double expected)
        {
            double actual = HomeWork2_Cycles.GetADevidedNumbers(a);

            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        public void GetCountOfNumbersDevidedByA_ShoulbRaiseExceptionIfAEqualtoZero
            (double a)
        {
            try
            {
                HomeWork2_Cycles.GetADevidedNumbers(a);
            }
            catch (DivideByZeroException ex)
            {
                Assert.AreEqual("a == 0", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }


    }
}

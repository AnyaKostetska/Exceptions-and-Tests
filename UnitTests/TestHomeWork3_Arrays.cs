using NUnit.Framework;
using ExceptionsTestsLibrary;
using System;

namespace UnitTests
{
    public class TestHomeWork3_Arrays
    {
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 5)]
        [TestCase(new[] { 10, 4, 3, 2 }, 10)]
        [TestCase(new[] { -5, 2, 0 }, 2)]
        [TestCase(new[] { 1 }, 1)]
        [TestCase(new[] { -1 }, -1)]
        public void Max_WhenFilledArrayPassed_ShouldFindMaxValue(int[] array, int expected)
        {
            int actual = HomeWork3_Arrays.GetMaxValueOfArray(array);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Max_WhenEmptyArrayPassed_ShouldThrowArgumentException()
        {
            try
            {
                HomeWork3_Arrays.GetMaxValueOfArray(new int[] { });
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Empty array!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void Max_WhenNullArrayPassed_ShouldThrowArgumentException()
        {
            try
            {
                HomeWork3_Arrays.GetMaxValueOfArray(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Empty array!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [TestCase(new[] { 1, 2, 3, 4, 5 }, 1)]
        [TestCase(new[] { 10, 4, 3, 2 }, 2)]
        [TestCase(new[] { -5, 2, 0 }, -5)]
        [TestCase(new[] { 1 }, 1)]
        [TestCase(new[] { -1 }, -1)]
        public void Min_WhenFilledArrayPassed_ShouldFindMinValue(int[] array, int expected)
        {
            int actual = HomeWork3_Arrays.GetMinValueOfArray(array);

            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Min_WhenEmptyArrayPassed_ShouldThrowArgumentException()
        {
            try
            {
                HomeWork3_Arrays.GetMaxValueOfArray(new int[] { });
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Empty array!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }

        [Test]
        public void Min_WhenNullArrayPassed_ShouldThrowArgumentException()
        {
            try
            {
                HomeWork3_Arrays.GetMaxValueOfArray(null);
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("Empty array!", ex.Message);
                Assert.Pass();
            }

            Assert.Fail();
        }
    }
}


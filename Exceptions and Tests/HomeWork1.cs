using System;

namespace ExceptionsTestLibrary
{
    public class HomeWork1
    {
        /// <summary>
        /// </summary>
        /// <param name="a">Should not be equal to zero</param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        /// <returns>X result</returns>
        /// <exception cref="DivideByZeroException"/>
        /// <exception cref="ArgumentException"/>
        public static double GetSolutionToLinearEquation(double a, double b, double c)
        {
            if ( a == 0 || b == 0 || c == 0)
            {
                throw new DivideByZeroException("a or b or c == 0");
            }
            return (c - b) / a;
        }
    }
}

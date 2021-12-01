using System;

namespace ExceptionsTestsLibrary
{
    public class HomeWork1_Basic
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

        public static double GetSolutionToEquation(double a, double b)
        {
            if (a == 0 & b == 0)
            {
                throw new DivideByZeroException("a or b == 0");
            }

            return ((5 * a) + (b * b)) / (b - a);
        }

        public static (double A, double B) FindAandBbyCoordinates(double x1, double y1, double x2, double y2)
        { 
            double A = (y1 - y2) / (x1 - x2);
            double B = y2 - A * x2;
            if (x1 - x2 == 0)
            {
                throw new DivideByZeroException("x1 - x2 == 0");
            }
            else 
            {
                return (A, B);
            }
        }
    }
}

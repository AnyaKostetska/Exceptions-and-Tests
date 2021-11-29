using System;

namespace ExceptionsTestsLibrary
{
    public class HomeWork2_Cycles
    {
    /// <summary>
    /// <param name="a">Should not be equal to zero</param>
    /// <exception cref="DivideByZeroException"/>
    /// </summary>
        public static double GetADevidedNumbers(double A)
        {
            if (A == 0)
            {
                throw new DivideByZeroException("a == 0");
            }
            else
            {
                double count = 0;
                for (double i = 1; i <= 10; i++)
            {
                if (i % A == 0)
                {
                    count++;
                }
            }
                return count;
            }
        }
    }
}

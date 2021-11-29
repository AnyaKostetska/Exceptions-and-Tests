using System;


namespace ExceptionsTestsLibrary
{
    public class HomeWork3_Arrays
    {
        public static int GetMaxValueOfArray(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Empty array!");
            }

            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }

        public static int GetMinValueOfArray(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Empty array!");
            }

            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            return minValue;
        }
    }
}

using System;
using ExceptionsTestsLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(100);
            }

            Console.WriteLine(HomeWork1_Basic.FindAandBbyCoordinates(12, 44, 45, 44));

            //for (int i = 1; i < array.Length; i++)
            //{
            //    Console.Write(array[i] + " ");
            //}
            //Console.WriteLine();
        }
    }
}

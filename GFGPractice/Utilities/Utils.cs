using System;
using System.Collections.Generic;
using System.Text;

namespace GFGPractice.Utilities
{
    public class Utils
    {
        static Random rand = new Random();
        public static void PrintArray<type>(type[] arr)
        {
            foreach(type t in arr)
            {
                Console.Write(t + " ");
            }
            Console.WriteLine();
        }

        public static int[] GenerateIntArray(int expectedArraySize)
        {
            int[] arr = new int[expectedArraySize];
            for(int iIndex = 0; iIndex < expectedArraySize; iIndex++)
            {
                arr[iIndex] = rand.Next(0, 1000);
                //arr[iIndex] = rand.Next(int.MinValue, int.MaxValue);
            }

            return arr;
        }
    }
}

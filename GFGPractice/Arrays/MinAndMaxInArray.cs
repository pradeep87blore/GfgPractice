using GFGPractice.Config;
using GFGPractice.Interfaces;
using GFGPractice.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GFGPractice.Arrays
{
    /// <summary>
    /// Solution for https://practice.geeksforgeeks.org/problems/find-minimum-and-maximum-element-in-an-array/0
    /// </summary>
    public class MinAndMaxInArray : IExecutable
    {
        public int ExecuteProgram()
        {
            int[] arr = Utils.GenerateIntArray(10);
            Utils.PrintArray<int>(arr);

            var ret = FindMinAndMax(arr);
            Console.WriteLine($"Min value: {ret.Item1}, Max value: {ret.Item2}");
            return Constants.SUCCESS;
        }

        /// <summary>
        /// Finds the min and max values in an int array
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>A tuple with the first element representing a min value and 
        /// the second representing the max value</returns>
        public (int, int) FindMinAndMax(int[] arr)
        {
            (int minVal, int maxVal) retValue;
            retValue.minVal = int.MaxValue;
            retValue.maxVal = int.MinValue;

            foreach(int iVal in arr)
            {
                if(iVal > retValue.maxVal)
                {
                    retValue.maxVal = iVal;
                }

                if (iVal < retValue.minVal)
                {
                    retValue.minVal = iVal;
                }
            }
            return retValue;
        }
    }
}

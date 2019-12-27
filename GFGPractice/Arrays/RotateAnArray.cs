using GFGPractice.Config;
using GFGPractice.Interfaces;
using GFGPractice.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GFGPractice.Arrays
{
    /// <summary>
    /// Solution for https://practice.geeksforgeeks.org/problems/rotate-array-by-n-elements/0
    /// Given an array, rotate it by a specified number of elements, clockwise or anticlockwise
    /// </summary>
    public class RotateAnArray : IExecutable
    {
        public int ExecuteProgram()
        {
            int[] arr = Utils.GenerateIntArray(10);
            Console.WriteLine("Original array:");
            Utils.PrintArray<int>(arr);

            var rotatedArr = RotateArray(arr, 5, true);
            Console.WriteLine("Array rotated clockwise by 5 times:");
            Utils.PrintArray<int>(rotatedArr);


            rotatedArr = RotateArray(arr, 5, false);
            Console.WriteLine("Array rotated anti-clockwise by 5 times:");
            Utils.PrintArray<int>(rotatedArr);

            return Constants.SUCCESS;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="clockwise"></param>
        public int[] RotateArray(int[] arr, int rotateBy, bool clockwise)
        {

            for (int iIndex = 0; iIndex < rotateBy; iIndex++)
            {
                if (clockwise)
                {
                    int temp = arr[0];
                    Array.Copy(arr, 1, arr, 0, arr.Length - 1);
                    arr[arr.Length - 1] = temp;
                }
                else
                {
                    int temp = arr[arr.Length - 1];
                    Array.Copy(arr, 0, arr, 1, arr.Length - 1);
                    arr[0] = temp;
                }
            }
            return arr;
        }
    }
}

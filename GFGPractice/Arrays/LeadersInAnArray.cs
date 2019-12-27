using GFGPractice.Config;
using GFGPractice.Interfaces;
using GFGPractice.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GFGPractice.Arrays
{
    /// <summary>
    /// Solution for https://practice.geeksforgeeks.org/problems/leaders-in-an-array/0
    /// Given an array of positive integers. Your task is to find the leaders in the array.
    /// Note: An element of array is leader if it is greater than or equal to all the elements to its right 
    /// side.Also, the rightmost element is always a leader.
    /// </summary>
    class LeadersInAnArray : IExecutable
    {
        public int ExecuteProgram()
        {
            int[] arr = Utils.GenerateIntArray(15);
            Console.WriteLine("Original array:");
            Utils.PrintArray<int>(arr);

            List<int> leaders = new List<int>();

            int currentMax = -1;
            for(int iIndex = arr.Length - 1; iIndex >= 0; iIndex-- )
            {
                if(arr[iIndex] > currentMax)
                {
                    leaders.Add(arr[iIndex]);
                    currentMax = arr[iIndex];
                }
            }

            leaders.Reverse();
            Console.WriteLine("Leaders in the array are:");
            foreach(var leader in leaders)
            {
                Console.WriteLine(leader);
            }

            return Constants.SUCCESS;
        }
    }
}

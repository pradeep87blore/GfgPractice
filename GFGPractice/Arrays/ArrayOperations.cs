using GFGPractice.Config;
using GFGPractice.Interfaces;
using GFGPractice.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GFGPractice.Arrays
{
    /// <summary>
    /// Solution for https://practice.geeksforgeeks.org/problems/operating-an-array/1
    /// This class performs some basic array operations: Insert into an array, delete from an array and search and array
    /// </summary>
    class ArrayOperations : IExecutable
    {
        /// <summary>
        /// Execute the functions of the class
        /// </summary>
        /// <returns></returns>
        public int ExecuteProgram()
        {
            var arr = PrepareArray();

            Console.WriteLine("Original Array");
            Utils.PrintArray<int>(arr);

            Console.WriteLine("Deleting 100");
            arr = DeleteItem(arr, 100);
            Utils.PrintArray<int>(arr);

            Console.WriteLine("Deleting 20");
            arr = DeleteItem(arr, 20);
            Utils.PrintArray<int>(arr);

            Console.WriteLine("Deleting 75 that doesn't exist in the arry");
            arr = DeleteItem(arr, 20);
            Utils.PrintArray<int>(arr);

            Console.WriteLine("Inserting 123 at index 0");
            arr = InsertItemAt(arr, 123, 0);
            Utils.PrintArray<int>(arr);

            Console.WriteLine("Inserting 111 at index 3");
            arr = InsertItemAt(arr, 111, 3);
            Utils.PrintArray<int>(arr);


            return Constants.SUCCESS;
        }


        private int[] PrepareArray()
        {
            int[] numbers = { 10, 20, 4, 6, 8, 1, 100 };
            return numbers;
        }

        /// <summary>
        /// Delete a specified item. 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="element"></param>
        /// <returns>Returns the original array if element not found
        /// Returns the updated array if the element was found</returns>
        public int[] DeleteItem(int[] arr, int element)
        {
            int index = SearchItem(arr, element);
            if (index != -1)
            {
                return DeleteItemAt(arr, (uint)index);
            }
            return arr;
        }

        /// <summary>
        /// Delete the element at a specified index 
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="element"></param>
        /// <returns>Returns the original array if element not found
        /// Returns the updated array if the element was found</returns>
        public int[] DeleteItemAt(int[] arr, uint index)
        {
            try
            {
                if(index > arr.Length)
                {
                    return arr;
                }
                int[] tempArr = new int[arr.Length - 1];
                for(uint iIterate = 0; iIterate < index; iIterate++)
                {
                    tempArr[iIterate] = arr[iIterate];
                }
                for (uint iIterate = index; iIterate < arr.Length - 1; iIterate++)
                {
                    tempArr[iIterate] = arr[iIterate + 1];
                }

                return tempArr;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
        
        /// <summary>
        /// Insert an element at the specified zero based index
        /// Thus, if the array is initially 10 30 20 50 60 and we want to insert 5 at index 3, 
        /// the output array should be 10 30 20 5 50 60
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="element"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public int[] InsertItemAt(int[] arr, int element, uint index)
        {
            int[] tempArr = new int[arr.Length + 1];
            Array.Copy(arr, 0, tempArr, 0, index); // Make a shallow copy
            tempArr[index] = element;
            Array.Copy(arr, index, tempArr, index+1, arr.Length - index); // Make a shallow copy

            return tempArr;
        }

        public int SearchItem(int[] arr, int key)
        {
            int iIndex = 0;
            foreach(int element in arr)
            {
                if(element == key)
                {
                    return iIndex;
                }
                iIndex++;
            }
            return -1; // Not found
        }
    }
}

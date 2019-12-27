using System;
using System.Collections.Generic;
using System.Text;

namespace GFGPractice.Utilities
{
    public class Utils
    {
        public static void PrintArray<type>(type[] arr)
        {
            foreach(type t in arr)
            {
                Console.WriteLine(t);
            }
        }
    }
}

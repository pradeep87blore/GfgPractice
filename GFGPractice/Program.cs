using GFGPractice.Arrays;
using GFGPractice.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static List<IExecutable> executables = new List<IExecutable>();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AddExecutables();

            ExecuteAll();

            Console.ReadKey();
        }

        private static void ExecuteAll()
        {
            foreach (var executable in executables)
            {
                executable.ExecuteProgram();

                Console.WriteLine("-----------------------------------------");
            }
        }

        private static void AddExecutables()
        {
            // executables.Add(new ArrayOperations());
            // executables.Add(new MinAndMaxInArray());
            executables.Add(new RotateAnArray());
        }
    }
}

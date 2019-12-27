using System;
using System.Collections.Generic;
using System.Text;

namespace GFGPractice.Interfaces
{
    /// <summary>
    /// Implement this interface to enable the Main to call the ExecuteProgram on each class
    /// </summary>
    interface IExecutable
    {
        /// <summary>
        /// Implement this function as a custom "Main" function to each class
        /// </summary>
        /// <returns></returns>
        int ExecuteProgram();
    }
}

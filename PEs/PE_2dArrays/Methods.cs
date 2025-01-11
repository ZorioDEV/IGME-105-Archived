using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_2dArrays
{
    internal class Methods
    {
        // *** METHODS ***
        /// <summary>
        /// Assigns all the spaces within a 2D array with random numbers from 0-100.
        /// </summary>
        /// <param name="array">The 2D Array</param>
        /// <param name="generator">Random Number</param>
        /// <param name="lowRange">Lowest Number Possible</param>
        /// <param name="highRange">Highest Number Possible</param>
        public static void Fill2DArray(int[,] array, Random generator, int lowRange, int highRange)
        {
            // loop through rows
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // loop through columns
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    // assign random value within the range
                    array[i, j] = generator.Next(lowRange, highRange + 1);
                }
            }
        }

        /// <summary>
        /// Prints out all the 2D Array's data.
        /// </summary>
        /// <param name="array">The 2D Array</param>
        public static void Print2DArray(int[,] array)
        {
            // prints headers for columns
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"\tCol {j + 1}");
            }
            Console.WriteLine();

            // loops through rows
            for (int i = 0; i < array.GetLength(0); i++)
            {
                // prints headers for rows
                Console.Write($"Row {i + 1}:\t");

                // loops through columns
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}

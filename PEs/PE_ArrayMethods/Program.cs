// Tyler Bye
// 10/21/2024
// Learning Array algorithms and Array methods
using System;
using System.ComponentModel;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PE_ArrayMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** VARIABLES ***

            string[] colorArray = { "green", "orange", "red", "yellow" };
            string[] stringArray1 = new string[3];
            string[] stringArray2 = CreateAndFillArray("other starting data", 6);
            int[] numbers = { 41, 7, 19, 299, 8743, 2, 55 };
            int smallest = FindSmallestValue(numbers);
            int largest = FindLargestValue(numbers);
            int howManyOdd = CountOddNumbers(numbers);
            bool exists = SearchForValue(numbers, 299);

            // *** MAIN CODE ***

            // prints out all the colors
            PrintArray(colorArray);
            Console.WriteLine();

            // prints out "*your starting data" 3 times 
            FillArray(stringArray1, "your starting data");
            PrintArray(stringArray1);
            Console.WriteLine();

            // prints out "*other starting data" 6 times
            PrintArray(stringArray2);
            Console.WriteLine();

            // prints out all the numbers
            PrintArray(numbers);
            Console.WriteLine();

            // finds the smallest value
            Console.WriteLine("Smallest value is " + smallest);
            Console.WriteLine();

            // finds the largest value
            Console.WriteLine("Largest value is " + largest);
            Console.WriteLine();

            // counts how many odds are in the array
            Console.WriteLine(howManyOdd + " odd numbers in the array.");
            Console.WriteLine();

            // searches if the array contains 299 & 8
            Console.WriteLine("Does array contain 299? " + exists);
            exists = SearchForValue(numbers, 8);
            Console.WriteLine("Does array contain 8? " + exists);
        }

        /// <summary>
        /// prints out a string for the length of the string array
        /// </summary>
        /// <param name="array">string array given</param>
        public static void PrintArray(string[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(" *" + array[i]);
            }
        }

        /// <summary>
        /// fills all values of an array with the string given 
        /// </summary>
        /// <param name="array">string array given</param>
        /// <param name="initialValue">string for console</param>
        public static void FillArray(string[] array, string initialValue)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = initialValue;
            }
        }

        /// <summary>
        /// creates an array and fills all values of an array with the string given
        /// </summary>
        /// <param name="startingValue">string for console</param>
        /// <param name="size">length of the array</param>
        /// <returns>string array</returns>
        public static string[] CreateAndFillArray(string startingValue, int size)
        {
            string[] array = new string[size];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = startingValue;
            }
            return array;
        }

        /// <summary>
        /// prints out an int for the length of the int array
        /// </summary>
        /// <param name="array">int array given</param>
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(" - " + array[i]);
            }
        }

        /// <summary>
        /// goes through all ints & finds the smallest value
        /// </summary>
        /// <param name="array">int array given</param>
        /// <returns>int</returns>
        public static int FindSmallestValue(int[] array)
        {
            int smallest = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];
                }
            }
            return smallest;
        }

        /// <summary>
        /// goes through all ints & finds the largest value
        /// </summary>
        /// <param name="array">int array given</param>
        /// <returns>int</returns>
        public static int FindLargestValue(int[] array)
        {
            int largest = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > largest)
                {
                    largest = array[i];
                }
            }
            return largest;
        }

        /// <summary>
        /// goes through all ints & adds up the amount of ints present
        /// </summary>
        /// <param name="array">int array given</param>
        /// <returns>int</returns>
        public static int CountOddNumbers(int[] array)
        {

            int oddAmount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    oddAmount++;
                }
            }
            return oddAmount;
        }

        /// <summary>
        /// goes through all ints & checks if it matches the search int
        /// </summary>
        /// <param name="array">int array given</param>
        /// <param name="search">searching int given</param>
        /// <returns>bool</returns>
        public static bool SearchForValue(int[] array, int search)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == search)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

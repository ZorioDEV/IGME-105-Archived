// ***************************************************************************
// Tyler Bye 
// 10/16/2024
// Static methods starter file
// Purpose: Practice with writing static methods
// ***************************************************************************

namespace StaticMethods_STARTER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Leave these variables here! Do not change them!
            // Setup variables necessary for testing all 6 methods
            // ----------------------------------------------------------------
            bool success = false;
            int biggest = 0;
            string word = "";


            DisplayHeadline("Print Hashtags");

            PrintHashtags(2);
            PrintHashtags(0);
            PrintHashtags(5);


            DisplayHeadline("Display Player Health Bar");

            DisplayPlayerHealthBar(2, 10);
            DisplayPlayerHealthBar(10, 10);
            DisplayPlayerHealthBar(75, 100);


            DisplayHeadline("Makes Ten");

            success = MakesTen(9, 10);
            Console.WriteLine(
                "Do the values 9 and 10 add to 10? OR is one of the numbers 10? {0}",
                success);

            success = MakesTen(9, 9);
            Console.WriteLine(
                "Do the values 9 and 9 add to 10? OR is one of the numbers 10? {0}",
                success);

            success = MakesTen(1, 9);
            Console.WriteLine(
                "Do the values 1 and 9 add to 10? OR is one of the numbers 10? {0}",
                success);



            DisplayHeadline("Largest");

            biggest = Largest(1, 2, 3);
            Console.WriteLine(
                "The largest value of 1, 2, and 3 is: {0}",
                           biggest);

            biggest = Largest(1, 3, 2);
            Console.WriteLine(
                "The largest value of 1, 3, and 2 is: {0}",
                           biggest);

            biggest = Largest(3, 2, 1);
            Console.WriteLine(
                "The largest value of 3, 2, and 1 is: {0}",
                           biggest);

            biggest = Largest(2, 1, 2);
            Console.WriteLine(
                "The largest value of 2, 1, and 2 is: {0}",
                           biggest);

            biggest = Largest(3, 3, 1);
            Console.WriteLine(
                "The largest value of 3, 3, and 1 is: {0}",
                           biggest);

            biggest = Largest(5, 5, 5);
            Console.WriteLine(
                "The largest value of 5, 5, and 5 is: {0}",
                           biggest);



            DisplayHeadline("Not String");

            word = NotString("candy");
            Console.WriteLine("Your string 'candy' is now: {0}", word);

            word = NotString("x");
            Console.WriteLine("Your string 'x' is now: {0}", word);

            word = NotString("not bad");
            Console.WriteLine("Your string 'not bad' is now: {0}", word);

            word = NotString("nothing");
            Console.WriteLine("Your string 'nothing' is now: {0}", word);



            DisplayHeadline("Remove Index");

            word = RemoveIndex("kitten", 1);
            Console.WriteLine("Your string 'kitten' removing 1 is now: {0}", word);

            word = RemoveIndex("kitten", 0);
            Console.WriteLine("Your string 'kitten' removing 0 is now: {0}", word);

            word = RemoveIndex("kitten", 5);
            Console.WriteLine("Your string 'kitten' removing 5 is now: {0}", word);

            word = RemoveIndex("kitten", 6);
            Console.WriteLine("Your string 'kitten' removing 6 is now: {0}", word);

            word = RemoveIndex("kitten", -1);
            Console.WriteLine("Your string 'kitten' removing -1 is now: {0}", word);

            word = RemoveIndex("a", 0);
            Console.WriteLine("Your string 'a' removing 0 is now: {0}", word);

            word = RemoveIndex("an", 0);
            Console.WriteLine("Your string 'an' removing 0 is now: {0}", word);
            

            DisplayHeadline("Distance");

            double distance = Distance(0, 0, 0, 0);
            Console.WriteLine("The distance between (0, 0) and (0, 0) is: " + distance);

            distance = Distance(1, 0, 4, 4);
            Console.WriteLine("The distance between (1, 0) and (4, 4) is: " + distance);

            distance = Distance(10, 2, 3, 5);
            Console.WriteLine("The distance between (10, 2) and (3, 5) is: " + distance);
        }   // End of Main. All static methods in this Program class must be written AFTER this!


        // --------------------------------------------------------------------------------------------------
        // ---------------------------------    SAMPLE STATIC METHOD    -------------------------------------
        // --------------------------------------------------------------------------------------------------

        // Public static methods should be written between the Main method
        //    and the end of Program class curly brace. 

        /// <summary>
        /// Prints a formatted headline in the console window.
        /// </summary>
        /// <param name="textToDisplay">The text that should be displayed. Must not exceed 55 characters.</param>
        public static void DisplayHeadline(string textToDisplay)
        {
            // Determine the length of the string
            // Then create a string with all dashes of the appropriate length.
            string allDashes = "-------------------------";
            for (int i = 0; i < textToDisplay.Length; i++)
            {
                allDashes += "-";
            }

            // Print the resulting output
            Console.WriteLine();
            Console.WriteLine(allDashes);
            Console.WriteLine($"-------- {textToDisplay} method --------");
            Console.WriteLine(allDashes);
        }


        // --------------------------------------------------------------------------------------------------
        // -----------------------------    METHODS FOR STUDENTS TO WRITE    --------------------------------
        // --------------------------------------------------------------------------------------------------

        // Public static methods should be written between the Main method
        //    and the end of Program class's curly brace. 

        /// <summary>
        /// Prints a series of hashtags on a single line.
        /// </summary>
        /// <param name="numberTags">Number of hashtags to print.</param>
        
        // takes in an int for the number of # that will be printed
        public static void PrintHashtags(int numberTags)
        {
            // loops until the user number of # is printed for that line
            for (int i = 0; i < numberTags; i++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }


        // takes two int to create a fraction of player health to max health
        public static void DisplayPlayerHealthBar(int currentHealth, int maxHealth)
        {
            Console.WriteLine($"Player Health: {currentHealth}/{maxHealth}");
        }


        /// <summary>
        /// Given 2 integers, determine whether one of them is 10 or if their sum is 10.
        /// </summary>
        /// <param name="number1">First value</param>
        /// <param name="number2">Second value</param>
        /// <returns>True when one value is 10 or if the sum of values is 10. False otherwise.</returns>
        
        // takes two int and checks if they equal 10 or are 10
        public static bool MakesTen(int number1, int number2)
        {
            if ((number1 + number2 == 10) || (number1 == 10) || (number2 == 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Returns the largest of three integers.
        /// </summary>
        /// <param name="number1">First value</param>
        /// <param name="number2">Second value</param>
        /// <param name="number3">Third value</param>
        /// <returns>Largest of the three integers.</returns>
        
        // finds the max of three int
        public static int Largest(int number1, int number2, int number3)
        {
            return Math.Max(number1, Math.Max(number2, number3));
        }

        /// <summary>
        /// Prints the string with "not" in front if and only if the beginning 
        /// of the string doesn't start with "not".
        /// </summary>
        /// <param name="word">Input Word</param>
        /// <returns>Tested Word</returns>

        // adds "not" if it doesnt start with "not"
        public static string NotString(string word)
        {
            if (word.StartsWith("not"))
            {
                return word;
            }
            else
            {
                return "not " + word;
            }
        }

        /// <summary>
        /// Removes the index given of the string inputed.
        /// </summary>
        /// <param name="word"></param>
        /// <param name="index"></param>
        /// <returns>If out of range or if empty.</returns>

        // removes the index value of the string
        public static string RemoveIndex(string word, int index)
        {
            // prints if out of range
            if (index < 0 || index >= word.Length)
            {
                return "Index is out of range.";
            }

            // sets result to removed index of word
            string result = word.Remove(index, 1);

            // prints if index is 0 & empty 
            if (result.Length == 0)
            {
                return "<empty>";
            }

            return result;
        }

        /// <summary>
        /// Given 4 integers, calculates the distance between the two points (x1, y1) and (x2, y2).
        /// </summary>
        /// <param name="x1">First X value</param>
        /// <param name="y1">First Y value</param>
        /// <param name="x2">Second X value</param>
        /// <param name="y2">Second Y value</param>
        /// <returns>Distance AFTER calculated.</returns>

        // takes in 4 int to calculate the distnace of two points
        public static double Distance(int x1, int y1, int x2, int y2)
        {
            // uses the distance formula to calculate 
            double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            return distance;
        }

    }       // End of Program class - All static methods must be written BEFORE this
}           // End of Namespace
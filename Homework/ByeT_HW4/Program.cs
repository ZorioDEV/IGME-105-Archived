// Tyler Bye
// 10/23/2024
// HW 4: Gradebook
namespace ByeT_HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** PSUEDOCODE ***
            /*
             * ASK user for assignment amount
             * TRYPARSE the input
             * 
             * WHILE you want to ASKUSER
             *      IF parse is successful
             *          IF RESULT is positive
             *              STOP asking user
             *          ELSE
             *              ASK user for another number & TRYPARSE
             *      ELSE user for another number & TRYPARSE
             *      
             * CREATE arrays from number of assignments
             * RESET ASKUSER
             *      
             * FOR the amount of assignments
             *     ASK for assignment name & store input
             *     ASK for assignment grade
             *          
             *     WHILE you want to ASKUSER
             *         IF parse is successful
             *             IF DOUBLERESULT is between 0-100
             *                 STOP asking user
             *             ELSE
             *                 ASK user for another number & TRYPARSE
             *         ELSE user for another number & TRYPARSE
             *     RESET ASKUSER
             * RESET ASKUSER
             *      
             * PRINT grade report w/ a method
             * PRINT average w/ a method
             *      
             * ASK user to replace a grade & TRYPARSE
             *      
             * WHILE you want to ASKUSER
             *     IF parse is successful
             *         IF RESULT is positive & within range of assignement array
             *             STOP asking user
             *         ELSE
             *             ASK user for another number & TRYPARSE
             *     ELSE user for another number & TRYPARSE
             * 
             * RESET ASKUSER
             * ASK user for new grade
             * 
             * WHILE you want to ASKUSER
             *    IF parse is successful
             *        IF DOUBLERESULT is between 0-100
             *            STOP asking user
             *        ELSE
             *            ASK user for another number & TRYPARSE
             *    ELSE user for another number & TRYPARSE
             * STORE new grade
             * 
             * PRINT final grades w/ a method
             * PRINT final average w/ a method
             * 
             * PRINT number of grades above average w/ a method
             * PRINT highest w/ a method
             * PRINT lowest w/ a method
             * PRINT if theres any duplicates w/ a method
             */

            // *** VARIABLES ***
            bool success = false;
            int result = -1;
            double doubleResult = -1;
            bool AskUser = true;

            // *** MAIN CODE ***
            // asks user for amount of assignments
            Console.Write("How many assignments are you saving? ");
            success = int.TryParse(Console.ReadLine()!.Trim(), out result);

            // checks if user should be asked a question
            while (AskUser)
            {
                // checks if the parse was successful
                if (success)
                {
                    // checks if the user input was positive
                    if (result > 0)
                    {
                        AskUser = false;
                    }
                    // asks user again if invalid input
                    else
                    {
                        Console.Write("That is not a valid number. " +
                            "Enter the number of assignments: ");
                        success = int.TryParse(Console.ReadLine()!.Trim(), out result);
                    }
                }
                // asks user again if invalid input
                else
                {
                    Console.Write("That is not a valid number. " +
                        "Enter the number of assignments: ");
                    success = int.TryParse(Console.ReadLine()!.Trim(), out result);
                }
            }

            // resets ASKUSER & tells user the amount of assignments
            string[] titles = new string[result];
            double[] grades = new double[result];
            AskUser = true;
            Console.WriteLine($"You are saving {result} assignments.\n");

            // allows user to enter in all the assignment data
            for (int i = 0; i < result; i++)
            {
                // asks user for assignment title
                Console.Write($"\nEnter the name for assignment #{i + 1}: ");
                titles[i] = Console.ReadLine()!.Trim();

                // ask user for assignment grade
                Console.Write($"Enter the grade {titles[i]}: ");
                success = double.TryParse(Console.ReadLine()!.Trim(), out doubleResult);

                // checks if user should be asked a question
                while (AskUser)
                {
                    // checks if the parse was successful
                    if (success)
                    {
                        // checks if DOUBLERESULT was within 0-100
                        if (doubleResult >= 0 && doubleResult <= 100)
                        {
                            AskUser = false;
                        }
                        // asks user again if invalid input
                        else
                        {
                            Console.Write("Grade must be between 0 and 100. Enter grade: ");
                            success = double.TryParse(Console.ReadLine()!.Trim(), out doubleResult);
                        }
                    }
                    // asks user again if invalid input
                    else
                    {
                        Console.Write("Grade must be between 0 and 100. Enter grade: ");
                        success = double.TryParse(Console.ReadLine()!.Trim(), out doubleResult);
                    }
                }

                // resetsd ASKUSER & stores grade data
                grades[i] = doubleResult;
                AskUser = true;
            }

            // resets ASKUSER & formats
            Console.WriteLine("\nAll grades are entered!\n");
            AskUser = true;

            // prints out all the current grades
            Console.WriteLine("Grade Report:");
            PrintArray(titles, grades);
            // prints out the grade average
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Average: {CalculateAverage(grades)}\n");

            // asks to replace a grade & tries to parse
            Console.Write("Which number grade do you want to replace? ");
            success = int.TryParse(Console.ReadLine()!.Trim(), out result);

            // checks if user should be asked a question
            while (AskUser)
            {
                // checks if the parse was successful
                if (success)
                {
                    // checks if RESULT is positive & within the range of TITLES
                    if (result > 0 && result <= titles.Length)
                    {
                        AskUser = false;
                    }
                    // asks user again if invalid input
                    else
                    {
                        Console.Write($"Index must be a number between 1 and {titles.Length}. Try again: ");
                        success = int.TryParse(Console.ReadLine()!.Trim(), out result);
                    }
                }
                // asks user again if invalid input
                else
                {
                    Console.Write($"Index must be a number between 1 and {titles.Length}. Try again: ");
                    success = int.TryParse(Console.ReadLine()!.Trim(), out result);
                }
            }

            // resets ASKUSER 
            AskUser = true;
            // asks user for new grade & tries to parse
            Console.Write($"Enter the grade {titles[result - 1]}: ");
            success = double.TryParse(Console.ReadLine()!.Trim(), out doubleResult);

            // checks if user should be asked a question
            while (AskUser)
            {
                // checks if the parse was successful
                if (success)
                {
                    // checks if DOUBLERESULT was within 0-100
                    if (doubleResult >= 0 && doubleResult <= 100)
                    {
                        AskUser = false;
                    }
                    // asks user again if invalid input
                    else
                    {
                        Console.Write("Grade must be between 0 and 100. Enter grade: ");
                        success = double.TryParse(Console.ReadLine()!.Trim(), out doubleResult);
                    }
                }
                // asks user again if invalid input
                else
                {
                    Console.Write("Grade must be between 0 and 100. Enter grade: ");
                    success = double.TryParse(Console.ReadLine()!.Trim(), out doubleResult);
                }
            }

            // stores & tells user new grade data
            grades[result - 1] = doubleResult;
            Console.WriteLine($"\nReplacing the grade at index {result} with {grades[result - 1]}");

            // prints out all the final grades
            Console.WriteLine("\nFinal Grade Report:");
            PrintArray(titles, grades);
            // prints out final grade average
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"Final Average: {CalculateAverage(grades)}");

            // tells user the amount of grades above that average
            Console.WriteLine($"\n{AboveAverage(grades)} grades are above average.\n");

            // tells user their highest grade
            Console.WriteLine($"The highest grade is {LargestGrade(grades)}.");

            // tells user their lowest grade
            Console.WriteLine($"The lowest grade is {SmallestGrade(grades)}.");

            // tells user if there are any duplicate grades
            FindDuplicate(grades);
        }

        /// <summary>
        /// prints out all the assignment titles w/ their grades
        /// </summary>
        /// <param name="titles">assignment titles</param>
        /// <param name="grades">assignment grades</param>
        public static void PrintArray(string[] titles, double[] grades)
        {
            // prints out all the assignment titles w/ their grades
            for (int i = 0; i < titles.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {titles[i]}: {grades[i]}");
            }
        }

        /// <summary>
        /// finds the average of all the assignment grades
        /// </summary>
        /// <param name="grades">assignment grades</param>
        /// <returns>grade average</returns>
        public static double CalculateAverage(double[] grades)
        {
            // creates the grade sum variable 
            double sum = 0;
            // finds the average of all the assignment grades
            for (int i = 0; i < grades.Length; i++)
            {
                sum = sum + grades[i];
            }
            // returns the average
            return sum / grades.Length;
        }

        /// <summary>
        /// finds how many grades are above the average of the grades
        /// </summary>
        /// <param name="grades">assignment grades</param>
        /// <returns>count of above average grades</returns>
        public static int AboveAverage(double[] grades)
        {
            // creates the above average variable
            int above = 0;
            // checks one-by-one if the grade is above the average or not
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > CalculateAverage(grades))
                {
                    above++;
                }
            }
            // returns the count of above average grades
            return above;
        }

        /// <summary>
        /// finds the largest grade
        /// </summary>
        /// <param name="grades">assignment grades</param>
        /// <returns>largest grade</returns>
        public static double LargestGrade(double[] grades)
        {
            // makes the largest variable the first index of grades
            double largest = grades[0];
            // checks one by one if the next index is greater or not
            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i] > largest)
                {
                    largest = grades[i];
                }
            }
            // returns the largest of the grades
            return largest;
        }

        /// <summary>
        /// finds the smallest grade
        /// </summary>
        /// <param name="grades">assignment grades</param>
        /// <returns>smallest grade</returns>
        public static double SmallestGrade(double[] grades)
        {
            // makes the smallest variable the first index of grades
            double smallest = grades[0];

            // checks one by one if the next index is less or not
            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i] < smallest)
                {
                    smallest = grades[i];
                }
            }
            // returns the smallest of the grades
            return smallest;
        }

        /// <summary>
        /// finds if there are any duplicate grades
        /// </summary>
        /// <param name="grades">assignment grades</param>
        public static void FindDuplicate(double[] grades)
        {
            // sets the amount of copies to zero
            int copies = 0;
            // checks one-by-one if the assignment grades are equal to another
            for (int i = 1; i < grades.Length; i++)
            {
                if (grades[i  - 1] == grades[i])
                {
                    copies++;
                }
            }
            // tells user if there are duplicates or not
            if (copies == 0)
            {
                Console.WriteLine("\nAll grades are unique.");
            }
            else
            {
                Console.WriteLine("\nA grade appears more than once in this set of grades.");
            }
        }
    }
}

// Tyler Bye
// 10/25/2024
// Practical 1
namespace ByeT_Practical1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** VARIABLES ***
            int userInput = 0;
            float temperature = 0.0f;
            string[] months = { "January", "February", "March", "April" };

            // *** MAIN CODE ***
            // loops runs when user wants to keep selecting options
            while (userInput != 4)
            {
                userInput = GetMenuOption();
                Console.WriteLine();

                // test which option the user wants to run
                switch (userInput)
                {
                    // responds with a user given temperature
                    case 1:
                        // ask user for a float temperature
                        Console.Write("Enter a temperature: ");
                        temperature = float.Parse(Console.ReadLine()!.Trim());

                        // tests if the temperature given is chilly or warm
                        if (temperature <= 65 && temperature >= 50)
                        {
                            Console.WriteLine("Chilly\n");
                        }
                        else if (temperature > 65 && temperature < 75)
                        {
                            Console.WriteLine("Warm!\n");
                        }
                        // if out of range then program is unsure
                        else
                        {
                            Console.WriteLine("Unsure!\n");
                        }
                        break;
                    // tells user the sum of all the squared values of the first # of integers
                    case 2:
                        Console.WriteLine($"Sum of squares of first 1 integers is {SumSquares(1)}");
                        Console.WriteLine($"Sum of squares of first 2 integers is {SumSquares(2)}");
                        Console.WriteLine($"Sum of squares of first 5 integers is {SumSquares(5)}\n");
                        break;
                    // prints out the first 4 months in reverse index order & their last 3 characters
                    case 3:
                        for (int i = 3; i >= 0; i--)
                        {
                            Console.WriteLine($"Index {i} is {months[i]}");
                        }
                        for (int i = 0; i < months.Length; i++)
                        {
                            Console.WriteLine(months[i].Substring(months[i].Length - 3));
                        }
                        Console.WriteLine();
                        break;
                    // tells user goodbye and ends program
                    case 4:
                        Console.WriteLine("Goodbye!");
                        return;
                    // impossible to achieve: if invalid input, loops back to menu selection
                    default:
                        break;
                }
            }
        } // END MAIN

        /// <summary>
        /// Prints out various options for user to select from.
        /// </summary>
        /// <returns>int menu index</returns>
        public static int GetMenuOption()
        {
            int userInput;
            // prints out options
            Console.WriteLine("Select one of the following:\n" +
                "1. Get weather conditions\n" +
                "2. Sum the squares of first N numbers\n" +
                "3. Create, populate, and print an array\n" +
                "4. Quit");
            // ask user for which option they want & parses it to int
            Console.Write("Enter an option number (1-4): ");
            userInput = int.Parse(Console.ReadLine()!.Trim());

            // tests if option is within range & returns if valid
            while (userInput > 4 || userInput < 1)
            {
                Console.Write("Invalid option. Try Again: ");
                userInput = int.Parse(Console.ReadLine()!.Trim());
            }
            return userInput;
        }

        /// <summary>
        /// Adds the sum of the first number of integers squared.
        /// </summary>
        /// <param name="number">first number of integers</param>
        /// <returns>total sum</returns>
        public static int SumSquares(int number)
        {
            // sets sum as zero before adding
            int sum = 0;
            // loops all the squared integers and adds it to the total sum
            for (int i = 1; i > 0; i++)
            {
                if (number == 0)
                {
                    // returns the total sum of the squared integers
                    return sum;
                }
                else
                {
                    sum = sum + (int)Math.Pow(number, 2);
                    number--;
                }
            }
            // returns the total sum of the squared integers
            return sum;
        }
    } // END PROGRAM
}

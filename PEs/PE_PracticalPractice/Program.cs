// Tyler Bye
// 10/23/2024
// Practicing for the Practical Exam
using System.Xml.Linq;

namespace PE_PracticalPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** VARIABLES ***

            // *** MAIN CODE ***
            //
            Console.WriteLine($"1 - 3 = {Difference(1, 3)}");
            Console.WriteLine($"7 - 4 = {Difference(7, 4)}");
            Console.WriteLine($"-9 - 45 = {Difference(-9, 45)}");
            Console.WriteLine($"5 - 5 = {Difference(5, 5)}\n");

            //
            Console.WriteLine($"Is 5 >= 0? {GreaterThanOrEqualToZero(5)}");
            Console.WriteLine($"Is 0 >= 0? {GreaterThanOrEqualToZero(0)}");
            Console.WriteLine($"Is -2 >= 0? {GreaterThanOrEqualToZero(-2)}\n");

            //
            int largerNumber = GetserNumber();
            Console.WriteLine($"The new number is {largerNumber}.\n");

            //
            string formattedName = GetUserName();
            Console.WriteLine(formattedName);

            //
            Console.WriteLine($"\nLargest value is {FindMax(1, 2, 3, 4)}");
            Console.WriteLine($"Largest value is {FindMax(1.6, 2.294, 3.0, 4.21)}");
            Console.WriteLine($"Largest value is {FindMax(10, 10, 20, 10)}");
            Console.WriteLine($"Largest value is {FindMax(-2, -5, -8, -10)}\n");

            //
            double[] array1 = { 1, -2, 3, 4, 5 };
            if (FindMax(array1) == -1)
            {
                Console.WriteLine("Error: array was empty.\r\n");
            }
            else
            {
                Console.WriteLine($"Largest value is {FindMax(array1)}");
            }
            //
            double[] array2 = { 233454, 5 };
            if (FindMax(array2) == -1)
            {
                Console.WriteLine("Error: array was empty.\r\n");
            }
            else
            {
                Console.WriteLine($"Largest value is {FindMax(array2)}");
            }
            //
            double[] array3 = { 1 };
            if (FindMax(array3) == -1)
            {
                Console.WriteLine("Error: array was empty.\r\n");
            }
            else
            {
                Console.WriteLine($"Largest value is {FindMax(array3)}");
            }
            //
            double[] array4 = { };
            if (FindMax(array4) == -1)
            {
                Console.WriteLine("Error: array was empty.\r\n");
            }
            else
            {
                Console.WriteLine($"Largest value is {FindMax(array4)}");
            }

            //
            Console.WriteLine($"The middle of the \"{"testing"}\" is {GetMiddle("testing")}");
            Console.WriteLine($"The middle of the \"{"middle"}\" is {GetMiddle("middle")}");
            Console.WriteLine($"The middle of the \"{"A"}\" is {GetMiddle("A")}");
            Console.WriteLine($"The middle of the \"{"bb"}\" is {GetMiddle("bb")}");

            //
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <returns></returns>
        static public int Difference(int numberOne, int numberTwo)
        {
            return numberOne - numberTwo;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        static public bool GreaterThanOrEqualToZero(int number)
        {
            if (number >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        static public int GetserNumber()
        {
            //
            int result = -1;
            bool success = false;
            bool AskUser = true;

            //
            Console.Write("Enter a whole number: ");
            success = int.TryParse(Console.ReadLine()!.Trim(), out result);

            // 
            while (AskUser)
            {
                //
                if (success)
                {
                    // 
                    if (result > 0 && result < 100)
                    {
                        AskUser = false;
                    }
                    else
                    {
                        Console.Write("Invalid number. Try again: ");
                        success = int.TryParse(Console.ReadLine()!.Trim(), out result);
                    }
                }
                else
                {
                    Console.Write("Invalid number. Try again: ");
                    success = int.TryParse(Console.ReadLine()!.Trim(), out result);
                }
            }

            //
            return result + 10;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        static public string GetUserName()
        {
            //
            string userInput;
            string lastLetter;
            
            //
            Console.Write("What is your name? ");
            userInput = Console.ReadLine()!.Trim();

            if (userInput.Length < 1)
            {
                return "ERROR: Provided string was empty.";
            }
            else
            {
                //
                lastLetter = userInput.Substring(userInput.Length - 1).ToUpper();

                //
                return "Your name is now " + 
                    (userInput.Remove(userInput.Length - 1) + lastLetter);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <param name="three"></param>
        /// <param name="four"></param>
        /// <returns></returns>
        static public double FindMax(double one, double two, double three, double four)
        {
            return Math.Max(one, Math.Max(two, Math.Max(three, four)));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static public double FindMax(double[] array)
        {
            //
            double largest = 0;

            //
            if (array.Length < 1)
            {
                return -1;
            }
            else
            {
                for (int i = 1; i < array.Length; i++)
                {
                    largest = Math.Max(array[i - 1], array[i]);
                }

                //
                return largest;
            }
        }

        static public string GetMiddle(string word)
        {
            double middle = word.Length / 2;

            if (word.Length == 1)
            {
                return word;
            }
            else if (Math.Floor(middle) == Math.Ceiling(middle))
            {
                return word.Substring((int)middle, (int)middle);
            }
            else
            {
                return word.Substring((int)Math.Floor(middle), (int)Math.Floor(middle)) +
                    word.Substring((int)Math.Ceiling(middle), (int)Math.Ceiling(middle));
            }
        }

        static public string Uncensor(string input)
        {
            return "hi";
        }
    }
}

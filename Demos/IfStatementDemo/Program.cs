/* Tyler Bye
 * 09/20/2024
 * Learning If Statements */

namespace IfStatementDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** ALL VARIABLES USED ***
            const int correctNumber = 7;
            
            // asks user for a number & parses it 
            Console.Write("Give me a whole number between 1 and 10: ");
            string userInput = Console.ReadLine()!;
            int userNumber = int.Parse(userInput);

            // ask user to choose between three colors
            Console.Write("Choose a color from red, green, & blue: ");
            string userColor = Console.ReadLine()!.ToLower().Trim();

            // sees what color the user choose & changes color to that
            if (userColor == "red")
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (userColor == "green")
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (userColor == "blue")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }

            // sees if the user guessed the number above correctly & print accordingly 
            if (userNumber == correctNumber)
            {
                Console.WriteLine("CONGRADULATIONS! You gussed the number correctly!");
            }
            if (userNumber < correctNumber)
            {
                Console.WriteLine("SORRY! You guessed a number too low! :(");
            }
            if (userNumber > correctNumber)
            {
                Console.WriteLine("SORRY! You guessed a number too high ! :(");
            }
        }
    }
}

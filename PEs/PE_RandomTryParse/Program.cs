// Tyler Bye
// 10/23/2024
// Number Guessing Game
namespace PE_RandomTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** PSEUDOCODE ***
            /*
             * Initialize variables & print the SECRETNUMBER
             * 
             * FOR 5 Attempts ASK user for a number
             *      ASK user for a number
             *      TRYPARSE the user's input
             *      
             *      IF parsable
             *          IF user guessed correctly
             *              PRINT correct & exit program
             *          ELSE IF the attempts are equal to 8
             *              PRINT that they ran out of attempts
             *          ELSE IF the guess is too high
             *              PRINT too high
             *          ELSE IF the guess is too low
             *              PRINT too low
             *      ELSE if not parsable
             *          PRINT invalid
             *          redo the attempt
             */

            // *** VARIABLES ***
            int result = -1;
            bool success = false;
            Random rng = new Random();
            int secretNumber = rng.Next(0, 101);
            int attemptNumber;

            // *** MAIN CODE ***
            // prints the random number (for testing purposes)
            Console.WriteLine($"Random Number: {secretNumber}");

            // loops until user guesses the number correctly or they run out of turns
            for (attemptNumber = 1; attemptNumber <= 8; attemptNumber++)
            {
                // asks user to guess a number & tries parsing the input
                Console.Write($"\nTurn #{attemptNumber}: Enter your guess: ");
                success = int.TryParse(Console.ReadLine()!.Trim(), out result);

                // tests if the input is parsable
                if (success)
                {
                    // test if the user guessed correctly
                    if (result == secretNumber)
                    {
                        Console.WriteLine($"Correct! You won in {attemptNumber} turns.");
                        return;
                    }
                    else if (attemptNumber == 8)
                    {
                        // tells user they ran out of turns
                        Console.WriteLine($"\nYou ran out of turns. " +
                            $"The number was {secretNumber}.");
                    }
                    // tests if the guess is too high or low
                    else if (result > secretNumber)
                    {
                        Console.WriteLine("Too High.");
                    }
                    else if (result < secretNumber)
                    {
                        Console.WriteLine("Too Low.");
                    }
                }
                // prints if the input is not parsable
                else
                {
                    Console.WriteLine("Invalid guess – try again!");
                    attemptNumber--;
                }
            }

        }
    }
}

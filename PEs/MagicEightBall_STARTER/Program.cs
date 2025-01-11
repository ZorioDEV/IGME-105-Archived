
// Tyler Bye 
// 11/03/24
// Making an 8ball 





namespace MagicEightBall_STARTER
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ----------------------------------------------------------------
            // Variable declaration block
            // ----------------------------------------------------------------
            string userChoice = "";
            string owner = "";

            // ********************************************
            // TODO: Declare a MagicEightBall object here!
            // ********************************************
            MagicEightBall MyMagicEightBall;

            // ----------------------------------------------------------------
            // Introduction to the program
            // ----------------------------------------------------------------
            // Initial welcome statement
            Console.WriteLine("Welcome to the Magic 8 Ball simulator!");
            Console.Write("Who owns this ball? ");
            owner = Console.ReadLine();

            // **************************************************
            // TODO: Initialize the MagicEightBall object here!
            // **************************************************
            MyMagicEightBall = new MagicEightBall(owner);

            // ----------------------------------------------------------------
            // Loop to play the game!
            // ----------------------------------------------------------------
            // Menu item that loops based on user's choice
            do
            {
                // First, present user with their options
                Console.WriteLine();
                Console.WriteLine("What would you like to do?");
                Console.Write("You can 'shake' the ball, get a 'report', or 'quit': ");
                userChoice = Console.ReadLine().Trim().ToLower();

                // Depending on their choice, run the corresponding code...
                switch (userChoice)
                {
                    case "shake":
                        // Get the user's question
                        Console.Write(
                            $" > {owner}, what is your question? ");
                        string userQuestion = Console.ReadLine();

                        // Start the answer in white
                        // And print the user's question in yellow
                        Console.Write(
                            $" > Let's see what the ball says to ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(
                            $" \"{userQuestion}\"...");

                        // Start the response in cyan
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        // *************************************************
                        // TODO: Call ShakeBall() and print results of returned string!
                        // *************************************************
                        Console.WriteLine();
                        Console.WriteLine(MyMagicEightBall.ShakeBall());


                        // Return text to white for next prompt
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    case "report":

                        // Start the response in cyan
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        // *************************************************
                        // TODO: Call Report() and print results of returned string!
                        // *************************************************
                        Console.WriteLine(MyMagicEightBall.Report());


                        // Return text to white for next prompt
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    case "quit":
                        // Start the response in cyan
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        // Print a goodbye message
                        Console.WriteLine(
                            $"Goodbye {owner}! Thanks for playing!");

                        // Return text to white for next prompt
                        Console.ForegroundColor = ConsoleColor.White;
                        break;

                    default:
                        // Print an "unrecognized" message
                        Console.WriteLine(
                            $" > {owner}, I do not recognize that response.");
                        break;
                }
            }
            while (userChoice != "quit");
        }
    }
}
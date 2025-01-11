// Tyler Bye
// 10/04/2024
// Learning For Loops
using System.Runtime.Intrinsics.Arm;

namespace PE_ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** VARIABLES ***
            int number = 0;
            string userInput;
            bool askUser = false;
            int width;
            int height;
            int column;
            int row;

            // *** MAIN CODE ***
            // --- FIRST SECTION ---
            // prints the numbers 0-10 using a while loop
            Console.WriteLine("0–10 While:");
            while (number < 11)
            {
                Console.Write(number + " ");
                number++;
            }

            // prints the numbers 0-10 using a do-while loop
            number = 0;
            Console.WriteLine("\n\n0–10 Do-While:");
            do
            {
                Console.Write(number + " ");
                number++;
            } while (number < 11);

            // prints the numbers 0-10 using a for loop
            Console.WriteLine("\n\n0–10 For:");
            for (number = 0; number < 11; number++)
            {
                Console.Write(number + " ");
            }

            // prints the numbers 100-90 backwards using a for loop
            Console.WriteLine("\n\n100–90 For:");
            for (number = 100; number > 89; number--)
            {
                Console.Write(number + " ");
            }

            // prints the numbers 0-50 by 5 using a for loop
            Console.WriteLine("\n\nMultiples of 5 For:");
            for (number = 0; number < 51; number += 5)
            {
                Console.Write(number + " ");
            }

            // prints the numbers 0-20 excluding multiples of 5 using a for loop
            Console.WriteLine("\n\nSkip Multiples of 5 For:");
            for (number = 0; number < 21; number++)
            {
                if (number % 5 == 0)
                {
                    continue;
                }
                Console.Write(number + " ");
            }

            // --- SECOND SECTION ---
            // divider for formating
            Console.WriteLine();
            for (number = 0; number < 61; number++)
            {
                Console.Write("-");
            }

            // loops after art, if user doesn't type ‘quit’
            while (true)
            {
                // asks user if they want to draw 
                Console.Write("\n\nWant to draw art? ");
                do
                {
                    // gives the user the valid options
                    Console.Write("Enter ‘continue’ or ‘quit’: ");
                    userInput = Console.ReadLine()!.Trim().ToLower();

                    // if user types ‘quit’ the program ends
                    if (userInput == "quit")
                    {
                        Console.WriteLine("Okay, goodbye!");
                        return;
                    }
                    // if user types 'continue' the art begins
                    else if (userInput == "continue")
                    {
                        askUser = true;
                        // asks user for a width 
                        Console.Write("\n\nEnter a width (3 or more): ");
                        userInput = Console.ReadLine()!.Trim();
                        width = int.Parse(userInput);
                        // if the input is invalid, asks the user again
                        while (width < 3)
                        {
                            Console.Write("Number must be 3 or greater. Enter a width: ");
                            userInput = Console.ReadLine()!.Trim();
                            width = int.Parse(userInput);
                        }

                        // asks user for a height
                        Console.Write("\n\nEnter a height (3 or more): ");
                        userInput = Console.ReadLine()!.Trim();
                        height = int.Parse(userInput);
                        // if the input is invalid, asks the user again
                        while (height < 3)
                        {
                            Console.Write("Number must be 3 or greater. Enter a height: ");
                            userInput = Console.ReadLine()!.Trim();
                            height = int.Parse(userInput);
                        }

                        // prints a rectangle of 'O's
                        Console.WriteLine();
                        for (column = 0; column < height; column++)
                        {
                            for (row = 0; row < width; row++)
                            {
                                Console.Write("O");
                            }
                            Console.WriteLine();
                        }

                        // prints a rectangle of 'O's with a hollow center
                        Console.WriteLine();
                        for (column = 0; column < height; column++)
                        {
                            // prints the top & bottom of the rectangle
                            if (column == 0 || column == (height - 1))
                            {
                                for (row = 0; row < width; row++)
                                {
                                    Console.Write("O");
                                }
                            }
                            // prints the sides of the rectangle
                            else
                            {
                                Console.Write("O");
                                for (row = 1; row < (width - 1); row++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write("O");
                            }
                            Console.WriteLine();
                        }
                    }
                    // if invalid the loop restarts & asks user again
                    else
                    {
                        Console.Write("I don’t recognize that. ");
                        askUser = false;
                    }
                } while (!askUser);

            }
        }
    }
}

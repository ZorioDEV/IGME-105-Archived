﻿namespace GDAPS_DebuggingStarter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable block
            string userNumber1AsString = "";
            string userNumber2AsString = "";
            string userAngleAsString = "";
            string userName = "";
            string newName = "";
            int userNumber1AsInt = 0;
            int userNumber2AsInt = 0;
            int userAngleAsInt = 0;
            double percentage;
            double sineOfAngle = 0;
            double userAngleAsRad = 0;


            // Ask the user for:
            //   1. number between 1 and 100
            //   2. number between 1 and 9 over 10
            // This program calculates X percentage of the first given number
            //   where the second number is a percentage from 0 to 100%.
            Console.WriteLine("Hi there! This is the percent calculator.");
            Console.WriteLine("Give me a number and I'll calculate it to your given percentage.");
            Console.WriteLine();
            Console.Write("First, enter a number between 1 and 100: ");
            userNumber1AsString = Console.ReadLine()!;
            userNumber1AsInt = int.Parse(userNumber1AsString);
            Console.Write("Now, enter a number between 1 and 9: ");
            userNumber2AsString = Console.ReadLine()!;
            userNumber2AsInt = int.Parse(userNumber2AsString);
            percentage = userNumber2AsInt / 10.0;

            // Perform necessary math on it!
            double userNumberAsPercentage = userNumber1AsInt * percentage;
            Console.WriteLine(
                $"{percentage * 100.0}% of " +                  // Prints out of 100% (20%)
                $"{userNumber1AsString} is " +         // User's chosen starting value (50)
                $"{userNumberAsPercentage}");          // Product (10)

            // Blank line for readable formatting
            Console.WriteLine();

            // Ask user for degrees
            // Tell the user the equivalent number of radians
            // Find the sin of the user's angle
            Console.WriteLine("Great! Now let's determine some trigonometry.");
            Console.Write("Give me a whole angle in degrees, and I'll tell you the sine! ");
            userAngleAsString = Console.ReadLine()!;
            userAngleAsInt = int.Parse(userAngleAsString);
            userAngleAsRad = userAngleAsInt * (Math.PI / 180);
            sineOfAngle = Math.Sin(userAngleAsRad);

            Console.WriteLine(
                "Converting to radians... " +                       //
                $"{userAngleAsInt} degrees is " +                   // 60 degrees
                $"{userAngleAsRad} radians.");      // 1.0471975511965976 radians

            Console.WriteLine(
                $"The sine of " +
                $"{Math.Round(userAngleAsRad,2)} radians is " +                   // 1.05 radians
                $"{Math.Round(sineOfAngle, 3)}");                   // 0.866


            // Blank line for readable formatting
            Console.WriteLine();

            // Ask user for their name
            // Change their name by placing the first character on the end
            //   like so:  Charlotte becomes harlotteC
            Console.WriteLine("Lastly, tell me your name!");
            userName = Console.ReadLine()!.Trim();                           // Emily
            newName = userName.Substring(1) + userName[0];    // milyE
            Console.WriteLine("I will rename you " + newName + "!");
            Console.WriteLine();

            // Goodbye!
            Console.WriteLine($"Thanks for playing my game!  Have a great day {newName} !");
        }
    }
}
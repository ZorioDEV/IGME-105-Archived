// Tyler Bye
// 10/09/2024
// HW 3: Golf & Superman
namespace ByeT_HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // --- PART ONE ---
            // *** PSEUDOCODE ***
            /*
            delcare & initialize all variables

            print a welcoming to Artillery Golf & tell user TARGETDISTANCE
            FOR 5 attempts & when USERGUESS is false
                ASK user for an angle & test if valid
                    IF between 0 and 90, then stop asking
                ASK user for an velocity & test if valid
                    IF positive, then stop asking

                convert angle into radians
                calculate FLIGHTTIME w/ formula given
                calculate USERDISTANCE & DISTANCEAWAY

                print out all information and users distance

                IF DISTANCEAWAY is within -0.5 & 0.5
                    print congratulate & a thank you
                ELSE IF they are on attempt 5
                    print a thank you 
                ELSE
                    print that they missed & try again
            */

            // *** VARIABLES ***
            bool userGuess = false;
            int attemptNumber;
            bool askUser = false;
            string userInput;
            double userAngle = 0;
            double userVelocity = 0;
            double userAngleInRad;
            double flightTime;
            double userDistance;
            const double cannonBarrel = 2.0;
            const double targetDistance = 751;
            double distanceAway;

            // *** MAIN CODE ***
            // header & tells user the target goal 
            Console.WriteLine("Welcome to Artillery Golf!");
            Console.WriteLine($"Your goal is to hit a target {targetDistance} " +
                $"meters away within 5 shots.");

            // loops 5 times or when user guessed correctly
            for (attemptNumber = 1; !userGuess && attemptNumber <= 5; attemptNumber++)
            {
                // tells user what attempt they are on
                Console.WriteLine($"\nAttempt {attemptNumber} ----------------------------------");
                // ask user for an angle
                while (!askUser)
                {
                    Console.Write("Enter the cannon’s angle (between 0 and 90 degrees): ");
                    userInput = Console.ReadLine()!.Trim();
                    userAngle = double.Parse(userInput);

                    // test if the input is valid
                    if (userAngle > 0 && userAngle < 90)
                    {
                        askUser = true;
                    }
                    else
                    {
                        Console.WriteLine("That is an invalid angle.");
                    }
                }

                // resets ASKUSER & formats
                askUser = false;
                Console.WriteLine();

                // ask user for an velocity
                while (!askUser)
                {
                    Console.Write("Enter the cannonball’s initial velocity (a positive number): ");
                    userInput = Console.ReadLine()!.Trim();
                    userVelocity = double.Parse(userInput);

                    // test if the input is valid
                    if (userVelocity > 0)
                    {
                        askUser = true;
                    }
                    else
                    {
                        Console.WriteLine("That is an invalid velocity.");
                    }
                }

                // resets ASKUSER & formats
                askUser = false;
                Console.WriteLine();

                // convert angle into radians
                userAngleInRad = (userAngle * Math.PI) / 180;
                // calculate FLIGHTTIME w/ formula given
                flightTime = (userVelocity * Math.Sin(userAngleInRad) + 
                    Math.Sqrt(Math.Pow(userVelocity, 2) * Math.Pow(Math.Sin(userAngleInRad), 2)
                    + 20.0 * cannonBarrel * Math.Sin(userAngleInRad))) / 10.0;
                // calculate USERDISTANCE & DISTANCEAWAY
                userDistance = (userVelocity * Math.Cos(userAngleInRad) * flightTime);
                distanceAway = userDistance - targetDistance;

                // print out all information and users distance
                Console.WriteLine($"A cannonball fired with an initial velocity of " +
                    $"{userVelocity} m/s, at an angle of {userAngle} degrees from the " +
                    $"\nground, will strike the ground {userDistance} meters away.");
                Console.Write($"The shot is {distanceAway} meters from the target. ");

                // tests if the users is within a certain distance
                if (distanceAway < 0.5 && distanceAway > -0.5)
                {
                    // congratulates user
                    Console.Write("A successful hit!");
                    Console.WriteLine("\n\nThanks for playing the Golf game!");
                    userGuess = true;
                }
                else if (attemptNumber == 5)
                {
                    // if user ran out of attempts
                    Console.WriteLine("\n\nRan out of attempts, but thanks for playing" +
                        " the Golf game!");
                }
                else
                {
                    // tells user to try again
                    Console.Write("Try again!\n");
                }
            }

            // --- PART TWO ---
            // *** PSEUDOCODE ***
            /*
            delcare & initialize new variables

            print a welcoming to Superman & tell user situation/info

            WHILE they want to keep playing
                ASK for a positive number of gravity
                    IF positive, then calculate initial velocity & tell user
                    ELSE try again
                ASK if they want to play again
                    IF yes, then rerun
                    ELSE IF no, then end loop
                    ELSE try again
            print a thank you 
            */

            // *** NEW VARIABLES ***
            const int buildingHeight = 660;
            bool runAgain = false;
            double userGravity;
            double initialVelocity;

            // *** MAIN CODE ***
            // resets ASKUSER & formats
            askUser = false;
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------------");
            // header & tells user conditions and info
            Console.WriteLine("Welcome to Superman!");
            Console.WriteLine($"Your goal is to find the initial velocity required for leaping " +
                $"over a {buildingHeight} foot tall\nbuilding on different planets.");
            Console.WriteLine("\nPlease enter the gravitational constant for the planet on which " +
                "Superman is currently \nattempting this jump. Units must be in feet/second^2.\n");

            // runs while user wants to play
            while (!runAgain)
            {
                // asks user for gravity & parses it
                while (!askUser)
                {
                    Console.Write("Gravitational constant (a positive number): ");
                    userInput = Console.ReadLine()!.Trim();
                    userGravity = double.Parse(userInput);

                    // tests if user input is positive 
                    if (userGravity > 0)
                    {
                        // calculates initial velocity
                        initialVelocity = Math.Sqrt(2 * userGravity * buildingHeight);
                        askUser = true;

                        // tells user what superman would need to jump w/ user gravity
                        Console.WriteLine($"Superman must jump with an initial velocity of at " +
                            $"least {initialVelocity} feet/second.");
                    }
                    else
                    {
                        Console.WriteLine("That is an invalid value.");
                    }
                }

                // resets ASKUSER & formats
                askUser = false;
                Console.WriteLine();

                // asks user if they want to keep playing
                while (!askUser)
                {
                    Console.Write("Want to try again? Enter ‘yes’ or ‘no’ to continue: ");
                    userInput = Console.ReadLine()!.Trim().ToLower();

                    // ends current loop
                    if (userInput == "yes")
                    {
                        askUser = true;
                    }
                    // ends both loops
                    else if (userInput == "no")
                    {
                        runAgain = true;
                        askUser = true;
                    }
                    // reasks loop if invalid
                    else
                    {
                        Console.WriteLine("I don’t recognize that response.");
                    }
                }

                // resets ASKUSER & formats
                askUser = false;
                Console.WriteLine();
            }

            // when loop ends, thank user
            Console.WriteLine("Thanks for playing the Superman game!");
        }
    }
}

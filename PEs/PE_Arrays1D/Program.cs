// Tyler Bye 
// 10/09/2024
// 1-Dimensional Arrays
namespace PE_Arrays1D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** PSEUDOCODE ***
            /*
            delcare & initialize all variables

            print header for monster types
            FOR loop that prints out each array value for monster types 
            print header for monster levels
            FOR loop that prints out each array value for monster levels 
            print header for monster loot
            FOR loop that prints out each array value for monster loot 

            print header for increased monster levels 
            FOR loop that prints out each array value for increased monster levels
            print header for decreased monster loot
            FOR loop that prints out each array value for decreased monster loot 

            FOR loop that prints out the added total of all the decreased monster loot

            WHILE the user has an invalid input loop the question
                print the question
                collect the user input and parse it to int for array value
                IF the value is within range for monster type

                    print the corresponding value for monster type
                    make the while input value true 

                    IF the value is within range for monster level
                        print the corresponding value for monster level
                    ELSE

                        print that its out of range for monster level
                    IF the value is within range for monster loot
                        print the corresponding value for monster loot
                    ELSE
                        print that its out of range for monster loot

                ELSE 
                    print that the value is invalid
            */

            // *** VARIABLES ***
            string[] monsterTypes = { "Goblin", "Orc", "Skeleton", "Dragon", "Troll" };
            int[] monsterLevels = { 1, 5, 2, 10, 6, 12 };
            double[] monsterLoot = { 15.5, 50, 8.25, 200 };
            int arrayCount = 0;
            double totalLoot = 0;
            string userInput;
            int userIndex;
            bool askUser = false;

            // *** MAIN CODE ***
            // header for monster types
            Console.WriteLine("Monster Types:");
            // prints out each array value for monster types
            for (arrayCount = 0; arrayCount < monsterTypes.Length; arrayCount++)
            {
                Console.WriteLine($"- {monsterTypes[arrayCount]}");
            }

            // resets count to 0 & formats 
            arrayCount = 0;
            Console.WriteLine();

            // header for monster levels
            Console.WriteLine("Monster Levels:");
            // prints out each array value for monster levels
            for (arrayCount = 0; arrayCount < monsterLevels.Length; arrayCount++)
            {
                Console.WriteLine($"- {monsterLevels[arrayCount]}");
            }

            // resets count to 0 & formats 
            arrayCount = 0;
            Console.WriteLine();

            // header for monster loot
            Console.WriteLine("Monster Loot:");
            // prints out each array value for monster loot
            for (arrayCount = 0; arrayCount < monsterLoot.Length; arrayCount++)
            {
                Console.WriteLine($"- {monsterLoot[arrayCount]}");
            }

            // resets count to 0 & formats 
            arrayCount = 0;
            Console.WriteLine();

            // header for increased monster levels
            Console.WriteLine("Values after monster levels increase:");
            // prints out each array value for increased monster levels
            for (arrayCount = 0; arrayCount < monsterLevels.Length; arrayCount++)
            {
                monsterLevels[arrayCount] = (monsterLevels[arrayCount] + 1);
                Console.WriteLine($"- {monsterLevels[arrayCount]}");
            }

            // resets count to 0 & formats 
            arrayCount = 0;
            Console.WriteLine();

            // header for decreases monster loot
            Console.WriteLine("Values after monster loot decreases by half:");
            // prints out each array value for decreases monster loot
            for (arrayCount = 0; arrayCount < monsterLoot.Length; arrayCount++)
            {
                monsterLoot[arrayCount] = (monsterLoot[arrayCount] / 2);
                Console.WriteLine($"- {monsterLoot[arrayCount]}");
            }

            // resets count to 0 & formats 
            arrayCount = 0;
            Console.WriteLine();

            // adds total of all the decreased monster loot one by one
            for (arrayCount = 0; arrayCount < monsterLoot.Length; arrayCount++)
            {
                totalLoot = totalLoot + monsterLoot[arrayCount];
            }
            // prints out the total & formats
            Console.WriteLine($"The sum of all monster loots is {totalLoot}");
            Console.WriteLine();

            // repeats until the input is valid & ASKUSER is true
            while (!askUser)
            {
                // asks the user to give an index value & parses it
                Console.Write("Enter an index: ");
                userInput = Console.ReadLine()!.Trim();
                userIndex = int.Parse(userInput);

                // tests if the value is within range for monster type
                if (userIndex >= 0 && userIndex < monsterTypes.Length)
                {
                    Console.WriteLine($"The monster type is {monsterTypes[userIndex]}");
                    askUser = true;
                    // tests if the value is within range for monster levels
                    if (userIndex >= 0 && userIndex < monsterLevels.Length)
                    {
                        Console.WriteLine($"The monster level is {monsterLevels[userIndex]}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot retrieve monster level. " +
                            $"There are {monsterLevels.Length} values in that array.");
                    }
                    // tests if the value is within range for monster loot
                    if (userIndex >= 0 && userIndex < monsterLoot.Length)
                    {
                        Console.WriteLine($"The monster loot is {monsterLoot[userIndex]}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot retrieve monster level. " +
                            $"There are {monsterLoot.Length} values in that array.");
                    }
                }
                // tells user their input is invalid and repeats question
                else
                {
                    Console.WriteLine("That is an invalid value. Try again.");
                }
            }

        }
    }
}

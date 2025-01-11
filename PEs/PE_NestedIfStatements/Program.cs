// Tyler Bye
// 9/25/2024
// Using simple AI w/ nested if statements
namespace PE_NestedIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** ALL VARIABLES USED ***
            string userInput;

            // asks user what the adventure sees & allows them to select a sight
            Console.WriteLine("Character: Adventurer");
            Console.WriteLine();
            Console.WriteLine("While traveling the adventurer stumbles across 3 different sights:");
            Console.WriteLine("Floating Islands, Mirror Lake, and Whispering Caves");
            Console.Write("Which sight will the adventurer explore? (islands/lake/caves): ");
            userInput = Console.ReadLine()!.ToLower().Trim();
            Console.WriteLine();

            // *** PSEUDOCODE ***
            /*
            adventurer sees 3 places & user decides

            islands -> adventurer finds something cool (ancient city)
            lake -> adventurer finds something cool (creepy ghost)
            caves -> given two options (left/right) 
                right -> adventurer finds something cool (treasure)
                left -> adventurer finds something not cool (trap)
                invalid -> goes home
            invalid -> goes home
            */

            // depending on the user input the adventurer goes to one of the sights
            if (userInput == "islands")
            {
                Console.WriteLine("The adventurer discovers an ancient city " +
                    "suspended in the sky, thrumming with forgotten magic.");
            }
            else if (userInput == "lake")
            {
                Console.WriteLine("The adventurer watches their reflection " +
                    "reach out and, with a ghostly smile, \nbeckon them into an " +
                    "inverted world beneath the water's surface.");
            }
            else if (userInput == "caves")
            {
                // in the caves the adventurer is met w/ a difficult left or right path
                Console.WriteLine("The adventurer steps into the cavern, the walls " +
                    "begin to murmur secrets in voices long forgotten.");
                Console.Write("The caves split off into 2 paths! (right/left): ");
                userInput = Console.ReadLine()!.ToLower().Trim();
                Console.WriteLine();

                if (userInput == "right")
                {
                    Console.WriteLine("The path reveals a buried treasure!");
                }
                else if (userInput == "left")
                {
                    Console.WriteLine("The path leaves to a spike trap!");
                }
                // if input doesn't match required strings, adventurer goes home
                else
                {
                    Console.WriteLine("[Invalid Input]: The adventurer returns " +
                    "home with no stories to tell of.");
                }
            }
            // if input doesn't match required strings, adventurer goes home
            else
            {
                Console.WriteLine("[Invalid Input]: The adventurer returns " +
                    "home with no stories to tell of.");
            }
        }
    }
}

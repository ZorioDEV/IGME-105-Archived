// Tyler Bye
// 09/29/2024
// Play Choice Storytelling
// NOTE: used ChatGPT for story generation
namespace ByeT_HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** PSEUDOCODE ***
            /* 
            Declare and initialize all player choice variables here
            Declare and initialize other necessary variables for the story

            // Scene 1
            Print scene 1’s initial story and 2 options

            Get the input from the user and save in an input variable
            Sanitize the user input

            Use a SWITCH to determine which option was chosen
                With each valid option:
                    Print out a message about the option
                    IF the option should modify a variable:
                        Change a variable
                IF the user’s input was invalid
                    Print an error message and exit console

            // Scene 2
            Print scene 2’s initial story and 2 options
            IF you need to print an extra option (based on a player 
            choice variable changed by scene 1)
                Print the extra option

            Get the input from the user and save in an input variable
            Sanitize the user input

            Use a SWITCH to determine which option was chosen
                With each valid option:
                    Print out a message about the option
                    IF the option should modify a variable:
                        Change a variable
                IF the user’s input was invalid
                    Print an error message and exit console

            // Scene 3
            Print scene 3’s initial story

            Use a series of compound if/else if blocks to determine which 
            of at least 4 different endings is printed.
             */

            // *** VARIABLES ***
            string userInput;
            int playerChoice1 = 0;
            int playerChoice2 = 0;
            double playerHealth = 0.5;
            bool hasRelic = false;
            bool hasOrb = false;
            int choiceNumber;

            // *** MAIN CODE ***
            // formating for scene 1 & player's current health
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Scene 1 - Tree of Ages\n");
            Console.WriteLine($"HEALTH: {playerHealth.ToString("P0")}\n");

            // introduction w/ two paths for the user to choose from
            Console.WriteLine(
                "A seasoned adventurer stood before the ancient Tree of Ages deep within the \n" +
                "forest, his heart racing as the legend of a powerful relic whispered in his \n" +
                "mind. The air was thick with anticipation, and the forest seemed to hold its \n" +
                "breath as he approached the tree, where two paths revealed themselves: a \n" +
                "dark, glowing tunnel beneath the earth and a spiral staircase of roots and \n" +
                "stone leading into the misty treetops.\n");
            Console.Write("Which path should the adventurer take? (TUNNEL/STAIRCASE): ");
            userInput = Console.ReadLine()!.ToLower().Trim();

            // test users option for scene 1
            switch (userInput)
            {
                // continues into tunnel & losses half their heal, but gains relic
                case "tunnel":
                    Console.WriteLine(
                        "\nThe adventurer ventured into the tunnel, its cold, damp air \n" +
                        "chilling them to the bone. The further they descended, the stronger \n" +
                        "the eerie light pulsed, revealing ancient carvings on the walls. \n" +
                        "Suddenly, the ground trembled, and the tunnel collapsed behind them, \n" +
                        "trapping them inside. Pressing on, the adventurer discovered a hidden\n" +
                        "chamber where the relic lay atop an altar. The relic’s power was \n" +
                        "real, but it came at a cost.\n");
                    hasRelic = true;
                    playerHealth = (playerHealth / 2);
                    Console.WriteLine($"HEALTH: {playerHealth.ToString("P0")}");
                    playerChoice1 = 1;
                    break;
                // continues up the staircase, health set to 100%, & gains orb
                case "staircase":
                    Console.WriteLine(
                        "\nThe adventurer ascended the spiraling staircase, the mist \n" +
                        "thickening with each step until the world below disappeared. As they \n" +
                        "reached the treetop, they found a hidden sanctuary bathed in golden \n" +
                        "light, where time seemed to slow. At the heart of the sanctuary stood\n" +
                        "a glowing orb, pulsing with life. Upon touching it, the adventurer’s \n" +
                        "vision filled with the knowledge of the forest—its history, its \n" +
                        "secrets, and its untapped power.\n");
                    playerHealth = 1;
                    Console.WriteLine($"HEALTH: {playerHealth.ToString("P0")}");
                    hasOrb = true;
                    playerChoice1 = 2;
                    break;
                // if invalid response, ends game & program
                default:
                    Console.WriteLine("\nInvalid choice. Gameover.");
                    Console.WriteLine("Press any key to continue . . .");
                    return;

            
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            // formating for scene 2 & player's current health
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Scene 2 - Mirror Lake\n");
            Console.WriteLine($"HEALTH: {playerHealth.ToString("P0")}\n");

            // introduction w/ two paths for the user to choose from
            Console.WriteLine(
                "In the dim glow of dawn, the adventurer stood at the edge of a vast, \n" +
                "mist-covered lake, its still surface reflecting the sky like a mirror. Across\n" +
                "the water, a distant island rose, shrouded in mystery with towering spires \n" +
                "of stone and strange, twisting trees. Legends told of an ancient being that \n" +
                "guarded the island — a creature neither friend nor foe, but one whose favor \n" +
                "or fury could decide the fate of anyone who dared approach. The only way \n" +
                "forward was a rickety wooden boat tied to the shore, its weathered boards \n" +
                "creaking as the adventurer stepped inside.\n");
            Console.WriteLine("OPTIONS: ");
            Console.WriteLine("1. Row toward the island, risking the creature’s wrath.");
            Console.WriteLine("2. Call out to the creature, attempting to make peaceful" +
                "\ncontact before crossing.");

            // gives user extra options if they have the orb or relic from scene 1
            if (hasOrb)
            {
                Console.WriteLine("3. Use the relic's power to summon a hidden passage" +
                    "\nbeneath the lake.");
            }
            else if (hasRelic)
            {
                Console.WriteLine("3. Commune with the forest through the orb, seeking" +
                    "\nguidance on how to safely reach the island.");
            }

            // asks user which path they want & parses it 
            Console.Write("\nWhich path should the adventurer take? (1/2/3): ");
            userInput = Console.ReadLine()!.Trim();
            choiceNumber = int.Parse(userInput);

            // test users option for scene 2
            switch (choiceNumber)
            {
                // continues on boat & losses 1/5 of players current health
                case 1:
                    Console.WriteLine(
                        "\nAs the adventurer paddled across the lake, the water erupted in a \n" +
                        "spray of scales and claws, revealing the ancient guardian. In a \n" +
                        "fierce battle for survival, the adventurer narrowly escaped with \n" +
                        "their life, forever marked by the creature’s fury and the island’s \n" +
                        "secrets.\n");
                    playerHealth = (playerHealth / 5);
                    Console.WriteLine($"HEALTH: {playerHealth.ToString("P0")}");
                    playerChoice2 = 1;
                    break;
                // continues to call creature (health doesn't change)
                case 2:
                    Console.WriteLine(
                        "\nThe adventurer’s voice echoed across the lake, and to their \n" +
                        "surprise, the creature emerged from the depths, intrigued rather \n" +
                        "than hostile. A conversation blossomed, revealing the guardian’s \n" +
                        "wisdom and granting safe passage to the island in exchange for a \n" +
                        "promise to protect its secrets.\n");
                    Console.WriteLine($"HEALTH: {playerHealth.ToString("P0")}");
                    playerChoice2 = 2;
                    break;
                // continues to use orb or relic (health doesn't change)
                case 3:
                    if (hasOrb)
                    {
                        Console.WriteLine("\nThe orb glowed brightly, and whispers of the \n" +
                            "forest filled the adventurer’s mind, revealing a forgotten path \n" +
                            "that snaked through the trees and led directly to the island. \n" +
                            "With newfound confidence and wisdom, the adventurer followed the \n" +
                            "path, ready to uncover the mysteries that awaited them.\n");
                        Console.WriteLine($"HEALTH: {playerHealth.ToString("P0")}");
                        playerChoice2 = 3;
                    }
                    else if (hasRelic)
                    {
                        Console.WriteLine("\nWith a surge of energy, the relic awakened, and a\n" +
                            "shimmering portal opened beneath the water’s surface, allowing \n" +
                            "the adventurer to dive through. Emerging on the other side, they \n" +
                            "found themselves on the island, but the relic now pulsed \n" +
                            "ominously, hinting at challenges yet to come.\n");
                        Console.WriteLine($"HEALTH: {playerHealth.ToString("P0")}");
                        playerChoice2 = 4;
                    }
                    // if invalid response, ends game & program
                    else
                    {
                        Console.WriteLine("\nInvalid choice. Gameover.");
                        Console.WriteLine("Press any key to continue . . .");
                        return;
                    }
                    break;
                // if invalid response, ends game & program
                default:
                    Console.WriteLine("\nInvalid choice. Gameover.");
                    Console.WriteLine("Press any key to continue . . .");
                    return;
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            // formating for scene 3 & player's current health
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Scene 3 - Ending\n");
            Console.WriteLine($"HEALTH: {playerHealth.ToString("P0")}\n");

            // introduction for scene 3
            Console.WriteLine(
                "As the adventurer stood there, the weight of their choices settled upon them,\n" +
                "intertwining destiny with the ancient secrets of the land. With each \n" +
                "heartbeat, the adventure unfolded, a tapestry of discovery and danger woven \n" +
                "into the fabric of their journey, beckoning them to embrace the unknown and \n" +
                "forge their own legend amidst the whispers of the forest and the echoes of \n" +
                "the past.");

            // decides the type of ending depending on previous choices from scenes 1 & 2
            // player's health is very low and had a rough journey, so goes home
            if (playerChoice1 == 1 && playerChoice2 == 1)
            {
                Console.WriteLine(
                    "\nBarely escaping the clutches of defeat, the adventurer turned away from\n" +
                    "the island, the weight of their near-fatal encounter heavy on their heart\n" +
                    "as they made their way home, forever changed by the experience.");
            }
            // player's health is low and had a rough journey, but they make it 
            else if (playerChoice1 == 1 && (playerChoice2 == 2 || playerChoice2 == 4))
            {
                Console.WriteLine(
                    "\nAfter a grueling journey fraught with challenges, the adventurer \n" +
                    "finally set foot on the island, driven by a mix of exhaustion and \n" +
                    "exhilaration as they prepared to uncover its hidden mysteries.");
            }
            // player's health is low and had their first difficulty, so goes home
            else if (playerChoice1 == 2 && playerChoice2 == 1)
            {
                Console.WriteLine(
                    "\nRealizing that some treasures are best left undiscovered, the \n" +
                    "adventurer turned away from the island, the echoes of their journey \n" +
                    "guiding them back home with a heart full of stories yet to be told.");
            }
            // player's health is max and had an easy journey, so they make it
            else if (playerChoice1 == 2 && (playerChoice2 == 2 || playerChoice2 == 3))
            {
                Console.WriteLine(
                    "\nWith the sun shining brightly and the gentle breeze guiding their way, \n" +
                    "the adventurer eagerly explored the island, excited to uncover its \n" +
                    "secrets after a surprisingly smooth and easy journey.");
            }
            // (impossible) if conditions are not met, the player dies on the spot
            else
            {
                Console.WriteLine(
                    "\nIn a moment of carelessness, the adventurer took a bite of a vibrant, \n" +
                    "alluring mushroom, only to collapse lifelessly to the forest floor as the\n" +
                    "poison coursed through their veins.");
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
}

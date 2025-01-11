/* Tyler Bye 
 * 9/12/2024
 * Manipulating Strings & Chars */
namespace PE_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** ALL VARIABLES USED ***
            // starting variables for names 
            string playerName = "Dash";
            string characterName = "Chonkerino";
            string gameName = "Return of the Catfather";
            string weaponName = "Paws of Steel";
            string capsPlayerName = playerName.ToUpper();
            string capsCharacterName = characterName.ToUpper();
            string capsGameName = gameName.ToUpper();
            // sidekick variables
            char firstPlayer = capsPlayerName[0];
            string lowerGameName = gameName.ToLower();
            string twoGameName = lowerGameName.Substring(0, 2);
            string lowerCharacterName = characterName.ToLower();
            string twoCharacterName = lowerCharacterName.Substring(0, 2);
            string lowerWeaponName = weaponName.ToLower();
            string threeWeaponName = lowerWeaponName.Substring(0,3);
            char lastWeaponName = weaponName[weaponName.Length - 1];

            // introductary section & tells user about the player & game
            Console.WriteLine($"Welcome {playerName}!");
            Console.WriteLine();
            Console.WriteLine($"Your game name is {gameName}.");
            Console.WriteLine($"Your character's name is {characterName}.");
            Console.WriteLine($"{characterName} wields the weapon {weaponName}.");

            // information section w/ stats about the player
            Console.WriteLine();
            Console.WriteLine("Here is some information about you:");
            // tells user the length of their name
            Console.WriteLine($"Your name is {playerName.Length} letters long.");
            // tells the user the difference between their player & character name
            Console.WriteLine($"{capsPlayerName} is " +
                $"{Math.Abs(playerName.Length - characterName.Length)} " +
                $"letters longer than {capsCharacterName}.");
            // calculates character level based off of player & character name
            Console.WriteLine($"Your character {capsCharacterName} would start at level " +
                $"{playerName.Length + (Math.Abs(playerName.Length - characterName.Length) * 2)}.");

            // creates a sidekick name from the preexisting letters of the orignial variables
            Console.WriteLine();
            Console.WriteLine($"Let’s come up with a sidekick name from {capsGameName}....");
            Console.WriteLine($"Your sidekick's name would be " +
                $"{firstPlayer + twoGameName + twoCharacterName + threeWeaponName + lastWeaponName}.");
        }
    }
}

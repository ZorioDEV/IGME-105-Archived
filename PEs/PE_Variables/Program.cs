/* Tyler Bye 
 * 9/7/2024
 * Practice w/ Variables */

using System.Xml.Linq;

namespace PE_Variables
{
    internal class Program
    {string characterName = "Zorio";
            const int startingPoints = 50;
        static void Main(string[] args)
        {
            // ***ALL VARIABLES USED***
            // assigns character name & max starting points to 50
            string characterName = "Zorio";
            const int startingPoints = 50;
            // makes strength 20% of all starting points
            int strengthStat = startingPoints / 5;
            // makes dexterity half of strenght's points
            int dexterityStat = strengthStat / 2;
            // sets intelligence to always be 7 points
            const int intelligenceStat = 7;
            // makes health 2 less than both dexterity & intelligence combined
            int healthStat = (dexterityStat + intelligenceStat) - 2;
            // makes charisma the remaining points left of the starting points
            int charismaStat = startingPoints - (strengthStat + dexterityStat + intelligenceStat + healthStat);

            // prints out all information w/ formating
            Console.WriteLine("Name: " + characterName);
            Console.WriteLine();
            Console.WriteLine(strengthStat + " Strength");
            Console.WriteLine(dexterityStat + " Dexterity");
            Console.WriteLine(intelligenceStat + " Intelligence");
            Console.WriteLine(healthStat + " Health");
            Console.WriteLine(charismaStat + " Charisma");
            Console.WriteLine();
            Console.WriteLine("TOTAL: " + startingPoints);
        }
    }
}

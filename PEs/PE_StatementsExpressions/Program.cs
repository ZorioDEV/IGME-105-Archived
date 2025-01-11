/* Tyler Bye
 * 9/1/2024
 *Statements & Expressions - PE 2 */
using System.Xml.Linq;
using System.Xml.Schema;

namespace PE_StatementsExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // prints player name & creates a blank dividor line
            Console.WriteLine("Name: Zorio");
            Console.WriteLine();

            // prints out stats of player, using different expressions
                // 20% of 50
                Console.WriteLine((50 * 0.2) + " Strength");
                // half of 'Strength'
                Console.WriteLine(((50 * 0.2) / 2) + " Dexterity");
                // always 7
                Console.WriteLine(7 + " Intelligence");
                // 2 less than both 'Strength' & 'Dexterity' combined
                Console.WriteLine(((((50 * 0.2) / 2) + 7) - 2) + " Health");
                // the left over to equal a total of 50
                Console.WriteLine((50 - ((50 * 0.2) + ((50 * 0.2) / 2) + 7 +
                    ((((50 * 0.2) / 2) + 7) - 2))) + " Charisma");

            // creates a blank dividor line & prints out the total amt of stat points
            Console.WriteLine();
            Console.WriteLine("TOTAL: " + ((50 - ((50 * 0.2) + ((50 * 0.2) / 2) + 7 +
                ((((50 * 0.2) / 2) + 7) - 2)) + ((((50 * 0.2) / 2) + 7) - 2) + 7 +
                ((50 * 0.2) / 2) + (50 * 0.2))));

            /* >>>USED VARIABLES<<<
            // asks user for their character's name & stores in a variable
            Console.WriteLine("What is your character's name?");
            string name = Console.ReadLine();

            // how all stats are calculated & stores in their respective variables
            double stat1 = 50 * 0.2;                                // 20% of 50
            double stat2 = stat1 / 2;                               // half of stat1
            double stat3 = 7;                                       // always 7
            double stat4 = ((stat2 + stat3) - 2);                   // 2 less than both stat1 & stat2 combined 
            double stat5 = 50 - (stat1 + stat2 + stat3 + stat4);    // the left over to equal a total of 50

            // prints out all information
            Console.WriteLine(); 
            Console.WriteLine("Name: " + name);
            Console.WriteLine();
            Console.WriteLine(stat1 + " Strength");
            Console.WriteLine(stat2 + " Dexterity");
            Console.WriteLine(stat3 + " Intelligence");
            Console.WriteLine(stat4 + " Health");
            Console.WriteLine(stat5 + " Charisma");
            Console.WriteLine();
            Console.WriteLine("TOTAL: " + (stat1 + stat2 + stat3 + stat4 + stat5));*/
        }
    }
}

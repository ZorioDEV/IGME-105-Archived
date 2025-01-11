// Tyler Bye
// 12/11/2024
// Second & Final Practial Exam for IGME 105
using System;

namespace ByeT_Practical2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** OBJECTS ***
            Minion coreHound = new Minion("Core Hound", 7, 9, 5, "Beast");
            Minion archmage = new Minion("Archmage", 6, 4, 7);
            Minion dragon = new Minion("Dragon", 10, 15, 12);
            Minion goblin = new Minion("Goblin", 3, 2, 5, "Thief");

            // creates a list of the Minion objects
            List<Card> myCards = new List<Card>();
            myCards.Add(coreHound);
            myCards.Add(archmage);
            myCards.Add(dragon);
            myCards.Add(goblin);

            // randomly generates an int for list index
            Random randomNumber = new Random();
            int randomIndexOne = randomNumber.Next(0, myCards.Count);
            int randomIndexTwo = randomNumber.Next(0, myCards.Count);
            // assigns the random minions 
            Minion randomMinionOne = (Minion)myCards[randomIndexOne];
            Minion randomMinionTwo = (Minion)myCards[randomIndexTwo];


            // *** MAIN CODE ***
            // prints out all of the possible minions
            Console.WriteLine("=== Available Cards ===");
            foreach(Minion minion in myCards)
            {
                Console.WriteLine($" - {minion.Name}");
            }
            Console.WriteLine();

            // prints out which minions were randomly selected
            Console.WriteLine("=== Randomly Chosen Minions ===");
            Console.WriteLine($" - {randomMinionOne.Name}");
            Console.WriteLine($" - {randomMinionTwo.Name}\n");

            // casts the random two minions into play
            Console.WriteLine("=== Casting ===");
            Console.Write($" - ");
            randomMinionOne.Cast();
            Console.Write($" - ");
            randomMinionTwo.Cast();
            Console.WriteLine();

            // prints out the stats of the two random minions
            Console.WriteLine("=== Status ===");
            Console.WriteLine($" - {randomMinionOne.ToString()}");
            Console.WriteLine($" - {randomMinionTwo.ToString()}\n");

            // makes the two random minions attack each other
            Console.WriteLine("=== Combat ===");
            randomMinionOne.TakeDamage(randomMinionTwo.Attack);
            randomMinionTwo.TakeDamage(randomMinionOne.Attack);
            Console.WriteLine();

            // prints out the new stats of the two random minions
            Console.WriteLine("=== Status ===");
            Console.WriteLine($" - {randomMinionOne.ToString()}");
            Console.WriteLine($" - {randomMinionTwo.ToString()}\n");
        }
    }
}

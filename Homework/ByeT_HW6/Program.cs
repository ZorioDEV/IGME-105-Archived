// Tyler Bye 
// 11/25/2024
// Character Battle
namespace ByeT_HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** VARIABLES ***
            Random random = new Random();
            List<CommonCharacter> contestants = new List<CommonCharacter>
            {new Dragon("Smaug", 120, 10, 5, 8, random),
            new Wizard("Gandalf", 80, 12, 50, 15, random),
            new Dragon("Fafnir", 100, 8, 4, 10, random),
            new Wizard("Merlin", 90, 9, 40, 12, random)};

            // *** MAIN CODE ***
            // introduces the contestants
            Console.WriteLine("Welcome to the Battle Royale!\n");
            Console.WriteLine("Contestants -----------------------------");
            // prints out each contestant in the character list
            foreach (CommonCharacter contestant in contestants)
            {
                Console.WriteLine(contestant);
                Console.WriteLine();
            }
            Console.WriteLine();

            // sets round count to 1 & starts the battle
            int round = 1;
            // loops while there is more than one player left in the battle
            while (contestants.Count > 1)
            {
                Console.WriteLine($"Round {round} -----------------------------");

                // each character attacks one another
                for (int i = 0; i < contestants.Count; i++)
                {
                    CommonCharacter attacker = contestants[i];

                    // randomly chooses a target
                    CommonCharacter target;
                    // tests if it's not the attacker
                    do
                    {
                        target = contestants[random.Next(contestants.Count)];
                    } while (target == attacker);

                    // makes the attack action with random damage amount
                    int damage = attacker.Attack();
                    target.TakeDamage(damage);
                    Console.WriteLine($"{attacker.Name} deals {damage} to {target.Name}.");
                }

                // prints the current health status's of all the characters
                Console.WriteLine();
                foreach (CommonCharacter contestant in contestants)
                {
                    Console.WriteLine($"{contestant.Name} has {contestant.Health} health left.");
                }
                Console.WriteLine();

                // tests if there are any casualties or if someone has fleed the battle
                Console.WriteLine(">> Casualties <<");
                for (int i = contestants.Count - 1; i >= 0; i--)
                {
                    CommonCharacter character = contestants[i];
                    // checks if the player is dead & removes them from the list
                    if (character.IsDead)
                    {
                        Console.WriteLine($"{character.Name} has died.");
                        contestants.RemoveAt(i);
                    }
                    // checks if the player is able to flee & removes them from the list
                    else if (character.ReadyToFlee())
                    {
                        Console.WriteLine($"{character.Name} has fled the battle.");
                        contestants.RemoveAt(i);
                    }
                }
                Console.WriteLine();

                // creates a pause which waits for user's input before moving on
                Console.WriteLine("<Press ENTER to continue to the next round>");
                Console.ReadLine();

                // increases the round count by 1
                round++;
            }

            // prints the winner or results of the battle
            Console.WriteLine("** Battle Finished **");
            // tests if there is one player left
            if (contestants.Count == 1)
            {
                Console.WriteLine($"{contestants[0].Name} is the winner!");
            }
            // only when there are no players left
            else
            {
                Console.WriteLine("Everyone has either died or fled.");
            }
        }
    }
}

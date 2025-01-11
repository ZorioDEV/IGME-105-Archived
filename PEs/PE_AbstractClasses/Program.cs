// Tyler Bye
// 12/03/2024
// Playing with Abstract Classes
namespace PE_AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** VARIABLES ***
            Dragon myDragon = new Dragon("Jimmy", 115, "fire", "poison");
            Beholder myBeholder = new Beholder("Carl", 90, "poison", "fire");
            int round = 1;

            // *** MAIN CODE ***
            // prints out the stats of both monsters
            Console.WriteLine(myDragon);
            Console.WriteLine(myBeholder);

            // loops for a number of rounds until one of the monsters has died
            while (myDragon.Health > 0 && myBeholder.Health > 0)
            {
                // prints round number
                Console.WriteLine($"\n-- Round {round} --");

                // makes each monster attack
                myDragon.Attack(myBeholder);
                myBeholder.Attack(myDragon);

                // prints out the resulting health of each monster
                Console.WriteLine($"Jimmy’s health is {myDragon.Health}.");
                Console.WriteLine($"Carl’s health is {myBeholder.Health}.");

                // increases round count by 1
                round++;
            }

            // tests which monster is dead & which monster won
            if (myDragon.Health > 0 && myBeholder.Health <= 0)
            {
                Console.WriteLine("\nJimmy has emerged victorious!");
            }
            else if (myBeholder.Health > 0 && myDragon.Health <= 0)
            {
                Console.WriteLine("\nCarl has emerged victorious!");
            }
            else
            {
                Console.WriteLine("\nIt's a tie! Both monsters have fallen.");
            }
        }
    }
}

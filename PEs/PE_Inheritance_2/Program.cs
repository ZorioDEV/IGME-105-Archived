// Tyler Bye
// 11/19/2024
// Learning Parent & Child Classes
using System.Dynamic;

namespace PE_Inheritance_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** OBJECTS ***
            //Monster myMonster = new Monster();
            //Monster myIceKing = new Monster("Ice King", 633, 85, false);
            //Zombie myZombie = new Zombie("Rob", 36, 100);
            //Vampire myVampire = new Vampire("Dracula", 496, 100);
            Monster monsterA = new Monster("A", 75, 90, true);
            Monster monsterB = new Monster("B", 12, 73, false);
            Monster monsterC = new Monster("C", 46, 0, true);
            Monster monsterD = new Monster("D", 98, 0, false);
            Zombie zombieA = new Zombie("Guts", 26, 100);
            Zombie zombieB = new Zombie("Munch", 39, 0);
            Vampire vampireA = new Vampire("Kalon", 1154, 53);
            Vampire vampireB = new Vampire("Calantha", 49, 20);
            Vampire vampireC = new Vampire("Dragos", 344, 0);

            // creates list of monster objects
            List<Monster> monsters = new List<Monster> {
                monsterA,
                monsterB,
                monsterC,
                monsterD,
                zombieA,
                zombieB,
                vampireA,
                vampireB,
                vampireC };

            // *** MAIN CODE ***
            // prints out the data for each monster within the list
            foreach (Monster monster in monsters)
            {
                monster.Print();
                // makes each zombie eat a Goomba
                if (monster is Zombie zombie)
                {
                    zombie.Eat("Goomba");
                }
                // makes each vampire shapeshift
                else if (monster is Vampire vampire)
                {
                    vampire.Shapeshift();
                }
                Console.WriteLine();
            }


            //Console.WriteLine(monsterA.ToString());
            //Console.WriteLine();
            //Console.WriteLine(monsterB.ToString());
            //Console.WriteLine();

            //Console.WriteLine(monsterC);
            //Console.WriteLine();
            //Console.WriteLine(monsterD);
            //Console.WriteLine();

            //zombieB.Print();
            //Console.WriteLine();
            //zombieA.Eat("Koopa Troopa");
            //Console.WriteLine();

            //Console.WriteLine(zombieA.ToString());
            //Console.WriteLine();
            //Console.WriteLine(zombieB.ToString());
            //Console.WriteLine();

            //vampireA.Print();
            //Console.WriteLine();

            //vampireB.Shapeshift();
            //vampireB.Eat("Piranha Plant");
            //Console.WriteLine();

            //vampireC.Shapeshift();
            //Console.WriteLine();

            //Console.WriteLine(vampireA.ToString());
            //Console.WriteLine();
            //Console.WriteLine(vampireB.ToString());
            //Console.WriteLine();
            //Console.WriteLine(vampireC.ToString());
            //Console.WriteLine();


            //// prints out all the monsters' data before any decay or hunger effects
            //Console.WriteLine("*** BEFORE time passing ***");
            //myVampire.PrintVampire();
            //Console.WriteLine();
            //myZombie.PrintZombie();
            //Console.WriteLine();

            //// allow 3 days to pass for the zombie
            //for (int i = 0; i < 3; i++)
            //{
            //    myZombie.DayPasses();
            //}

            //// allow 5 days to pass for the vampire
            //for (int i = 0; i < 5; i++)
            //{
            //    myVampire.DayPasses();
            //}

            //// prints out all the monsters' data after any decay or hunger effects
            //Console.WriteLine("*** AFTER time passing ***");
            //myVampire.PrintVampire();
            //Console.WriteLine();
            //myZombie.PrintZombie();
            //Console.WriteLine();
        }
    }
}

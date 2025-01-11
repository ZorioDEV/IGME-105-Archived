namespace PE_Inheritance_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** OBJECTS ***
            Monster myMonster = new Monster();
            Monster myIceKing = new Monster("Ice King", 633, 85, false);
            Zombie myZombie = new Zombie("Rob", 36, 100);
            Vampire myVampire = new Vampire("Dracula", 496, 100);

            // *** MAIN CODE ***
            // prints out all the monsters' data before any decay or hunger effects
            Console.WriteLine("*** BEFORE time passing ***");
            myVampire.PrintVampire();
            Console.WriteLine();
            myZombie.PrintZombie();
            Console.WriteLine();

            // allow 3 days to pass for the zombie
            for (int i = 0; i < 3; i++)
            {
                myZombie.DayPasses();
            }

            // allow 5 days to pass for the vampire
            for (int i = 0; i < 5; i++)
            {
                myVampire.DayPasses();
            }

            // prints out all the monsters' data after any decay or hunger effects
            Console.WriteLine("*** AFTER time passing ***");
            myVampire.PrintVampire();
            Console.WriteLine();
            myZombie.PrintZombie();
            Console.WriteLine();
        }
    }
}

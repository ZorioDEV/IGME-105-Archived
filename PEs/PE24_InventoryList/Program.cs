// Tyler Bye
// 11/11/2024
// Functional Inventory w/ Lists
namespace PE24_InventoryList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** VARIABLES ***
            List<string> inventory = new List<string>();
            Inventory myInventory = new Inventory(inventory);
            string userInput;

            // *** MAIN CODE ***
            // manually adds 3 items to the inventory
            myInventory.AddToInventory("rope");
            myInventory.AddToInventory("map");
            myInventory.AddToInventory("lock picks");

            // gives uesr set options & lets user decide 
            do
            {
                Console.Write("\nOptions: Add, Count, Get, Remove, Print, Print Index, or Quit. ");
                userInput = Console.ReadLine()!.Trim().ToLower();

                // adds items to the list
                if (userInput == "add")
                {
                    myInventory.AddToInventory();
                }
                // tells user the length of the list
                else if (userInput == "count")
                {
                    myInventory.ListCount();
                }
                // pulls the string of the index within the list
                else if (userInput == "get")
                {
                    Console.WriteLine($"Item is '{myInventory.RetrieveItem()}'.");
                }
                // removes items from the list
                else if (userInput == "remove")
                {
                    myInventory.RemoveFromInventory();
                }
                // prints the list without indexes
                else if (userInput == "print")
                {
                    myInventory.PrintInventory(false);
                }
                // prints the list with indexes
                else if (userInput == "print index")
                {
                    myInventory.PrintInventory(true);

                }
                // ends program
                else if (userInput == "quit")
                {
                    Console.WriteLine("Goodbye!");
                    return;
                }
                // if user inputs anything other than the options given
                else
                {
                    Console.WriteLine("[INVALID]");
                }
            } while (userInput != "quit");
        }
    }
}

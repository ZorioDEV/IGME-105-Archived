using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE24_InventoryList
{
    internal class Inventory
    {
        // *** FIELDS ***
        private List<string> inventory = new List<string>();


        // *** CONSTRUCTORS ***
        /// <summary>
        /// Read-only constructor that returns object length.
        /// </summary>
        public int InventoryCount
        {
            get
            {
                return inventory.Count();
            }
        }

        /// <summary>
        /// Paramatorized constructor for basic inventory.
        /// </summary>
        /// <param name="inventory">List of string items.</param>
        public Inventory(List<string> inventory)
        {
            this.inventory = inventory;
        }

        // *** METHODS ***
        /// <summary>
        /// Adds an item to the inventory. 
        /// </summary>
        public void AddToInventory()
        {
            // asks user for the new item
            Console.Write("Enter an item to add to your inventory: ");
            string item = Console.ReadLine()!.Trim();

            // adds item and tells user its been added
            inventory.Add(item);
            Console.WriteLine($"Added {item} to the inventory.");
        }

        /// <summary>
        /// Adds an specific item to the inventory.
        /// </summary>
        /// <param name="item">Specific item.</param>
        public void AddToInventory(string item)
        {
            inventory.Add(item);
            Console.WriteLine($"Added {item} to the inventory.");
        }

        /// <summary>
        /// Tells user the length of the list.
        /// </summary>
        public void ListCount()
        {
            Console.WriteLine($"Your inventory has {InventoryCount} items.");
        }

        /// <summary>
        /// Prints the list of items with and without index counters.
        /// </summary>
        /// <param name="showIndices"></param>
        public void PrintInventory(bool showIndices)
        {
            // tells user the length of the list
            ListCount();

            // prints list with indexes
            if (showIndices)
            {
                for (int i = 0; i < InventoryCount; i++)
                {
                    Console.WriteLine($"Item {i}: {inventory[i]}");
                }
            }
            // prints list without indexes
            else
            {
                for (int i = 0; i < InventoryCount; i++)
                {
                    Console.WriteLine($"\t {inventory[i]}");
                }
            }
        }

        /// <summary>
        /// Removes the item from the list.
        /// </summary>
        public void RemoveFromInventory()
        {
            // new parsing variables
            bool success = false;
            int result = -1;

            // asks user for index
            Console.WriteLine("Remove an item.");
            Console.Write("Which index? ");
            success = int.TryParse(Console.ReadLine()!.Trim(), out result);

            // tests if valid response
            int index = GetValidIndex(success, result);

            // tells user the item is removed & removes it from the list
            Console.WriteLine($"Removed ‘{inventory[index]}’ at index {index}.");
            inventory.RemoveAt(index);
        }

        /// <summary>
        /// Retrieves the item from within the inventory.
        /// </summary>
        /// <returns>Item from inventory.</returns>
        public string RetrieveItem()
        {
            // new parsing variables
            bool success = false;
            int result = -1;

            // asks user for index
            Console.WriteLine("Retrieve an item.");
            Console.Write("Which index? ");
            success = int.TryParse(Console.ReadLine()!.Trim(), out result);

            // tests if valid response
            int index = GetValidIndex(success, result);

            // tells user that they recieved the item & returns string of item
            Console.WriteLine($"Returning item at index {index}.");
            return inventory[index];
        }

        /// <summary>
        /// Tests if the user inputs are valid integers within the index range.
        /// </summary>
        /// <param name="success">Bool if response is parsable.</param>
        /// <param name="result">Integer of response.</param>
        /// <returns></returns>
        public int GetValidIndex(bool success, int result)
        {
            // sees if the parse was successful and if the result is within the index range
            while (!(success && result >= 0 && result <= inventory.Count()))
            {
                Console.WriteLine($"Index must be between 0 and {inventory.Count()}.");
                Console.Write("Try again. Which index? ");
                success = int.TryParse(Console.ReadLine()!.Trim(), out result);
            }

            // returns the valid integer response
            return result;
        }
    }
}

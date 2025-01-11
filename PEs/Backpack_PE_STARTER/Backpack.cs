using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Backpack_PE
{
    /// <summary>
    /// Backpack class.
    /// Students will write the contents of this class themselves.
    /// A Backpack belonging to an NPC, holding a collection of items.
    /// </summary>
    internal class Backpack
    {
        // *** FIELDS ***
        private string owner;
        private List<string> stuff;
        private Random rng;

        // *** PROPERTIES ***
        /// <summary>
        /// Read-only property of owner's name.
        /// </summary>
        public string Owner
        {
            get
            {
                return owner;
            }
        }

        // *** CONSTRUCTOR ***
        /// <summary>
        /// Main constructor to initialize the backpack with an owner.
        /// </summary>
        /// <param name="owner">The name of the backpack's NPC.</param>
        public Backpack(string owner)
        {
            this.owner = owner;
            this.stuff = new List<string>();
            this.rng = new Random();
        }

        // *** METHODS ***
        /// <summary>
        /// Adds an item to the backpack.
        /// </summary>
        /// <param name="item">The item being added.</param>
        public void AddToPack(string item)
        {
            stuff.Add(item);
            Console.WriteLine($"The item '{item}' was added to {owner}'s backpack.");
        }

        /// <summary>
        /// Prints the contents of the backpack.
        /// </summary>
        public void PrintPackContents()
        {
            Console.WriteLine($"{owner}'s backpack contents:");

            // tests if backpack is empty
            if (stuff.Count == 0)
            {
                Console.WriteLine("Backpack is empty!");
            }
            // prints out all items of the backpack
            else
            {
                foreach (string item in stuff)
                {
                    Console.WriteLine($"- {item}");
                }
            }
        }

        /// <summary>
        /// Removes and returns the item at the specified index.
        /// </summary>
        /// <param name="index">The index of the item to remove.</param>
        /// <returns>The removed item.</returns>
        /// <exception cref="Exception">Thrown if the index is out of range.</exception>
        public string GetItemInSlot(int index)
        {
            string item = null;
            try
            {
                // tests if index is possible or out of range
                if (index < 0 || index >= stuff.Count)
                {
                    Console.WriteLine($"The specified index {index} is out of the range 0 to {stuff.Count - 1}.");
                }
                // removes item from backpack
                else
                {
                    item = stuff[index];
                    stuff.RemoveAt(index);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            return item;
        }

        /// <summary>
        /// Removes and returns a random item from the backpack.
        /// </summary>
        /// <returns>The removed item.</returns>
        /// <exception cref="Exception">Thrown if the backpack is empty.</exception>
        public string GetRandomItem()
        {
            string item = null;
            try
            {
                // tests if backpack is empty
                if (stuff.Count == 0)
                {
                    Console.WriteLine($"Cannot return item from {owner}'s empty backpack.");
                }
                // gets random item & removes it from backpack
                else
                {
                    int index = rng.Next(stuff.Count);
                    item = stuff[index];
                    stuff.RemoveAt(index);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
            return item;
        }
    }
}

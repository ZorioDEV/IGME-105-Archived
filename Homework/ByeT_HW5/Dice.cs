using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ByeT_HW5
{
    internal class Dice
    {
        // generates a randome number
        private Random randomGenerator;

        /// <summary>
        /// Public class reference for dice.
        /// </summary>
        public Dice()
        {

        }

        /// <summary>
        /// Randomly generates a number between 1-6 to simulate a dice roll.
        /// </summary>
        /// <returns>Dice number after roll.</returns>
        public int RollDice()
        {
            randomGenerator = new Random();
            int diceNumber = randomGenerator.Next(1, 7);
            return diceNumber;
        }

        /// <summary>
        /// Randomly generates a number between 1-6 to simulate
        /// a dice roll for a specified amount of die.
        /// </summary>
        /// <param name="amount">Number of die.</param>
        /// <returns>Total dice number after rolls.</returns>
        public int RollDice(int amount)
        {
            // set total to zero before roll
            int total = 0;

            for (int i = 0; i < amount; i++)
            {
                total += RollDice();
            }
            return total;
        }
    }
}

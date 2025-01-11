using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ByeT_HW5
{
    internal class Monopoly
    {
        // *** FEILDS ***
        private Dice myDice;
        private int numberOfPlayers;
        private int aroundTheBoard;
        // ALL monopoly tile names
        private string[] propertyNames = {
        "Go",
        "Mediterranean Avenue",
        "Community Chest (1)",
        "Baltic Avenue",
        "Income Tax",
        "Reading Railroad",
        "Oriental Avenue",
        "Chance (1)",
        "Vermont Avenue",
        "Connecticut Avenue",
        "Jail",
        "St. Charles Place",
        "Electric Company",
        "States Avenue",
        "Virginia Avenue",
        "Pennsylvania Railroad",
        "St. James Place",
        "Community Chest (2)",
        "Tennessee Avenue",
        "New York Avenue",
        "Free Parking",
        "Kentucky Avenue",
        "Chance (2)",
        "Indiana Avenue",
        "Illinois Avenue",
        "B&O Railroad",
        "Atlantic Avenue",
        "Ventnor Avenue",
        "Water Works",
        "Marvin Gardens",
        "Go To Jail",
        "Pacific Avenue",
        "North Carolina Avenue",
        "Community Chest (3)",
        "Pennsylvania Avenue",
        "Short Line Railroad",
        "Chance (3)",
        "Park Place",
        "Luxury Tax",
        "Boardwalk"
        };

        /// <summary>
        /// Paramatorized constructor for Monopoly
        /// </summary>
        /// <param name="numberOfPlayers">Amount of players playing.</param>
        /// <param name="aroundTheBoard">Number of times they have gone around the board.</param>
        public Monopoly(int numberOfPlayers, int aroundTheBoard)
        {
            // creating new objects & setting variables w/ feilds
            this.numberOfPlayers = numberOfPlayers;
            this.aroundTheBoard = aroundTheBoard;
            myDice = new Dice();

        }

        /// <summary>
        /// Runs a Monopoly simulation & collects data on the tile visits.
        /// </summary>
        /// <returns>Percentages of each tile visit.</returns>
        public double[] Analyze()
        {
            // NEW visit & percentage variables
            int[] visits = new int[propertyNames.Length];
            int totalVisits = 0;
            double[] percentages = new double[propertyNames.Length];

            // loops for the amount of players
            for (int i = 0; i < numberOfPlayers; i++)
            {
                // sets new player position to zero
                int currentPosition = 0;

                // loops for the set amount of times around the board
                for (int y = 0; y < aroundTheBoard; y++)
                {
                    // adds dice roll number to create new position & visit
                    int diceNumber = myDice.RollDice(2);
                    currentPosition = (currentPosition + diceNumber) % propertyNames.Length;

                    visits[currentPosition]++;
                    totalVisits++;

                    // special case of landing on the jail tile
                    if (currentPosition == 30)
                    {
                        currentPosition = 10;
                    }
                }
            }

            // calculates the percentages of the tile visits
            for (int i = 0; i < propertyNames.Length; i++)
            {
                percentages[i] = (visits[i] / (double)totalVisits) * 100;
            }
            return percentages;
        }

        /// <summary>
        /// Prints out the data received from the Monopoly simulation. 
        /// </summary>
        /// <param name="visitPercentages">Resulting visit percentages per tile.</param>
        public void PrintResults(double[] visitPercentages)
        {
            Console.WriteLine("\nStudy Results:\n");

            // loops for the amount of tiles in Monopoly
            for (int i = 0; i < propertyNames.Length; i++)
            {
                Console.WriteLine($"\t{propertyNames[i]} : {Math.Round(visitPercentages[i], 2)}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_CardDeck
{
    internal class Deck
    {
        // *** FIELDS ***
        private Random randomGenerator;
        private Card[] cardCollection;

        /// <summary>
        /// Base object for all decks.
        /// </summary>
        public Deck()
        {
            // creates array for cards & random number generator
            cardCollection = new Card[52];
            randomGenerator = new Random();

            // creates array for possible suits & sets index to zero
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            int index = 0;

            // assigns all values and suits to the deck
            for (int i = 0; i < suits.Length; i++)
            {
                for (int value = 1; value <= 13; value++)
                {
                    cardCollection[index] = new Card(value, suits[i]);
                    index++;
                }
            }
        }

        /// <summary>
        /// Prints out all the cards in the deck.
        /// </summary>
        public void PrintDeck()
        {
            Console.WriteLine("Your Deck:");
            // goes through every card and prints its values & suits
            for (int i = 0; i < cardCollection.Length; i++)
            {
                cardCollection[i].PrintCard();
            }
        }

        /// <summary>
        /// Randomly deals a specified amount of cards.
        /// </summary>
        /// <param name="amount">Amount of cards dealt.</param>
        public void Deal(int amount)
        {
            Console.WriteLine($"\nYour hand of {amount} cards:");
            // randomly generates each card that was dealt
            for (int i = 0; i < amount; i++)
            {
                int randomIndex = randomGenerator.Next(0, cardCollection.Length);
                cardCollection[randomIndex].PrintCard();
            }
        }
    }
}

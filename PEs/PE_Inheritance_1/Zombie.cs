using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PE_Inheritance_1
{
    internal class Zombie : Monster
    {
        // *** FIELDS ***
        private double rateOfDecay;

        // *** PROPERTIES ***
        /// <summary>
        /// Read-Only property for the Zombie's rateOfDecay.
        /// </summary>
        public double RateOfDecay
        {
            get
            {
                return rateOfDecay;
            }
        }

        // *** CONSTRUCTORS ***
        /// <summary>
        /// Parameterized Zombie values & sets the rate of decay.
        /// </summary>
        /// <param name="name">Name of the zombie.</param>
        /// <param name="age">Age of the zombie.</param>
        /// <param name="constitution">The zombie's constitution.</param>
        public Zombie(string name, int age, double constitution)
                : base(name, age, constitution, true)
        {
            rateOfDecay = 0.93;
        }

        // *** METHODS ***
        /// <summary>
        /// Makes one day pass & allows for decay.
        /// </summary>
        public void DayPasses()
        {
            // calculates decay and rounds constitution
            Constitution *= rateOfDecay;
            Constitution = Math.Round(Constitution, 2);

            // tests if constitution is less than 1 & sets isAnimated to false
            if (Constitution < 1 )
            {
                IsAnimated = false;
            }
        }

        /// <summary>
        /// Prints out all of Zombie's data.
        /// </summary>
        public void PrintZombie()
        {
            Console.WriteLine("Zombie information:");
            PrintMonster();
            Console.WriteLine($"Decay rate: {rateOfDecay}");
        }
    }
}

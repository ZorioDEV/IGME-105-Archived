using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_Inheritance_1
{
    internal class Vampire : Monster
    {
        // *** FIELDS ***
        private double rateOfHunger;
        private string form;

        // *** PROPERTIES ***
        /// <summary>
        /// Read-Only property for Vampire's rateOfHunger.
        /// </summary>
        public double RateOfHunger
        {
            get
            {
                return rateOfHunger;
            }
        }

        /// <summary>
        /// Read-Only property for Vampire's form.
        /// </summary>
        public string Form
        {
            get
            {
                return form;
            }
        }

        // *** CONSTRUCTORS ***
        /// <summary>
        /// Parameterized Zombie values & sets the rate of hunger and form.
        /// </summary>
        /// <param name="name">Name of the vampire.</param>
        /// <param name="age">Age of the vampire.</param>
        /// <param name="constitution">The vampire's constitution.</param>
        public Vampire(string name, int age, double constitution)
                : base(name, age, constitution, false)
        {
            rateOfHunger = constitution * 0.08;
            form = "human";
        }

        // *** METHODS ***
        /// <summary>
        /// Makes one day pass & allows for hunger.
        /// </summary>
        public void DayPasses()
        {
            // calculates hunger and rounds constitution
            Constitution -= rateOfHunger;
            Constitution = Math.Round(Constitution, 2);

            // tests if constitution is less than 1 & sets isAnimated to false
            if (Constitution < 1)
            {
                IsAnimated = false;
            }

            // tests if constitution is 60 or below & adds 2 hunger rate
            if (Constitution <= 60)
            {
                rateOfHunger += 2;
            }
        }

        /// <summary>
        /// Prints out all of the Vampire's data.
        /// </summary>
        public void PrintVampire()
        {
            Console.WriteLine("Vampire information:");
            PrintMonster();
            Console.WriteLine($"Hunger rate: {rateOfHunger}");
            Console.WriteLine($"Currently in {form} form");
        }
    }
}

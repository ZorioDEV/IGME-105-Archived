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
        public override void Print()
        {
            Console.WriteLine("Vampire information:");
            base.Print();
            Console.WriteLine($"Hunger rate: {rateOfHunger}");
            Console.WriteLine($"Currently in {form} form");
        }

        /// <summary>
        /// Vampire eats a victim and restores constitution.
        /// </summary>
        /// <param name="victim">Name of victim.</param>
        public override void Eat(string victim)
        {
            Constitution = 100;
            Console.WriteLine($"{Name} drinks the blood of {victim} and feels restored.");
        }
        
        /// <summary>
        /// Allows Vampire to change form.
        /// </summary>
        public void Shapeshift()
        {
            // tests if constiution is below 10
            if (Constitution >= 10)
            {
                // swaps form between human and bat
                if (form == "human")
                {
                    form = "bat";
                    Console.WriteLine($"{Name} shifts into {form} form.");
                }
                else if (form == "bat")
                {
                    form = "human";
                    Console.WriteLine($"{Name} shifts into {form} form.");
                }
            }
            // tells user they dont have enough constitution to swap forms
            else
            {
                Console.WriteLine($"{Name} no longer has the energy to swap forms.");
            }
        }

        /// <summary>
        /// Tells user data and if the Vampire is hungry and their actions.
        /// </summary>
        /// <returns>Various responses based on constitution.</returns>
        public override string ToString()
        {
            // tests if constitution is above 60
            if (Constitution > 60)
            {
                return base.ToString() + $" {Name}'s hunger is in check" +
                    $" as they explore the night in {form} form.";
            }
            // tests if constitution is within 60-1
            else if (Constitution > 0)
            {
                return base.ToString() + $" {Name} desperately wanders" +
                    $" the night as a {form} in search of a midnight snack to curb hunger.";
            }
            // tests if constitution is zero & below
            else
            {
                return base.ToString() + $" {Name}, lifeless from hunger," +
                    $" waits for a companion to bring a fresh treat before playing again.";
            }
        }
    }
}

// Tyler Bye
// 09/27/2024
// Learning Compound Conditionals
namespace PE_CompoundConditionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** PSEUDOCODE *** 
            /*
            ASK user for birth month & day

            IF January AND Date is 1 - 19
                Print “Capricorn”
            OTHERWISE January AND Date is 20 – 31 OR February AND Date is 1 – 18
                Print “Aquarius”
            OTHERWISE February AND Date is 19 – 29
                Print “Pisces”
            OTHERWISE anything else
                Print “Invalid”

            ASK user two questions

            IF bigger than a soccer ball AND animal
                Print “wolf”
            OTHERWISE bigger than a soccer ball AND vegetable
                Print “watermelon”
            OTHERWISE bigger than a soccer ball AND mineral
                Print “car”
            OTHERWISE smaller than a soccer ball AND animal
                Print “mouse”
            OTHERWISE smaller than a soccer ball AND vegetable
                Print “carrot”
            OTHERWISE smaller than a soccer ball AND mineral
                Print “paper clip”
            OTHERWISE
                Print “Invalid”
             */

            // *** ALL VARIABLES USED ***
            string userInput;
            string birthMonth;
            int birthDay;
            string questionOne;
            string questionTwo;

            // *** MAIN CODE ***
            // formats the section
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("WHAT’S YOUR SIGN?");
            Console.WriteLine("---------------------------------------------------------------");
            // asks the user what their birth month and day is to tell them what sign they are
            Console.Write("What is your birth month? ");
            birthMonth = Console.ReadLine()!.ToLower().Trim();
            Console.Write("On which day were you born? ");
            userInput = Console.ReadLine()!.ToLower().Trim();
            birthDay = int.Parse(userInput);

            // tests through conditionals to see what sign they are 
            if ((birthMonth == "january") && (birthDay <= 19))
            {
                Console.WriteLine("Your sign is Capricorn.");
            }
            else if (((birthMonth == "january") && (birthDay > 19)) || ((birthMonth == "february") && (birthDay <= 19)))
            {
                Console.WriteLine("Your sign is Aquarius.");
            }
            else if ((birthMonth == "february") && (birthDay > 19))
            {
                Console.WriteLine("Your sign is Pisces.");
            }
            // program only tests for 3 different signs
            else
            {
                Console.WriteLine("Invalid birthdate for this program!");
            }
            Console.WriteLine();

            // formats the section
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("2 QUESTIONS");
            Console.WriteLine("---------------------------------------------------------------");
            // asks the user two questions to guess what they are thinking
            Console.WriteLine("Think of any object and I will tell you what it is.");
            Console.Write("     - Question 1. Is it ANIMAL, VEGETABLE, or MINERAL? ");
            questionOne = Console.ReadLine()!.ToLower().Trim();
            Console.Write("     - Question 2. Is it bigger than a soccer ball? YES or NO? ");
            questionTwo = Console.ReadLine()!.ToLower().Trim();

            // tests through conditionals to guess what they were thinking of
            if (questionTwo == "yes" && questionOne == "animal")
            {
                Console.WriteLine("I guess you are thinking of a wolf!");
            }
            else if (questionTwo == "yes" && questionOne == "vegetable")
            {
                Console.WriteLine("I guess you are thinking of a watermelon!");
            }
            else if (questionTwo == "yes" && questionOne == "mineral")
            {
                Console.WriteLine("I guess you are thinking of a car!");
            }
            else if (questionTwo == "no" && questionOne == "animal")
            {
                Console.WriteLine("I guess you are thinking of a mouse!");
            }
            else if (questionTwo == "no" && questionOne == "vegetable")
            {
                Console.WriteLine("I guess you are thinking of a carrot!");
            }
            else if (questionTwo == "no" && questionOne == "mineral")
            {
                Console.WriteLine("I guess you are thinking of a paper clip!");
            }
            else
            {
                Console.WriteLine("An invalid choice was given!");
            }

        }
    }
}

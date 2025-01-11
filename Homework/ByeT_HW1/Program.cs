namespace ByeT_HW1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** ALL VARIABLES USED ***
            string firstName;
            string lastName;
            string userInput;
            double age;
            string firstThreeLetters;
            string lastThreeLetters;
            string newName;
            int lettersLonger;
            double sunDistance;
            const int earthOrbitSun = 93_383_000;
            const int nameDivider = 3;
            // Madlibs -> 6 string variables 
            string userNounOne;
            string userNounTwo;
            string userNounThree;
            string userAdjectiveOne;
            string userAdjectiveTwo;
            string userVerbOne;
            // Madlibs -> 3 int variables 
            int userNumberOne;
            int userNumberTwo;
            int userNumberThree;
            // Madlibs -> 1 double variable
            double userFloatingPoint;

            // *** MAIN CODE FOR ACTIVITY 1 ***
            // ask user for name & age
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your first name: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            firstName = Console.ReadLine()!.Trim();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your last name: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            lastName = Console.ReadLine()!.Trim();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Enter your age ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("[decimals are allowed]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(": ");
            Console.ForegroundColor = ConsoleColor.Green;
            userInput = Console.ReadLine()!.Trim()!;
            age = double.Parse(userInput);
            Console.ForegroundColor = ConsoleColor.White;

            // creates a new name w/ user's first & last name
            firstThreeLetters = firstName.Substring(0, nameDivider);
            lastThreeLetters = lastName.Substring(lastName.Length - nameDivider);
            newName = (firstThreeLetters + lastThreeLetters);

            // makes an introduction w/ user's info
            Console.WriteLine();
            Console.Write($"Welcome, ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"{firstName} {lastName}");
            Console.ForegroundColor = ConsoleColor.White;

            // gives user a nickname
            Console.Write($"! Your new nickname is ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(newName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".");
            Console.WriteLine();

            // states facts w/ user's info
            Console.WriteLine("Here's some facts about you!");
            // tells user the difference of their first & last name
            Console.Write("    - Your first name is ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            lettersLonger = (firstName.Length - lastName.Length);
            Console.Write(lettersLonger);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" letter(s) longer than your last name.");
            // tells user the how far they've traveled around the sun
            Console.Write("    - In your ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(age);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" trips around the sun, you traveled ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            sunDistance = Math.Round((age * earthOrbitSun), 1);
            Console.Write(sunDistance);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" miles!");
            Console.WriteLine();

            // *** MAIN CODE FOR ACTIVITY 2 ***
            // asks user for random nouns, verbs, adjs, & #s
            Console.WriteLine();
            Console.Write($"Lets play a Madlibs game, ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(newName);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("!");
            // asks for all the nouns
            Console.Write("    Enter a noun: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            userNounOne = Console.ReadLine()!.Trim();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    Enter another noun: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            userNounTwo = Console.ReadLine()!.Trim();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    Enter another noun: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            userNounThree = Console.ReadLine()!.Trim();
            Console.ForegroundColor = ConsoleColor.White;
            // asks for all the adjectives
            Console.Write("    Enter an adjective: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            userAdjectiveOne = Console.ReadLine()!.Trim();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    Enter another adjective: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            userAdjectiveTwo = Console.ReadLine()!.Trim();
            Console.ForegroundColor = ConsoleColor.White;
            // asks for the verb
            Console.Write("    Enter a verb ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("[NO \"-ING\"]");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(": ");
            Console.ForegroundColor = ConsoleColor.Green;
            userVerbOne = Console.ReadLine()!.Trim();
            Console.ForegroundColor = ConsoleColor.White;
            // asks for all the numbers & parses them
            Console.Write("    Enter a number: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            userInput = Console.ReadLine()!.Trim()!;
            userNumberOne = int.Parse(userInput);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    Enter another number: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            userInput = Console.ReadLine()!.Trim()!;
            userNumberTwo = int.Parse(userInput);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    Enter another number: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            userInput = Console.ReadLine()!.Trim()!;
            userNumberThree = int.Parse(userInput);
            Console.ForegroundColor = ConsoleColor.White;
            // asks for the flooting-point number & parses it
            Console.Write("    Enter a ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("decimal");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" number: ");
            Console.ForegroundColor = ConsoleColor.Green;
            userInput = Console.ReadLine()!.Trim()!;
            userFloatingPoint = double.Parse(userInput);
            Console.ForegroundColor = ConsoleColor.White;

            // ***STORY GENERATED FROM CHATGPT ***
            // uses user inputs & tells a story
            // gives title of the story
            Console.WriteLine();
            Console.WriteLine("A Day in the Life of a Superhero");
            Console.WriteLine();
            // first part of the story: 3 nouns & 1 adj used
            Console.Write("It was a quiet morning in the city of ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(userNounOne.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(", when suddenly, a loud crash echoed from the ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(userNounTwo.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(". The sky turned ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(userAdjectiveOne.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(", and the citizens knew something was wrong. Without " +
                "hesitation, the superhero known as ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(userNounThree.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" sprang into action.");
            Console.WriteLine();
            // second part of the story: 1 verb, 3 numbers, 1 noun, & 1 adj used
            Console.Write("Using their incredible powers, they managed to ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(userVerbOne.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" across ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(userNumberOne);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" buildings in a single leap. The villain," +
                " standing at the top of a ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(userNumberTwo);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("-story tower, thought they were safe. But ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(userNounThree.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" was determined. With a ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(userAdjectiveTwo.ToUpper());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" plan, they climbed the tower in just ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(userNumberThree);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" seconds.");
            Console.WriteLine();
            // conclusion of the story: flooting-point number used
            Console.Write("At last, after ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(userFloatingPoint);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" minutes of battle, the day was saved!");
            Console.WriteLine();
        }
    }
}

// Tyler Bye
// 10/10/2024
// Playing with Enums and Arrays
namespace PE_EnumerationsArrays
{
    // delcares & states Weather enum
    public enum Weather
    {
        Sunny,
        Cloudy,
        Rainy,
        Snowy,
        Windy
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // *** PSEUDOCODE ***
            /*
            create the WEATHER enum

            initialize & delcare variables

            make a header and inform user

            FOR each day ask the user what the weather condition is
            
            FOR each day tell the user a response to the weather condition
                IF SUNNY tell them its sunny
                ELSE IF CLOUDY tell them its cloudy
                ELSE IF RAINY tell them to bring an umbrella
                    add to total rainy day count
                ELSE IF SNOWY tell them to wear warm clothes
                ELSE IF WINDY tell them to hold onto their hat
                ELSE it is an invalid input

            tell the user how many total rainy days there was
            */

            // *** VARIABLES ***
            int dayCount;
            string[] weatherCondition = {"","","","","","",""};
            int rainyDays = 0;

            // *** MAIN CODE ***
            // header & tells user options
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your choices are: Sunny, Cloudy, Rainy, Snowy or Windy.");

            // asks the user 7 times for what the weather conditions is that day
            for (dayCount = 0; dayCount < weatherCondition.Length; dayCount++)
            {
                Console.Write($"Enter the weather condition for day {dayCount + 1}: ");
                weatherCondition[dayCount] = Console.ReadLine()!.Trim();
            }

            // prints out responses to the user's weather conditions 
            Console.WriteLine();
            for (dayCount = 0; dayCount < weatherCondition.Length; dayCount++)
            {
                // resets the color to white & prints the day number
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write($"Day {dayCount + 1}: ");

                // converts the enum to strings and tests the conditions for each day
                if (weatherCondition[dayCount] == Weather.Sunny.ToString())
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("It's a beautiful sunny day!");
                }
                else if (weatherCondition[dayCount] == Weather.Cloudy.ToString())
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("It's a bit cloudy today.");
                }
                else if (weatherCondition[dayCount] == Weather.Rainy.ToString())
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Don't forget your umbrella!");
                    // adds to the count of total rainy days
                    rainyDays++;
                }
                else if (weatherCondition[dayCount] == Weather.Snowy.ToString())
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Wear warm clothes, it's snowing!");
                }
                else if (weatherCondition[dayCount] == Weather.Windy.ToString())
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("It's windy, hold onto your hat!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[Invalid Input]");
                }
            }

            // changes color to blue & tells users how many rainy days they had
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nThere are {rainyDays} rainy days.");
        }
    }
}

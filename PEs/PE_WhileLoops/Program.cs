// Tyler Bye
// 10/02/2024
// Learning & Testing While Loops
namespace PE_WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** VARIABLES ***
            int loopNumber = 0;
            int odd = 1;
            int even = 0;
            bool askUser = false;
            string userInput;
            int valueCount;
            double valueNumber;
            double totalNumber = 0;

            // *** MAIN CODE ***
            // adds 1 while LOOPNUMBER is less than 20
            while (loopNumber < 20)
            {
                loopNumber++;
            }
            // when LOOPNUMBER is between 20-23 then it prints the number (adds by 1)
            while (loopNumber >= 20 && loopNumber <= 23)
            {
                Console.WriteLine(loopNumber);
                loopNumber++;
            }
            // formats the console & resets LOOPNUMBER to zero
            Console.WriteLine("-------------");
            loopNumber = 0;

            // makes LOOPNUMBER equal to 1
                loopNumber++;
            // when LOOPNUMBER is between 1-10 then it prints the number (adds by 1)
            while (loopNumber >= 1 && loopNumber <= 10)
            {
                Console.Write($"{loopNumber} ");
                loopNumber++;
            }
            // formats the console & resets LOOPNUMBER to zero
            Console.WriteLine("\n-------------");
            loopNumber = 0;

            // makes LOOPNUMBER equal to 1
            loopNumber++;
            // when LOOPNUMBER is between 1-10 then it prints the number (adds by 1)
            do
            {
                Console.Write($"{loopNumber} ");
                loopNumber++;
            } while (loopNumber >= 1 && loopNumber <= 10);
            // formats the console & resets LOOPNUMBER to zero
            Console.WriteLine("\n-------------");
            loopNumber = 0;

            // adds 5 while LOOPNUMBER is less than 24
            while (loopNumber < 24)
            {
                loopNumber = loopNumber + 5;
            }
            // when LOOPNUMBER is between 25-75 then it prints the number (adds by 10)
            while (loopNumber >= 25 && loopNumber <= 75)
            {
                // if else statement for formating so that ',' is not printed at the end
                if (loopNumber == 75)
                {
                    Console.Write(loopNumber);
                    loopNumber = loopNumber + 10;
                }
                else
                {
                    Console.Write($"{loopNumber}, ");
                    loopNumber = loopNumber + 10;
                }
            }
            // formats the console & resets LOOPNUMBER to zero
            Console.WriteLine("\n-------------");
            loopNumber = 0;

            // sets LOOPNUMBER to 10
            loopNumber = 10;
            // when LOOPNUMBER is between 10-5 then it prints the number (subtracts by 1)
            while (loopNumber <= 10 && loopNumber >= 5)
            {
                Console.WriteLine(loopNumber);
                loopNumber--;
            }
            // formats the console & resets LOOPNUMBER to zero
            Console.WriteLine("-------------");
            loopNumber = 0;

            // when mod is 1 or when the LOOPNUMBER is less than (or equal) to 20 then it adds 1
            while (loopNumber % 2 == odd || loopNumber <= 20)
            {
                loopNumber++;
                // when mod is 0 and less than (or equal to 20) then it prints the number
                while(loopNumber % 2 == even && loopNumber <= 20)
                {
                    // if else statement for formating so that '*' is not printed at the end
                    if (loopNumber == 20)
                    {
                        Console.WriteLine(loopNumber);
                        loopNumber++;
                    }
                    else
                    {
                        Console.Write($"{loopNumber}*");
                        loopNumber++;
                    }
                }
            }
            // formats the console & resets LOOPNUMBER to zero
            Console.WriteLine("-------------");
            loopNumber = 0;

            // asks user to enter a word until they enter 'STOP'
            while (!askUser)
            {
                Console.Write("Enter a word: ");
                userInput = Console.ReadLine()!;
                if (userInput == "STOP")
                {
                    Console.WriteLine("Okay!");
                    askUser = true;
                }
            }
            // formats the console & resets ASKUSER to false
            Console.WriteLine("-------------");
            askUser = false;

            // asks user to enter a word until they enter 'STOP'
            do
            {
                Console.Write("Enter a word: ");
                userInput = Console.ReadLine()!;
                if (userInput == "STOP")
                {
                    Console.WriteLine("Okay!");
                    askUser = true;
                }
            } while (!askUser);
            // formats the console
            Console.WriteLine("-------------");

            // asks the user how many values they would like to add up
            Console.Write("How many values? ");
            userInput = Console.ReadLine()!;
            valueCount = int.Parse(userInput);
            // ask the user for a value the number of values they entered
            do
            {
                valueCount--;
                Console.Write("Enter a value: ");
                userInput = Console.ReadLine()!;
                // parses the user's input & adds it to the total number
                valueNumber = double.Parse(userInput);
                totalNumber = totalNumber + valueNumber;
            } while (valueCount > 0);
            // tells the user their total sum number of all their values
            Console.WriteLine($"The sum of those numbers is {Math.Round(totalNumber, 1)}");
            // formats the console
            Console.WriteLine("-------------");
        }
    }
}

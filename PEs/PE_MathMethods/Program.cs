/* Tyler Bye
 * 9/9/2024
 * Casting, Arithmetic, and the Math class */

namespace PE_MathMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ***ALL VARIABLES USED***
            // states the player's name & their total time spent on the game
            string playerName = "Zorio";
            int playTime = 274;

            // cordinates of point one in 2D space, inlcuding both x- & y-axis values
            int pointOneX = -13;
            int pointOneY = 51;

            // cordinates of point two in 2D space, inlcuding both x- & y-axis values
            int pointTwoX = 17;
            int pointTwoY = 28;

            // states the values of some floating-point #s
            double numberA = 7.9;
            double numberB = 2.25;

            // gives two variables for 60 degrees with one in Radians
            double sixtyDegrees = 60;
            double sixtyDegreesRad = (60 * (Math.PI / 180));

            // distance formula for point one & point two
            double distance = Math.Sqrt(Math.Pow((pointOneX - pointTwoX), 2) 
                + Math.Pow((pointOneY - pointTwoY), 2));

            // ***PRINTING OUT INFORMATION***
            // headline & spacer for the add section
            Console.WriteLine("--- ADDITION ---");
            // restates # A & B then adds them together
            Console.WriteLine($"Number A: {numberA}");
            Console.WriteLine($"Number B: {numberB}");
            Console.WriteLine($"{numberA} + {numberB} = {numberA + numberB}");
            Console.WriteLine("Now I'll add just the whole number parts.");
            // rounds the double down to the nearest int and adds the two #s together
            Console.WriteLine($"{Math.Floor(numberA)} + {Math.Floor(numberB)} " +
                $"= {Math.Floor(numberA) + Math.Floor(numberB)}");

            // headline & spacer for the div & mod section
            Console.WriteLine();
            Console.WriteLine("--- DIVISION and MODULUS ---");
            // tells user their total # of hours played and converts it into days and hours
            Console.WriteLine($"{playerName} has played a game for {playTime} hours.");
            Console.WriteLine($"They have played for {playTime / 24} " +
                $"days and {playTime % 24} hours.");

            // headline & spacer for the sin & cos section
            Console.WriteLine();
            Console.WriteLine("--- SINE and COSINE ---");
            // restates the 60 degrees and it in Radians
            Console.WriteLine($"{sixtyDegrees} degrees is {sixtyDegreesRad} radians.");
            // converts the 60 degrees in terms of sine & cosine
            Console.WriteLine($"The sine is {Math.Sin(sixtyDegreesRad)}");
            Console.WriteLine($"The cosine is {Math.Cos(sixtyDegreesRad)}");

            // headline & spacer for the distance section
            Console.WriteLine();
            Console.WriteLine("--- DISTANCE ---");
            // restates point 1 & 2 in cordinates then gives the distance between them
            Console.WriteLine($"Point One: ({pointOneX},{pointOneY})");
            Console.WriteLine($"Point Two: ({pointTwoX},{pointTwoY})");
            Console.WriteLine($"The distance between these points is {distance}");

            // headline & spacer for the rounding section
            Console.WriteLine();
            Console.WriteLine("--- ROUNDING ---");
            // restates the distance & rounds them with 2 different precisions 
            Console.WriteLine($"The distance is {distance}");
            Console.WriteLine($"That is approximately {Math.Ceiling(distance)} units," +
                $" or {Math.Round(distance, 3)} to be more precise.");

            // headline & spacer for the comparison section
            Console.WriteLine();
            Console.WriteLine("--- COMPARISON ---");
            // compares # A & B then returns the larger of the two 
            Console.WriteLine($"Let's compare 2 numbers: {numberA} and {numberB}");
            Console.WriteLine($"{Math.Max(numberA, numberB)} is the larger value");
        }
    }
}

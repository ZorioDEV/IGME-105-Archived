namespace PE_InputParsing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ***ALL VARIABLES USED***
            // states the player's name & their total time spent on the game
            string userName;
            string playerName;
            double playTime;

            // cordinates of point one in 2D space, inlcuding both x- & y-axis values
            double pointOneX;
            double pointOneY;

            // cordinates of point two in 2D space, inlcuding both x- & y-axis values
            double pointTwoX;
            double pointTwoY;

            // states the values of some floating-point #s
            string userInput;
            double numberA;
            double numberB;

            // gives two variables for degrees with one in Radians
            double degrees;
            double degreesInRadians;

            // distance formula for point one & point two
            double distance;

            // ***PRINTING OUT INFORMATION***
            // headline & spacer for the add section
            Console.WriteLine("--- NAME ANALYSIS ---");
            // asks user their name & states fact about it 
            Console.Write("What is your name? ");
            userName = Console.ReadLine()!;
            Console.WriteLine($"{userName} has {userName.Length} letters");
            Console.WriteLine($"It starts with \"{userName[0]}\" and ends with" +
                $" \"{userName[userName.Length - 1]}\"");


            // headline & spacer for the add section
            Console.WriteLine("--- ADDITION ---");
            // asks user for two #s & parses then from string to double
            Console.Write("Give me the first number? ");
            userInput = Console.ReadLine()!;
            numberA = double.Parse(userInput);
            Console.Write("Give me the second number? ");
            userInput = Console.ReadLine()!;
            numberB = double.Parse(userInput);
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
            Console.Write("What is your player's name? ");
            playerName = Console.ReadLine()!;
            Console.Write("What's their number of gameplay hours? ");
            userInput = Console.ReadLine()!;
            playTime = double.Parse(userInput);
            Console.WriteLine($"{playerName} has played a game for {playTime} hours.");
            Console.WriteLine($"They have played for {playTime / 24} " +
                $"days and {playTime % 24} hours.");

            // headline & spacer for the sin & cos section
            Console.WriteLine();
            Console.WriteLine("--- SINE and COSINE ---");
            // user for degrees and it in Radians
            Console.Write("What's the number of degrees? ");
            userInput = Console.ReadLine()!;
            degrees = double.Parse(userInput);
            // converts the degrees in terms of radians
            degreesInRadians = (degrees * (Math.PI / 180));
            Console.WriteLine($"{degrees} degrees is {degreesInRadians} radians.");
            // converts the degrees in terms of sine & cosine
            Console.WriteLine($"The sine is {Math.Sin(degreesInRadians)}");
            Console.WriteLine($"The cosine is {Math.Cos(degreesInRadians)}");

            // headline & spacer for the distance section
            Console.WriteLine();
            Console.WriteLine("--- DISTANCE ---");
            // asks user for all points & parses then from string to double
            Console.Write("Whats the first point's X value? ");
            userInput = Console.ReadLine()!;
            pointOneX = double.Parse(userInput);
            Console.Write("Whats the first point's Y value? ");
            userInput = Console.ReadLine()!;
            pointOneY = double.Parse(userInput);
            Console.Write("Whats the second point's X value? ");
            userInput = Console.ReadLine()!;
            pointTwoX = double.Parse(userInput);
            Console.Write("Whats the second point's Y value? ");
            userInput = Console.ReadLine()!;
            pointTwoY = double.Parse(userInput);
            // distance formula for point one & point two
            distance = Math.Sqrt(Math.Pow((pointOneX - pointTwoX), 2)
                + Math.Pow((pointOneY - pointTwoY), 2));
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

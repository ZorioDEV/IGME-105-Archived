// Tyler Bye
// 10/16/2024
// In-Class Method Demo
namespace StaticMethodDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // asks user for a whole #
            Console.Write("Enter a whole number: ");
            int number1 = int.Parse(Console.ReadLine()!.Trim());
            
            // asks user for a whole #
            Console.Write("Enter another whole number: ");
            int number2 = int.Parse(Console.ReadLine()!.Trim());

            // tells user the sum of their numbers using the method SUM
            Sum(number1, number2);

            // tells user the sum of their numbers using the method SUMRETURN
            Console.WriteLine($"The sum of these numbers is {SumReturn(number1, number2)}.");

        } // End Main

        /// <summary>
        /// Prints the sum of two numbers. 
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        // Method declaration: public static returntype ID(list of params)
        public static void Sum(int one, int two)
        {
            // tells user the sum of their numbers
            Console.WriteLine($"The sum of these numbers is {one + two}.");
        }

        /// <summary>
        /// Calculates & returns the sum of two integers.
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        /// <returns>Sum of two int.</returns>
        public static int SumReturn(int one, int two)
        {
            // int sumofNumbers = one + two;
            // return sumofNumbers;

            return one + two;
        }

    } // End Progam
}

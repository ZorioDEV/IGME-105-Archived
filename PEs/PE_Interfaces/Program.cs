// Tyler Bye
// 11/21/2024
// Learning Interfaces
namespace PE_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // *** OBJECTS ***
                Point point1 = new Point(0, 0);
                Point point2 = new Point(5, 5);
                Circle circle1 = new Circle(0, 0, 3);
                Circle circle2 = new Circle(4, 4, 2);

                // *** MAIN CODE ***
                // prints initial data
                Console.WriteLine(point1);
                Console.WriteLine(point2);
                Console.WriteLine(circle1);
                Console.WriteLine(circle2);

                // moves point2 to (2, 2)
                point2.MoveTo(2, 2);

                // moves circle2 by -1 on both X & Y
                circle2.MoveBy(-1, -1);

                // prints updated data
                Console.WriteLine("\nAfter moving:");
                Console.WriteLine(point1);
                Console.WriteLine(point2);
                Console.WriteLine(circle1);
                Console.WriteLine(circle2);

                // calculates & displays distances
                Console.WriteLine($"\nDistance between points: {point1.DistanceTo(point2)}");
                Console.WriteLine($"Distance between circle1 and point1: {circle1.DistanceTo(point1)}");
                Console.WriteLine($"Distance between circle1 and point2: {circle1.DistanceTo(point2)}");
                Console.WriteLine($"Distance between circle2 and point1: {circle2.DistanceTo(point1)}");
                Console.WriteLine($"Distance between circle2 and point2: {circle2.DistanceTo(point2)}");

                // compares areas of circles
                Console.WriteLine($"\nCircle1 is larger than Circle2: {circle1.IsLargerThan(circle2)}");

                // checks if circles contain points
                Console.WriteLine($"Circle1 contains point1: {circle1.ContainsPosition(point1)}");
                Console.WriteLine($"Circle1 contains point2: {circle1.ContainsPosition(point2)}");
                Console.WriteLine($"Circle2 contains point1: {circle2.ContainsPosition(point1)}");
                Console.WriteLine($"Circle2 contains point2: {circle2.ContainsPosition(point2)}");
            }
        }
    }
}

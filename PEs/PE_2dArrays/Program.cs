namespace PE_2dArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** MAIN CODE ***
            // Initialize Random object
            Random myRandom = new Random();

            // Init a 2D array of 2 x 4 elements with random values
            int[,] integerArray = new int[2, 4];
            Methods.Fill2DArray(integerArray, myRandom, 0, 100);
            
            // Print values in the array
            Methods.Print2DArray(integerArray);
        }
    }
}

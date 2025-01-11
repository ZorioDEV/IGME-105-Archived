// * * * * * * * * * * * * * * * * * * * * * *
// *     Programmer: Johnny Fagerlin         *
// *      IGME 105 interfaces demo           *
// *            11.20.2024                   *
// * * * * * * * * * * * * * * * * * * * * * *

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize variables here.
            bool bIsRunning = true;
            List<IPosition> pWorldObjects = new List<IPosition>();
            Player pPlayerObj = new Player("Johnny, The Great", 10);

            // TODO: Uncomment after implementing the interfaces.
            pWorldObjects.Add(pPlayerObj);
            pWorldObjects.Add(new Enemy(10, 5));
            pWorldObjects.Add(new Enemy(24, 15));

            // Setting up the game loop.
            while (bIsRunning)
            {
                // Drawing the world.
                DrawWorld(pWorldObjects);

                // Updating the world.
                UpdateWorld(pWorldObjects);

                // TODO: Calculate if the distance between the player and 
                //  the enemies is greater than a particular amount and then
                //  dictate whether or not an enemy is dead.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(pPlayerObj.ToString() + " is in the world I guess?");
                Console.ForegroundColor = ConsoleColor.White;

                // Pausing in between iterations.
                Console.Write("\n\nReady to proceed?  Press enter!");
                Console.ReadLine();

                // Clearing the Console Window for the next DrawWorld method call.
                Console.Clear();
            }
        }

        /// <summary>
        /// Writes the world and all positioned objects in it to the console window.
        /// </summary>
        /// <param name="a_pPositionedObjects">List of all objects in the world.</param>
        public static void DrawWorld(List<IPosition> a_pPositionedObjects)
        {
            // Setting some world constants.
            const char WorldCharacter = '#';
            const int MaxCount = 25;

            // Looping along the Y axis.
            for (uint y = 0; y < MaxCount; y++)
            {
                Console.Write(WorldCharacter);

                // Looping along the X axis.
                for (uint x = 0; x < MaxCount; x++)
                {
                    bool bObjFlag = false;

                    // Looping through all objects to check if there are
                    //  at this particular (X, Y) position.
                    foreach (IPosition obj in a_pPositionedObjects)
                    {
                        // TODO: Uncomment after implementing the interfaces.
                        // If there is a match:
                        if (obj.X == x && obj.Y == y)
                        {
                            if (obj is Player)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else if (obj is Enemy)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                        
                            // Write the object's texture.
                            Console.Write(obj.Texture);
                        
                            // Set the object flag.
                            bObjFlag = true;
                        
                            // Reseting the console color.
                            Console.ForegroundColor = ConsoleColor.White;
                        
                            // Break from the loop.
                            break;
                        }
                    }

                    // If the flag was set, then continue to the next iteration.
                    if (bObjFlag) continue;

                    // Checking if we are in empty space or the world bounds.
                    if (y != 0 && y != MaxCount - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(WorldCharacter);
                    }
                }

                Console.WriteLine(WorldCharacter);
            }
        }

        /// <summary>
        /// Updates all of the positions of objects in the world.
        /// </summary>
        /// <param name="a_pPositionedObjects">List of all objects in the world.</param>
        public static void UpdateWorld(List<IPosition> a_pPositionedObjects)
        {
            Random pRandom = new Random();

            // Looping through all world updating objects.
            foreach (IPosition obj in a_pPositionedObjects)
            {
                // Choosing a random direction to travel in.
                Direction current = (Direction)pRandom.Next(1, 5);

                // Setting variables to move by.
                int uAmountY = 0;
                int uAmountX = 0;

                // Based on the random direction, set the variables to move by.
                switch (current)
                {
                    case Direction.Left:
                        uAmountX = -1;
                        break;
                    case Direction.Right:
                        uAmountX = 1;
                        break;
                    case Direction.Up:
                        uAmountY = -1;
                        break;
                    case Direction.Down:
                        uAmountY = 1;
                        break;
                }

                // TODO: Uncomment after implementing the interfaces.
                // Move by the variables.
                obj.MoveBy(uAmountX, uAmountY);

                // Make sure IPosition objects stay in bounds.
                obj.KeepInBounds();
            }
        }
    }
}

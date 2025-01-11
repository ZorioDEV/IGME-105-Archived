// * * * * * * * * * * * * * * * * * * * * * *
// *     Programmer: Johnny Fagerlin         *
// *      IGME 105 interfaces demo           *
// *            11.20.2024                   *
// * * * * * * * * * * * * * * * * * * * * * *

namespace InterfacesDemo
{
    /// <summary>
    /// Contains the definitions for objects that have positions in the world.
    /// </summary>
    public interface IPosition : IWrite
    {

        // Properties:
        // TODO: create a property for the X position
        public int X { get; set; }
        // TODO: create a property for the Y position
        public int Y { get; set; }

        // Methods:
        /// <summary>
        /// Moves the IPosition object by the specified amount.
        /// </summary>
        /// <param name="a_uOffsetX">The amount we are moving on the X axis.</param>
        /// <param name="a_uOffsetY">The amount we are moving on the Y axis.</param>
        // TODO: Create a void MoveBy method that takes in an X offset and Y offset.
        public void MoveBy( int a_uOffsetX, int a_uOffsetY);
        // TODO: Uncomment after implementing all parts of the interface.
        /// <summary>
        /// Keeps IPosition objects within bounds of the game world.
        /// </summary>
        public void KeepInBounds()
        {
            // Keeping the IPosition objects in bounds on the X axis.
            if (this.X >= 25)
            {
                this.X = 24;
            }
            else if (this.X <= 0)
            {
                this.X = 1;
            }
            
            // Keeping the IPosition objects in bounds on the Y axis.
            if (this.Y >= 25)
            {
                this.Y = 24;
            }
            else if (this.Y <= 0)
            {
                this.Y = 1;
            }
        }
    }
}

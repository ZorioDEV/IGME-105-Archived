// * * * * * * * * * * * * * * * * * * * * * *
// *     Programmer: Johnny Fagerlin         *
// *      IGME 105 interfaces demo           *
// *            11.20.2024                   *
// * * * * * * * * * * * * * * * * * * * * * *

namespace InterfacesDemo
{
    /// <summary>
    /// Generic player testing class for demo purposes.
    ///     Does not actually really do all that much.
    /// </summary>
    public class Player : IDistance
    {

        // Fields:
        private const char m_cTexture = 'O';
        private string m_sName;
        private int m_uLevel;
        private int m_uPositionX;
        private int m_uPositionY;

        // Properties:
        /// <summary>
        /// Read property for the Player's texture.
        /// </summary>
        public char Texture
        {
            get { return m_cTexture; }
        }

        // --------------------------------------------------------------------

        // TODO: Implement the X position property
        public int X
        {
            get { return m_uPositionX; }
            set { m_uPositionX = value; }
        }
        // TODO: Implement the Y position property
        public int Y
        {
            get { return m_uPositionY; }
            set { m_uPositionY = value; }
        }
        // Constructors:
        // TODO: Implement a default constructor.

        // --------------------------------------------------------------------

        /// <summary>
        /// Parameterized constructor for the Player class.
        /// </summary>
        /// <param name="a_sName">String name of the player.</param>
        /// <param name="a_uLevel">Int current level of the player.</param>
        public Player(string a_sName, int a_uLevel)
        {
            // Setting the passed in values.
            m_sName = a_sName;
            m_uLevel = a_uLevel;

            // Setting the player's starting location.
            m_uPositionX = 1;
            m_uPositionY = 1;
        }

        // Methods:
        /// <summary>
        /// Moves the calling Player by the specified amount.
        /// </summary>
        /// <param name="a_uOffsetX">Amount to move on the X axis.</param>
        /// <param name="a_uOffsetY">Amount to move by on the Y axis. 
        /// (Recall that down is positive)</param>
        public void MoveBy(int a_uOffsetX, int a_uOffsetY)
        {
            m_uPositionX += a_uOffsetX;
            m_uPositionY += a_uOffsetY;
        }

        /// <summary>
        /// Constructs a string representation of the calling Player instance.
        /// </summary>
        /// <returns>A string containing the calling Player's data.</returns>
        public override string ToString()
        {
            // Constructing a string representation of the player.
            return $"Player {m_sName}";
        }

    }
}

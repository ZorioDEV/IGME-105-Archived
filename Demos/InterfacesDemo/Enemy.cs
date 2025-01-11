using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    /// <summary>
    /// Enemy for the small console window game.
    /// </summary>
    public class Enemy : IDistance
    {

        // Fields:
        private char m_cTexture;
        private int m_uPositionX;
        private int m_uPositionY;
        private bool m_bIsDead;

        // Properties:
        /// <summary>
        /// Read property for the Enemy's texture.
        /// </summary>
        public char Texture
        {
            get { return m_cTexture; }
        }

        /// <summary>
        /// Read and write property for the Enemy's X position.
        /// </summary>
        public int X
        {
            get { return m_uPositionX; }
            set { m_uPositionX = value; }
        }

        /// <summary>
        /// Read and write property for the Enemy's Y position.
        /// </summary>
        public int Y
        {
            get { return m_uPositionY; }
            set { m_uPositionY = value; }
        }

        /// <summary>
        /// Read and Write property for whether or not the Enemy is dead.
        /// </summary>
        public bool IsDead
        {
            get { return m_bIsDead; }
            set { m_bIsDead = value; }
        }

        // Constructors:
        /// <summary>
        /// Functional default constructor of the Enemy class.
        /// </summary>
        /// <param name="a_cTexture">Character representation of the enemy.</param>
        public Enemy(char a_cTexture = 'X')
        {
            m_cTexture = a_cTexture;
            m_bIsDead = false;
            m_uPositionX = 1;
            m_uPositionY = 1;
        }
        /// <summary>
        /// Parameterized constructor of the Enemy class.
        /// </summary>
        /// <param name="a_uPositionX">Starting X position.</param>
        /// <param name="a_uPositionY">Starting Y position.</param>
        /// <param name="a_cTexture">Character representation for the Enemy.</param>
        public Enemy(int a_uPositionX, int a_uPositionY, char a_cTexture = 'X')
        {
            m_cTexture = a_cTexture;
            m_bIsDead = false;
            m_uPositionX = a_uPositionX;
            m_uPositionY = a_uPositionY;
        }

        // Methods:
        /// <summary>
        /// Moves the calling Enemy by the specified amount.
        /// </summary>
        /// <param name="a_uOffsetX">Amount to move on the X axis.</param>
        /// <param name="a_uOffsetY">Amount to move by on the Y axis. 
        /// (Recall that down is positive)</param>
        public void MoveBy(int a_uOffsetX, int a_uOffsetY)
        {
            m_uPositionX += a_uOffsetX;
            m_uPositionY += a_uOffsetY;
        }
    }
}

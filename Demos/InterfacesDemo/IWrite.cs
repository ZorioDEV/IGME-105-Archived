// * * * * * * * * * * * * * * * * * * * * * *
// *     Programmer: Johnny Fagerlin         *
// *      IGME 105 interfaces demo           *
// *            11.20.2024                   *
// * * * * * * * * * * * * * * * * * * * * * *

namespace InterfacesDemo
{
    /// <summary>
    /// Contains the definitions for objects that can be written to the console.
    /// </summary>
    public interface IWrite
    {
        /// <summary>
        /// Read property for the Writeable object's texture character.
        /// </summary>
        public char Texture { get; }

    }
}

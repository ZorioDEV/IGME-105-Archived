using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_Interfaces
{
    public interface IArea
    {
        // *** PROPERTIES ***
        double Area { get; }
        double Perimeter { get; }

        // *** MAIN CODE ***
        /// <summary>
        /// Tests if an (x,y) coordinate is within the area of the object.
        /// </summary>
        /// <param name="position">Position of the point.</param>
        /// <returns>True or False</returns>
        bool ContainsPosition(IPosition position);

        /// <summary>
        /// Test if this area larger than the area of another object.
        /// </summary>
        /// <param name="areaToCheck">Area of other object.</param>
        /// <returns>True or False</returns>
        bool IsLargerThan(IArea areaToCheck);
    }
}

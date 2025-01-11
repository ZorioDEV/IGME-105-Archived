using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_Interfaces
{
    public interface IPosition
    {
        // *** PROPERTIES ***
        double X { get; set; }
        double Y { get; set; }

        // *** MAIN CODE ***
        /// <summary>
        /// Distance formula for two points.
        /// </summary>
        /// <param name="position">Position of the value.</param>
        /// <returns>Distance between the 2 points.</returns>
        double DistanceTo(IPosition position);

        /// <summary>
        /// Moves x- and y-values to new location.
        /// </summary>
        /// <param name="x">New X-value</param>
        /// <param name="y">New Y-value</param>
        void MoveTo(double x, double y);

        /// <summary>
        /// Moves x- and y-values by a specified amount.
        /// </summary>
        /// <param name="xOffset">Amount of values moved in the x-values.</param>
        /// <param name="yOffset">Amount of values moved in the y-values.</param>
        void MoveBy(double xOffset, double yOffset);
    }
}

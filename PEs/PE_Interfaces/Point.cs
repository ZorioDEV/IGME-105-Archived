using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_Interfaces
{
    public class Point : IPosition
    {
        // *** PROPERTIES ***
        public double X { get; set; }
        public double Y { get; set; }

        // *** METHODS ***
        /// <summary>
        /// Main constructor for Point, assigns x and y accordingly.
        /// </summary>
        /// <param name="x">X-value</param>
        /// <param name="y">Y-value</param>
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Distance formula for two points.
        /// </summary>
        /// <param name="position">Position of the value.</param>
        /// <returns>Distance between the 2 points.</returns>
        public double DistanceTo(IPosition position)
        {
            return Math.Sqrt(Math.Pow(X - position.X, 2) + Math.Pow(Y - position.Y, 2));
        }

        /// <summary>
        /// Moves x- and y-values to new location.
        /// </summary>
        /// <param name="x">New X-value</param>
        /// <param name="y">New Y-value</param>
        public void MoveTo(double x, double y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Moves x- and y-values by a specified amount.
        /// </summary>
        /// <param name="xOffset">Amount of values moved in the x-values.</param>
        /// <param name="yOffset">Amount of values moved in the y-values.</param>
        public void MoveBy(double xOffset, double yOffset)
        {
            X += xOffset;
            Y += yOffset;
        }

        /// <summary>
        /// Prints the point's values.
        /// </summary>
        /// <returns>String of X- and Y-values.</returns>
        public override string ToString()
        {
            return $"Point(X: {X}, Y: {Y})";
        }
    }
}

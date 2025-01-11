using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_Interfaces
{
    public class Circle : IPosition, IArea
    {
        // *** PROPERTIES ***
        public double X { get; set; }
        public double Y { get; set; }
        public double Radius { get; }

        /// <summary>
        /// Main constructor for Circle, assigns x-values, y-values, & radius. 
        /// </summary>
        /// <param name="x">X-value</param>
        /// <param name="y">Y-value</param>
        /// <param name="radius">Radius value</param>
        public Circle(double x, double y, double radius)
        {
            X = x;
            Y = y;
            Radius = radius;
        }

        /// <summary>
        /// Calculates area of a circle.
        /// </summary>
        public double Area => Math.PI * Math.Pow(Radius, 2);

        /// <summary>
        /// Calculates perimeter of a circle.
        /// </summary>
        public double Perimeter => 2 * Math.PI * Radius;

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
        /// Tests if an (x,y) coordinate is within the area of the object.
        /// </summary>
        /// <param name="position">Position of the point.</param>
        /// <returns>True or False</returns>
        public bool ContainsPosition(IPosition position)
        {
            return DistanceTo(position) <= Radius;
        }

        /// <summary>
        /// Test if this area larger than the area of another object.
        /// </summary>
        /// <param name="areaToCheck">Area of other object.</param>
        /// <returns>True or False</returns>
        public bool IsLargerThan(IArea areaToCheck)
        {
            return Area > areaToCheck.Area;
        }

        /// <summary>
        /// Prints out values of the circle's values & data.
        /// </summary>
        /// <returns>String of X, Y, Radius, Area, & Perimeter values.</returns>
        public override string ToString()
        {
            return $"Circle(X: {X}, Y: {Y}, Radius: {Radius}, Area: {Area}, Perimeter: {Perimeter})";
        }
    }
}

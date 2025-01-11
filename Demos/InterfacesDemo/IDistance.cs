// * * * * * * * * * * * * * * * * * * * * * *
// *     Programmer: Johnny Fagerlin         *
// *      IGME 105 interfaces demo           *
// *            11.20.2024                   *
// * * * * * * * * * * * * * * * * * * * * * *

namespace InterfacesDemo
{
    /// <summary>
    /// Interface for objects that calculate their distance from other objects.
    /// </summary>
    public interface IDistance : IPosition
    {

        // The distance formula:
        /*   
         
         d = sqrt(
                sum(
                    pow((x2 - x1), 2),
                    pow((y2 - y1), 2)
                )        
             )      
        
         */

        // Methods:
        public double Distance(IDistance a_pDistance)
        {
            double dDifferenceX = Math.Pow(a_pDistance.X - this.X, 2);
            double dDifferenceY = Math.Pow(a_pDistance.Y - this.X, 2);

            return Math.Sqrt(dDifferenceX + dDifferenceY);
        }
    }
}

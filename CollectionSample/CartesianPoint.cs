/*  CartesianPoint.cs - Defines the CartesianPoint Class
 * 
 *  Author:     Thom MacDonald
 *  Author:     Your Name
 *  Since:       Jan 2016 <update>
 *  
 *  Added for Tutorial 4 - Collections
 *  - MyCoordinates() iterator
 *  - GetEnumerator() iterator
 *  - Clone() - Shallow copying to support ICloneable
 *  - ShallowClone() - An alternative to implementing ICloneable
 */

using System;

namespace CollectionSample
{
    /// <summary>
    /// The CartesianPoint class represents a point on a 2-D plane, designateded by two integer coordinates: X and Y.
    /// </summary>
    /// <see cref="https://en.wikipedia.org/wiki/Cartesian_coordinate_system"/>
    public class CartesianPoint
    {

        #region TUTORIAL 2 
        /// <summary>
        /// Represents the maximum coordinate value
        /// </summary>
        private static int theLimit = 100; // private static (shared) field, initialized
        public static int Limit            // public property linked to the private field 
        {
            get // Accessing
            {
                return theLimit;
            }
            set // Mutating
            {
                theLimit = value;
            }
        }

        /// <summary>
        /// Represents the X coordinate value
        /// </summary>
        private int myX;    // private instance field
        public int X        // public property linked to the private field
        {
            get // Accessing the field
            {
                return myX;
            }
            set // Mutating the field
            {
                // if valid:
                if (value >= -Limit && value <= Limit)
                {
                    myX = value; // set the field
                }
                // otherwise:
                else
                {
                    // throw an exception
                    throw (new ArgumentOutOfRangeException("X", value, "X value must be assigned a value between +/- " + Limit + "."));
                }
            }
        }

        /// <summary>
        /// Represents the Y coordinate value
        /// </summary>
        private int myY;    // private instance field
        public int Y        // public property linked to the private field
        {
            get // Accessing the field
            {
                return myY;
            }
            set // Mutating the field
            {
                // if valid:
                if (value >= -Limit && value <= Limit)
                {
                    myY = value; // set the field
                }
                // otherwise:
                else
                {
                    // throw an exception
                    throw (new ArgumentOutOfRangeException("Y", value, "Y value must be assigned a value between +/- " + Limit + "."));
                }
            }
        }

        /// <summary>
        /// Constructor for instances of CartesianPoint
        /// </summary>
        /// <param name="x">X coordinate value</param>
        /// <param name="y">Y coordinate value</param>
        public CartesianPoint(int x = 0, int y = 0)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// SetPoint - modifies the X, Y coordinates for an existing point.
        /// </summary>
        /// <param name="x">X coordinate value</param>
        /// <param name="y">Y coordinate value</param>
        public void SetPoint(int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// ToString - converts the X, Y coordinates into a string in the accepted notation: (X, Y).
        /// </summary>
        /// <returns>the X, Y coordinates as a string</returns>
        public override string ToString()
        {
            return string.Format("({0:F0}, {1:F0})", myX, myY);
        }

        /// <summary>
        /// operator-(CartesianPoint, CartesianPoint) - Calculates the distance between two points
        /// </summary>
        /// <param name="pointA">one CartesianPoint</param>
        /// <param name="pointB">another CartesianPoint</param>
        /// <returns>The distance between the two parameter points</returns>
        /// <seealso cref="https://msdn.microsoft.com/en-us/library/8edha89s%28v=vs.110%29.aspx"/>

        public static double operator -(CartesianPoint pointA, CartesianPoint pointB)
        {
            // return the formula (based on Pythagorean theorem)
            return Math.Sqrt(
                (pointA.myX - pointB.myX) * (pointA.myX - pointB.myX) +
                (pointA.myY - pointB.myY) * (pointA.myY - pointB.myY));
        }
        #endregion


        /*******************************************************

         ********************************************************/
        #region TUTORIAL 4
        /// <summary>
        /// An iterator method that supplies each of the values to be used in a foreach block in sequence.
        /// </summary>
        /// <returns>The x then y coordinates in sequence.</returns>
        public System.Collections.IEnumerable myCoordinates()
        {
            yield return X; //Returns x first
            yield return Y; //Returns y next
        }

        /// <summary>
        /// GetEnumerator(), An iterator method that supplies each of the values to be used in a foreach block in sequence. 
        /// </summary>
        /// <returns>The x then y coordinates in sequence.</returns>
        public System.Collections.IEnumerator GetEnumerator()
        {
            yield return X;
            yield return Y;
        }

        /// <summary>
        /// Implementing cloning functionality for the CartesianPoint class. Shallow copying is sufficient because CartesianPoint contains only value-type data.
        /// </summary>
        /// <returns>A shallow copy of the object.</returns>
        /// <remarks>Some programmers disagree with implementing ICloneable because there is no way to determine if the copy/clone is shallow or deep. See ref.</remarks>
        /// <see cref="http://blogs.msdn.com/b/brada/archive/2003/04/09/49935.aspx"/>
        

        /// <summary>
        /// A practical alternative to supporting ICloneable.
        /// </summary>
        /// <param name="source">The point we want to clone</param>
        /// <returns>A shallow copy of the point.</returns>
        

        #endregion
    }
}

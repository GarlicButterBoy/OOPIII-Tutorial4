/*  PointList.cs - Defines an index-based CartesianPoint collection class
 * 
 *  Author:     Thom MacDonald
 *  Author:     Your Name
 *  Since:       Jan 2016 <update>
 */

using System;
using System.Collections; // for CollectionBase abstract class. 

namespace CollectionSample
{
    public class PointList
    {
        /*******************************************************
        * Part 1 - Basic PointList class:
        ********************************************************/
        
        /// <summary>
        /// Add(), implemented as a strongly typed method.
        /// </summary>
        /// <param name="newPoint">The object to add. Must be a CartesianPoint or something derived from CartesianPoint.</param>
        

        /// <summary>Additional IList/InnerList methods to implement as strongly typed methods.</summary>
        /// <remarks>Note these are just examples. There are others.</remarks>
        /// <see cref="https://msdn.microsoft.com/en-us/library/system.collections.collectionbase%28v=vs.110%29.aspx"/>
        
        /// <summary>
        /// An indexer is a special kind of property that you can add to a class to provide array-like access.
        /// </summary>
        /// <param name="pointIndex"></param>
        /// <returns>The index in the List we wish to access.</returns>

        /*******************************************************
         * Part 2 - Iterators
         ********************************************************/
        /// <summary>
        /// Hides the base class GetEnumerator(). Adds some Debugging messages.
        /// </summary>
        /// <returns>Each point in sequence.</returns>
        
        /*******************************************************
         * Part 5 - Deep Copying
         ********************************************************/

        /// <summary>
        /// Default constructor for empty PointList objects.
        /// </summary>
        

        /// <summary>
        /// Constructor for copying PointList objects safely
        /// </summary>
        /// <remarks>Similair to a copy constructor in C++</remarks>
        /// <param name="sourceList"></param>
        

        /// <summary>
        /// A practical alternative to supporting ICloneable.
        /// </summary>
        /// <param name="source">The point list we want to clone</param>
        /// <returns>A deep copy of the point list.</returns>
        

    }
}

/*  PointList.cs - Defines an index-based CartesianPoint collection class
 * 
 *  Author:     Thom MacDonald
 *  Author:     Nick Sturch-Flint
 *  Since:      Feb 7, 2021
 */


using System;
using System.Collections; // for CollectionBase abstract class. 
using System.Collections.Generic;

namespace CollectionSample 
{
    public class PointList : CollectionBase
    {
        /*******************************************************
        * Part 1 - Basic PointList class:
        ********************************************************/
        
        /// <summary>
        /// Add(), implemented as a strongly typed method.
        /// </summary>
        /// <param name="newPoint">The object to add. Must be a CartesianPoint or something derived from CartesianPoint.</param>
        public void Add(CartesianPoint newPoint)
        {
            //Use list, gives access to items through an IList Interface
            //List.Add(newPoint);
            //Use the ArrayList object used to store items
            InnerList.Add(newPoint);
        }

        /// <summary>Additional IList/InnerList methods to implement as strongly typed methods.</summary>
        /// <remarks>Note these are just examples. There are others.</remarks>
        /// <see cref="https://msdn.microsoft.com/en-us/library/system.collections.collectionbase%28v=vs.110%29.aspx"/>
        public void Insert(int theIndex, CartesianPoint newPoint) { List.Insert(theIndex, newPoint); }
        public void Remove(CartesianPoint oldPoint) { List.Remove(oldPoint); }
        public bool Contains(CartesianPoint aPoint) { return List.Contains(aPoint); }
        /// <summary>
        /// An indexer is a special kind of property that you can add to a class to provide array-like access.
        /// </summary>
        /// <param name="pointIndex"></param>
        /// <returns>The index in the List we wish to access.</returns>
        public CartesianPoint this[int pointIndex]
        {
            get
            {
                return (CartesianPoint)List[pointIndex];
            }
            set
            {
                List[pointIndex] = value;
            }
        }
        /*******************************************************
         * Part 2 - Iterators
         ********************************************************/
        /// <summary>
        /// Hides the base class GetEnumerator(). Adds some Debugging messages.
        /// </summary>
        /// <returns>Each point in sequence.</returns>
        public new IEnumerator GetEnumerator()
        {
            foreach (object point in List)
            {
                System.Diagnostics.Debug.WriteLine("Returning next point...");
                yield return point;
            }
        }
        /*******************************************************
         * Part 5 - Deep Copying
         ********************************************************/

        /// <summary>
        /// Default constructor for empty PointList objects.
        /// </summary>
        public PointList() { }

        /// <summary>
        /// Constructor for copying PointList objects safely
        /// </summary>
        /// <remarks>Similair to a copy constructor in C++</remarks>
        /// <param name="sourceList"></param>
        public PointList(PointList sourceList)
        {
            foreach (CartesianPoint point in sourceList)
            {
                this.Add(CartesianPoint.ShallowClone(point));
            }
        }

        /// <summary>
        /// A practical alternative to supporting ICloneable.
        /// </summary>
        /// <param name="source">The point list we want to clone</param>
        /// <returns>A deep copy of the point list.</returns>
        public static PointList DeepClone(PointList sourceList)
        {
            PointList copyList = new PointList();

            foreach (CartesianPoint point in sourceList)
            {
                copyList.Add(CartesianPoint.ShallowClone(point));
            }

            return copyList;
        }

    }
}

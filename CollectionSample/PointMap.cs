/*  PointMap.cs - Defines a 'keyed' CartesianPoints Collection Class
 * 
 *  Author:     Thom MacDonald
 *  Author:     Nick Sturch-Flitn
 *  Since:      Feb 7, 2021
 */

using System;
using System.Collections; // for DictionaryBase abstract class. 

namespace CollectionSample 
{
    
    /// <summary>
    /// PointMap is a container of CartesianPoint objects based on a Dictionary
    /// </summary>
    /// <see cref="https://msdn.microsoft.com/en-us/library/system.collections.dictionarybase%28v=vs.110%29.aspx"/>
    public class PointMap : DictionaryBase, ICloneable
    {
        /// <summary>
        /// Add(), implemented as a strongly typed method.
        /// </summary>
        /// <param name="newKey">The key value associated with the object.</param>
        /// <param name="newPoint">The object to add. Must be a CartesianPoint or something derived from CartesianPoint.</param>
        public void Add(string newKey, CartesianPoint newPoint)
        {
            Dictionary.Add(newKey, newPoint);
        }

        /// <summary>
        /// Remove(), implemented as a strongly typed method.
        /// </summary>
        /// <param name="newPoint">The object to remove. Must be a CartesianPoint or something derived from CartesianPoint.</param>
        public void Remove(CartesianPoint oldPoint)
        {
            Dictionary.Remove(oldPoint);
        }
        /// <summary>
        /// Contains() - determines if a key is in the dictionary 
        /// </summary>
        /// <param name="key">The key we are looking for.</param>
        /// <returns>True if the key is in the dictionary, false if not.</returns>
        public bool Contains(string key)
        {
           return Dictionary.Contains(key);
        }
        /// <summary>
        /// An indexer is a special kind of property that provides access to objects in the collection through the sub-script operator.
        /// </summary>
        /// <param name="theKey">The key in the Dictionary we wish to access</param>
        /// <returns>The CartesianPoitn associated with that key.</returns>
        public CartesianPoint this[string theKey]
        {
            get { return (CartesianPoint)Dictionary[theKey];            }
            set { Dictionary[theKey] = value; }
        }

        
        /// <summary>
        /// A property to access the collection of keys.
        /// </summary>
        public ICollection Keys
        {
            get { return Dictionary.Keys; }
        }

        /// <summary>
        /// A property to access the collection of values.
        /// </summary>
        public ICollection Values
        {
            get { return Dictionary.Values; }
        }

        /*******************************************************
         * Part 4 -Copy/Cloning
         ********************************************************/

        /// <summary>
        /// Default constructor for empty PointMap objects.
        /// </summary>
        public PointMap() { }

        /// <summary>
        /// Constructor for copying PointMap objects safely
        /// </summary>
        /// <remarks>Similar to a copy constructor in C++</remarks>
        /// <param name="sourceList"></param>
        public PointMap(PointMap sourceMap)
        {
            foreach (string key in sourceMap.Keys)
            {
                this.Add(key, sourceMap[key].Clone() as CartesianPoint);
            }
        }

        /// <summary>
        /// Implementing cloning functionality for the PointMap class. Deep copying is needed because PointMap contains reference-type data.
        /// </summary>
        /// <returns>A deep copy of the object.</returns>
        /// <remarks>Some programmers disagree with implementing ICloneable because there is no way to determine if the copy/clone is shallow or deep. See ref.</remarks>
        /// <see cref="http://blogs.msdn.com/b/brada/archive/2003/04/09/49935.aspx"/>
        public object Clone()
        {
            PointMap newMap = new PointMap();

            foreach (string key in Dictionary.Keys)
            {
                newMap.Add(key, this[key].Clone() as CartesianPoint);
            }
            return newMap;
        }

    }
}

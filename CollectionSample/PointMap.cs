/*  PointMap.cs - Defines a 'keyed' CartesianPoints Collection Class
 * 
 *  Author:     Thom MacDonald
 *  Author:     Your Name
 *  Since:       Jan 2016 <update>
 */

using System;
using System.Collections; // for DictionaryBase abstract class. 

namespace CollectionSample
{
    
    /// <summary>
    /// PointMap is a container of CartesianPoint objects based on a Dictionary
    /// </summary>
    /// <see cref="https://msdn.microsoft.com/en-us/library/system.collections.dictionarybase%28v=vs.110%29.aspx"/>
    public class PointMap
    {
        /// <summary>
        /// Add(), implemented as a strongly typed method.
        /// </summary>
        /// <param name="newKey">The key value associated with the object.</param>
        /// <param name="newPoint">The object to add. Must be a CartesianPoint or something derived from CartesianPoint.</param>
        

        /// <summary>
        /// Remove(), implemented as a strongly typed method.
        /// </summary>
        /// <param name="newPoint">The object to remove. Must be a CartesianPoint or something derived from CartesianPoint.</param>

        /// <summary>
        /// Contains() - determines if a key is in the dictionary 
        /// </summary>
        /// <param name="key">The key we are looking for.</param>
        /// <returns>True if the key is in the dictionary, false if not.</returns>

        /// <summary>
        /// An indexer is a special kind of property that provides access to objects in the collection through the sub-script operator.
        /// </summary>
        /// <param name="theKey">The key in the Dictionary we wish to access</param>
        /// <returns>The CartesianPoitn associated with that key.</returns>

        
        /// <summary>
        /// A property to access the collection of keys.
        /// </summary>


        /// <summary>
        /// A property to access the collection of values.
        /// </summary>


        /*******************************************************
         * Part 4 -Copy/Cloning
         ********************************************************/

        /// <summary>
        /// Default constructor for empty PointMap objects.
        /// </summary>
        

        /// <summary>
        /// Constructor for copying PointMap objects safely
        /// </summary>
        /// <remarks>Similar to a copy constructor in C++</remarks>
        /// <param name="sourceList"></param>
        

        /// <summary>
        /// Implementing cloning functionality for the PointMap class. Deep copying is needed because PointMap contains reference-type data.
        /// </summary>
        /// <returns>A deep copy of the object.</returns>
        /// <remarks>Some programmers disagree with implementing ICloneable because there is no way to determine if the copy/clone is shallow or deep. See ref.</remarks>
        /// <see cref="http://blogs.msdn.com/b/brada/archive/2003/04/09/49935.aspx"/>
        

    }
}

/*  Program.cs - Defines the Program class for the Collections video exercise
 * 
 *  Author:     Thom MacDonald
 *  Author:     Your Name
 *  Since:       Jan 2016 <update>
 *  See:        https://www.youtube.com/playlist?list=PLfNfAX7mRzNpBAcNk36dCtWmaZ8uEE_lc
 */

using System;
using System.Diagnostics; // for Debug and Trace objects
using System.Collections; // for DictionaryEntry class. 

namespace CollectionSample
{
   
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                /*******************************************************
                 * Part 1 - Basic PointList class:
                 * - Declare a PointList
                 * - Use PointList Methods (Add, Insert, Remove)
                 * - Iterate through a PointList object.
                 ********************************************************/
                
                // Create an empty point list
                PointList myList = new PointList();

                // Add two new points:
                myList.Add(new CartesianPoint(3, 4));
                myList.Add(new CartesianPoint(88, 99));
                myList.Add(new CartesianPoint(4, 4));

                // Show the points (foreach loop - inherited functionality from CollectionBase)
                Console.WriteLine("After adding, here are the points stored in myList");
                foreach (CartesianPoint point in myList)
                {
                    Console.WriteLine("\t" + point.ToString());
                }
                // Insert a new point at the start
                myList.Insert(0, new CartesianPoint(6, 7));
                // Show the points (for loop using sub-script)
                for (int index = 0; index < myList.Count; index++)
                {
                    Console.WriteLine("\tmyList[{0}]: {1}", index, myList[index].ToString());
                }
                // Remove a point
                CartesianPoint aPoint = myList[2];
                // Create a reference to the point we want to remove
                // remove that point
                myList.Remove(aPoint);
                // Show the points
                Console.WriteLine("After removing, here are the points stored in myList");
                for (int index = 0; index < myList.Count; index++)
                {
                    Console.WriteLine("\tmyList[{0}]: {1}", index, myList[index].ToString());
                }

                // pause program.
                Console.WriteLine("\nPress any key to continue...");
                //Console.ReadKey();
                Console.Clear();

                /*******************************************************
                 * Part 2 - Iterators:
                 ********************************************************/

                // Iterate through a single point's coordinate values using MyCoordinates iterator:
                Console.WriteLine("\nThe individual coordinates for {0} are: ", aPoint);
                foreach (int coordinate in aPoint.myCoordinates())
                {
                    Console.WriteLine("\t{0}", coordinate);
                }
                // Iterate through a single point's coordinate values using GetEnumerator():
                Console.WriteLine("\nThe individual coordinates for {0} are: ", aPoint);
                foreach (int coordinate in aPoint)
                {
                    Console.WriteLine("\t{0}", coordinate);
                }
                // Iterate through myList using GetEnumerator(). Watch the output window.
                Console.WriteLine("\nThe points stored in myList are: ");
                foreach (CartesianPoint point in myList)
                {
                    Console.WriteLine("\t" + point.ToString());
                }
                // pause program.
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();

                /*******************************************************
                 * Part 3 - Keyed Collections:
                 * - Declare a PointMap and Add entries
                 * - Iterate through a PointMap
                 * - Use PointList Methods (Add, Insert, Remove)
                 * - Iterate through a PointList object.
                 ********************************************************/

                // Create a new points map and add some entries
                
                // Show the entries (foreach loop - inherited functionality from DictionaryBase)
                
                // Change one of the entries (uses Indexer)
                
                // Show the entries (foreach loop using Keys property)
                
                // pause program.
                Console.WriteLine("\nPress any key to continue...");
                //Console.ReadKey();
                Console.Clear();

                /*******************************************************
                 * Part 4 - Cloning:
                 ********************************************************/
                 // A new key

                 // mySecondMap is a reference to myMap
                 // mySecondMap is a copy of myMap
                 // mySecondMap is clone (copy) of myMap

                 // Adding to mySecondMap

                // Does myMap contain the new key?
                
                // pause program.
                Console.WriteLine("\nPress any key to continue...");
                //Console.ReadKey();
                Console.Clear();

                /*******************************************************
                 * Part 5 - Deep Copying:
                 ********************************************************/

                 // mySecondList is a reference to myList
                 // mySecondList is a copy of myList
                 // mySecondList is a ' deep clone' of myList

                 // Create a new point
                 // Adding to mySecondList

                // Does myList contain the new point?
                
                
            }
            catch (Exception e)
            {
                // Show the type of exception, and the exception message to the user.
                Console.WriteLine("\n{0}\n{1}", e.GetType(), e.Message);
            }

            // end of program.
            Console.WriteLine("\nPress any key to end the program...");
            Console.ReadKey();

        }
    }
}

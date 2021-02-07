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
                //Console.ReadKey();
                Console.Clear();

                /*******************************************************
                 * Part 3 - Keyed Collections:
                 * - Declare a PointMap and Add entries
                 * - Iterate through a PointMap
                 * - Use PointList Methods (Add, Insert, Remove)
                 * - Iterate through a PointList object.
                 ********************************************************/

                // Create a new points map and add some entries
                PointMap myMap = new PointMap();
                myMap.Add("Home", new CartesianPoint(99, 99));
                myMap.Add("School", new CartesianPoint(45, 3));
                myMap.Add("Work", new CartesianPoint(95, 9));

                // Show the entries (foreach loop - inherited functionality from DictionaryBase)
                Console.WriteLine("\nAfter adding, here are the entries stored in myMap");
                Console.WriteLine("\nKEY        VALUE\n=================");
                foreach (DictionaryEntry entry in myMap)
                {
                    Console.WriteLine("{0}{1}", entry.Key.ToString().PadRight(10), entry.Value);
                }
                // Change one of the entries (uses Indexer)
                myMap["Home"] = new CartesianPoint(0, 0);

                // Show the entries (foreach loop using Keys property)
                Console.WriteLine("\nAfter editing, here are the entries stored in myMap");
                Console.WriteLine("\nKEY        VALUE\n=================");
                foreach (string key in myMap.Keys)
                {
                    Console.WriteLine("{0}{1}", key.PadRight(10), myMap[key]);
                }
                // pause program.
                Console.WriteLine("\nPress any key to continue...");
                //Console.ReadKey();
                Console.Clear();

                /*******************************************************
                 * Part 4 - Cloning:
                 ********************************************************/
                // A new key
                string pub = "Pub";
                // mySecondMap is a reference to myMap
                //PointMap mySecondMap = myMap;
                // mySecondMap is a copy of myMap
                //PointMap mySecondMap = new PointMap(myMap);
                // mySecondMap is clone (copy) of myMap
                PointMap mySecondMap = myMap.Clone() as PointMap;
                // Adding to mySecondMap
                mySecondMap.Add(pub, new CartesianPoint(88, 88));
                // Does myMap contain the new key?
                Console.WriteLine("AFter modifaication of mySecondMap, myMap {0} contains \"{1}\".",
                myMap.Contains(pub) ? "does" : "does not", pub);

                Console.WriteLine("\nAll entries in myMap");
                Console.WriteLine("\nKEY        VALUE\n=================");
                foreach (string key in myMap.Keys)
                {
                    Console.WriteLine("{0}{1}", key.PadRight(10), myMap[key]);
                }
                // pause program.
                Console.WriteLine("\nPress any key to continue...");
                //Console.ReadKey();
                Console.Clear();

                /*******************************************************
                 * Part 5 - Deep Copying:
                 ********************************************************/

                // mySecondList is a reference to myList
                //PointList mySecondList = myList;
                // mySecondList is a copy of myList
                //PointList mySecondList = new PointList(myList);
                // mySecondList is a ' deep clone' of myList
                PointList mySecondList = PointList.DeepClone(myList);

                // Create a new point
                CartesianPoint newPoint = new CartesianPoint(88, 99);
                // Adding to mySecondList
                mySecondList.Add(newPoint);

                // Does myList contain the new point?
                Console.WriteLine("\nAfter modding mySecondList, myList {0} contain {1}.",
                    myList.Contains(newPoint) ? "does" : "does not", newPoint);

                Console.WriteLine("\nCurrently stored in List: ");
                for (int index = 0; index < myList.Count; index++)
                {
                    Console.WriteLine("\tmyList[{0}]: {1}", index, myList[index].ToString());
                }

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

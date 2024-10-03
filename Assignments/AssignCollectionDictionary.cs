using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AssignCollectionDictionary
    {
       static void Main()
        {
            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "One");
            dt.Add(2, "Two");
            dt.Add(3, "Three");
            dt.Add(4, "Four");
            dt.Add(5, "Five");
            dt.Add(6, "Six");
            dt.Add(7, "Seven");
            dt.Add(8, "Eight");
            dt.Add(9, "Nine");
            dt.Add(10, "Ten");

            //Display elements on Console
            Console.WriteLine("Elements of Dictionary-------------->");
            foreach (KeyValuePair<int, string> kvp in dt)
            {
                Console.WriteLine($"{kvp.Key})  {kvp.Value}");

            }

            //Modifying element from Dictionary
            dt[3] = "THREE";
            dt[4] = "FOUR";
            dt[5] = "FIVE";
            Console.WriteLine("After modification---->");
            foreach (KeyValuePair<int, string> kvp in dt)
            {
                Console.WriteLine($"{kvp.Key})  {kvp.Value}");

            }

            //Removing element from ductionary
            dt.Remove(6);
            dt.Remove(8);
            Console.WriteLine("After removing 6th and 8th element---->");
            foreach (KeyValuePair<int, string> kvp in dt)
            {
                Console.WriteLine($"{kvp.Key})  {kvp.Value}");

            }

            //filter element in the dictionary
            Console.WriteLine("Filtering elements---->");
            if (dt.ContainsKey(9) && dt.ContainsKey(10))
            {
                Console.WriteLine("Yes, key: 9 & 10 exists in dictionary");
            }

            dt.Clear();
            Console.WriteLine(dt.Count());





        }

    }
}

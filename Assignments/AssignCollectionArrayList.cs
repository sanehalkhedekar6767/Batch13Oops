using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AssignCollectionArrayList
    {
        static void Main()
        {
            //creating array list
            ArrayList array = new ArrayList();

            array.Add(1);
            array.Add(2);   
            array.Add(3);   
            array.Add(4);
            array.Add(5);
            array.Add(6);   
            array.Add(7);
            array.Add(8);
            array.Add(9);
            array.Add(10);
            Console.WriteLine("Original array-------------->");
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("After removing element from array-------------->");
            array.Remove(3);
            foreach (int item in array)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("After clear operation on array-------------->");
            array.Clear();
            foreach (int item in array)
            {
                Console.WriteLine(item + " ");
            }



        }
    }
}

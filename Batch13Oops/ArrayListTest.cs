using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class ArrayListTest
    {
        static void Main()
        {
            //creating object of array list
            ArrayList list = new ArrayList();

            //adding element in to array list
            list.Add(1);
            list.Add("Hello");    
            list.Add(true);

            //access the elements/items
            Console.WriteLine("Array List elements: Add");
            foreach (var item in list)
            {
                Console.WriteLine(item + " "); 
            }

            //Remove item
            list.Remove(true);
            Console.WriteLine("Array List elements: Remove item");
            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }

            ////RemoveAt
            //list.RemoveAt(1);
            //Console.WriteLine("Array List elements: RemoveAt");
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item + " ");
            //}

            //Reverse
            list.Reverse();
            Console.WriteLine("Reverse Array List elements: ");
            foreach (var item in list)
            {
                Console.WriteLine(item + " ");
            }


        }

        
    }
}

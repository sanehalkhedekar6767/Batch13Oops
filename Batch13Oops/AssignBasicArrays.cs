using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class AssignBasicArrays
    {
        static void Main()
        {

            Console.WriteLine("Assignment 1 -------------------------------------->");
            int[] array = { 2, 4, 6, 8, 10 };
            int sum = 0;
            Console.Write("Array is: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
                sum += i;
            }
            
            Console.WriteLine("\nSum of elements of array is: "+sum);

            Console.WriteLine("Assignment 2 -------------------------------------->");
            Console.WriteLine("Average of array elements is: "+(sum / array.Length));

        }
    }
}

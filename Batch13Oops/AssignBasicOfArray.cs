using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AssignBasicOfArray
    {
       
        static void Main()
        {
            int[] array = { 9, 7, 4, 2, 5, 3, 6, 8, 10};
            Console.Write("Given array is: ");
            for (int k = 0; k < array.Length; k++)
            {
                Console.Write(array[k] + " ");
            }

            //Print alternate elements of an array
            Console.Write("\nAlternate elements of the array are: ");

            for (int i = 0; i < array.Length; i+=2)
            {
                Console.Write(array[i] + " ");

            }

            //Print number of elements in an array
            Console.WriteLine($"\nNumber of elements in array are: {array.Length}");

            //Print minimum value in array 
            int min = array[0];
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] < min)
                {
                    min = array[j];
                }

            }
            Console.WriteLine($"Minimum element of array is: {min}");

            //Print minimum value in array 
            int max = array[0];
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    max = array[j];
                }

            }
            Console.WriteLine($"Maximum element of array is: {max}");
        }
    }
}

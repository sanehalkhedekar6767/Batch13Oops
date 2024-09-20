using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class Assign2Array2
    {

        static void Main()
        {
            int countEven = 0;
            int countOdd = 0;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Console.Write("Given array is: ");
            foreach (int num in array)
            {
                if (num % 2 == 0)
                {
                    countEven++;
                }
                else
                {
                    countOdd++;
                }
                Console.Write(" "+num+" ");
            }
            Console.WriteLine("\nTotal even numbers in array are: " + countEven);
            Console.WriteLine("Total odd numbers in array are: " + countOdd);

        }
    }
}

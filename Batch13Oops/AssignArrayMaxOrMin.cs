using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class AssignArrayMaxOrMin
    {
        static void Main()
        {
            
            int[] array = { 50, 30, 80, 10, 40 };
            int max = array[0];
            int min = array[0];
            foreach (int num in array)
            {
                if (num>max)
                {
                    max = num;
                }
                if (num<min)
                {
                    min = num; 
                }
            }
            Console.WriteLine("Maximum number is :" + max);
            Console.WriteLine("Minimum number is :" + min);
        }
    }
}

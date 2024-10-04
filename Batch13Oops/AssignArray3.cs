using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AssignArray3
    {

        static void Main(String[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int count = 0;
            Console.WriteLine("Prime numbers in given array are: ");
            for (int i = 0; i< nums.Length; i++)
            {
                count = 0;
                for (int j = 2; j < nums[i]; j++)
                {
                    if (nums[i] % j == 0)
                    {
                        count++;
                        break;
                    }
                }
                if (count==0 && nums[i] >= 2)
                {
                    Console.Write(nums[i] + "  ");
                }
            }
        }
    }
}

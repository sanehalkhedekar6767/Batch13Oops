using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Assign2Break
    {
        static void Main()
        {
            int sum = 0;
            Console.WriteLine("Break statement------------------------->");
            while (true)
            {
                Console.Write("Enter the number: ");
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    break;
                }
                else
                {
                    sum = sum + number;
                    Console.WriteLine("Sum is: "+sum);
                }
            }
        }
    }
}

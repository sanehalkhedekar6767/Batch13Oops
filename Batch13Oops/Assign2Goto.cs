using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Assign2Goto
    {
        static void Main()
        {
            //goto statement
            Console.WriteLine("Goto Statement-------------------------->");
        start:
            Console.Write("Enter the age between 0 & 120: ");
            int age = int.Parse(Console.ReadLine());
            if (age > 0 && age < 120)
            {
                Console.WriteLine("Entered age is: " + age);
            }
            else
            {
                Console.WriteLine("Enter valid age");
                goto start;
            }
        }
    }
}

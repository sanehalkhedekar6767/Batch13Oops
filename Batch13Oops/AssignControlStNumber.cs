using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AssignControlStNumber
    {
        static void Main()
        {
            Console.WriteLine("Enter number");
            //Taking user input
            int number = int.Parse(Console.ReadLine());

            //if else if statement
            if (number == 0)
            {
                Console.WriteLine("Number is Zero");
            }
            else if (number > 0)
            {
                Console.WriteLine("Number is Positive");
            }if(number < 0)
            {
                Console.WriteLine("Number is Negative");
            }
        }
    }
}

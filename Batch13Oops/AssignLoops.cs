using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AssignLoops
    {
        static void Main()
        {
            Console.WriteLine("For loop --->");
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Student id: " + i);  
            }
            Console.WriteLine("while loop --->");
            int j = 0;
            while (j <=10)
            {
                Console.WriteLine("Student id: " + j);
                j++;
            }
            Console.WriteLine("Do while loop --->");
            int k = 0;
            do
            {
                Console.WriteLine("Student id: " + k);
                k++;
            }
            while (k<=10);


        }
    }
}

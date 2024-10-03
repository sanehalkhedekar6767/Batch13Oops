using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AssignCollectionStack
    {
        static void Main()
        {
            Stack stk = new Stack();

            //add elements in stack
            stk.Push("Tata");
            stk.Push("Mahindra");
            stk.Push("MG");
            stk.Push("Hyundai");
            stk.Push("Ford");


            //Display stack elements
            Console.WriteLine("Stack elements");
            foreach (string item in stk)
            {
                Console.Write($"{item}, "); 
            }

            //remove items(Pop)
            Console.WriteLine("\nRemoved elements from stack----->");
            object topelement = stk.Pop();
            object secondelement = stk.Pop();
    
            //Display removed stack elements
            Console.WriteLine(topelement);
            Console.WriteLine(secondelement);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class AssignArraySearch
    {
        
        static void Main()
        {
            Console.Write("Enter the name: ");
            String name = Console.ReadLine();
            String[] array = { "ALice", "Bob", "Charlie", "David", "Emily"};


            bool isPresent = false;
            
            foreach (String search in array)
            {
                if (search.Equals(name))
                {
                    isPresent = true;
                    break;
                }

            }
        
            if (isPresent)
            {
                Console.WriteLine(name + " is present in the array");
                
            }
            else
            {
                Console.WriteLine(name + " is not present in the array");

            }
        }
    }
}

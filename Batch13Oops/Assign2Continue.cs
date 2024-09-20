using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class Assign2Continue
    {
        static void Main()
        {
            //continue statement
            Console.WriteLine("Continue Statement------------------------------->");
            for (int i = 0; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                
                Console.WriteLine("Number not divisible by 3 is: "+ i);


            }
        }
    }
}

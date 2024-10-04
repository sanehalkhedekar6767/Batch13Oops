using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Assign2ForEach
    {
        static void Main()
        {
            //foreach loop
            Console.WriteLine("For each loop----------------------------->");
            String[] mob_brand = { "Vivo", "Oppo", "One Plus", "Apple", "Samsung", "Realme" };
            foreach (String brand in mob_brand)
            {
                Console.WriteLine("Top Brands are: " +brand);

            }

        }
    }
}

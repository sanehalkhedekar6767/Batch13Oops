using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class HashSetExample
    {
        static void Main()
        {
            //create a hashset
            HashSet<int> num = new HashSet<int>();

            //add element to the hashset
            num.Add(1);
            num.Add(2);
            num.Add(3);
            num.Add(4);
            num.Add(5);
            num.Add(5);//Duplicate item

            Console.WriteLine("HashSet items");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }

            //find particular element in the hashset
            bool containstwo = num.Contains(2);
            Console.WriteLine("Hashset contains 2: " + containstwo);

            //remove element from hashset
            num.Remove(3);
            Console.WriteLine('a');
            Console.Write("After removal: ");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine('a');

            HashSet<int> hashset = new HashSet<int>{1, 2, 3, 4,5};
            num.UnionWith(hashset);
            foreach(int i in num)
            {
                Console.WriteLine(i);
            }

        }
    }
}
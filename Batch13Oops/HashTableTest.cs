using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class HashTableTest
    {
        static void Main()
        {
            //creating object of hashtable
            Hashtable ht = new Hashtable();

            //adding key-value pairing to the hashtable
            ht.Add(1, "java");
            ht.Add(2, "c");
            ht.Add(3, 1200);
            ht.Add(4, true);

            //accessing the items although typecasting
            string val1 = (string)ht[1];
            string val2 = (string)ht[2];
            string val3 = Convert.ToString((int)ht[3]);
            bool val4 = (bool)ht[4];

            //display value
            Console.WriteLine($"value1: {val1}");
            Console.WriteLine($"value2: {val2}");
            Console.WriteLine($"value3: {val3}");
            Console.WriteLine($"value4: {val4}");

            ht[3] = "AWS";





        }
    }
}

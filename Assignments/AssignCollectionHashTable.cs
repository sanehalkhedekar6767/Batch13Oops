using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AssignCollectionHashTable
    {
        static void Main()
        {
            //creating Hashtable
            Hashtable myHashTable = new Hashtable();

            //adding key-value pairing to the hashtable
            myHashTable.Add(1, "java");
            myHashTable.Add(2, "c");
            myHashTable.Add(3, "Phython");
            myHashTable.Add(4, "C#");
            myHashTable.Add(5, "Php");


            //accessing the items although typecasting
            string val1 = (string)myHashTable[1];
            string val2 = (string)myHashTable[2];
            string val3 = (string)myHashTable[3];
            string val4 = (string)myHashTable[4];
            string val5 = (string)myHashTable[5];

            //display value
            Console.WriteLine($"value1: {val1}");
            Console.WriteLine($"value2: {val2}");
            Console.WriteLine($"value3: {val3}");
            Console.WriteLine($"value4: {val4}");
            Console.WriteLine($"value4: {val5}");


            //removing items from hashtable
            myHashTable.Remove(4);
            myHashTable.Remove(3);

            //deleting elements from hashtable
            myHashTable.Clear();

          
        }
    }
}

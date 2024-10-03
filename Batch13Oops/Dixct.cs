using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class Dixct
    {
        static void Main()
        {
            //initialize dictionary
            Dictionary<string, int> agedt = new Dictionary<string, int>();

            //adding key-valu pairing in dictionary
            agedt.Add("Abc", 34);
            agedt.Add("def", 90);
            agedt.Add("ghi", 67);

            //print all the elements in the dictionary
            Console.WriteLine("All elements in the dictionary");
            foreach (KeyValuePair<string, int>KVP in agedt)
            {
                Console.WriteLine($"{KVP.Key}:{KVP.Value}");

            }

            //modify dict
            agedt["Abc"] = 45;
            Console.WriteLine("All elements in the dictionary");
            foreach (KeyValuePair<string, int> KVP in agedt)
            {
                Console.WriteLine($"{KVP.Key}:{KVP.Value}");

            }

            //remove element fron dict
            agedt.Remove("def");

            //search element in the dict
            if (agedt.ContainsKey("Abc"))
            {
                Console.WriteLine("Exists in dict");
            }

            agedt.Clear();
            Console.WriteLine(agedt.Count());


        }
    }
}

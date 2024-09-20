using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class Assign2Array
    {
        public static String revString(String str)
        {
            String reverse = "";
            for (int i = str.Length -1; i>=0 ; i--)
            {
               reverse += str[i]; 
            }
            return reverse;
        }
       static void Main(String[]args)
        {
            String str = "CODEMIND TECHNOLOGY";
            Console.WriteLine("Given string is: "+str);
            Console.WriteLine("Reverse of string is: " +revString(str));
        }
    }
}

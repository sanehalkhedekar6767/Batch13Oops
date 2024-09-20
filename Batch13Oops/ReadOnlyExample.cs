using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    class ReadOnlyex
    {
        //property fields
        public readonly int initialvalue;
        public static readonly double pi;

        public ReadOnlyex(int initialValue)
        {
            initialvalue = initialValue;
            initialValue = 20;
        }
        static  ReadOnlyex()
        {
            pi = 3.1485;
        }
        public void PrintValues()
        {
            Console.WriteLine($"Initial Value: {initialvalue}");
            Console.WriteLine($" Value of pi : {pi}");
        }

    }

    internal class ReadOnlyExample
    {
        static void Main()
        {
            ReadOnlyex read = new ReadOnlyex(10);
            read.PrintValues();
        }
    }
}

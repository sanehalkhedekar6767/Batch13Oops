using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    class Constantex
    {
        //normal variable decalration
        public int a = 10;
        public const double pi = 3.1485;
        public const string AppName = "My App";
        public string name = "Test";

        public void PrintConstants()
        {
            Console.WriteLine($"The value  of pi is: {pi}");
            Console.WriteLine($"Application name is: {AppName}");
            //AppName = "Test new";  //cant chaneg as it is decalred as constant
            name = "Test1";
            Console.WriteLine(name);
        }
    }
    internal class ConstantExample
    {
        static void Main()
        {
            Constantex cons = new Constantex();
            cons.PrintConstants();
        }
    }
}

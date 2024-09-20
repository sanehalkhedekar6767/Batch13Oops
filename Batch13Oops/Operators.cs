using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class Operators
    {
        public static void Main()
        {
            //Aritmetic operator
            int a = 10;
            int b = 3;


            Console.WriteLine("Arithmetic Operator");
            Console.WriteLine($"Addition of two numbers  is {a + b}"); //addition
            Console.WriteLine($"Subtraction of two numbers  is {a - b}"); //Subtraction
            Console.WriteLine($"Multiplication of two numbers  is {a * b}"); //Multiplicationion
            Console.WriteLine($"Division of two numbers  is {a / b}"); //Division
            Console.WriteLine($"Modulus of two numbers  is {a % b}"); //Modulus


            //Relational operator
            Console.WriteLine("Relational Operator");
            Console.WriteLine($"a==b:{a==b}");
            Console.WriteLine($"a!=b:{a != b}");
            Console.WriteLine($"a!=b:{a != b}");
            Console.WriteLine($"a>b:{a > b}");
            Console.WriteLine($"a<b:{a < b}");
            Console.WriteLine($"a>=b:{a >= b}");
            Console.WriteLine($"a<=b:{a <= b}");






        }
    }
}

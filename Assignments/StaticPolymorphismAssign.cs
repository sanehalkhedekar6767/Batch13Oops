using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Calculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }
        public int add(int a, int b, int c)
        {
            return a + b + c;
        }
        public double add(double a, double b)
        {
            return a + b;
        }
    }
    internal class StaticPolymorphismAssign
    {
       static void Main()
        {
            Calculator obj = new Calculator();

            int m1 = obj.add(5, 10);
            int m2 = obj.add(6, 1, 2);
            double m3 = obj.add(2, 6.3);

            Console.WriteLine("Assignment 1---------------->");
            Console.WriteLine("Sum of 2 values: " + m1);
            Console.WriteLine("Sum of 3 values: " + m2);
            Console.WriteLine("Sum of 2 double values: " + m3);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    class MathOperation
    {
        //Method overloading or compile time polymorphism or early binding
        //Method name same class also same but different parameters
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b) {
            return a + b; 
        }
    }
    internal class StaticPolymorphism
    {
        static void Main()
        {
            MathOperation obj = new MathOperation();

            //calling overload methods
            int m1 = obj.Add(2, 3);
            double m2 = obj.Add(4, 2);

            Console.WriteLine("Sum of integers: "+m1 );
            Console.WriteLine("Sum of doubles: "+m2 );

        }
    }
}

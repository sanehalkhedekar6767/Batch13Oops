using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public abstract class Shape{
        public abstract double CalculateArea(double l, double b);

        public void Display()
        {
            Console.WriteLine("Area of Shape");
        }

     }

    public class Rectangle : Shape
    { 

        public override double CalculateArea(double l, double b)
        {
            return l*b;
        }

    }

    public class Circle : Shape
    {
        public override double CalculateArea(double l, double b)
        {
            double pi = 3.14;
            return pi*l;
        }

    }


    internal class AbstractClassAssign
    {
        static void Main()
        {
            Rectangle rect = new Rectangle();
            rect.Display();
            Console.WriteLine("Area of Rectangle is: "+rect.CalculateArea(3.2, 5));

            Circle circle = new Circle();
            circle.Display();
            Console.WriteLine("Area of circle is: "+circle.CalculateArea(5, 4));



        }
    }
}

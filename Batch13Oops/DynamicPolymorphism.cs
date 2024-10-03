using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class DynamicPolymorphism
    {

        //Dynameic polymorphism / Overriding / Late binding
        //Method name same parameter also same but different class


        //Base class

        class Shape {
            public virtual void draw()
            {
                Console.WriteLine("Drawing a shape");
            }
        }
        //Derived class 1
        class Circle : Shape
        {
            //override draw method
            public override void draw()
            {
                Console.WriteLine("Drawing  a circle");
            }
        }
        //Derived class 2
        class Rectangle : Shape
        {
            //override draw method
            public override void draw()
            {
                Console.WriteLine("Drawing  a Rectangle");
            }
        }
      
        static void Main()
        {
            //creating object of different classes
            Shape shape = new Shape();
            Shape circle = new Circle();       
            Shape rect = new Rectangle();

            //calling the draw methods of each object
            shape.draw();
            circle.draw();
            rect.draw();

        }
    }
}

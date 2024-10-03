using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class HierarchicalInheritance
    {

        class MyShape  //base class
        {
            public void Draw()
            {
                Console.WriteLine("Drawing a MyShape");
            }

        }

        class Circle : MyShape //derived class
        {
            public void DrawCircle()
            {
                Console.WriteLine("Drawing a circle");
            }
        }
        class Rectangle : MyShape
        {
            public void DrawRectangle()
            {
                Console.WriteLine("Drawing a Rectangle");
            }
        }
        class Triangle : MyShape
        {
            public void DrawTriangle()
            {
                Console.WriteLine("Drawing a Triangle");
            }
        }
        static void Main()
        {
            Circle circle = new Circle();
            circle.Draw();  //inherit from base
            circle.DrawCircle();  //inherit from derived

            Rectangle rectangle = new Rectangle();
            rectangle.Draw();
            rectangle.DrawRectangle();

            Triangle triangle = new Triangle();
            triangle.Draw();
            triangle.DrawTriangle();

        }
    }
}

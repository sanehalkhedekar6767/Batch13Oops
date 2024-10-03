//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Assignments
//{
//    class Animal
//    {
//        public virtual void draw()
//        {
//            Console.WriteLine("Drawing a shape");
//        }
//    }

//    class Circle : Animal
//    {
//        public override void draw()
//        {
//            Console.WriteLine("Drawing a Circle shape");
//        }
//    }
//    //class Rectangle : Animal
//    //{
//    //    public override void draw()
//    //    {
//    //        Console.WriteLine("Drawing a Rectangle shape");
//    //    }
//    //}
//    internal class DynamicPolymorphismAssign
//    {
//        static void Main()
//        {
//            Animal animal = new Animal();
//            Animal circle = new Circle();
//            //Animal rect = new Rectangle();

//            Console.WriteLine("Assignment 2------------>"); 
//            animal.draw();
//            circle.draw();
//            //rect.draw();
//        }
//    }
//}

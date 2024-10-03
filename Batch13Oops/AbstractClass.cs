using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    //abstract class
    public abstract class Animal
    {
        //abstract method (No implementation)
        public abstract void MakeSound();

        //non abstract method (that has implementation)
        public void Eat()
        {
            Console.WriteLine("Animal is eating");

            //public Animal()
            //    {
            //        Console.WriteLine("Test");
            //    }
        }


        //derived class dog
        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Dog barks");
            }
        }

        //derived class cat
        public class Cat : Animal
        {
            public override void MakeSound()
            {
                //implementation of the abstract method
                Console.WriteLine("Cats meows");
            }
        }
        internal class AbstractClass
        {
            static void Main()
            {
                ////creating object of derived class
                //Animal a = new Animal();
                //a.MakeSound();

                //creating object of derived class
                Dog dog = new Dog();
                Cat cat = new Cat();

                //call method
                dog.MakeSound();
                dog.Eat();
                cat.MakeSound();
                cat.Eat();

            }

        }

    }
}

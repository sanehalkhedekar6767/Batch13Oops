using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    class Vehicle //Base class or Parent class or Super class
    {
        public string Brand {  get; set; }

        public void Drive()
        {
            Console.WriteLine($"{Brand} is Driving");
        }

    }
    class Car : Vehicle  //derived class or child class or sub class
    {

        public int NumberOfDoors {  get; set; }
        public void ShowCarInfo()
        {
            Console.WriteLine($"{Brand} car has {NumberOfDoors} doors");
        }

    }

    internal class SingleInheritance
    {
        static void Main()
        {
            Car mycar = new Car();
            mycar.Brand = "Tata";
            mycar.NumberOfDoors = 4;
            mycar.Drive();
            mycar.ShowCarInfo();
        }
    }
}

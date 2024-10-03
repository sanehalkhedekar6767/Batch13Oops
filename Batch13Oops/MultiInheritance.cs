using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    class MyVehicle //Base class or Parent class or Super class
    {

        public void Start()
        {
            Console.WriteLine("The vehicle is started");
        }

    }
    class OffRiding : MyVehicle  
    {
        public void Drive()
        {
            Console.WriteLine("The car is driving");
        }

    }
    class SportCar : OffRiding  //derived class or child class or sub class
    {

        public void TurboBoost()
        {
            Console.WriteLine("The sports car is in turbo mode");
        }

    }
    internal class MultiInheritance
    {
        static void Main()
        {
            SportCar mysportcar = new SportCar();
            mysportcar.Start();
            mysportcar.Drive();
            mysportcar.TurboBoost();
        }
    }
}

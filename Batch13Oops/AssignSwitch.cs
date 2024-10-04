using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AssignSwitch
    {
        static void Main()
        {
            Console.WriteLine("1.Burger: 120 \n2.Pizza: 400 \n3.Salad: 200 \n4.Muffins: 80 \n5.Smoothie: 150");
            Console.WriteLine("---------------------------------");
            Console.Write("Enter your choice: ");
            int food = int .Parse(Console.ReadLine());
            switch (food)
            {
                case 1:
                    Console.WriteLine("Chosen item: Burger \nPrice: 120");
                    break;
                case 2:
                    Console.WriteLine("Chosen item: Pizza \nPrice: 400");
                    break;
                case 3:
                    Console.WriteLine("Chosen item: Salad \nPrice: 200");
                    break;
                case 4:
                    Console.WriteLine("Chosen item: Muffins \nPrice: 80");
                    break;
                case 5:
                    Console.WriteLine("Chosen item: Smoothie \nPrice: 150");
                    break;
                default:
                    Console.WriteLine("Refer Menu Card and enter valid order");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class ControlStatements
    {
        static void Main()
        {
            //if statement
            int number = 5;
            if (number > 0)
            {
                Console.WriteLine("The number is positive");
            }

            //if else statement
            else
            {
                Console.WriteLine("number is negative");
            }
            //if else if statement
            if (number > 0)
            {
                Console.WriteLine("The number is positive");

            }

            //Switch Statement
            int Day = 5;
            switch (Day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Monday");
                    break;
                default:
                    Console.WriteLine("Not a valid day");
                    break;
            }

            //Looping Statements

            //1. For loop
            for(int i=0; i<5; i++)
            {
                Console.WriteLine("Iteration: " + i);
            }

            //2. while loop
            int j = 0;
            while (j<5)
            {
                Console.WriteLine("Iteration on while loop: " + j);
                j++;
            }

            //3. do while loop
            int n = 0;
            do
            {
                Console.WriteLine("Iterations of do while loop: " + n);
                n++;
            }
            while (n<5);

            //for each
            String[] fruits = { "Apple", "Mango", "Kiwi", "Berry", "Grapes" };
            foreach (String fruit in fruits)
            {
                Console.WriteLine("Fruit name is: " + fruit);
            }

            //continue staement
            for(int i = 0; i < 5; i++)
            {
                if (i==3)
                {
                    continue;
                }
                Console.WriteLine("Iterations: " +i);

            }

            //go to statement
            int count = 0;
            startloop:
            if (count<5)
            {
                Console.WriteLine($"count is {count}");
                count++;
                goto startloop;
            }
            Console.WriteLine("Loop with goto is finished");

            //break statement
            int num = 2;
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    goto case 3;
                case 3:
                    Console.WriteLine("three");
                    break;
                default:
                    Console.WriteLine("invalid number");
                    break;
            }










        }
    }
}

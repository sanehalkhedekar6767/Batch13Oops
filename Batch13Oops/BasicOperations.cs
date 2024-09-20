using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Batch13Oops //project name - namesapace
{
    internal class BasicOperations  //class- template chosen as class, internal- acess modifier
    {
        static void Main()
        {
            //Test message to display
            Console.WriteLine("Test Message");


            //ctrl+k+d to format page ctrl+shift+k


            //Int- Datatype
            //Variable declaration
            int num1 = 10;

            int num2 = 20;
            int sum = num1 + num2;
            Console.WriteLine("The sum of two numbers is " + sum);

            //String datatype
            String myString = "Welcome";
            Console.WriteLine("String- " + myString);


            //Boolean
            bool status = true;
            Console.WriteLine("Boolean " + status);

            //Double
            double myDouble = 12.55;
            Console.WriteLine("Double " + myDouble);


            //Char- only one letter is allowed
            char myChar = 'A';
            Console.WriteLine("Char " + myChar);

            //Long
            long myLong = 12345678L;
            Console.WriteLine("Long " + myLong);



        }
    }
}

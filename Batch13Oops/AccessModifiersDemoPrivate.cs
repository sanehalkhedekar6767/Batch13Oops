using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    
   
    internal class AccessModifiersDemoPrivate
    {

        private class Person
        {
            private String firstName;
            private String lastName;


            public void DisplayFullName(String FirstName, String LastName)
            {
                firstName = FirstName;  
                lastName = LastName;
            }

            public void ShowFullName()
            {
                Console.WriteLine("Full Name is: "+firstName+" "+lastName);
            }

        }
        static void Main()
        {
            Person obj = new Person();
            obj.DisplayFullName("Sanehal", "Khedekar");
            obj.ShowFullName();
        }
    }
}

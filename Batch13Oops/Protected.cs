using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    class BaseClass
    {
        private int PrivateField;
        protected int ProtectedField;
        public int PublicField;

        public void SetField(int value)
        {
            PrivateField = value;
            ProtectedField = value;

            Console.WriteLine("Protected Field " + ProtectedField);
            Console.WriteLine("Private Field " + ProtectedField);
            Console.WriteLine("Public Field " + PublicField);



        }

    }
    class DerivedClass : BaseClass {
        public int Display(int value)
        {
            Console.WriteLine("Display "+ProtectedField);
            //Console.WriteLine("Display " + PrivateField);
            Console.WriteLine("Public Field " + PublicField);


            return 1;
        }
    }

    class DerivedClassNew : BaseClass 
    {
        public void Show()
        {
            Console.WriteLine("Show " + ProtectedField); //error occurs because its not a child of base class which has this field
        }
    }
    class Protected
    {
       static void Main()
        {
            DerivedClassNew obj = new DerivedClassNew();
            obj.Show(); 
        }
    }
}

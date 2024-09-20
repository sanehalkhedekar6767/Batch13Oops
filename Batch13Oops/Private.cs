using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    class PrivateClass
    {


        private int PrivateField;

        public void setField(int value)
        {
            PrivateField = value;
        }
        public void show()
        {
            Console.WriteLine("Private field value " + PrivateField);
        }

    }

    class Private 
    {
        static void Main()
        {
            //    PrivateClass obj = new PrivateClass();
            //    obj.setField(10);
            //    obj.show();

            //Can access public members everywhere
            PublicClassExample obj = new PublicClassExample();
            obj.PublicProperty = 1;
            obj.Show();

        }
    }

   
}

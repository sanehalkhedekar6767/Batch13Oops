using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    public class PublicClassExample
    {
        public int PublicProperty { get; set;}
        public void Show()
        {
            Console.WriteLine("Public property "+PublicProperty);
        }
    }
    public class Public
    {
        static void Main() 
        {
            //PublicClassExample obj = new PublicClassExample();
            //obj.PublicProperty = 1;
            //obj.Show();
        }
       
    }
}

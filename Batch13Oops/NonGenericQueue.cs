using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class NonGenericQueue
    {
        static void Main()
        {
            Queue qu = new Queue();
            //FIFO - first in first out
            //enqueue - it is bascically used to add the elements into the queue

            qu.Enqueue("Abc");
            qu.Enqueue(4568);
            qu.Enqueue(true);

            //dequeue - to remove elements
            object firstelement = qu.Dequeue();
            object secondelement = qu.Dequeue();
            object thirdelement = qu.Dequeue();

            //Display the items
            Console.WriteLine("Dequeue elements");
            Console.WriteLine(firstelement);
            Console.WriteLine(secondelement);
            Console.WriteLine(thirdelement);




        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class NonGenericStack
    {
        static void Main()
        {


            //create a non - generic stack
            Stack st = new Stack();
            //LIFO - last in first out

            st.Push("top");
            st.Push(97);
            st.Push(false);

            Console.WriteLine(st);

            //remove items(Pop)
            Console.WriteLine("pop elements");
            object topelement = st.Pop();
            object secondelement = st.Pop(); 
            object thirdelement = st.Pop();

            Console.WriteLine(topelement);
            Console.WriteLine(secondelement);   
            Console.WriteLine(thirdelement);
            Console.WriteLine("Is stack empty: " + (st.Count == 0));

        }

    }
}

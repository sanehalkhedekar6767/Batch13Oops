using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class AssignStringBuilder
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello, ");
            sb.Append("Today ");
            sb.Append("was ");
            sb.Append("a ");
            sb.Append("Great ");
            sb.Append("Day ");

            Console.WriteLine("String using append  -----------> ");
            Console.WriteLine(sb);

            sb.Replace("Today", "Yesterday");
            Console.WriteLine("String using replace  -----------> ");
            Console.WriteLine(sb);

            sb.Remove(0, 6);
            Console.WriteLine("String using remove  -----------> ");
            Console.WriteLine(sb);


        }
    }
}

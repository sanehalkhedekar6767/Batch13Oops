using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace   
{
    public enum Year
    {
       January,
       February,
       March,
       April,
       May,
       June,
       July,
       August,
       September,
       October,
       November,
       December
    }
    internal class AssignEnum
    {
        static void Main()
        {
            Year month = Year.December;
            switch (month)
            {
                case Year.January:
                    Console.WriteLine("January");
                    break;
                case Year.February:
                    Console.WriteLine("February");
                    break;
                case Year.March:
                    Console.WriteLine("March");
                    break;
                case Year.April:
                    Console.WriteLine("April");
                    break;
                case Year.May:
                    Console.WriteLine("May");
                    break;
                case Year.June:
                    Console.WriteLine("June");
                    break;
                case Year.July:
                    Console.WriteLine("July");
                    break;
                case Year.August:
                    Console.WriteLine("August");
                    break;
                case Year.September:
                    Console.WriteLine("September");
                    break;
                case Year.October:
                    Console.WriteLine("October");
                    break;
                case Year.November:
                    Console.WriteLine("November");
                    break;
                case Year.December:
                    Console.WriteLine("December");
                    break;
            }

            if (month == Year.January)
            {
                Console.WriteLine("Starting month of Year");
            }
            if(month == Year.December)
            {
                Console.WriteLine("Ending month of Year");

            }
        }
    }
}

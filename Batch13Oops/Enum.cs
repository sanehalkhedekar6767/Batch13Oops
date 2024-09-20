using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    public enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    enum HTTPStatusCode
    {
        OK = 200,
        BadRequest = 400,
        Unauthorized =401,
        Forbiden = 500
    }
    internal class Enum
    {
        
        static void Main()
        {

            DerivedClass bs = new DerivedClass();
            bs.SetField(10);
            Console.WriteLine();

            //Days today = Days.Sunday;

            ////week days
            //switch (today)
            //{
            //    case Days.Sunday:
            //        Console.WriteLine("Today is Sunday");
            //        break;

            //    case Days.Monday:
            //        Console.WriteLine("Today is Monday");
            //        break;

            //    case Days.Tuesday:
            //        Console.WriteLine("Today is Tuesday");
            //        break;
            //    case Days.Wednesday:
            //        Console.WriteLine("Today is Wednesday");
            //        break;
            //    case Days.Thursday:
            //        Console.WriteLine("Today is Thursday");
            //        break;
            //    case Days.Friday:
            //        Console.WriteLine("Today is Friday");
            //        break;
            //    case Days.Saturday:
            //        Console.WriteLine("Today is Saturday");
            //        break;
            //}

            ////to check week end
            //if (today == Days.Saturday || today == Days.Sunday)
            //{
            //    Console.WriteLine("Yup! it's weekend");
            //}
            //else
            //{
            //    Console.WriteLine("Yup! it's week day");

            //}
            ////Console.BackgroundColor = ConsoleColor.Yellow; //to change background color

            //HTTPStatusCode code = HTTPStatusCode.OK;
            //Console.WriteLine("HTTPStatus Code: " +code);

            //int codeNumber = (int)code;
            //Console.WriteLine("HTTP Status Code number: " + codeNumber);



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class AssignControlStGrade
    {
      static void Main()
        {
            Console.WriteLine("Enter the Grade: ");
            int grade = int.Parse(Console.ReadLine());

            if (grade >= 90)
            {
                Console.WriteLine("Grade: A");
            }
            else if (grade < 90 && grade >= 80)
            {
                Console.WriteLine("Grade: B");
            }
            else if (grade < 80 && grade >= 70)
            {
                Console.WriteLine("Grade: C");
            }
            else if (grade < 70 && grade >=55)
            {
                Console.WriteLine("Grade: D");
            }
            else
            {
                Console.WriteLine("Grade: F");

            }


        }
    }
}

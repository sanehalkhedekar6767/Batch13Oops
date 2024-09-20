using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch13Oops
{
    internal class Array
    {
        static void Main()
        {
            //Declare array
            string[] Mobile = new string[4];

            //Assigning values
            Mobile[0] = "Apple";
            Mobile[1] = "Vivo";
            Mobile[2] = "OnePLus";
            Mobile[3] = "Nokia";

            //Access array value
            Console.WriteLine("Mobiles in array index: ");
            for (int i = 0; i < Mobile.Length; i++)
            {
                Console.WriteLine(Mobile[i]);
            }

            //reverse number
            int[] numbers = { 1, 2, 3, 4, 5 };

            //Print array values
            Print(numbers);
            Reverse(numbers);
            //Console.WriteLine("print reverse array");
            //Print(numbers);



        }
        public static void Print(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.WriteLine(num + " ");
            }
        }
        public static void Reverse(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                //element swapping
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;    
                 start++;
                end--;
            }

            //initialize multidimensional array
            int[,] matrix = new int[,]
            {
                { 1,2,3},
                { 4,5,6},
                { 7,8,9}
            };

            //accessing the elements from array
            Console.WriteLine("Element at(0,0)" + matrix[0, 0]);
            Console.WriteLine("Element at(1,2)" + matrix[1, 2]);

            //print all the elements in array

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3 ;j ++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            //jagged array
            //declration of the jagged array
            int[][] jaggedArray = new int[][]
            {
                new int[]{ 1,2},
                new int[]{3,4,5},
                new int[]{6,7,8,9}
            };

            //Accessing elements of jagged array
            Console.WriteLine("Elements at[0][1]: " + jaggedArray[0][1]);
            Console.WriteLine("Elements at[2][3]: " + jaggedArray[2][3]);

            //looping through a jagged array
            for (int i = 0; i < jaggedArray.Length ; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]+" ");  
                }
                Console.WriteLine();
            }

            //String 
            String a = "hello";
            Console.WriteLine(a);
            a = "everyone";
            Console.WriteLine(a);

            String fname = "Sanehal";
            String lname = "khedekar";
            String name = fname + lname;
            Console.WriteLine(name);

            //String Builder
            StringBuilder str = new StringBuilder();
            str.Append("hello");
            str.Append(" , ");
            str.Append("everyone");
            string result = str.ToString();
            Console.WriteLine(result);

            //insert word at index 5 specific location
            str.Insert(5, "dear");
            Console.WriteLine(str);

            //replace a string
            str.Replace("hello", "great");
            Console.WriteLine(str);

            //to replace string builder
            str.Clear();

            //Boxing
            int num = 90;//value type(int)
            object obj = num;//boxing will convert value to object(reference)


            //UnBoxing
            object objnew = 35;//boxed integer value
            int num1 = (int)objnew;//unboxing will convert object to value type






        }
    }
}

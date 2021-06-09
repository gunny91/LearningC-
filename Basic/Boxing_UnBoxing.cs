using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_UnBoxing
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              [ Object format ]
              All class's superial class called object
              - C# providing a object format to handle all data types

              - 
             */

            object obj1 = 111;
            object obj2 = 3.14122123124m; // decimal data m(decimal) ,,,, L(long) ,,, f(float),,,, d(double) set as literal values

            object obj3 = true;
            object obj4 = "WPF ";

            Console.WriteLine(obj1);
            Console.WriteLine(obj2);
            Console.WriteLine(obj3);
            Console.WriteLine(obj4);


            Console.ReadKey();



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 *  Why
 */
namespace Delegate3.cs
{
    class Program
    {
        //Bubble sort algorithm
        // 9 2 5 7 8
        // 0 0 0 0 9
        // 
        static void BSort(int[] arr1)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for( i =0; i< arr1.Length -1; i++)
            {
                for(j=0; j<arr1.Length-(i+1);j++)
                {
                    //accending
                    if(arr1[j] > arr1[j + 1])
                    {
                        temp = arr1[j+1];
                        arr1[j + 1] = arr1[j];
                        arr1[j] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int[] arr = {22,11,55,3,17 };

            Console.WriteLine("-------------------Accending order------------------");
            BSort(arr);

            for(int i =0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
           Console.WriteLine( );

            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

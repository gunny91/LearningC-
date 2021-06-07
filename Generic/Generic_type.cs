using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericPrac
{
    class Program
    {
        static void CopyData<T>(T[] a, T[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];

            }
        }
        static void Main(string[] args)
        {
            int[] a = { 11, 12, 33, 44, 55, 66 };
            int[] b = new int[a.Length]; ;
            CopyData<int>(a, b);

            foreach (int item in b)
            {
                Console.WriteLine(item);
                Console.WriteLine();

            }

            MyList<string> myList1 = new MyList<string>();
            myList1[0] = "A";
            myList1[1] = "B";
            myList1[2] = "C";
            myList1[3] = "D";
            myList1[4] = "E";

            for (int i = 0; i < myList1.Length; i++)
            {
                Console.WriteLine(myList1[i]);
            }

            MyList<int> myList2 = new MyList<int>();
            myList2[0] = 100;
            myList2[1] = 300;
            myList2[2] = 500;
            myList2[3] = 10000;


            for(int i= 0; i<myList2.Length; i++)
            {
                Console.WriteLine(myList2[i]);
            }
        }

        class MyList<T>
        {
            private T[] array;
            
            public MyList()
            {
                array = new T[4];
            }

            public T this[int idx]
            {
                get { return array[idx]; }
                set
                {
                    if (idx >= array.Length)
                    {
                        Array.Resize<T>(ref array, idx + 1);
                        Console.WriteLine($"Array size : {array.Length}");
                    }
                    array[idx] = value;
                }
            }

            public int Length
            { get { return array.Length; } }
        }
    }

}

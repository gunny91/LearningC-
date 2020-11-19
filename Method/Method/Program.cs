using System;

namespace Method
{
    
    
    class Program
    {

        static void MyMethod() { Console.WriteLine("First method in C #"); }

        static void ParaMthod(string fname) { Console.WriteLine(fname+" Refsnes"); }

        static void GetCountry(string country = "Korea") { Console.WriteLine(country); }

        static int AdditionHundred(int x) { return x + 100; }


        static void Main(string[] args)
        {
            MyMethod();

            ParaMthod("Hello");
            ParaMthod("Gunny");
            ParaMthod("Yi Ting");

            GetCountry("USA");
            GetCountry();

            Console.WriteLine( AdditionHundred(100000));

        }
    }
}

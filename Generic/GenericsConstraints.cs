using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/**
    *  Generic Constraint
    *  Generic method, Generic class that used T(Type parameter) 
    *  
    *  When we are using constraint for Generics, we need to use where statement
    *  void CopyData<T> (T a, T b) where T: struct 
    *  T is value form!
    *  
    *  Constraint type
    *  - where T : struct  T is value form
    *  - where T : class   T should be a reference type
    *  - where T : new()   T must have a default constructor
    */

namespace GenericsConstraintEx
{
   
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

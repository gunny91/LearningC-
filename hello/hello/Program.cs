using System;

namespace hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("This is practice");

            Console.Write("temp write\n");

            String name = "Gunny";
            Console.WriteLine(name);

            int myInt = 9;
            double myDouble = myInt;       // Automatic casting: int to double

            Console.WriteLine(myInt);      // Outputs 9
            Console.WriteLine(myDouble);   // Outputs 9


            double x = 9.14;
            int y = (int)x;

            Console.WriteLine(x);
            Console.WriteLine(y);

            int t = 10;
            double c = 5.25;
            bool myBool = true;

            Console.WriteLine(Convert.ToString(t));
            Console.WriteLine(Convert.ToDouble(t));    // convert int to double
            Console.WriteLine(Convert.ToInt32(c));  // convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // convert bool to string


        }
    }
}

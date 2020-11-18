using System;

namespace Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 100 + 1000;
            Console.WriteLine(x * 2);
            int y = Math.Max(100, 2);
            int v = Math.Min(2, 111);
            Console.WriteLine(y + "Min is " + v);
            double sqrt = Math.Sqrt(100);
            int abs = Math.Abs(-12);

            Console.WriteLine(sqrt + " the abs is " + abs);
        }

    }
}

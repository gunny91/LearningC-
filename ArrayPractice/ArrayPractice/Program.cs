using System;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] cars = { "BMW", "KIA", "HYUNDAI", "FORD" };

            int[] num = { 1, 2, 3, 4 };


            for (int i = 0; i < cars.Length; i++) {
                Console.WriteLine(cars[i]);
                Console.WriteLine(num[i]);
            }

            Console.WriteLine("/////////////////////////////////");
            foreach (string i in cars) { Console.WriteLine(i); }
        }
    }
}

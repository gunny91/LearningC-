using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 *  Delegate Convey A method to B method
 *  
 *  Void temp(int arg1){...}
 *  
 *  int a = 123;
 *  temp(A);
 *  
 *  class DempClass 
 *  {
 *      int id;
 *      string name;
 *      public void DisplayInfo(){}
 *  }
 *  void temp(DemoClass d){...}
 *  
 *  DempClass d = new DempClass();
 *  Temp(d);
 * -------------------------Delegate-----------
 * void temp(MyDelegate method){...}
 * delegate int Mydelegate(string str);
 * 
 * int StringToInt(string str){...}
 * MyDelegate myDelegate = new MyDelegate(StringToInt);
 * 
 * AAA(myDelegate); 
 * 
 *  
 *  
 *  
 * 
 * 
 */
namespace Delegate1
{
   

    class Program
    {
        delegate int MyDelegate(string str);

        void TestMethod()
        {
            //delegate object
            MyDelegate md = new MyDelegate(StringToInt);
            TempGet(md);
        }

        // delegate method
        int StringToInt(string str)
        {
            return int.Parse(str);
        }

        //getting delegate
        void TempGet(MyDelegate md)
        {
            int i = md("100");
            Console.WriteLine(i);
        }
        static void Main(string[] args)
        {
            new Program().TestMethod();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
           
            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}

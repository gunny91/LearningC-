using System;
using System.Diagnostics;

namespace hello
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public class UserInput
	{
		public UserInput()
		{

			static void Main(string[] args)
			{
				Console.WriteLine("Enter Your Name");
				String userName = Console.ReadLine();

				Console.WriteLine("UserName is " + userName);
			}
		}

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}

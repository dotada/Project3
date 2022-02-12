using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primary
{
    public class calculator
    {
        public void division()
        {
			System.Threading.Thread.Sleep(500);
			System.Console.WriteLine("Hello and welcome to my division program.");
			System.Threading.Thread.Sleep(500);
			System.Console.WriteLine("Please enter first number: ");
			string lin1 = Console.ReadLine();
			int num1 = Int16.Parse(lin1);
			System.Console.WriteLine("Please enter second number: ");
			string lin2 = Console.ReadLine();
			int num2 = Int16.Parse(lin2);
			System.Console.WriteLine($"The result is: {(double)num1 / num2}");
			System.Console.WriteLine("Press Enter to exit.");
			Console.ReadLine();
		}

		public void multiplication()
        {
			System.Threading.Thread.Sleep(500);
			System.Console.WriteLine("Hello and welcome to my multiplication program.");
			System.Threading.Thread.Sleep(500);
			System.Console.WriteLine("Please enter first number: ");
			string lin1 = Console.ReadLine();
			int num1 = Int16.Parse(lin1);
			System.Console.WriteLine("Please enter second number: ");
			string lin2 = Console.ReadLine();
			int num2 = Int16.Parse(lin2);
			System.Console.WriteLine($"The result is: {(double)num1 * num2}");
			System.Console.WriteLine("Press Enter to exit.");
			Console.ReadLine();
		}

		public void addition()
        {
			System.Threading.Thread.Sleep(500);
			System.Console.WriteLine("Hello and welcome to my addition program.");
			System.Threading.Thread.Sleep(500);
			System.Console.WriteLine("Please enter first number: ");
			string lin1 = Console.ReadLine();
			int num1 = Int16.Parse(lin1);
			System.Console.WriteLine("Please enter second number: ");
			string lin2 = Console.ReadLine();
			int num2 = Int16.Parse(lin2);
			System.Console.WriteLine($"The result is: {(double)num1 + num2}");
			System.Console.WriteLine("Press Enter to exit.");
			Console.ReadLine();
		}

		public void subtraction()
        {
			System.Threading.Thread.Sleep(500);
			System.Console.WriteLine("Hello and welcome to my subtraction program.");
			System.Threading.Thread.Sleep(500);
			System.Console.WriteLine("Please enter first number: ");
			string lin1 = Console.ReadLine();
			int num1 = Int16.Parse(lin1);
			System.Console.WriteLine("Please enter second number: ");
			string lin2 = Console.ReadLine();
			int num2 = Int16.Parse(lin2);
			System.Console.WriteLine($"The result is: {(double)num1 - num2}");
			System.Console.WriteLine("Press Enter to exit.");
			Console.ReadLine();
		}
    }
}

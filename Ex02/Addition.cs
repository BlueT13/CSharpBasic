using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
	class Addition
	{
		public void PrintAddition(string[] args)
		{
			int number1;
			int number2;
			int sum;
			
			Console.WriteLine("Enter first integer: ");
			number1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter second integer: ");
			number2 = int.Parse(Console.ReadLine());

			sum = number1 + number2;
			Console.WriteLine("Sum is {0}\n", sum);
		}
	}
}

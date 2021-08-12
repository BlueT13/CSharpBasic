using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02
{
	class Comparison
	{
		public void PrintComparison(string[]args)
		{
			int number1;
			int number2;

			Console.WriteLine("Enter first integer: ");
			number1 = int.Parse(Console.ReadLine());

			Console.WriteLine("Enter second integer: ");
			number2 = int.Parse(Console.ReadLine());

			if (number1 == number2)
				Console.WriteLine("{0} == {1}", number1, number2);

			if (number1 != number2)
				Console.WriteLine("{0} != {1}", number1, number2);

			if (number1 < number2)
				Console.WriteLine("{0} < {1}", number1, number2);

			if (number1 > number2)
				Console.WriteLine("{0} > {1}", number1, number2);

			if (number1 <= number2)
				Console.WriteLine("{0} <= {1}", number1, number2);

			if (number1 >= number2)
				Console.WriteLine("{0} >= {1}", number1, number2);
		}
	}
}

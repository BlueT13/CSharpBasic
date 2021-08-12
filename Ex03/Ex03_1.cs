using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03
{
	class Ex03_1
	{
		public void PrintEx03_1(string[] args)
		{
			int radius;
			radius = 10 * 5;
			Console.WriteLine($"{radius}");

			char c1 = 'a', c2 = 'b', c3 = 'c';
			c1 = 'r';
			Console.WriteLine($"{c1}");
			Console.WriteLine($"{c2}");
			Console.WriteLine($"{c3}");

			double weight = 75.56;
			weight = weight + 5.0;
			Console.WriteLine($"{weight}");
		}
	}
}
